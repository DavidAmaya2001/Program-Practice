using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_5_Parte_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Message("Ingrece como parametro su sueldo: ");
            decimal Sueldo = decimal.Parse(Console.ReadLine());
            Message("Ingrese a que categoria pertenece: ");
            char Categ = char.Parse(Console.ReadLine());

            decimal Resultado = CatA(Sueldo, Categ);
            Message("Su sueldo con aumento segun su categoria es de: " + Resultado);

            Console.ReadKey();
        }

        static decimal CatA (decimal sueldo, char categoria)
        {
            decimal resultado = 0;
            switch (categoria)
            {
                case 'A':
                    resultado = sueldo + 400;
                    break;
                case 'B':
                    resultado = sueldo + 200;
                    break;
                case 'C':
                    resultado = sueldo + 100;
                    break;
                default:
                    resultado = sueldo + 50;
                    break;
            }
            return resultado;
        }
        static void Message(string cadena)
        {
            Console.WriteLine(cadena);
        }
    }
}
