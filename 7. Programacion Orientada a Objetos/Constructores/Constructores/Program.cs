using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Llenando parametros gracias al constructor en una sola linea
            Persona oPersona = new Persona("Felipe","Gonzales","Suarez",23,2000);  // Llamando la clase con el constructor que posee parametros

            //Llenando parametros sin constructor por separado
            Persona oPersona2 = new Persona();         // Llamando clase con el constructor Persona() por defecto sin parametros
            oPersona2.nombre = "Jorge";
            oPersona2.aPaterno = "Fernandez";
            oPersona2.aMaterno = "Cocolizo";
            oPersona2.edad = 30;
            oPersona2.sueldo = 1000;

            Console.WriteLine("Edad: " + oPersona.edad);

            Console.WriteLine("Edad obj2: " + oPersona2.edad);


            Console.ReadKey();

        }
    }
}
