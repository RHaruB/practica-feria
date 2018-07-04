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
        public ventalumno(  )
        {
            InitializeComponent();

        }

        private void label1_Click()
        {
           
        }
        public void hablar(SpeechRecognizedEventArgs e)
        {
            
            label1.Text = e.Result.Text;
        }


    }
}
