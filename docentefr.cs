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
        public horainicio_text()
        {
            InitializeComponent();
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
                based.query.CommandText = "select p.nom_pro, m.nom_mat, m.paralelo, au.cod_aula, au.imagen, ma.hora_ini, ma.hora_fin  from pro01 p join mat01 m on (p.cod_pro=m.cod_pro) join mathor01 ma on (m.cod_mat=ma.cod_mat and m.paralelo=ma.paralelo and m.cod_carrera=ma.cod_carrera and m.cod_jornada=ma.cod_jornada and m.periodo=ma.periodo) join aula01 au on (ma.cod_aula=au.cod_aula) where p.nom_pro like '%" + nombre + "%'";
                based.conexion.Open();
                based.query.Connection = based.conexion;
                based.consultar = based.query.ExecuteReader();
                while (based.consultar.Read())
                {
                    textnombre.Text = based.consultar.GetString(0);
                    textcurso.Text = based.consultar.GetString(3);
                    paralelo_text.Text = based.consultar.GetString(2);
                    Materia_text.Text = based.consultar.GetString(1);
                    texthorainici.Text = Convert.ToString( based.consultar.GetMySqlDateTime(5));
                    horafin_text.Text = Convert.ToString(based.consultar.GetMySqlDateTime(6));

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
            rec.SetInputToDefaultAudioDevice();
            rec.LoadGrammar(new DictationGrammar());
            rec.SpeechRecognized += _Recognition_SpeechRecognized;
            rec.RecognizeAsync(RecognizeMode.Multiple);
        }
        public void _Recognition_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            textBox_docente.Text = e.Result.Text;
            // System.Windows.Forms.MessageBox.Show(palabra);
        }

        private void textBox_docente_TextChanged(object sender, EventArgs e)
        {
            btbuscar.PerformClick();
        }
    }

}
