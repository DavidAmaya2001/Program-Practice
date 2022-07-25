using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_y_Propiedades
{
    internal class Program
    {
        // ------------------------------------------------- Objetos ------------------------------------------------- //
        static void Main(string[] args)
        {
            // --------------------------------------- Usando clase Persona --------------------------------------- //

            Persona objPersona = new Persona();                        // Creando el objeto

            objPersona.nombre = "Julio";                               // Asignando propiedades a la clase Persona por medio del objeto
            objPersona.apaterno = "Nieves";
            objPersona.amaterno = "Sandoval";
            objPersona.edad = 45;
            objPersona.sueldo = 5000;

            Persona objPersona2 = new Persona();                       // Creando otro objeto con la misma clase

            objPersona2.nombre = "Ricardo";                             // Asiganando propiedades a otro objeto
            objPersona2.apaterno = "de la Cruz";
            objPersona2.amaterno = "Murayai";
            objPersona2.edad = 32;
            objPersona2.sueldo = 4000;

            Console.WriteLine(objPersona.nombre + " " + objPersona.amaterno + " " + objPersona.apaterno);
            Console.WriteLine(objPersona2.nombre + " " + objPersona2.apaterno + " " + objPersona2.amaterno);

            Console.WriteLine(objPersona.nombreCompleto());
            Console.WriteLine(objPersona2.nombreCompleto());

            double total = objPersona.sueldo * 12;
            Console.WriteLine(total);
            double total2 = objPersona2.sueldo * 12;
            Console.WriteLine(total2);

            Console.WriteLine(objPersona.calcularSueldoAnual());
            Console.WriteLine(objPersona2.calcularSueldoAnual());

            // --------------------------------------- Usando clase Usuario --------------------------------------- //

            Usuario objUsuario = new Usuario();

            objUsuario.nombreUser = "TuTioElPollo Oficial";
            objUsuario.contraseña = "12345678";

            Console.WriteLine("El usuario es: " + objUsuario.nombreUser);
            Console.WriteLine("Su contraseña es: " + objUsuario.contraseña);





            Console.ReadKey();


        }
    }
}
