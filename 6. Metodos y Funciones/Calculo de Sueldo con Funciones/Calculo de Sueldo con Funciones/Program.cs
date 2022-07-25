using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo_de_Sueldo_con_Funciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el sueldo diario: ");
            decimal sueldo = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el sueldo que desea obtener");
            Console.WriteLine("1. Semanal");
            Console.WriteLine("2. Mensual");
            Console.WriteLine("3. Anual");
            char opcion = char.Parse(Console.ReadLine());

            switch (opcion)
            {
                case '1': Console.WriteLine("Sueldo Semanal: " + SueldoSemanal(sueldo));
                    break;
                case '2': Console.WriteLine("Sueldo Mensual: " + SueldoMensual(sueldo));
                    break;
                case '3': Console.WriteLine("Sueldo Anual: " + SueldoAnual(sueldo));
                    break;
                default: Console.WriteLine("Numero erroneo");
                    break;
            }

            Console.ReadKey();
        }

        // Semanal (7 dias)

        static decimal SueldoSemanal(decimal sueldodiario)
        {
            return sueldodiario * 7;
        }

        // Mensual (30 dias)

        static decimal SueldoMensual(decimal sueldodiario)
        {
            return sueldodiario * 30;
        }

        // Anual (365 dias)

        static decimal SueldoAnual(decimal sueldodiario)
        {
            return sueldodiario * 365;
        }
    }
}
