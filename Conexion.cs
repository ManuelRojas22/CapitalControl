using System;
using Microsoft.Data.SqlClient;

namespace CapitalControl
{
    class Conexion
    {
        public static string CadenaConexion =>
            "Data Source=.;Initial Catalog=CapitalControl" +
            ";Integrated Security=True;TrustServerCertificate=True";

        public static string RegistrarUsuario(string nombre, string email, string password)
        {
            try
            {
                using (var cn = new SqlConnection(CadenaConexion))
                using (var cmd = new SqlCommand(
                    "INSERT INTO dbo.usuarios (nombres, email, password_hash, rol_id, estado, email_verificado) " +
                    "VALUES (@nombre, @email, @hash, 2, 'activo', 1)", cn))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@hash", BCrypt.Net.BCrypt.HashPassword(password));
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    return "";
                }
            }
            catch (SqlException ex) when (ex.Number == 2627 || ex.Number == 2601)
            {
                return "Ese correo ya está registrado";
            }
            catch (Exception ex)
            {
                return "Error de base de datos: " + ex.Message;
            }
        }

        public static string ValidarUsuario(string email, string password)
        {
            using (var cn = new SqlConnection(CadenaConexion))
            {
                cn.Open();
                using (var tx = cn.BeginTransaction())
                {
                    int id;
                    int intentos;
                    string nombre;
                    string hash;
                    string estado;
                    DateTime? bloqueadoHasta;

                    using (var cmd = new SqlCommand(
                        "SELECT id, nombres, password_hash, estado, intentos_fallidos, bloqueado_hasta " +
                        "FROM dbo.usuarios WHERE email = @email", cn, tx))
                    {
                        cmd.Parameters.AddWithValue("@email", email);
                        using (var dr = cmd.ExecuteReader())
                        {
                            if (!dr.Read())
                            {
                                RegistrarIntento(cn, tx, email, false, "usuario_inexistente");
                                tx.Commit();
                                return null;
                            }

                            id = dr.GetInt32(0);
                            nombre = dr.GetString(1);
                            hash = dr.GetString(2);
                            estado = dr.GetString(3);
                            intentos = dr.GetInt32(4);
                            bloqueadoHasta = dr.IsDBNull(5) ? (DateTime?)null : dr.GetDateTime(5);
                        }
                    }

                    if (estado != "activo" || (bloqueadoHasta.HasValue && bloqueadoHasta.Value > DateTime.Now))
                    {
                        RegistrarIntento(cn, tx, email, false, "bloqueado");
                        tx.Commit();
                        return null;
                    }

                    if (!BCrypt.Net.BCrypt.Verify(password, hash))
                    {
                        int nuevosIntentos = intentos + 1;
                        DateTime? hasta = nuevosIntentos >= 3 ? DateTime.Now.AddMinutes(15) : (DateTime?)null;

                        using (var cmd = new SqlCommand(
                            "UPDATE dbo.usuarios SET intentos_fallidos = @intentos, bloqueado_hasta = @hasta, " +
                            "estado = CASE WHEN @hasta IS NOT NULL THEN 'bloqueado' ELSE estado END " +
                            "WHERE id = @id", cn, tx))
                        {
                            cmd.Parameters.AddWithValue("@intentos", nuevosIntentos);
                            cmd.Parameters.AddWithValue("@hasta", (object)hasta ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.ExecuteNonQuery();
                        }

                        RegistrarIntento(cn, tx, email, false, "contrasena_incorrecta");
                        tx.Commit();
                        return null;
                    }

                    using (var cmd = new SqlCommand(
                        "UPDATE dbo.usuarios SET intentos_fallidos = 0, bloqueado_hasta = NULL, " +
                        "ultimo_acceso = SYSDATETIME() WHERE id = @id", cn, tx))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }

                    RegistrarIntento(cn, tx, email, true, null);
                    tx.Commit();
                    return nombre;
                }
            }
        }

        private static void RegistrarIntento(SqlConnection cn, SqlTransaction tx,
            string email, bool exitoso, string razon)
        {
            using (var cmd = new SqlCommand(
                "INSERT INTO dbo.intentos_login (email, exitoso, fecha, razon) " +
                "VALUES (@email, @exitoso, SYSDATETIME(), @razon)", cn, tx))
            {
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@exitoso", exitoso);
                cmd.Parameters.AddWithValue("@razon", (object)razon ?? DBNull.Value);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
