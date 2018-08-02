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
        SpeechSynthesizer leer = new SpeechSynthesizer();


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
            Choices lista = new Choices();
            try
            {
                based.query.CommandText = select;
                based.conexion.Open();
                based.query.Connection = based.conexion;
                based.consultar = based.query.ExecuteReader();
                while (based.consultar.Read())
                {
                    lista.Add( based.consultar.GetString(0));
                }
                //lista.Add(new string[] { "alumno", "docente", "curso", "aula" });
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                //throw;
            }
            
            //Grammar gramatica = new Grammar(new GrammarBuilder(lista));
            return lista;
        }
    }
}
