using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using CapitalControl.Models;

namespace CapitalControl.Services
{
    /// <summary>
    /// Guarda y carga los datos del usuario (transacciones, deudas, metas y
    /// membresías) en SQL Server. Todas las consultas usan parámetros (@...).
    /// Los métodos de guardar devuelven true si todo salió bien; si falla,
    /// muestran el error en un MessageBox y devuelven false.
    /// </summary>
    public static class BaseDatos
    {
        // ------------------------------------------------------------------
        // Utilidades
        // ------------------------------------------------------------------
        private static SqlConnection AbrirConexion()
        {
            var cn = new SqlConnection(Conexion.CadenaConexion);
            cn.Open();
            return cn;
        }

        private static bool MostrarError(Exception ex)
        {
            MessageBox.Show("Error de base de datos:\n" + ex.Message, "CapitalControl",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        // TxType <-> texto guardado en la columna "tipo"
        private static string TipoATexto(TxType tipo)
        {
            if (tipo == TxType.Ingreso) return "Ingreso";
            if (tipo == TxType.Gasto) return "Gasto";
            return "Inversion";
        }

        private static TxType TextoATipo(string texto)
        {
            if (texto == "Ingreso") return TxType.Ingreso;
            if (texto == "Gasto") return TxType.Gasto;
            return TxType.Inversion;
        }

        // ------------------------------------------------------------------
        // Usuario y carga inicial
        // ------------------------------------------------------------------
        public static int ObtenerIdUsuario(string email)
        {
            using (var cn = AbrirConexion())
            using (var cmd = new SqlCommand("SELECT id FROM dbo.usuarios WHERE email = @email", cn))
            {
                cmd.Parameters.AddWithValue("@email", email);
                object id = cmd.ExecuteScalar();
                return id == null ? 0 : Convert.ToInt32(id);
            }
        }

        /// <summary>Se llama después del login/registro: llena AppData con los datos del usuario.</summary>
        public static bool CargarDatosUsuario()
        {
            try
            {
                CargarCategorias();
                CargarTransacciones();
                CargarDeudas();
                CargarMetas();
                CargarMembresias();
                AppData.RecalcularBalance();
                return true;
            }
            catch (Exception ex) { return MostrarError(ex); }
        }

        private static void CargarCategorias()
        {
            foreach (var lista in AppData.Categories.Values) lista.Clear();

            using (var cn = AbrirConexion())
            using (var cmd = new SqlCommand("SELECT tipo, nombre FROM dbo.categorias ORDER BY nombre", cn))
            using (var dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    AppData.Categories[TextoATipo(dr.GetString(0))].Add(dr.GetString(1));
                }
            }
        }

        private static void CargarTransacciones()
        {
            AppData.Transactions.Clear();

            using (var cn = AbrirConexion())
            using (var cmd = new SqlCommand(
                "SELECT id, tipo, monto, categoria, descripcion, fecha FROM dbo.transacciones " +
                "WHERE usuario_id = @uid ORDER BY fecha DESC, id DESC", cn))
            {
                cmd.Parameters.AddWithValue("@uid", AppData.UserId);
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        var t = new Transaction
                        {
                            Id = dr.GetInt32(0),
                            Type = TextoATipo(dr.GetString(1)),
                            Amount = dr.GetDecimal(2),
                            Category = dr.GetString(3),
                            Description = dr.GetString(4),
                            Date = dr.GetDateTime(5)
                        };
                        t.RaiseAll();
                        AppData.Transactions.Add(t);
                    }
                }
            }
        }

