using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_LinQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Origen de Datos
            int[] numeros = { 17, 14, 24, 27, 30, 29 };

            // Consulta de Datos
            var consulta = from numero in numeros
                           where numero < 28
                           orderby numero
                           select numero;

            // Ejecucion de Consulta
            foreach(var item in consulta)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
