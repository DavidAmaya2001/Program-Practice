using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Abstractas
{
    class Program
    {
        static void Main(string[] args)
        {

            // Estacion oEstacion = new Estacion(); no se puede instanciar una clase abstracta

            Invierno oInvierno = new Invierno();
            oInvierno.sensacion();

            Verano oVerano = new Verano();
            oVerano.sensacion();


            Console.ReadKey();
        }
    }
}
