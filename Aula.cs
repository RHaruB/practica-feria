using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;

namespace practica_feria
{
    public partial class Aula : Form
    {
        public SpeechRecognitionEngine rec = new SpeechRecognitionEngine();
        SpeechSynthesizer leer = new SpeechSynthesizer();
       
        escucha nuevoescucha = new escucha();
        conexion_base based = new conexion_base();

        //string pal, bandera;
        public Aula()
        {
            InitializeComponent();
        }

        private void Aula_Load(object sender, EventArgs e)
        {
            
            based.conexiondb();
            based.conexion.Close();
            nuevoescucha.hablar("que curso deseas saber");
            escuchar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 principal = new Form1();
            principal.Show();
            this.Close();

        }
    
        private void buscarbd()
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
                MessageBox.Show(direcion);
                
                pictureBox2.Image = new System.Drawing.Bitmap(direcion);
                
            }
            catch (Exception ex )
            {

                 MessageBox.Show(ex.Message);
            }
            finally
            {
                based.conexion.Close();
            }
        }

        public void escuchar()
        {
            rec.SetInputToDefaultAudioDevice();
            rec.LoadGrammar(new DictationGrammar());
            rec.SpeechRecognized += _Recognition_SpeechRecognized;
            rec.RecognizeAsync(RecognizeMode.Multiple);
        }

        private void textBox_aula_TextChanged(object sender, EventArgs e)
        {
            buscarbd();
           /* rec.RecognizeAsyncStop();
            nuevoescucha.escuchar();
            if (nuevoescucha.palabra == "no") buscarbd();
            else
            {
                nuevoescucha.rec.RecognizeAsyncStop();
                escuchar();
            }*/
        }

        public void _Recognition_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            textBox_aula.Text = e.Result.Text;
            // System.Windows.Forms.MessageBox.Show(palabra);
        }

    }
}
