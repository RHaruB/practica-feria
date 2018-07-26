using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica_feria
{
    public partial class Aula : Form
    {
        conexion_base based = new conexion_base();
        public Aula()
        {
            InitializeComponent();
        }

        private void Aula_Load(object sender, EventArgs e)
        {
            //conexion_base conexion_nueva = new conexion_base();
            based.conexiondb();
            based.conexion.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 principal = new Form1();
            principal.Show();
            this.Close();

        }

        private void textBox_aula_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string direcion = "";
                string cod = textBox_aula.Text;
                based.query.CommandText = "select imagen from aula01 au where au.cod_aula='" + cod + "'";
                based.conexion.Open();
                based.query.Connection = based.conexion;
                based.consultar = based.query.ExecuteReader();
                while (based.consultar.Read())
                {
                    direcion = based.consultar.GetString(0);
                }
                //pictureBox1.Image = new System.Drawing.Bitmap(direcion);
                MessageBox.Show(direcion);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                based.conexion.Close();
            }
            
            
        }
    }
}
