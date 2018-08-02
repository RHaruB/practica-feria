using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace practica_feria
{
    public class conexion_base
    {
        public MySqlCommand query = new MySqlCommand();
        public MySqlConnection conexion;
        public MySqlDataReader consultar;
        public string sql = "server=rfzh1996.tk;user id=rfzh1996_biblio;Port=3306;database=rfzh1996_biblio;password=7TXSoa8c1o;Sslmode=none";
        //public string sql = "SERVER=localhost; DATABASE=ug;PORT=3308; UID=root; PWD=;Sslmode=none";
        public void conexiondb()
        {
            try
            {
                conexion = new MySqlConnection();
                conexion.ConnectionString = sql;
                conexion.Open();
                //System.Windows.Forms.MessageBox.Show("exito");
                conexion.Close();
            }
            catch (Exception )
            {
               // System.Windows.Forms.MessageBox.Show(ex.Message);
               // throw ex;
            }
        }
       
    
    }
}
