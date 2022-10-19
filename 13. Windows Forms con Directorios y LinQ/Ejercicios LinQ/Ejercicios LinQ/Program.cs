using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_LinQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Origen de Datos
            string[] utilesEscolares = { "Cartuchera", "Lapiz", "Hoja", "Cuaderno", "Tajador" };

            // Consulta de Datos
            var consulta = from utiles in utilesEscolares
                           orderby utiles descending
                           select utiles;

            // Ejecucion de Consulta
            foreach(var item in consulta)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
