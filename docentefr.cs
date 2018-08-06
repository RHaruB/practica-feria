using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech.Recognition;


namespace practica_feria
{
    public partial class horainicio_text : Form
    {
        public SpeechRecognitionEngine rec = new SpeechRecognitionEngine();
        SpeechSynthesizer leer = new SpeechSynthesizer();

        escucha nuevoescucha = new escucha();
        conexion_base based = new conexion_base();
        string hora_actual;
        public horainicio_text()
        {
            InitializeComponent();
            hora_actual = DateTime.Now.ToString("HH:mm:ss");
            
        }

        private void docentecbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void docentefr_Load(object sender, EventArgs e)
        {
            //conexion_base conexion_nueva = new conexion_base();
            //conexion_nueva.conexiondb();

            based.conexiondb();
            escuchar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 principal = new Form1();
            principal.Show();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void buscar(string nombre)
        {
            try
            {
                based.query.CommandText = "select p.nom_pro, m.nom_mat, m.paralelo, au.cod_aula, au.imagen, ma.hora_ini, ma.hora_fin  from pro01 p join mat01 m on (p.cod_pro=m.cod_pro) join mathor01 ma on (m.cod_mat=ma.cod_mat and m.paralelo=ma.paralelo and m.cod_carrera=ma.cod_carrera and m.cod_jornada=ma.cod_jornada and m.periodo=ma.periodo) join aula01 au on (ma.cod_aula=au.cod_aula) where p.nom_pro ='" + nombre + "' and '"+hora_actual+"' between ma.hora_ini and ma.hora_fin ";
                based.conexion.Open();
                based.query.Connection = based.conexion;
                based.consultar = based.query.ExecuteReader();
                while (based.consultar.Read())
                {
                    textnombre.Text = based.consultar.GetString(0);
                    pictureBox2.Image = new System.Drawing.Bitmap(based.consultar.GetString(4));
                    paralelo_text.Text = based.consultar.GetString(2);
                    Materia_text.Text = based.consultar.GetString(1);
                    texthorainici.Text =  based.consultar.GetString(5);
                    horafin_text.Text = based.consultar.GetString(6);
                    textcurso.Text = based.consultar.GetString(3);
                    
    //                MessageBox.Show(based.consultar.GetString(4));

                }
                based.conexion.Close();
            }
            catch (Exception el)
            {

                MessageBox.Show(el.Message);
            }
            
            
        }

        private void btbuscar_Click(object sender, EventArgs e)
        {
            buscar(textBox_docente.Text);
        }
        public void escuchar()
        {
            string selectdoc = "select nom_pro from pro01";
            
            rec.SetInputToDefaultAudioDevice();
            Choices listadocente = new Choices();
            listadocente.Add(nuevoescucha.gramaticadocente(selectdoc)  );
            Grammar gramatica = new Grammar(new GrammarBuilder(listadocente));
            //Grammar gramatica = ;
            rec.LoadGrammar(gramatica);
            //rec.LoadGrammar(new DictationGrammar());
            rec.SpeechRecognized += _Recognition_SpeechRecognized;
            rec.RecognizeAsync(RecognizeMode.Multiple);
        }
        public void _Recognition_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
           // MessageBox.Show(e.Result.Text);
            textBox_docente.Text = e.Result.Text;
            // System.Windows.Forms.MessageBox.Show(palabra);
        }

        private void textBox_docente_TextChanged(object sender, EventArgs e)
        {
            if (this.Text == "regresar" || this.Text == "salir")
            {
                button1.PerformClick();
            }
            else
                btbuscar.PerformClick();
        }

        private void textnombre_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textcurso_TextChanged(object sender, EventArgs e)
        {
            rec.RecognizeAsyncStop();
            leer.Speak("El Docente" + Convert.ToString(textnombre.Text) + "da clases de " + Convert.ToString(Materia_text.Text) + "  en el curso " + Convert.ToString(textcurso.Text));
             string palabra=nuevoescucha.retornar();
             if(palabra=="salir" ) button1.PerformClick();
            //retornar();
        }

        private void groupBox_horario_docente_Enter(object sender, EventArgs e)
        {

        }
        public void retornar()
        {

            leer.Rate = 0;
            leer.Volume = 100;
            leer.Speak(" si deseas salir solo dilo ?");
            Choices lista = new Choices();
            lista.Add(new string[] { "salir", "retornar", "papa", "volver" });
            Grammar gramatica = new Grammar(new GrammarBuilder(lista));
            try
            {
                rec.SetInputToDefaultAudioDevice();
                rec.LoadGrammar(gramatica);
                rec.SpeechRecognized += reconocimiento1;
                rec.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch (Exception el)
            {

                //MessageBox.Show(el.Message); ;
            }
            rec.RecognizeAsyncStop();
            System.Windows.Forms.MessageBox.Show("si llego");
            //palabra = "salir";
            //return palabra;

        }
        public void reconocimiento1(object sender, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Text == "salir" || e.Result.Text == "volver" || e.Result.Text == "papa")
            {
                button1.PerformClick();
            }
        }
    }

}
