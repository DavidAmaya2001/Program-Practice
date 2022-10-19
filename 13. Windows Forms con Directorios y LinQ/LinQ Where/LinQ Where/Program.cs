using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_Where
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Fuente de datos
            int[] numeros = { 99, 56, 75, 45, 12 };

            // Definicion de Consulta
            var consulta = from numero in numeros // from {variable de rango} in {variable de origen de datos}
                           where numero > 70      // where {condicion con la variable de rango}
                           select numero;         // select {seleccion de la variable de rango ya filtrada}

            // Ejecución de la consulta
            foreach(var item in consulta)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

        }
    }
}
