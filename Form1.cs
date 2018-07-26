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
    public partial class Form1 : Form
    {
        SpeechSynthesizer leer = new SpeechSynthesizer();
        public Form1()
        {
            InitializeComponent();
        }
        SpeechRecognitionEngine rec = new SpeechRecognitionEngine();
        
        private void Form1_Load(object sender, EventArgs e)
        {
            leer.Rate = 0;
            leer.Volume = 100;
            leer.Speak(" Que deseas hacer ?");
            Choices lista = new Choices();
            lista.Add(new string[] { "alumno", "docente", "curso","aula"});
            Grammar gramatica = new Grammar(new GrammarBuilder(lista));
            try
            {
                rec.SetInputToDefaultAudioDevice();
                rec.LoadGrammar(gramatica);
                rec.SpeechRecognized += reconocimiento;
                rec.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch (Exception el)
            {

                MessageBox.Show(el.Message);;
            }
        }
            public void reconocimiento(object sender, SpeechRecognizedEventArgs e)
            {
                if (e.Result.Text == "alumno"){
                alumno_bt.PerformClick();
                }else if (e.Result.Text == "docente"){
                docente_bt.PerformClick();
                   /* leer.Volume = 100;
                    leer.Rate = 0;
                    leer.Speak("Que docente deseas buscar?");
                    leer.Speak(" por favor dime el nombre del profesor");
                    this.Hide();
                    docentefr nuevo_docente = new docentefr();
                    nuevo_docente.Show();*/
                }else if (e.Result.Text == "curso"|| e.Result.Text == "aula")
            {
                aula_bt.PerformClick();
                   /* leer.Volume = 100;
                    leer.Rate = 0;
                    leer.Speak("Que aula deseas buscar?");
                    leer.Speak(" por favor dime el numero del aula");
                    this.Hide();
                    Aula nuevo_curso = new Aula();
                    nuevo_curso.Show();*/
                }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            //leer.Speak(" Que alumno deseas buscar?");
            rec.RecognizeAsyncStop();
            ventalumno nueva_venta = new ventalumno();
            nueva_venta.Show();
            this.Hide();
        }

        private void docente_bt_Click(object sender, EventArgs e)
        {
            rec.RecognizeAsyncStop();
            horainicio_text nueva_ventana = new horainicio_text();
            nueva_ventana.Show();
            this.Hide();
        }

        private void aula_bt_Click(object sender, EventArgs e)
        {
            rec.RecognizeAsyncStop();
            Aula nueva_ventana = new Aula();
            nueva_ventana.Show();
            this.Hide();
        }
    }
}

