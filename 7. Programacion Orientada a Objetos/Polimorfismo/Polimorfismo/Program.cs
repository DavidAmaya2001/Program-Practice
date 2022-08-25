using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona oPersona = new Persona();
            oPersona.nombre = "Julio";
            oPersona.apPaterno = "Fernandez";
            oPersona.apMaterno = "Felipe";

            Persona oPersona2 = new Empleado();

            Persona oPersona3 = new Cliente();
            
        }
    }
}
