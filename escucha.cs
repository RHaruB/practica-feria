using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Recognition;
using System.Speech.Synthesis;

namespace practica_feria
{
    class escucha
    {
        public string palabra { set; get; }
        public SpeechRecognitionEngine rec = new SpeechRecognitionEngine();
        public SpeechSynthesizer leer = new SpeechSynthesizer();
        

        public void escuchar()
        {
            rec.SetInputToDefaultAudioDevice();
            rec.LoadGrammar(new DictationGrammar());
            rec.SpeechRecognized += _Recognition_SpeechRecognized;
            rec.RecognizeAsync(RecognizeMode.Multiple);
        }

        public void _Recognition_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            palabra = e.Result.Text;
           // System.Windows.Forms.MessageBox.Show(palabra);
        }
        public void hablar(string habla)
        {
            leer.Speak(habla);
        }
        public Choices gramaticadocente(string select)
        {
             conexion_base based = new conexion_base();
             Choices lista_docente = new Choices();
            
            try
            {
                based.query.CommandText = select;
                based.conexiondb();
                based.conexion.Open();
                //based.conexion.Open();
                based.query.Connection = based.conexion;
                based.consultar = based.query.ExecuteReader();
                while (based.consultar.Read())
                {
                    lista_docente.Add( based.consultar.GetString(0));
                }
                //lista.Add(new string[] { "alumno", "docente", "curso", "aula" });
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                //throw;
            }
            finally
            {
                based.conexion.Close();
            }
            
            //Grammar gramatica = new Grammar(new GrammarBuilder(lista));
            return lista_docente;
        }
        public string retornar()
        {
            
                leer.Rate = 0;
                leer.Volume = 100;
                leer.Speak(" si deseas salir solo dilo ?");
                Choices lista_1 = new Choices();
                lista_1.Add(new string[] { "salir", "retornar", "papa" });
                Grammar gramatica = new Grammar(new GrammarBuilder(lista_1));
                try
                {
                    rec.SetInputToDefaultAudioDevice();
                    rec.LoadGrammar(gramatica);
                    rec.SpeechRecognized += reconocimiento;
                    rec.RecognizeAsync(RecognizeMode.Multiple);
                }
                catch (Exception el)
                {

                    //MessageBox.Show(el.Message); ;
                }
            rec.RecognizeAsyncStop();
            //System.Windows.Forms.MessageBox.Show("si llego");
            palabra = "salir";
            return palabra;

        }
        public void reconocimiento(object sender, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Text == "salir"|| e.Result.Text == "retornar" || e.Result.Text == "papa")
            {
                palabra = "window.close();";
            }
        }

        public void escucharsalir()
        {
           SpeechRecognitionEngine rec1 = new SpeechRecognitionEngine();
        Choices lista = new Choices();
            lista.Add(new string[] { "salir", "retornar" });
            Grammar gramatica = new Grammar(new GrammarBuilder(lista));
            rec1.SetInputToDefaultAudioDevice();
            rec1.LoadGrammar(gramatica);
            rec1.SpeechRecognized += verificasalir;
            rec1.RecognizeAsync(RecognizeMode.Multiple);
        }

        public void verificasalir(object sender, SpeechRecognizedEventArgs e)
        {
            if(e.Result.Text=="salir"|| e.Result.Text=="retornar") palabra = "si";
            // System.Windows.Forms.MessageBox.Show(palabra);
        }
    }
}
