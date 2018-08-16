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
        public SpeechRecognitionEngine rec1 = new SpeechRecognitionEngine();
        SpeechSynthesizer leer = new SpeechSynthesizer();
       
        escucha nuevoescucha = new escucha();
        conexion_base based = new conexion_base();
        //string ban = "i";
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
            rec1.RecognizeAsyncStop(); 
            rec.RecognizeAsyncStop();
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
                based.query.CommandText = "select imagen from aula01 au where au.cod_aula ='" + cod + "'";
                based.conexion.Open();
                based.query.Connection = based.conexion;
                based.consultar = based.query.ExecuteReader();
                while (based.consultar.Read())
                {
                    direcion = based.consultar.GetString(0);
                }
                //MessageBox.Show(direcion);
                pictureBox2.Image = new System.Drawing.Bitmap(based.consultar.GetString(0));
                rec.RecognizeAsyncStop();
                leer.Speak("ese es el curso" + textBox_aula.Text);
                retornar();
                /*nuevoescucha.escucharsalir();
                if(nuevoescucha.palabra == "si")
                {
                    button1.PerformClick();
                }*/


            }
            catch (Exception ex )
            {

               //  MessageBox.Show(ex.Message);
            }
            finally
            {
                based.conexion.Close();
            }
        }

        public void escuchar()
        {
            string selectdoc = "select cod_aula from aula01";

            rec.SetInputToDefaultAudioDevice();
            Choices listadocente = new Choices();
            listadocente.Add(nuevoescucha.gramaticadocente(selectdoc));
            Grammar gramatica = new Grammar(new GrammarBuilder(listadocente));
            //Grammar gramatica = ;
            rec.LoadGrammar(gramatica);
            rec.SpeechRecognized += _Recognition_SpeechRecognized;
            rec.RecognizeAsync(RecognizeMode.Multiple);
        }

        private void textBox_aula_TextChanged(object sender, EventArgs e)
        {
            if(this.Text== "regresar" || this.Text == "salir")
            {
               // button1.PerformClick();
            }
                else
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           /* nuevoescucha.escucharsalir();
            if (nuevoescucha.palabra == "si")
            {
                button1.PerformClick();
            }
            */
        }
        public void retornar()
        {

            leer.Rate = 0;
            leer.Volume = 100;
            leer.Speak(" si deseas salir solo dilo");
            Choices lista = new Choices();
            lista.Add(new string[] { "salir", "retornar", "papa", "volver" });
            Grammar gramatica = new Grammar(new GrammarBuilder(lista));
            try
            {
                rec1.SetInputToDefaultAudioDevice();
                rec1.LoadGrammar(gramatica);
                rec1.SpeechRecognized += reconocimiento1;
                rec1.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch (Exception el)
            {

                MessageBox.Show(el.Message); ;
            }
            //rec.RecognizeAsyncStop();
            //System.Windows.Forms.MessageBox.Show("si llego");
            //palabra = "salir";
            //return palabra;

        }
        public void reconocimiento1(object sender, SpeechRecognizedEventArgs e)
        {
            //textBox1.Text = e.Result.Text;
            if (e.Result.Text == "salir" || e.Result.Text == "volver" || e.Result.Text == "papa")
            {
                 button1.PerformClick();
            }
        }
    }
}
