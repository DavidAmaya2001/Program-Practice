using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructuras_Repetitivas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // --------------------------- Acumuladores Contadores --------------------------- //

            int c = 21;
            c++;                               // ++ aumenta el valor a +1 la variable
            c--;                               // -- disminuye el valor a -1 la variable
            c += 10;                           // += aumenta el valor a la derecha del =
            c -= 10;                           // -= disminuye el valor a la derecha del -

            // ------------------------------------ While ------------------------------------ //

            int i = 1;
            while (i<= 50)                     // while ( condicion )
            {
                i++;                           // la variable i entra a un while que repetira un comando mientras se cumpla la condición while
            }

            // ------------------------------ Ejercicio While ------------------------------ //

            // Imprimir del 120 al 1 de 2 en 2

            int a = 120;

            while (a >= 1)
            {
                Console.WriteLine(a);
                a-=2;
            }

            // Permitir ingresar 5 numeros y hallar su suma

            int p = 1;
            double numero = 0;
            double suma = 0;

            while (p <= 5)
            {
                Console.WriteLine("Digite el " + p + "° numero: ");
                numero = double.Parse(Console.ReadLine());
                suma += numero;
                p++;
            }
            Console.WriteLine("La suma de los 5 numeros es: " + suma);

            // Ingresar un numero y calcular su triple hasta que se ingrese el numero 0

            double Numero = 0;
            Console.WriteLine("Ingrese un numero para calcular su triple, si se ingresa 0 el programa finaliza");
            Numero = double.Parse(Console.ReadLine());
            
            while(Numero != 0)
            {
                double triple = Numero * 3;
                Console.WriteLine("El triple del numero ingresado es: " + triple);
                Console.WriteLine("Ingrese otro numero para calcular su triple, si se ingresa 0 el programa finaliza");
                Numero = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Programa finalizado");

            // Ingresar un numero e indicar si es par o impar hasta que se ingrese un numero negativo
            // Uso del break en while

            double NumeroPI = 0;
            Console.WriteLine("Ingrese el numero a verificar, si el numero es menor a 0 el programa finaliza");
            NumeroPI = double.Parse(Console.ReadLine());

            while (NumeroPI >= 0)
            {
                if(NumeroPI < 0)
                {
                    break;
                }
                else if(NumeroPI % 2 == 0)  
                {
                    Console.WriteLine("El numero es par");
                }
                else
                {
                    Console.WriteLine("El numero es impar");
                }
                Console.WriteLine("Ingrese otro numero a verificar, si el numero es menor a 0 el programa finaliza");
                NumeroPI = double.Parse(Console.ReadLine());

            }
            Console.WriteLine("Programa Finalizado");

            // ---------------------------------- Do While ------------------------------------ //

            int number, j=1, cont=0;
            do
            {
                Console.WriteLine("Ingrese el numero " + j);
                j++;
                cont++;
                number = int.Parse(Console.ReadLine());

            } while (number >=0);
            cont--;
            Console.WriteLine("Numeros positivos ingresados es: " + cont);

            // ------------------------------------ For -------------------------------------- //

            for (int k=1;k<=20;k++)                                    // for ( inicializador ; final ; acumulador/contador )
            {
                Console.WriteLine("Explotando el Hola Mundo");
            }

            // -------------------------------- Ejercicio For ------------------------------- //

            // Tabla del 2

            for(int mult = 1; mult <= 12; mult++)
            {
                int tabla = 2 * mult;
                Console.WriteLine(" 2 x " + mult + " = " + tabla);
            }


            // Listado de numeros pares entre rango 

            Console.WriteLine("Ingrese el numero que delimite el rango inferior");
            int rInferior = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero que delimite el rango superior");
            int rSuperior = int.Parse(Console.ReadLine());

            for (int inf = rInferior; inf <= rSuperior; inf++)
            {
                if(inf % 2 == 0)
                {
                    Console.WriteLine(inf);
                }
            }

            Console.ReadKey();
        }
    }
}
