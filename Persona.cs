using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_feria
{
    class Persona
    {
        public string nombre { set; get; }
        public string curso { set; get; }
        public string horario { set; get; }
        public DateTime dia { set; get; }
        public DateTime hora { set; get; }
        public string materia { set; get; }
        public string imagen { set; get; }
        public Persona() { }
        public void escuchar() { }
       /* public void conexion() {
            conexion_base connec = new conexion_base();
            connec.conexiondb();
        }*/
    }

}
