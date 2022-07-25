using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_y_Propiedades
{
    public class Persona
    {
        public string nombre { get; set; }
        public string apaterno { get; set; }
        public string amaterno { get; set; }
        public int edad { get; set; }
        public double sueldo { get; set; }

        public string nombreCompleto()
        {
            return nombre + " " + apaterno + " " + amaterno;
        }

        public double calcularSueldoAnual()
        {
            return sueldo * 12;
        }
    }
}
