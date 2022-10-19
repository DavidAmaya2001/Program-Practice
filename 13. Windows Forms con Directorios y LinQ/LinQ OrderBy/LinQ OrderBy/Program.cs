using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_OrderBy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Fuente de Datos
            int[] numeros = { 9, 11, 4, 7, 12, 16, 15 };

            // Definir la consulta
            var consulta = from numero in numeros
                           orderby numero descending // OrderBy por defecta ordena Acendentemente
                           select numero;

            // Ejecutar la consulta

            foreach(var item in consulta)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
