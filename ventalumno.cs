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
    public partial class ventalumno : Form
    {
        conexion_base conexion_nueva = new conexion_base();
        SpeechSynthesizer leer = new SpeechSynthesizer();
        SpeechRecognitionEngine rec = new SpeechRecognitionEngine();
        escucha nuevoescucha=new escucha();
        string actual;
        public ventalumno(  )
        {
            InitializeComponent();
            actual = DateTime.Now.ToString("HH:mm:ss");
            escuchar();
        }

        private void label1_Click()
        {
           
        }
        public void hablar(SpeechRecognizedEventArgs e)
        {
            
            label1.Text = e.Result.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox_profesor_TextChanged(object sender, EventArgs e)
        {
            leer.Speak("Bienvenido " + Convert.ToString(Nombre_txt.Text) + "tienes clases en el curso " + Convert.ToString(curso_text.Text));
           // MessageBox.Show(actual);
        }

        private void ventalumno_Load(object sender, EventArgs e)
        {
            conexion_nueva.conexiondb();
        }
        public void _Recognition_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            textBox_ci_alumno.Text = e.Result.Text;
            // System.Windows.Forms.MessageBox.Show(palabra);
        }

        public void escuchar()
        {
            string selectdoc = "select cedula from alu01";

            rec.SetInputToDefaultAudioDevice();
            Choices listadocente = new Choices();
            listadocente.Add(nuevoescucha.gramaticadocente(selectdoc));
            Grammar gramatica = new Grammar(new GrammarBuilder(listadocente));
            //Grammar gramatica = ;
            rec.LoadGrammar(gramatica); 
            rec.SpeechRecognized += _Recognition_SpeechRecognized;
            rec.RecognizeAsync(RecognizeMode.Multiple);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 principal = new Form1();
            principal.Show();
            this.Close();
        }

        public void buscar(string cedula)
        {
            try
            {
                conexion_nueva.query.CommandText = "select a.cedula, a.nombres, a.apellidos, d.nom_mat, e.nom_pro, h.cod_aula, g.hora_ini, g.hora_fin, h.imagen from alu01 a join est01 b on (a.cedula = b.cedula) join matxest01 c on(b.cedula = c.cedula) join mat01 d on(c.cod_carrera = d.cod_carrera and c.cod_jornada = d.cod_jornada and c.cod_mat = d.cod_mat and c.paralelo = d.paralelo and c.periodo = d.periodo) join pro01 e on(d.cod_pro = e.cod_pro) join mat01 f on(e.cod_pro = f.cod_pro) join mathor01 g on(f.cod_mat = g.cod_mat) join aula01 h on(g.cod_aula = h.cod_aula) where a.cedula = '" + cedula + "' and '"+actual+"' between g.hora_ini and g.hora_fin ";
                conexion_nueva.conexion.Open();
                conexion_nueva.query.Connection = conexion_nueva.conexion;
                conexion_nueva.consultar = conexion_nueva.query.ExecuteReader();
                while (conexion_nueva.consultar.Read())
                {
                    Nombre_txt.Text = conexion_nueva.consultar.GetString(2)+ " "+ conexion_nueva.consultar.GetString(1);
                    pictureBox2.Image = new System.Drawing.Bitmap(conexion_nueva.consultar.GetString(8));
                    horario_text.Text = conexion_nueva.consultar.GetString(6)+ "-" + conexion_nueva.consultar.GetString(7);
                    curso_text.Text = conexion_nueva.consultar.GetString(5);
                    Materia_text.Text = conexion_nueva.consultar.GetString(3);
                    profesor_text.Text = conexion_nueva.consultar.GetString(4);
                    groupBox1.Visible = true;

                }
                conexion_nueva.conexion.Close();
            }
            catch (Exception el)
            {

                MessageBox.Show(el.Message);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
       
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btbuscar_Click(object sender, EventArgs e)
        {
            buscar(textBox_ci_alumno.Text);
        }

        private void Nombre_txt_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox_ci_alumno_TextChanged(object sender, EventArgs e)
        {
            btbuscar.PerformClick();
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbhora.Text = DateTime.Now.ToString("HH:mm:ss");
            lbfecha.Text = DateTime.Now.ToString("ddddd");
        }
    }
}
