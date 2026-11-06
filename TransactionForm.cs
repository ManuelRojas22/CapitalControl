using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using CapitalControl.Models;
using CapitalControl.Services;

namespace CapitalControl
{
    /// <summary>
    /// Formulario de previsualizacion (WinForms) de "Nueva Transaccion".
    /// Generado con el patron estandar de InitializeComponent para poder
    /// abrirse y editarse desde el Diseñador de Windows Forms de Visual Studio
    /// (mover botones, paneles y etiquetas con el mouse) sin necesidad de ejecutar la app,
    /// replicando el diseño y la logica de Views/TransactionFormView.xaml (version WPF).
    /// Incluye una barra lateral para navegar hacia el Dashboard o volver al inicio,
    /// igual que la barra lateral de Views/ShellView.xaml.
    /// </summary>
    public partial class TransactionForm : Form
    {
        /// <summary>Se dispara cuando el usuario pide navegar a "dashboard", "transaction" o "landing".</summary>
        public event EventHandler<string> NavigateRequested;

        private TxType _type = TxType.Gasto;
        private Timer _successTimer;
        private bool _layoutReady = false;

        // Responsive constants (matching DashboardForm)
        private const int LayoutMargin = 24;
        private const int ColGap = 18;
        private const int DesktopBreak = 1300;
        private const int TabletBreak = 900;
        private const int SidebarExpanded = 260;
        private const int SidebarCollapsed = 64;

