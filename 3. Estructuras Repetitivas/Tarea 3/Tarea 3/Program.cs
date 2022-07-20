using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 1

            // Imprimir los numeros del 19 al 37, de 2 en 2. Usar la estructura While

            int nInicial = 19;
            while (nInicial <= 37)
            {
                Console.WriteLine(nInicial);
                nInicial += 2;
            }

            // Ejercicio 2

            // Imprimir la mitad de un numero, hasta que se ingrese un numero negativo. Usar el Do While

            double Numero=0;
            Console.WriteLine("Ingrese un numero para calcular la mitad de este. Si ingresa un numero negativo el programa finaliza");
            Numero = double.Parse(Console.ReadLine());
            if(Numero>=0)
            {
                do
                {
                    double Mitad = Numero / 2;
                    Console.WriteLine("La mitad del numero ingresado es: " + Mitad);
                    Console.WriteLine("Ingrese un numero para calcular la mitad de este. Si ingresa un numero negativo el programa finaliza");
                    Numero = double.Parse(Console.ReadLine());
                } while (Numero >= 0);
                Console.WriteLine("Fin del programa");
            }
            else
            {
                Console.WriteLine("Fin del programa");
            }

            // Ejercicio 3

            // Hallar la suma de 5 numeros (Usando la estructura For)
            
            double resultado = 0;
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Ingrese el " + i + "° numero: ");
                double numero = double.Parse(Console.ReadLine());
                resultado = resultado+ numero;
                
            }
            Console.WriteLine("El resultado de la suma de 5 numeros es: " + resultado);
            

            Console.ReadLine();
        }
    }
}
