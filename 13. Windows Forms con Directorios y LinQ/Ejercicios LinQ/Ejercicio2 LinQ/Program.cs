using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_LinQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Origen de Datos
            int[] edades = { 16, 19, 22, 17, 30, 45, 29 };

            // Consulta de Datos
            var consulta = from edad in edades
                           where edad > 18
                           select edad;

            // Ejecucion de la Consulta
            foreach(var item in consulta)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

        }
    }
}
