using System;
using System.Windows.Forms;

namespace CapitalControl
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm mainForm = new MainForm();
            LoginForm loginForm = new LoginForm();
            RegisterForm registerForm = new RegisterForm();
            DashboardForm dashboardForm = new DashboardForm();
            TransactionForm transactionForm = new TransactionForm();
            HistoryForm historyForm = new HistoryForm();
            MembershipsForm membershipsForm = new MembershipsForm();
            DebtsCreditsForm debtsCreditsForm = new DebtsCreditsForm();
            SavingsGoalsForm savingsGoalsForm = new SavingsGoalsForm();

            EventHandler<string> navigate = null;
            navigate = (sender, target) => Navigate(target,
                mainForm, loginForm, registerForm,
                dashboardForm, transactionForm, historyForm,
                membershipsForm, debtsCreditsForm, savingsGoalsForm);

            mainForm.NavigateRequested += navigate;
            loginForm.NavigateRequested += navigate;
            registerForm.NavigateRequested += navigate;
            dashboardForm.NavigateRequested += navigate;
            transactionForm.NavigateRequested += navigate;
            historyForm.NavigateRequested += navigate;
            membershipsForm.NavigateRequested += navigate;
            debtsCreditsForm.NavigateRequested += navigate;
            savingsGoalsForm.NavigateRequested += navigate;

            // Prevent closing the app when Login/Register are closed with the X button.
            FormClosingEventHandler hideAndShowMain = (s, e) =>
            {
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    e.Cancel = true;
                    ((Form)s).Hide();
                    mainForm.Show();
                }
            };
            loginForm.FormClosing += hideAndShowMain;
            registerForm.FormClosing += hideAndShowMain;

            // Start with the landing (MainForm)
            Application.Run(mainForm);
        }

        private static void Navigate(string target,
            MainForm mainForm,
            LoginForm loginForm,
            RegisterForm registerForm,
            DashboardForm dashboardForm,
            TransactionForm transactionForm,
            HistoryForm historyForm,
            MembershipsForm membershipsForm,
            DebtsCreditsForm debtsCreditsForm,
            SavingsGoalsForm savingsGoalsForm)
        {
            // Hide all forms first
            mainForm.Hide();
            loginForm.Hide();
            registerForm.Hide();
            dashboardForm.Hide();
            transactionForm.Hide();
            historyForm.Hide();
            membershipsForm.Hide();
            debtsCreditsForm.Hide();
            savingsGoalsForm.Hide();

            switch (target)
            {
                case "login":
                    loginForm.Show();
                    break;
                case "register":
                    registerForm.Show();
                    break;
                case "app":
                case "dashboard":
                    dashboardForm.Show();
                    break;
                case "transaction":
                    transactionForm.Show();
                    break;
                case "history":
                    historyForm.Show();
                    break;
                case "memberships":
                    membershipsForm.Show();
                    break;
                case "debts":
                    debtsCreditsForm.Show();
                    break;
                case "goals":
                    savingsGoalsForm.Show();
                    break;
                case "landing":
                case "main":
                default:
                    mainForm.Show();
                    break;
            }
        }
    }
}