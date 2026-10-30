using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Drawing;

namespace CapitalControl
{
    class Conexion
    {
        SqlConnection Conn = new SqlConnection("Data Source=.\\MSSQLSERVER01;Initial Catalog=" + Conexion.VarGlobal.xNomDB + ";Integrated Security=True");
        //SqlConnection Conn = new SqlConnection("Data Source=ZAFARI\\MSSQLSERVER01;Initial Catalog=" + Conexion.VarGlobal.xNomDB + ";Integrated Security=True"); //Define Cadena de Conex conn
        //SqlConnection Conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Proyecto;Integrated Security=True"); //Define Cadena de Conex conn
        private SqlCommandBuilder Cmb;
        public DataSet Ds = new DataSet();
        public SqlDataAdapter Da;

        public DataSet DsNC = new DataSet();
        public SqlDataAdapter DaNC;
        private SqlCommandBuilder CmbNC;

        public SqlCommand Comando;
        public static class VarGlobal
        {
            public static string xNomDB = "ADSO";
            public static int xColFrm = 0;
            public static int xEstIni = 0;
            public static int TiketNfac = 0; 
            public static string xNomU = "";
            public static string xNomC = "";
            public static string xTipoU = "";
            public static int xswCNF = 0;
            public static Color xColorFondo = Color.White;
            public static byte[] xFoto; // (byte[])fila["Foto"];
            public static byte[] xLogo;
            public static byte[] xFondo;

            public static int CenterFrm = 0;
        }
        public bool Conectar()
        {
            try { Conn.Open();  return true;  }
            catch (Exception ex) { MessageBox.Show("Error al Conectar Base de Datos por " + ex.ToString());  return false; }
            finally  { Conn.Close(); }
        }
        public bool ExisteT(string tabla)
        {
            Conn.Open();
            string ConsultaObj = @"SELECT Count(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = '" + tabla + "'";
            Comando = new SqlCommand(ConsultaObj, Conn);
            int i = Convert.ToInt32(Comando.ExecuteScalar());
            Conn.Close();
            if (i > 0) { return true; }
            else { MessageBox.Show("No existe la tabla <<" + tabla + ">>"); return false; }
        }

        public void ConsultaDatos(string sql, string Tabla)
        {
            Ds.Tables.Clear();
            Da = new SqlDataAdapter(sql, Conn);
            Cmb = new SqlCommandBuilder(Da);
            Da.Fill(Ds, Tabla);
        }

        public bool ConsultaItem(string tabla, string condicion)
        {
            Conn.Open();
            string ConsultaItem = "Select Count(*) From " + tabla + " Where " + condicion;
            Comando = new SqlCommand(ConsultaItem, Conn);
            int i = Convert.ToInt32(Comando.ExecuteScalar());
            Conn.Close();
            if (i > 0) { return true; }
            else { return false; } //MessageBox.Show("Registro NO existente"); 
        }

        public bool Insertar(string sql)
        {
            Conn.Open();
            Comando = new SqlCommand(sql, Conn);
            int i = Comando.ExecuteNonQuery();
            Conn.Close();
            if (i > 0) { return true; }
            else { return false; }
        }

        public bool Actualizar(string tabla, string campos, string condicion)
        {
            Conn.Open();
            string Actualizar = "Update " + tabla + " set " + campos + " Where " + condicion;
            Comando = new SqlCommand(Actualizar, Conn);
            int i = Comando.ExecuteNonQuery();
            Conn.Close();
            if (i > 0) { return true; }
            else { return false; }
        }

        public bool ActualizarSinId(string tabla, string campos)
        {
            Conn.Open();
            string Actualizar = "Update " + tabla + " set " + campos;
            Comando = new SqlCommand(Actualizar, Conn);
            int i = Comando.ExecuteNonQuery();
            Conn.Close();
            if (i > 0) { return true; }
            else { return false; }
        }

        public bool Eliminar(string tabla, string condicion)
        {
            Conn.Open();
            string Eliminar = "Delete From " + tabla + " Where " + condicion;
            Comando = new SqlCommand(Eliminar, Conn);
            int i = Comando.ExecuteNonQuery();
            Conn.Close();
            if (i > 0) { return true; }
            else { return false; }
        }
        public void ConsultaDatosNC(string sql, string Tabla)
        {
            DsNC.Tables.Clear();
            DaNC = new SqlDataAdapter(sql, Conn);
            CmbNC = new SqlCommandBuilder(DaNC);
            DaNC.Fill(DsNC, Tabla);
        }      
    }
}
