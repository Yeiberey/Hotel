using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Hotel
{
    public class Conexion
    {
        string cadena = "Data Source=YEIBEREY\\SQLEXPRESS;Initial Catalog=dbHotel; Integrated Security=true";
        public SqlConnection conectarDB = new SqlConnection();
        public Conexion()
        {
            conectarDB.ConnectionString = cadena;
        }
        public void abrir()
        {
            try
            {
                conectarDB.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("error al abrir BD " + ex.Message);
            }
        }
        public void cerrar()
        {
            conectarDB.Close();
        }

        public void SQL_SELECT(string select, string tabla, System.Windows.Forms.DataGridView datagrid)
        {
            abrir();
            string consulta = "select "+select+" from "+tabla;
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conectarDB);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            datagrid.DataSource = dt;
            cerrar();

        }


    }
}
