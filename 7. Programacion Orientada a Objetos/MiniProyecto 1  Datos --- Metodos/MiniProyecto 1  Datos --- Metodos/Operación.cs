using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProyecto_1__Datos_____Metodos
{
    public class Operación
    {
       public string operacion { get; set; }

       public double calculadora()
        {
            double resultado = 0;

            switch (operacion)
            {
                case "+": double suma = sumatoria();
                    Console.WriteLine(" ------------------------------------------------ ");
                    Console.WriteLine(" |       La sumatoria realizada es de: " + suma + "       | ");
                    Console.WriteLine(" ------------------------------------------------ ");
                    break;
                case "-": double resta = restando();
                    Console.WriteLine(" ------------------------------------------------ ");
                    Console.WriteLine(" |     El resultado de la resta es de: " + resta + "      | ");
                    Console.WriteLine(" ------------------------------------------------ ");
                    break;
                case "*": double mltp = multiplicando();
                    Console.WriteLine(" ------------------------------------------------ ");
                    Console.WriteLine(" |  El resultado de la multiplicación es de: " + mltp + " | ");
                    Console.WriteLine(" ------------------------------------------------ ");
                    break;
                case "/": double divs = dividendo();
                    if (divs != 2.141567829818)
                    {
                        Console.WriteLine(" ------------------------------------------------ ");
                        Console.WriteLine(" |    El resultado de la división es de: " + divs + "     | ");
                        Console.WriteLine(" ------------------------------------------------ ");
                    }
                    else
                    {
                        Console.WriteLine(" ------------------------------------------------ ");
                        Console.WriteLine("  | No se puede llevar acabo la operación (divisor != 0)  | ");
                        Console.WriteLine(" ------------------------------------------------ ");
                    }
                    break;
                case "^": double potc = potencia();
                    Console.WriteLine(" ------------------------------------------------ ");
                    Console.WriteLine(" |     El resultado de la potencia es de: " + potc + "    | ");
                    Console.WriteLine(" ------------------------------------------------ ");
                    break;
                case "!": int fact = factorial();
                    if (fact != -1)
                    {
                        Console.WriteLine(" ------------------------------------------------ ");
                        Console.WriteLine(" |     El resultado del factorial es de: " + fact + "     | ");
                        Console.WriteLine(" ------------------------------------------------ ");
                    }
                    else
                    {
                        Console.WriteLine(" ------------------------------------------------ ");
                        Console.WriteLine(" | No se puede llevar acabo la operación (factorial > 0)  | ");
                        Console.WriteLine(" ------------------------------------------------ ");
                    }
                    
                    break;
                /*case "Abs": double absl = valorAbsoluto();
                    Console.WriteLine(" ------------------------------------------------ ");
                    Console.WriteLine(" |   El resultado del valor absoluto es de: " + absl + "  | ");
                    Console.WriteLine(" ------------------------------------------------ ");
                    break;
                case "Tr": double trig = Triangulo();
                    Console.WriteLine(" ------------------------------------------------ ");
                    Console.WriteLine(" |      El resultado de el lado es de: " + trig + "       | ");
                    Console.WriteLine(" ------------------------------------------------ ");
                    break;*/
                default: Console.WriteLine("Error");
                    break;
            }

            return resultado;
        }
        public double sumatoria()
        {
            double result = 0;
            int i = 1;
            Console.WriteLine("\n                             -------------------------------------------------------");
            Console.WriteLine("                             ------------------------ Suma -------------------------");
            Console.WriteLine("                             -------------------------------------------------------");
            Console.WriteLine("\nIngrese el " + i + "° valor que desea sumar: ");
            double numero1 = double.Parse(Console.ReadLine());
            i++;
            Console.WriteLine("Ingrese el " + i + "° valor que desea sumar: ");
            double numero2 = double.Parse(Console.ReadLine());
            result = numero1 + numero2;
           
            Console.WriteLine("\n¿desea ingresar otro numero?");
            Console.WriteLine("Si -> agregara otro numero a sumar, No -> se realizara la suma");
            string opcion = Console.ReadLine();
            if(opcion=="Si" || opcion=="si" || opcion == "SI")
            {
                while(opcion == "Si" || opcion == "si" || opcion == "SI")
                {
                    i++;
                    Console.WriteLine("\nIngrese el " + i + "° valor que desea sumar: ");
                    double numeroX = double.Parse(Console.ReadLine());
                    result = result + numeroX;
                    Console.WriteLine("\n¿desea ingresar otro numero?");
                    Console.WriteLine("Si -> agregara otro numero a sumar, No -> se realizara la suma");
                    opcion = Console.ReadLine();
                }
            }
            else
            {
                
            }

            return result;
            
        }
        public double restando()
        {
            double result = 0;
            int i = 1;
            Console.WriteLine("\n                             -------------------------------------------------------");
            Console.WriteLine("                             ------------------------ Resta ------------------------");
            Console.WriteLine("                             -------------------------------------------------------");
            Console.WriteLine("\nIngrese el " + i + "° valor que desea restar: ");
            double numero1 = double.Parse(Console.ReadLine());
            i++;
            Console.WriteLine("Ingrese el " + i + "° valor que restara al 1°: ");
            double numero2 = double.Parse(Console.ReadLine());
            result = numero1 - numero2;

            Console.WriteLine("\n¿desea ingresar otro numero?");
            Console.WriteLine("Si -> agregara otro numero a restar, No -> se realizara la resta");
            string opcion = Console.ReadLine();
            if (opcion == "Si" || opcion == "si" || opcion == "SI")
            {
                while (opcion == "Si" || opcion == "si" || opcion == "SI")
                {
                    i++;
                    Console.WriteLine("\nIngrese el " + i + "° valor que restara al 1°: ");
                    double numeroX = double.Parse(Console.ReadLine());
                    result = result - numeroX;
                    Console.WriteLine("\n¿desea ingresar otro numero?");
                    Console.WriteLine("Si -> agregara otro numero a restar, No -> se realizara la resta");
                    opcion = Console.ReadLine();
                }
            }
            else
            {

            }
            return result;
        }
        public double multiplicando()
        {
            double result = 0;
            int i = 1;
            Console.WriteLine("\n                             -------------------------------------------------------");
            Console.WriteLine("                             ------------------- Multiplicación --------------------");
            Console.WriteLine("                             -------------------------------------------------------");
            Console.WriteLine("\nIngrese el " + i + "° valor que desea multiplicar: ");
            double numero1 = double.Parse(Console.ReadLine());
            i++;
            Console.WriteLine("Ingrese el " + i + "° valor que desea multiplicar: ");
            double numero2 = double.Parse(Console.ReadLine());
            result = numero1 * numero2;

            Console.WriteLine("\n¿desea ingresar otro numero?");
            Console.WriteLine("Si -> agregara otro numero a multiplicar, No -> se realizara la multiplicación");
            string opcion = Console.ReadLine();
            if (opcion == "Si" || opcion == "si" || opcion == "SI")
            {
                while (opcion == "Si" || opcion == "si" || opcion == "SI")
                {
                    i++;
                    Console.WriteLine("\nIngrese el " + i + "° valor que desea multiplicar: ");
                    double numeroX = double.Parse(Console.ReadLine());
                    result = result * numeroX;
                    Console.WriteLine("\n¿desea ingresar otro numero?");
                    Console.WriteLine("Si -> agregara otro numero a multiplicar, No -> se realizara la multiplicación");
                    opcion = Console.ReadLine();
                }
            }
            else
            {
                
            }

            return result;
        }
        public double dividendo()
        {
            double result = 0;
            int i = 1;
            Console.WriteLine("\n                             -------------------------------------------------------");
            Console.WriteLine("                             ---------------------- División -----------------------");
            Console.WriteLine("                             -------------------------------------------------------");
            Console.WriteLine("\nIngrese el valor del dividendo: ");
            double numero1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del divisor: ");
            double numero2 = double.Parse(Console.ReadLine());
            if (numero2 != 0)
            {
                result = numero1 / numero2;
                Console.WriteLine("\n¿desea ingresar otro numero?");
                Console.WriteLine("Si -> agregara otro divisor, No -> se realizara la división");
                string opcion = Console.ReadLine();
                if (opcion == "Si" || opcion == "si" || opcion == "SI")
                {
                    while (opcion == "Si" || opcion == "si" || opcion == "SI")
                    {
                        Console.WriteLine("\nIngrese otro divisor al dividendo: ");
                        double numeroX = double.Parse(Console.ReadLine());
                        result = result / numeroX;
                        Console.WriteLine("\n¿desea ingresar otro numero?");
                        Console.WriteLine("Si -> agregara otro divisor, No -> se realizara la división");
                        opcion = Console.ReadLine();
                    }
                }
                else
                {

                }

            }
            else
            {
                result = 2.141567829818;
            }
            return result;
        }
        public double potencia()
        {
            double result = 0;
            int i = 1;
            Console.WriteLine("\n                             -------------------------------------------------------");
            Console.WriteLine("                             ----------------------- Potecia -----------------------");
            Console.WriteLine("                             -------------------------------------------------------");
            Console.WriteLine("\nIngrese el valor de la base: ");
            double numero1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de la potencia: ");
            double numero2 = double.Parse(Console.ReadLine());
            result = Math.Pow(numero1, numero2);

            Console.WriteLine("\n¿desea ingresar otro numero?");
            Console.WriteLine("Si -> agregara otro numero de potencia (a^b^c), No -> se realizara la operación");
            string opcion = Console.ReadLine();

            if (opcion == "Si" || opcion == "si" || opcion == "SI")
            {
                while (opcion == "Si" || opcion == "si" || opcion == "SI")
                {
                    Console.WriteLine("\nIngrese otro valor de potencia (a^b^c)");
                    double numeroX = double.Parse(Console.ReadLine());
                    result = Math.Pow(result,numeroX);
                    Console.WriteLine("\n¿desea ingresar otro numero?");
                    Console.WriteLine("Si -> agregara otro numero de potencia (a^b^c), No -> se realizara la operación");
                    opcion = Console.ReadLine();
                }
            }
            else
            {

            }

            return result;
        }
        public int factorial()
        {
            int result = 0;
            int i;
            
            Console.WriteLine("\n                             -------------------------------------------------------");
            Console.WriteLine("                             ------------------- Numero Factorial ------------------");
            Console.WriteLine("                             -------------------------------------------------------");

            
            Console.WriteLine("\nIngrese el valor a calcular su factorial (numero entero): ");
            int numero = int.Parse(Console.ReadLine());
            result = numero;
            if (numero>0) {
                for (i = numero; i >= 1; i--)
                {
                    if (i != 1)
                    {
                        result = (result * (i - 1));
                    }
                    else
                    {

                    }
                }
            }
            else if (numero == 0)
            {
                result = 1;
            }
            else
            {
                result= -1;
            }

            return result;
        }
       
    }
}
