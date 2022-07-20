using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------Calculadora Basica----------");
            Console.WriteLine("\nDigite el primer numero que se operara");
            string numero1 = Console.ReadLine();
            double Numero1 = Convert.ToDouble(numero1);
            Console.WriteLine("\nDigite el segundo numero que se operara");
            string numero2 = Console.ReadLine();
            double Numero2 = Convert.ToDouble(numero2);
            Console.WriteLine("\nIngrese el signo segun la operación que desea");
            Console.WriteLine("Ingrese el signo (+) para hacer la sumatoria");
            Console.WriteLine("Ingrese el signo (-) para hacer la resta");
            Console.WriteLine("Ingrese el signo (*) para hacer la multiplicación");
            Console.WriteLine("Ingrese el signo (/) para hacer la división");
            string signo = Console.ReadLine();

            switch (signo)
            {
                case "+": 
                    double suma = Numero1 + Numero2;
                    Console.WriteLine("La sumatoria entre ambos numeros es: " + suma);
                        break;
                case "-":
                    double resta = Numero1 - Numero2;
                    Console.WriteLine("La resta entre ambos numeros es: " + resta);
                    break;
                case "*":
                    double multip = Numero1 * Numero2;
                    Console.WriteLine("La multiplicación entre ambos numeros es: " + multip);
                    break;
                case "/":
                    if(Numero2 == 0)
                    {
                        Console.WriteLine("La operacion no puede calcularse");
                    }
                    else
                    {
                        double div = Numero1 / Numero2;
                        Console.WriteLine("La división entre ambos numeros es: " + div);
                    }
                    break;
                default:
                    Console.WriteLine("Error (Signo Equivocado)");
                    break;

            }
            Console.ReadKey();

        }
    }
}
