using System;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace CapitalControl
{
    public class UsuariosForm : Form
    {
        private sealed class RolItem
        {
            public int Id { get; }
            public string Nombre { get; }

            public RolItem(int id, string nombre)
            {
                Id = id;
                Nombre = nombre;
            }

            public override string ToString()
            {
                return Nombre;
            }
        }

        private readonly DataGridView grid = new DataGridView();
        private readonly TextBox txtId = new TextBox();
        private readonly TextBox txtNombres = new TextBox();
        private readonly TextBox txtApellidos = new TextBox();
        private readonly TextBox txtEmail = new TextBox();
        private readonly TextBox txtTelefono = new TextBox();
        private readonly TextBox txtClave = new TextBox();
        private readonly ComboBox cboRol = new ComboBox();
        private readonly ComboBox cboEstado = new ComboBox();
        private readonly Button btnNuevo = new Button { Text = "Nuevo" };
        private readonly Button btnGuardar = new Button { Text = "Guardar" };
        private readonly Button btnEliminar = new Button { Text = "Eliminar" };
        private readonly Button btnCerrar = new Button { Text = "Cerrar" };
        private bool _nuevo;

        public UsuariosForm()
        {
            Text = "CapitalControl - Usuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Size = new Size(880, 580);
            MinimumSize = new Size(780, 520);

            txtId.ReadOnly = true;
            txtClave.UseSystemPasswordChar = true;
            cboRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.Items.AddRange(new object[] { "activo", "inactivo", "bloqueado", "pendiente_verificacion" });

            var campos = new TableLayoutPanel
            {
                Dock = DockStyle.Top,
                ColumnCount = 2,
                RowCount = 8,
                Height = 250,
                Padding = new Padding(10)
            };
            campos.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110));
            campos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            AgregarCampo(campos, "Id", txtId, 0);
            AgregarCampo(campos, "Nombres", txtNombres, 1);
            AgregarCampo(campos, "Apellidos", txtApellidos, 2);
            AgregarCampo(campos, "Correo", txtEmail, 3);
            AgregarCampo(campos, "Teléfono", txtTelefono, 4);
            AgregarCampo(campos, "Contraseña", txtClave, 5);
            AgregarCampo(campos, "Rol", cboRol, 6);
            AgregarCampo(campos, "Estado", cboEstado, 7);

            var botones = new FlowLayoutPanel
            {
                Dock = DockStyle.Bottom,
                Height = 48,
                Padding = new Padding(10, 8, 10, 8)
            };
            botones.Controls.Add(btnNuevo);
            botones.Controls.Add(btnGuardar);
            botones.Controls.Add(btnEliminar);
            botones.Controls.Add(btnCerrar);

            grid.Dock = DockStyle.Fill;
            grid.ReadOnly = true;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.MultiSelect = false;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            Controls.Add(grid);
            Controls.Add(botones);
            Controls.Add(campos);

            Load += (s, e) => Cargar();
            grid.SelectionChanged += Grid_SelectionChanged;
            btnNuevo.Click += Nuevo_Click;
            btnGuardar.Click += Guardar_Click;
            btnEliminar.Click += Eliminar_Click;
            btnCerrar.Click += (s, e) => Close();
        }

        private static void AgregarCampo(TableLayoutPanel panel, string texto, Control control, int fila)
        {
            var etiqueta = new Label
            {
                Text = texto + ":",
                AutoSize = true,
                Anchor = AnchorStyles.Left | AnchorStyles.Right,
                TextAlign = ContentAlignment.MiddleLeft
            };
            control.Dock = DockStyle.Fill;
            control.Margin = new Padding(3, 4, 3, 4);
            panel.Controls.Add(etiqueta, 0, fila);
            panel.Controls.Add(control, 1, fila);
        }

        private void Cargar()
        {
            try
            {
                cboRol.Items.Clear();
                using (var cn = new SqlConnection(Conexion.CadenaConexion))
                using (var cmd = new SqlCommand("SELECT id, nombre FROM dbo.roles ORDER BY nombre", cn))
                {
                    cn.Open();
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            cboRol.Items.Add(new RolItem(dr.GetInt32(0), dr.GetString(1)));
                        }
                    }
                }

                using (var cn = new SqlConnection(Conexion.CadenaConexion))
                using (var da = new SqlDataAdapter(
                    "SELECT u.id, u.nombres, u.apellidos, u.email, u.telefono, u.rol_id, " +
                    "r.nombre AS rol, u.estado FROM dbo.usuarios u " +
                    "LEFT JOIN dbo.roles r ON r.id = u.rol_id " +
                    "ORDER BY u.apellidos, u.nombres", cn))
                {
                    var dt = new DataTable();
                    da.Fill(dt);
                    grid.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los usuarios:\n" + ex.Message,
                    "CapitalControl", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Grid_SelectionChanged(object sender, EventArgs e)
        {
            if (grid.CurrentRow == null || grid.CurrentRow.DataBoundItem == null) return;

            var fila = ((DataRowView)grid.CurrentRow.DataBoundItem).Row;
            txtId.Text = Convert.ToString(fila["id"]);
            txtNombres.Text = Convert.ToString(fila["nombres"]);
            txtApellidos.Text = Convert.ToString(fila["apellidos"]);
            txtEmail.Text = Convert.ToString(fila["email"]);
            txtTelefono.Text = Convert.ToString(fila["telefono"]);
            txtClave.Clear();
            cboEstado.Text = Convert.ToString(fila["estado"]);

            int rolId = Convert.ToInt32(fila["rol_id"]);
            for (int i = 0; i < cboRol.Items.Count; i++)
            {
                if (((RolItem)cboRol.Items[i]).Id == rolId)
                {
                    cboRol.SelectedIndex = i;
                    break;
                }
            }
            _nuevo = false;
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            _nuevo = true;
            txtId.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();
            txtClave.Clear();
            if (cboRol.Items.Count > 0) cboRol.SelectedIndex = 0;
            cboEstado.Text = "activo";
            txtNombres.Focus();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            string nombres = txtNombres.Text.Trim();
            string apellidos = txtApellidos.Text.Trim();
            string email = txtEmail.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            string clave = txtClave.Text;
            var rol = cboRol.SelectedItem as RolItem;

            if (nombres.Length == 0 || apellidos.Length == 0 || email.Length == 0)
            {
                MessageBox.Show("Nombres, apellidos y correo son obligatorios.");
                return;
            }
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Ingresa un correo electrónico válido.");
                return;
            }
            if (rol == null)
            {
                MessageBox.Show("Selecciona un rol.");
                return;
            }
            if (_nuevo && clave.Length < 8)
            {
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres.");
                return;
            }
            if (ExisteEmail(email, _nuevo ? 0 : Convert.ToInt32(txtId.Text)))
            {
                MessageBox.Show("Ese correo ya está registrado.");
                return;
            }

            try
            {
                using (var cn = new SqlConnection(Conexion.CadenaConexion))
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = cn;
                    if (_nuevo)
                    {
                        cmd.CommandText =
                            "INSERT INTO dbo.usuarios (uuid, nombres, apellidos, email, password_hash, telefono, rol_id, estado, email_verificado) " +
                            "OUTPUT INSERTED.id VALUES (@uuid, @nombres, @apellidos, @email, @hash, @telefono, @rol, @estado, 1)";
                        cmd.Parameters.AddWithValue("@uuid", Guid.NewGuid());
                        cmd.Parameters.AddWithValue("@hash", BCrypt.Net.BCrypt.HashPassword(clave));
                    }
                    else
                    {
                        string cambiarClave = clave.Length > 0 ? ", password_hash = @hash" : "";
                        cmd.CommandText =
                            "UPDATE dbo.usuarios SET nombres = @nombres, apellidos = @apellidos, email = @email, " +
                            "telefono = @telefono, rol_id = @rol, estado = @estado" + cambiarClave + " WHERE id = @id";
                        cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtId.Text));
                        if (clave.Length > 0)
                        {
                            cmd.Parameters.AddWithValue("@hash", BCrypt.Net.BCrypt.HashPassword(clave));
                        }
                    }

                    cmd.Parameters.AddWithValue("@nombres", nombres);
                    cmd.Parameters.AddWithValue("@apellidos", apellidos);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@telefono", (object)telefono ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@rol", rol.Id);
                    cmd.Parameters.AddWithValue("@estado", cboEstado.Text);

                    cn.Open();
                    if (_nuevo)
                    {
                        txtId.Text = Convert.ToString(cmd.ExecuteScalar());
                    }
                    else
                    {
                        cmd.ExecuteNonQuery();
                    }
                }

                Cargar();
                MessageBox.Show("Datos guardados.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de base de datos:\n" + ex.Message,
                    "CapitalControl", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static bool ExisteEmail(string email, int idActual)
        {
            using (var cn = new SqlConnection(Conexion.CadenaConexion))
            using (var cmd = new SqlCommand(
                "SELECT COUNT(*) FROM dbo.usuarios WHERE email = @email AND id <> @id", cn))
            {
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@id", idActual);
                cn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (_nuevo || txtId.Text.Length == 0) return;

            var respuesta = MessageBox.Show("¿Eliminar al usuario " + txtEmail.Text + "?",
                "CapitalControl", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuesta != DialogResult.Yes) return;

            try
            {
                using (var cn = new SqlConnection(Conexion.CadenaConexion))
                using (var cmd = new SqlCommand("DELETE FROM dbo.usuarios WHERE id = @id", cn))
                {
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtId.Text));
                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
                Cargar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar el usuario:\n" + ex.Message,
                    "CapitalControl", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
