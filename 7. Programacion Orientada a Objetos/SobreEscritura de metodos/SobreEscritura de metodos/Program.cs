using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreEscritura_de_metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            // En este caso se ha asignado "tiene varios colores" en las clases hijos pero en la Fresa y Pera no hay varios colores
            // asi que se usara sobreescritura para evitar esa asignacion de la clase padre
            Pera oPera = new Pera();
            oPera.color();
            Fresa oFresa = new Fresa();
            oFresa.color();


            Console.ReadKey();
        }
    }
}
