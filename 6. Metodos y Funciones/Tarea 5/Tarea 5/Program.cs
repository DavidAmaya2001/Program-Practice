using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer numero:");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero:");
            int numero2 = int.Parse(Console.ReadLine());

            ImpNumerosPares(numero1, numero2);

            Console.ReadKey();
        }
        static void ImpNumerosPares(int number1, int number2)
        {
            for(int i=number1; i <= number2; i++)
            {
                if (i % 2 == 0)
                {
                    Message(i.ToString());
                }
                else
                {

                }
            }
        }
        static void Message(string cadena)
        {
            Console.WriteLine(cadena);
        }
    }
}
