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
        public Form1()
        {
            InitializeComponent();
        }
        SpeechRecognitionEngine rec = new SpeechRecognitionEngine();
        SpeechSynthesizer leer = new SpeechSynthesizer();
        private void Form1_Load(object sender, EventArgs e)
        {
            leer.Rate = 0;
            leer.Volume = 100;
            leer.Speak(" Que deseas hacer ?");
            Choices lista = new Choices();
            lista.Add(new string[] { "buscar alumno", "ingresar", "docente" });
            Grammar gramatica = new Grammar(new GrammarBuilder(lista));
            try
            {

                rec.SetInputToDefaultAudioDevice();
                rec.LoadGrammar(gramatica);
                rec.SpeechRecognized += reconocimiento;
                rec.RecognizeAsync(RecognizeMode.Multiple);
                


            }
            catch (Exception)
            {

                throw;
            }
        }
            public void reconocimiento(object sender, SpeechRecognizedEventArgs e)
            {
                if (e.Result.Text == "buscar alumno")
                {
                label1.Text = "alumno";
                    leer.Volume = 100;
                    leer.Rate = 0;
                //leer.Speak("Hola amo");
                this.Hide();

                ventalumno frm = new ventalumno();
                frm.hablar(e);

                frm.Show();
            }
                if (e.Result.Text == "docente")
                {
                  
                    leer.Volume = 100;
                    leer.Rate = 0;
                    leer.Speak("viernes");
                }
                if (e.Result.Text == "ingresar")
                {
                   
                    leer.Volume = 100;
                    leer.Rate = 0;
                    leer.Speak("La inteligencia artificial viernes");
                }
            }
        }
    }