        public TransactionForm()
        {
            InitializeComponent();

            // Prevent layout code from running in the VS Designer
            if (this.DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return;

            this.MinimumSize = new Size(520, 600);
            this.StartPosition = FormStartPosition.CenterScreen;

            pnlRoot.Dock = DockStyle.Fill;
            pnlMain.AutoScroll = true;
            pnlMain.Dock = DockStyle.Fill;

            // Apply emoji-capable font to controls that show icons
            ApplyEmojiFallbackFont();

            // Store original button texts for sidebar collapse/expand
            StoreOriginalSidebarTexts();

            this.Load += TransactionForm_Load;
            this.Resize += TransactionForm_Resize;
            // Recargar categorías y saldo cada vez que se muestra (llegan después del login)
            this.VisibleChanged += (s, e) =>
            {
                if (!Visible) return;
                LoadCategories();
                UpdateBalanceWarning();
            };

            WireEvents();
            ResetForm();
        }

        private void TransactionForm_Load(object sender, EventArgs e)
        {
            _layoutReady = true;
            PerformResponsiveLayout();
        }

        private void TransactionForm_Resize(object sender, EventArgs e)
        {
            if (_layoutReady)
                PerformResponsiveLayout();
        }

        private void PerformResponsiveLayout()
        {
            pnlMain.SuspendLayout();
            pnlSidebar.SuspendLayout();
            pnlCard.SuspendLayout();
            try
            {
                int totalW = this.ClientSize.Width;
                int totalH = this.ClientSize.Height;

                bool isDesktop = totalW >= DesktopBreak;
                bool isTablet = totalW >= TabletBreak && totalW < DesktopBreak;
                bool isMobile = totalW < TabletBreak;

                // ---- Sidebar ----
                LayoutSidebar(isMobile);
                int sidebarW = isMobile ? SidebarCollapsed : SidebarExpanded;

                // ---- Main content area (pnlMain) ----
                int contentW = totalW - sidebarW - 2 * LayoutMargin;
                if (contentW < 300) contentW = 300;

                int currentTop = 0;

                // Title block
                currentTop = LayoutTitleBlock(contentW, currentTop);

                // Success / Warning boxes (stacked)
                currentTop = LayoutAlertBoxes(contentW, currentTop);

                // Card form
                currentTop = LayoutCardForm(contentW, currentTop, isDesktop, isTablet, isMobile);

                // Update scrollable area
                pnlMain.AutoScrollMinSize = new Size(0, currentTop + LayoutMargin);
            }
            finally
            {
                pnlCard.ResumeLayout();
                pnlSidebar.ResumeLayout();
                pnlMain.ResumeLayout();
            }
        }

        // ---------- Sidebar (copied from DashboardForm) ----------
        private void StoreOriginalSidebarTexts()
        {
            var btns = new[] { btnNavDashboard, btnNavTransaction, btnNavHistory,
                               btnNavMemberships, btnNavDebts, btnNavGoals };
            foreach (var b in btns)
            {
                if (b.Tag == null) b.Tag = b.Text; // keep original
            }
        }

        private void ApplyEmojiFallbackFont()
        {
            string fontName = "Segoe UI";
            using (var installed = new System.Drawing.Text.InstalledFontCollection())
            {
                var names = installed.Families.Select(f => f.Name).ToArray();
                if (names.Contains("Segoe UI Emoji"))
                    fontName = "Segoe UI Emoji";
                else if (names.Contains("Segoe UI Symbol"))
                    fontName = "Segoe UI Symbol";
            }

            var controls = new Control[]
            {
                btnNavDashboard, btnNavTransaction, btnNavHistory,
                btnNavMemberships, btnNavDebts, btnNavGoals, btnNavBack,
                lblSuccessIcon, lblWarningIcon
            };

            foreach (var c in controls)
            {
                if (c != null)
                    c.Font = new Font(fontName, c.Font.Size, c.Font.Style);
            }
        }

        private void LayoutSidebar(bool mobile)
        {
            int w = mobile ? SidebarCollapsed : SidebarExpanded;
            pnlSidebar.Width = w;
            pnlSidebar.Height = this.ClientSize.Height;

            if (pnlSidebar.BackColor == Color.Transparent)
                pnlSidebar.BackColor = Color.FromArgb(37, 37, 38);

            lblSidebarLogo.Visible = !mobile;
            lblSidebarSubtitle.Visible = !mobile;

            var btns = new[] { btnNavDashboard, btnNavTransaction, btnNavHistory,
                               btnNavMemberships, btnNavDebts, btnNavGoals };

            int startTop = 106;
            int backBtnHeight = 40;
            int bottomMargin = 12;
            int gapAboveBack = 12;

            int availableH = pnlSidebar.ClientSize.Height - startTop
                             - backBtnHeight - bottomMargin - gapAboveBack;

            const int idealBtnH = 48;
            const int idealGap = 6;
            int idealPerBtn = idealBtnH + idealGap;
            int neededH = btns.Length * idealPerBtn;

            int btnH, gap;
            bool needsScroll = false;

            if (availableH >= neededH)
            {
                btnH = idealBtnH;
                gap = idealGap;
            }
            else
            {
                float scale = Math.Max(0.6f, (float)availableH / neededH);
                btnH = Math.Max(30, (int)(idealBtnH * scale));
                gap = Math.Max(2, (int)(idealGap * scale));

                int scaledNeeded = btns.Length * (btnH + gap);
                needsScroll = scaledNeeded > availableH;
            }

            pnlSidebar.AutoScroll = needsScroll;

            int btnW = w - 24 - (needsScroll ? 16 : 0);
            int top = 106;
            foreach (var b in new[] { btnNavDashboard, btnNavTransaction, btnNavHistory,
                               btnNavMemberships, btnNavDebts, btnNavGoals })
            {
                b.Width = btnW;
                b.Left = 12;
                b.Top = top;
                b.Height = btnH;
                b.Visible = true;

                if (mobile)
                {
                    string original = b.Tag?.ToString() ?? b.Text;
                    string emoji = original.Split(' ')[0];
                    b.Text = emoji;
                    b.TextAlign = ContentAlignment.MiddleCenter;
                }
                else
                {
                    b.Text = b.Tag?.ToString() ?? b.Text;
                    b.TextAlign = ContentAlignment.MiddleLeft;
                }
                top += b.Height + gap;
            }

            btnNavBack.Left = 12;
            btnNavBack.Width = btnW;
            btnNavBack.Visible = true;
            if (needsScroll)
                btnNavBack.Top = top + 12;
            else
                btnNavBack.Top = pnlSidebar.ClientSize.Height - btnNavBack.Height - 12;
        }

        // ---------- Main content layout helpers ----------
        private int LayoutTitleBlock(int contentW, int top)
        {
            lblTitle.Width = contentW;
            lblTitle.Left = LayoutMargin;
            lblTitle.Top = top;

            lblSubtitle.Width = contentW;
            lblSubtitle.Left = LayoutMargin;
            lblSubtitle.Top = lblTitle.Bottom + 8;

            return lblSubtitle.Bottom;
        }

        private int LayoutAlertBoxes(int contentW, int top)
        {
            // Success box
            pnlSuccessBox.Width = contentW;
            pnlSuccessBox.Left = LayoutMargin;
            pnlSuccessBox.Top = top + LayoutMargin;

            // Warning box (below success)
            pnlWarningBox.Width = contentW;
            pnlWarningBox.Left = LayoutMargin;
            pnlWarningBox.Top = pnlSuccessBox.Bottom + 8;

            return Math.Max(pnlSuccessBox.Bottom, pnlWarningBox.Bottom);
        }

        private int LayoutCardForm(int contentW, int top, bool desktop, bool tablet, bool mobile)
        {
            // Card form
            int cardW = contentW;
            pnlCard.Width = cardW;
            pnlCard.Left = LayoutMargin;
            pnlCard.Top = top + LayoutMargin;

            // Type label
            lblTypeLabel.Width = cardW - 40;
            lblTypeLabel.Left = 20;
            lblTypeLabel.Top = 20;

            // Type buttons - responsive layout
            LayoutTypeButtons(cardW, 50, desktop, tablet, mobile);

            // Amount
            lblAmountLabel.Width = cardW - 40;
            lblAmountLabel.Left = 20;
            lblAmountLabel.Top = 110;

            lblDollarSign.Left = 20;
            lblDollarSign.Top = 138;

            txtAmount.Width = cardW - 64;
            txtAmount.Left = 44;
            txtAmount.Top = 134;

            lblAmountError.Width = cardW - 40;
            lblAmountError.Left = 20;
            lblAmountError.Top = 170;

            // Category
            lblCategoryLabel.Width = cardW - 40;
            lblCategoryLabel.Left = 20;
            lblCategoryLabel.Top = 196;

            cmbCategory.Width = cardW - 40;
            cmbCategory.Left = 20;
            cmbCategory.Top = 222;

            lblCategoryError.Width = cardW - 40;
            lblCategoryError.Left = 20;
            lblCategoryError.Top = 256;

            // Description
            lblDescriptionLabel.Width = cardW - 40;
            lblDescriptionLabel.Left = 20;
            lblDescriptionLabel.Top = 282;

            txtDescription.Width = cardW - 40;
            txtDescription.Left = 20;
            txtDescription.Top = 308;

            lblDescriptionError.Width = cardW - 40;
            lblDescriptionError.Left = 20;
            lblDescriptionError.Top = 396;

            // Date
            lblDateLabel.Width = cardW - 40;
            lblDateLabel.Left = 20;
            lblDateLabel.Top = 422;

            txtDate.Width = Math.Min(300, cardW - 40);
            txtDate.Left = 20;
            txtDate.Top = 448;

            lblDateError.Width = cardW - 40;
            lblDateError.Left = 20;
            lblDateError.Top = 482;

            // Buttons
            int btnsTop = 520;
            btnSave.Width = desktop ? 478 : (cardW - 40);
            btnSave.Left = 20;
            btnSave.Top = btnsTop;

            btnCancel.Width = 150;
            btnCancel.Left = desktop ? 510 : (cardW - 170);
            if (!desktop) btnCancel.Left = 20;
            btnCancel.Top = desktop ? btnsTop : (btnSave.Bottom + 10);

            int cardBottom = Math.Max(btnSave.Bottom, btnCancel.Bottom) + 20;
            pnlCard.Height = cardBottom;

            return pnlCard.Bottom;
        }

        private void LayoutTypeButtons(int cardW, int top, bool desktop, bool tablet, bool mobile)
        {
            if (desktop)
            {
                // Three columns side by side
                int gap = ColGap;
                int btnW = (cardW - 40 - 2 * gap) / 3;

                btnTypeIncome.Width = btnW;
                btnTypeIncome.Left = 20;
                btnTypeIncome.Top = top;
                btnTypeIncome.Height = 42;

                btnTypeExpense.Width = btnW;
                btnTypeExpense.Left = btnTypeIncome.Right + gap;
                btnTypeExpense.Top = top;
                btnTypeExpense.Height = 42;

                btnTypeInvestment.Width = btnW;
                btnTypeInvestment.Left = btnTypeExpense.Right + gap;
                btnTypeInvestment.Top = top;
                btnTypeInvestment.Height = 42;
            }
            else
            {
                // Tablet/Mobile: stacked vertically
                int btnW = cardW - 40;
                int btnH = 42;
                int gap = 8;
                int left = 20;

                btnTypeIncome.Width = btnW;
                btnTypeIncome.Left = left;
                btnTypeIncome.Top = top;
                btnTypeIncome.Height = btnH;

                btnTypeExpense.Width = btnW;
                btnTypeExpense.Left = left;
                btnTypeExpense.Top = top + btnH + gap;
                btnTypeExpense.Height = btnH;

                btnTypeInvestment.Width = btnW;
                btnTypeInvestment.Left = left;
                btnTypeInvestment.Top = top + 2 * (btnH + gap);
                btnTypeInvestment.Height = btnH;
            }
        }

        // ---------- Existing logic ----------
        private void WireEvents()
        {
            btnNavDashboard.Click += (s, e) => Raise("dashboard");
            btnNavTransaction.Click += (s, e) => Raise("transaction");
            btnNavHistory.Click += (s, e) => Raise("history");
            btnNavMemberships.Click += (s, e) => Raise("memberships");
            btnNavDebts.Click += (s, e) => Raise("debts");
            btnNavGoals.Click += (s, e) => Raise("goals");
            btnNavBack.Click += (s, e) => Raise("landing");

            btnTypeIncome.Click += (s, e) => SelectType(TxType.Ingreso);
            btnTypeExpense.Click += (s, e) => SelectType(TxType.Gasto);
            btnTypeInvestment.Click += (s, e) => SelectType(TxType.Inversion);

            txtAmount.TextChanged += (s, e) => UpdateBalanceWarning();

            btnSave.Click += BtnSave_Click;
            btnCancel.Click += BtnCancel_Click;
        }

        private void Raise(string target)
        {
            EventHandler<string> handler = NavigateRequested;
            if (handler != null) handler(this, target);
        }

        private void SelectType(TxType type)
        {
            _type = type;
            ApplyTypeStyles();
            LoadCategories();
            UpdateBalanceWarning();
        }

        private void ApplyTypeStyles()
        {
            SetTypeButtonStyle(btnTypeIncome, _type == TxType.Ingreso);
            SetTypeButtonStyle(btnTypeExpense, _type == TxType.Gasto);
            SetTypeButtonStyle(btnTypeInvestment, _type == TxType.Inversion);
        }

        private static void SetTypeButtonStyle(Button btn, bool selected)
        {
            if (selected)
            {
                btn.BackColor = System.Drawing.Color.FromArgb(38, 55, 82);
                btn.ForeColor = System.Drawing.Color.FromArgb(55, 148, 255);
                btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(55, 148, 255);
            }
            else
            {
                btn.BackColor = System.Drawing.Color.Transparent;
                btn.ForeColor = System.Drawing.Color.FromArgb(133, 133, 133);
                btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(60, 60, 60);
            }
        }

        private void LoadCategories()
        {
            cmbCategory.Items.Clear();
            foreach (string c in AppData.Categories[_type]) cmbCategory.Items.Add(c);
            cmbCategory.SelectedIndex = -1;
        }

        private void UpdateBalanceWarning()
        {
            decimal amount;
            bool parsed = TryParseMoney(txtAmount.Text, out amount);
            decimal balance = AppData.Balance;

            if (_type == TxType.Gasto && parsed && amount > balance)
            {
                lblWarningText.Text = "El gasto excede tu saldo disponible (" + Fmt.Money(balance) + ")";
                pnlWarningBox.Visible = true;
            }
            else
            {
                pnlWarningBox.Visible = false;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            HideErrors();
            pnlSuccessBox.Visible = false;

            bool valid = true;
            decimal amount = 0;

            if (string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                ShowError(lblAmountError, "El monto es requerido");
                valid = false;
            }
            else if (!TryParseMoney(txtAmount.Text, out amount))
            {
                ShowError(lblAmountError, "El monto debe ser un numero valido");
                valid = false;
            }
            else if (amount <= 0)
            {
                ShowError(lblAmountError, "El monto debe ser mayor a cero");
                valid = false;
            }

            if (cmbCategory.SelectedItem == null)
            {
                ShowError(lblCategoryError, "La categoria es requerida");
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                ShowError(lblDescriptionError, "La descripcion es requerida");
                valid = false;
            }

            DateTime date;
            if (!DateTime.TryParseExact(txtDate.Text.Trim(), "yyyy-MM-dd",
                    CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
            {
                ShowError(lblDateError, "Usa el formato AAAA-MM-DD");
                valid = false;
                date = DateTime.Today;
            }

            if (!valid) return;

            TryParseMoney(txtAmount.Text, out amount);

            bool guardado = BaseDatos.InsertarTransaccion(new Transaction
            {
                Date = date,
                Type = _type,
                Category = cmbCategory.SelectedItem.ToString(),
                Description = txtDescription.Text.Trim(),
                Amount = amount
            });
            if (!guardado) return;

            pnlSuccessBox.Visible = true;
            ResetForm();
            StartSuccessTimer();
        }

        private void StartSuccessTimer()
        {
            if (_successTimer != null) _successTimer.Stop();
            _successTimer = new Timer { Interval = 3000 };
            _successTimer.Tick += delegate
            {
                pnlSuccessBox.Visible = false;
                _successTimer.Stop();
            };
            _successTimer.Start();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            HideErrors();
            pnlSuccessBox.Visible = false;
            SelectType(TxType.Gasto);
            ResetForm();
        }

        private void ResetForm()
        {
            txtAmount.Text = "";
            txtDescription.Text = "";
            txtDate.Text = DateTime.Today.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
            ApplyTypeStyles();
            LoadCategories();
            UpdateBalanceWarning();
        }

        private static void ShowError(Label target, string message)
        {
            target.Text = message;
            target.Visible = true;
        }

        private void HideErrors()
        {
            lblAmountError.Visible = false;
            lblCategoryError.Visible = false;
            lblDescriptionError.Visible = false;
            lblDateError.Visible = false;
        }

        private static bool TryParseMoney(string text, out decimal value)
        {
            text = (text ?? "").Replace("$", "").Replace(" ", "").Replace(".", "").Replace(",", ".");
            return decimal.TryParse(text, NumberStyles.Any, CultureInfo.InvariantCulture, out value);
        }
    }
}