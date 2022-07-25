using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_usando_Funciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el simbolo de la operacion que desea realizar");
            Console.WriteLine(" + -> Suma    - -> Resta   * -> Multiplicacion   / -> Division");
            char simbolo = Char.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el primer numero: ");
            decimal val1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero: ");
            decimal val2 = decimal.Parse(Console.ReadLine());
            

            decimal Resultado = Calculadora(val1, val2, simbolo);
            Console.WriteLine(Resultado);

            Console.ReadKey();
        }

        static decimal Calculadora(decimal a, decimal b, char operacion)
        {
            decimal resultado = 0;
            switch (operacion)
            {
                case '+': resultado = a + b;
                    break;
                case '-': resultado = a - b;
                    break;
                case '*': resultado = a * b;
                    break;
                case '/':
                    if (b == 0)
                    {
                        Console.WriteLine("No se puede realizar la operación");
                        resultado = 0;
                    }
                    else
                    {
                        resultado = a / b;
                    }
                    break;
                default: Console.WriteLine("Error de simbolo ingresado");
                    break;
            }

            return resultado;
        }
    }
}