        private static void CargarDeudas()
        {
            AppData.Debts.Clear();

            using (var cn = AbrirConexion())
            using (var cmd = new SqlCommand(
                "SELECT id, acreedor, es_banco, total, pagado, fecha_vencimiento, tasa_interes FROM dbo.deudas " +
                "WHERE usuario_id = @uid ORDER BY id DESC", cn))
            {
                cmd.Parameters.AddWithValue("@uid", AppData.UserId);
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        var d = new Debt
                        {
                            Id = dr.GetInt32(0),
                            Creditor = dr.GetString(1),
                            IsBank = dr.GetBoolean(2),
                            Total = dr.GetDecimal(3),
                            Paid = dr.GetDecimal(4),
                            DueDate = dr.GetDateTime(5),
                            InterestRate = (double)dr.GetDecimal(6)
                        };
                        d.RaiseAll();
                        AppData.Debts.Add(d);
                    }
                }
            }
        }

        private static void CargarMetas()
        {
            AppData.Goals.Clear();

            using (var cn = AbrirConexion())
            using (var cmd = new SqlCommand(
                "SELECT id, nombre, categoria, objetivo, actual, fecha_objetivo, color FROM dbo.metas_ahorro " +
                "WHERE usuario_id = @uid ORDER BY id DESC", cn))
            {
                cmd.Parameters.AddWithValue("@uid", AppData.UserId);
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        var g = new SavingsGoal
                        {
                            Id = dr.GetInt32(0),
                            Name = dr.GetString(1),
                            Category = dr.IsDBNull(2) ? "" : dr.GetString(2),
                            Target = dr.GetDecimal(3),
                            Current = dr.GetDecimal(4),
                            TargetDate = dr.GetDateTime(5).ToString("yyyy-MM-dd"),
                            ColorKey = dr.GetString(6)
                        };
                        g.RaiseAll();
                        AppData.Goals.Add(g);
                    }
                }
            }
        }

        private static void CargarMembresias()
        {
            AppData.Subscriptions.Clear();

            using (var cn = AbrirConexion())
            using (var cmd = new SqlCommand(
                "SELECT id, nombre, costo, dia_facturacion, logo, activa FROM dbo.membresias " +
                "WHERE usuario_id = @uid ORDER BY id DESC", cn))
            {
                cmd.Parameters.AddWithValue("@uid", AppData.UserId);
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        var s = new Subscription
                        {
                            Id = dr.GetInt32(0),
                            Name = dr.GetString(1),
                            Cost = dr.GetDecimal(2),
                            BillingDay = dr.GetInt32(3),
                            Logo = dr.IsDBNull(4) ? "" : dr.GetString(4),
                            IsActive = dr.GetBoolean(5)
                        };
                        s.RaiseAll();
                        AppData.Subscriptions.Add(s);
                    }
                }
            }
        }

        // ------------------------------------------------------------------
        // Transacciones
        // ------------------------------------------------------------------
        /// <summary>Guarda la transacción, le asigna su Id y la agrega al inicio de AppData.Transactions.</summary>
        public static bool InsertarTransaccion(Transaction t)
        {
            try
            {
                using (var cn = AbrirConexion())
                using (var cmd = new SqlCommand(
                    "INSERT INTO dbo.transacciones (usuario_id, tipo, monto, categoria, descripcion, fecha) " +
                    "OUTPUT INSERTED.id VALUES (@uid, @tipo, @monto, @cat, @desc, @fecha)", cn))
                {
                    cmd.Parameters.AddWithValue("@uid", AppData.UserId);
                    cmd.Parameters.AddWithValue("@tipo", TipoATexto(t.Type));
                    cmd.Parameters.AddWithValue("@monto", t.Amount);
                    cmd.Parameters.AddWithValue("@cat", t.Category);
                    cmd.Parameters.AddWithValue("@desc", t.Description);
                    cmd.Parameters.AddWithValue("@fecha", t.Date.Date);
                    t.Id = (int)cmd.ExecuteScalar();
                }

                t.RaiseAll();
                AppData.Transactions.Insert(0, t);
                AppData.RecalcularBalance();
                return true;
            }
            catch (Exception ex) { return MostrarError(ex); }
        }

        // ------------------------------------------------------------------
        // Deudas
        // ------------------------------------------------------------------
        public static bool InsertarDeuda(Debt d)
        {
            try
            {
                using (var cn = AbrirConexion())
                using (var cmd = new SqlCommand(
                    "INSERT INTO dbo.deudas (usuario_id, acreedor, es_banco, total, pagado, fecha_vencimiento, tasa_interes) " +
                    "OUTPUT INSERTED.id VALUES (@uid, @acreedor, @banco, @total, @pagado, @venc, @tasa)", cn))
                {
                    cmd.Parameters.AddWithValue("@uid", AppData.UserId);
                    AgregarParametrosDeuda(cmd, d);
                    d.Id = (int)cmd.ExecuteScalar();
                }

                d.RaiseAll();
                AppData.Debts.Insert(0, d);
                return true;
            }
            catch (Exception ex) { return MostrarError(ex); }
        }

        public static bool ActualizarDeuda(Debt d)
        {
            try
            {
                using (var cn = AbrirConexion())
                using (var cmd = new SqlCommand(
                    "UPDATE dbo.deudas SET acreedor = @acreedor, es_banco = @banco, total = @total, pagado = @pagado, " +
                    "fecha_vencimiento = @venc, tasa_interes = @tasa WHERE id = @id AND usuario_id = @uid", cn))
                {
                    cmd.Parameters.AddWithValue("@id", d.Id);
                    cmd.Parameters.AddWithValue("@uid", AppData.UserId);
                    AgregarParametrosDeuda(cmd, d);
                    cmd.ExecuteNonQuery();
                }

                d.RaiseAll();
                return true;
            }
            catch (Exception ex) { return MostrarError(ex); }
        }

        private static void AgregarParametrosDeuda(SqlCommand cmd, Debt d)
        {
            cmd.Parameters.AddWithValue("@acreedor", d.Creditor ?? "");
            cmd.Parameters.AddWithValue("@banco", d.IsBank);
            cmd.Parameters.AddWithValue("@total", d.Total);
            cmd.Parameters.AddWithValue("@pagado", d.Paid);
            cmd.Parameters.AddWithValue("@venc", d.DueDate.Date);
            cmd.Parameters.AddWithValue("@tasa", (decimal)d.InterestRate);
        }

        // ------------------------------------------------------------------
        // Metas de ahorro
        // ------------------------------------------------------------------
        public static bool InsertarMeta(SavingsGoal g)
        {
            try
            {
                using (var cn = AbrirConexion())
                using (var cmd = new SqlCommand(
                    "INSERT INTO dbo.metas_ahorro (usuario_id, nombre, categoria, objetivo, actual, fecha_objetivo, color) " +
                    "OUTPUT INSERTED.id VALUES (@uid, @nombre, @cat, @objetivo, @actual, @fecha, @color)", cn))
                {
                    cmd.Parameters.AddWithValue("@uid", AppData.UserId);
                    AgregarParametrosMeta(cmd, g);
                    g.Id = (int)cmd.ExecuteScalar();
                }

                g.RaiseAll();
                AppData.Goals.Insert(0, g);
                return true;
            }
            catch (Exception ex) { return MostrarError(ex); }
        }

        public static bool ActualizarMeta(SavingsGoal g)
        {
            try
            {
                using (var cn = AbrirConexion())
                using (var cmd = new SqlCommand(
                    "UPDATE dbo.metas_ahorro SET nombre = @nombre, categoria = @cat, objetivo = @objetivo, actual = @actual, " +
                    "fecha_objetivo = @fecha, color = @color WHERE id = @id AND usuario_id = @uid", cn))
                {
                    cmd.Parameters.AddWithValue("@id", g.Id);
                    cmd.Parameters.AddWithValue("@uid", AppData.UserId);
                    AgregarParametrosMeta(cmd, g);
                    cmd.ExecuteNonQuery();
                }

                g.RaiseAll();
                return true;
            }
            catch (Exception ex) { return MostrarError(ex); }
        }

        public static bool EliminarMeta(SavingsGoal g)
        {
            try
            {
                using (var cn = AbrirConexion())
                using (var cmd = new SqlCommand("DELETE FROM dbo.metas_ahorro WHERE id = @id AND usuario_id = @uid", cn))
                {
                    cmd.Parameters.AddWithValue("@id", g.Id);
                    cmd.Parameters.AddWithValue("@uid", AppData.UserId);
                    cmd.ExecuteNonQuery();
                }

                AppData.Goals.Remove(g);
                return true;
            }
            catch (Exception ex) { return MostrarError(ex); }
        }

        private static void AgregarParametrosMeta(SqlCommand cmd, SavingsGoal g)
        {
            DateTime fecha;
            if (!DateTime.TryParse(g.TargetDate, out fecha)) fecha = DateTime.Today;

            cmd.Parameters.AddWithValue("@nombre", g.Name ?? "");
            cmd.Parameters.AddWithValue("@cat", (object)g.Category ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@objetivo", g.Target);
            cmd.Parameters.AddWithValue("@actual", g.Current);
            cmd.Parameters.AddWithValue("@fecha", fecha.Date);
            cmd.Parameters.AddWithValue("@color", g.ColorKey ?? "blue");
        }

        // ------------------------------------------------------------------
        // Membresías
        // ------------------------------------------------------------------
        public static bool InsertarMembresia(Subscription s)
        {
            try
            {
                using (var cn = AbrirConexion())
                using (var cmd = new SqlCommand(
                    "INSERT INTO dbo.membresias (usuario_id, nombre, costo, dia_facturacion, logo, activa) " +
                    "OUTPUT INSERTED.id VALUES (@uid, @nombre, @costo, @dia, @logo, @activa)", cn))
                {
                    cmd.Parameters.AddWithValue("@uid", AppData.UserId);
                    AgregarParametrosMembresia(cmd, s);
                    s.Id = (int)cmd.ExecuteScalar();
                }

                s.RaiseAll();
                AppData.Subscriptions.Insert(0, s);
                return true;
            }
            catch (Exception ex) { return MostrarError(ex); }
        }

        public static bool ActualizarMembresia(Subscription s)
        {
            try
            {
                using (var cn = AbrirConexion())
                using (var cmd = new SqlCommand(
                    "UPDATE dbo.membresias SET nombre = @nombre, costo = @costo, dia_facturacion = @dia, logo = @logo, " +
                    "activa = @activa WHERE id = @id AND usuario_id = @uid", cn))
                {
                    cmd.Parameters.AddWithValue("@id", s.Id);
                    cmd.Parameters.AddWithValue("@uid", AppData.UserId);
                    AgregarParametrosMembresia(cmd, s);
                    cmd.ExecuteNonQuery();
                }

                s.RaiseAll();
                return true;
            }
            catch (Exception ex) { return MostrarError(ex); }
        }

        private static void AgregarParametrosMembresia(SqlCommand cmd, Subscription s)
        {
            cmd.Parameters.AddWithValue("@nombre", s.Name ?? "");
            cmd.Parameters.AddWithValue("@costo", s.Cost);
            cmd.Parameters.AddWithValue("@dia", s.BillingDay);
            cmd.Parameters.AddWithValue("@logo", (object)s.Logo ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@activa", s.IsActive);
        }
    }
}
