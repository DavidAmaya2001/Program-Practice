using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 200, numero2 = 0;

            try
            {
                int resultado = numero1 / numero2;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ocurrio un error, no se puede dividir entre 0");
            }

            string numero = "123a";
            try
            {
                int numeroConvertido = int.Parse(numero);
            }
            catch (FormatException)
            {
                Console.WriteLine("No se puede convertir esa cadena a string");
            }

            int[] numbers = new int[4];
            try
            {
                numbers[0] = 1;
                numbers[1] = 2;
                numbers[2] = 3;
                numbers[3] = 4;
                numbers[4] = 5;
            }
            catch (Exception ex)                          // Exception abarca cualquier excepcion
            {
                Console.WriteLine(ex.Message);
            }
            finally                                       // Se ejecuta pase o no pase el error
            {
                Console.WriteLine("Programa sigue ejecutandose");
            }
            Console.WriteLine("Hola");


            Console.ReadKey();
        }
    }
}
