using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcion
{
    internal class Program
    {
        // ------------------------------------------ Funciones ------------------------------------------ //

        static void Main(string[] args)
        {
            int SumaResultado = Suma(6, 7);
            Console.WriteLine(SumaResultado);

            int SumaResultado2 = Suma(11, 13);
            Console.WriteLine(SumaResultado2);

            Console.WriteLine("Escriba el 1° numero: ");
            int val1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el 2° numero: ");
            int val2 = int.Parse(Console.ReadLine());

            int SumaResultado3 = Suma(val1, val2);
            Console.WriteLine(SumaResultado3);


            Console.ReadKey();
        }

        // Funcion
        static int Suma(int a, int b)
        {
            return a + b;                          // La funcion es una linea de codigos que se almacena en una variable que
        }                                          // puede ser invocada multiples veces
    }
}
