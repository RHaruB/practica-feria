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
                System.Windows.Forms.MessageBox.Show("exito");
                conexion.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                throw ex;
            }
        }
      /*  public string consultaaula(string direccion)
        {
            string img = "";
            //conexiondb();
            conexion = new MySqlConnection();
            conexion.ConnectionString = sql;
            conexion.Open();
            try
            {
                
                
                MySqlCommand comandobuscar = new MySqlCommand("select imagen from aula01 au where cod_aula='305';",conexion);
                MySqlDataReader reader = comandobuscar.ExecuteReader();
                while (reader.Read())
                {
                    img = reader.GetString(1);

                }
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);;
            }
            conexion.Close();
           

            return img;
        */
    }
}
