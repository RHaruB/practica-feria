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
              
                based.query.Connection = based.conexion;
                based.consultar = based.query.ExecuteReader();
                while (based.consultar.Read())
                {
                    lista_docente.Add( based.consultar.GetString(0));
                }
                
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
            
    
            return lista_docente;
        }
        public void escucharinicial()
        {
            leer.Rate = 0;
            leer.Volume = 100;
            leer.Speak(" que horario deseas ver ?");
            leer.Speak(" todo el horario del dia de hoy, horario actual o horario sigueinte");
            Choices lista = new Choices();
            lista.Add(new string[] { "todo","actual","siguiente" });
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

                System.Windows.Forms.MessageBox.Show(el.Message);
            }
        }
        public void reconocimiento(object sender, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Text == "todo")
            {
                palabra = "todo";
            }
            else if (e.Result.Text == "actual")
            {
                palabra = "actual";

            }
            else if (e.Result.Text == "siguiente")
            {
                palabra = "siguiente";

            }
        }
    }
}
