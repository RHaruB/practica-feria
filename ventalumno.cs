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
        SpeechRecognitionEngine rec1 = new SpeechRecognitionEngine();
        SpeechRecognitionEngine rec2 = new SpeechRecognitionEngine();
        escucha nuevoescucha=new escucha();
       public  string actual, palabra, hora_siguiente, dia;
        public ventalumno(  )
        {
            InitializeComponent();
            actual = DateTime.Now.ToString("HH:mm:ss");
            //actual = "21:00:00";
            // escuchar();
            hora_siguiente = DateTime.Now.AddHours(+1).ToString("HH:mm:ss");
            
            //MessageBox.Show(hora_actual);
            //hora_actual ="21:00:00";
            dia = DateTime.Now.ToString("ddddd").ToUpper();
            dia = dia.Substring(0, 1);

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
            escucharinicial();
           
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
            rec2.RecognizeAsyncStop();
            rec1.RecognizeAsyncStop();
            rec.RecognizeAsyncStop();
            Form1 principal = new Form1();
            principal.Show();
            this.Close();
        }

        public void buscar(string cedula)
        {
            rec.RecognizeAsyncStop();
            Persona profesor = new Persona();
            List<Persona> profesor1 = new List<Persona>();
            try
            {
                conexion_nueva.query.CommandText = "select a.cedula, a.nombres, a.apellidos, d.nom_mat, e.nom_pro, h.cod_aula, g.hora_ini, g.hora_fin, h.imagen, g.cod_diia from alu01 a join est01 b on (a.cedula = b.cedula) join matxest01 c on(b.cedula = c.cedula) join mat01 d on(c.cod_carrera = d.cod_carrera and c.cod_jornada = d.cod_jornada and c.cod_mat = d.cod_mat and c.paralelo = d.paralelo and c.periodo = d.periodo) join pro01 e on(d.cod_pro = e.cod_pro) join mat01 f on(e.cod_pro = f.cod_pro) join mathor01 g on(f.cod_mat = g.cod_mat) join aula01 h on(g.cod_aula = h.cod_aula) where a.cedula = '" + cedula + "' and '"+actual+"' between g.hora_ini and g.hora_fin and g.cod_diia ='"+dia+"' ";
                if(palabra == "siguiente") conexion_nueva.query.CommandText = "select a.cedula, a.nombres, a.apellidos, d.nom_mat, e.nom_pro, h.cod_aula, g.hora_ini, g.hora_fin, h.imagen, g.cod_diia from alu01 a join est01 b on (a.cedula = b.cedula) join matxest01 c on(b.cedula = c.cedula) join mat01 d on(c.cod_carrera = d.cod_carrera and c.cod_jornada = d.cod_jornada and c.cod_mat = d.cod_mat and c.paralelo = d.paralelo and c.periodo = d.periodo) join pro01 e on(d.cod_pro = e.cod_pro) join mat01 f on(e.cod_pro = f.cod_pro) join mathor01 g on(f.cod_mat = g.cod_mat) join aula01 h on(g.cod_aula = h.cod_aula) where a.cedula = '" + cedula + "' and '" + hora_siguiente + "' between g.hora_ini and g.hora_fin and g.cod_diia ='" + dia + "' ";
                if (palabra == "todo") conexion_nueva.query.CommandText = "select a.cedula, a.nombres, a.apellidos, d.nom_mat, e.nom_pro, h.cod_aula, g.hora_ini, g.hora_fin, h.imagen, g.cod_diia from alu01 a join est01 b on (a.cedula = b.cedula) join matxest01 c on(b.cedula = c.cedula) join mat01 d on(c.cod_carrera = d.cod_carrera and c.cod_jornada = d.cod_jornada and c.cod_mat = d.cod_mat and c.paralelo = d.paralelo and c.periodo = d.periodo) join pro01 e on(d.cod_pro = e.cod_pro) join mat01 f on(e.cod_pro = f.cod_pro) join mathor01 g on(f.cod_mat = g.cod_mat) join aula01 h on(g.cod_aula = h.cod_aula) where a.cedula = '" + cedula + "' and g.cod_diia ='"+dia+"' ";
                conexion_nueva.conexion.Open();
                conexion_nueva.query.Connection = conexion_nueva.conexion;
                conexion_nueva.consultar = conexion_nueva.query.ExecuteReader();
                while (conexion_nueva.consultar.Read())
                {
                    if (palabra == "todo")
                    {
                        profesor.nombre = conexion_nueva.consultar.GetString(0);
                        profesor.materia = conexion_nueva.consultar.GetString(1);
                        profesor.hora_inicio = conexion_nueva.consultar.GetString(5);
                        profesor.hora_fin = conexion_nueva.consultar.GetString(6);
                        profesor.curso = conexion_nueva.consultar.GetString(3);
                        profesor1.Add(profesor);
                    }
                    else
                    {
                        groupBox1.Visible = true;
                        Nombre_txt.Text = conexion_nueva.consultar.GetString(2) + " " + conexion_nueva.consultar.GetString(1);
                        pictureBox2.Image = new System.Drawing.Bitmap(conexion_nueva.consultar.GetString(8));
                        horario_text.Text = conexion_nueva.consultar.GetString(6) + "-" + conexion_nueva.consultar.GetString(7);
                        curso_text.Text = conexion_nueva.consultar.GetString(5);
                        Materia_text.Text = conexion_nueva.consultar.GetString(3);
                        profesor_text.Text = conexion_nueva.consultar.GetString(4);
                    }

                }
                dataGridView1.DataSource = profesor1;
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
            retornar();
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
        }
       public void comprobar(string text)
        {
            rec1.RecognizeAsyncStop();
            if (text == "todo") {
                
               // MessageBox.Show("todo");
               groupBox2.Visible = true;
               
            }
            if (text == "actual") ; //MessageBox.Show("actual");
                if (text == "siguiente") ;// MessageBox.Show("siguiente");
        }
        public void escucharinicial()
        {
            leer.Rate = 0;
            leer.Volume = 100;
            leer.Speak(" que horario deseas ver ?");
            leer.Speak(" todo el horario del dia de hoy, horario actual o horario siguiente");
            Choices lista = new Choices();
            lista.Add(new string[] { "todo", "actual", "siguiente" });
            Grammar gramatica = new Grammar(new GrammarBuilder(lista));
            try
            {
                rec1.SetInputToDefaultAudioDevice();
                rec1.LoadGrammar(gramatica);
                rec1.SpeechRecognized += reconocimiento;
                rec1.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch (Exception el)
            {

                System.Windows.Forms.MessageBox.Show(el.Message);
            }
        }
        public void reconocimiento(object sender, SpeechRecognizedEventArgs e)
        {
            rec1.RecognizeAsyncStop();
           // MessageBox.Show(e.Result.Text);
            if (e.Result.Text == "todo")
            {
                palabra = "todo";
                rec1.RecognizeAsyncStop();
                //MessageBox.Show("Test");
                groupBox2.Visible = true;
                escuchar();
            }
            else if (e.Result.Text == "actual")
            {
                palabra = "actual";
                escuchar();

            }
            else if (e.Result.Text == "siguiente")
            {
                escuchar();
                palabra = "siguiente";

            }
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
                rec2.SetInputToDefaultAudioDevice();
                rec2.LoadGrammar(gramatica);
                rec2.SpeechRecognized += reconocimiento1;
                rec2.RecognizeAsync(RecognizeMode.Multiple);
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
