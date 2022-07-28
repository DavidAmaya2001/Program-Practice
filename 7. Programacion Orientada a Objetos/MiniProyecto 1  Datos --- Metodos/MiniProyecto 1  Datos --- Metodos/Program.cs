using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProyecto_1__Datos_____Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("----------------------------------------------- Mini Calculadora ------------------------------------------------");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");
            
            

            string acceso = "true";
            do
            {
                Console.WriteLine("\n----------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("\n     1. Suma (+)               2. Resta (-)               3. Multiplicación (*)               4. División (/)  ");
                Console.WriteLine("\n   5. Potencia (^)           6. Factorial (!)            7. Valor Absoluto (Abs)             8. Triangulo (Tr) ");
                Console.WriteLine("\n----------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("\n\nIngrese el simbolo entre parentesis del tipo  de operación que desea realizar: ");
                Operación calculadora = new Operación();
                calculadora.operacion = Console.ReadLine();
                calculadora.calculadora();

                Console.WriteLine("\n¿Desea realizar otra operación?");
                Console.WriteLine(" Si -> continua el programa      No -> se cierra el programa");
                acceso = Console.ReadLine();
                if(acceso == "si" || acceso =="Si" || acceso == "SI")
                {
                    acceso = "true";
                }
                else
                {
                    acceso = "false";
                }

            } while (acceso == "true");

            Mantener();
        }
        static void Mantener()
        {
            Console.ReadKey();
        }
    }
}
