using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores
{
    public class Persona
    {
        public Persona()
        {
                                     // Este constructor se crea por defecto y se llama en ( Persona oPersona = new Persona() )
                                     //                                                                            constructor
        }

        public Persona(string nombre, string aPaterno, string aMaterno,int edad, double sueldo)
        {
            this.nombre = nombre;
            this.aPaterno = aPaterno;
            this.aMaterno = aMaterno;
            this.edad = edad;
            this.sueldo = sueldo;
        }
        public string nombre { get; set; }
        public string aPaterno { get; set; }
        public string aMaterno { get; set; }
        public int edad { get; set; }
        public double sueldo { get; set; }
    }
}
