using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el Ejercicio que desea realizar: ");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Area de un Triangulo");
            Console.WriteLine("3. Ejercicio Comercial");
            int opcion = int.Parse(Console.ReadLine());
            switch(opcion)
            {
                case 1: Console.WriteLine("----------Ejercicio de Suma----------");
                    Console.WriteLine("Ingrese el primer numero: ");
                    int numero1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo numero: ");
                    int numero2 = int.Parse(Console.ReadLine());
                    int Sumatoria = numero1 + numero2;
                    Console.WriteLine("La sumatoria de ambos numeros ingresados es: " + Sumatoria );
                    break;

                case 2: Console.WriteLine("----------Ejercicio Area----------");
                    Console.WriteLine("Ingrese la medida de la base en metros: ");
                    double BaseTriangulo = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la medida de la altura en metros: ");
                    double AlturaTriangulo = double.Parse(Console.ReadLine());
                    double Area = (BaseTriangulo * AlturaTriangulo) / 2;
                    Console.WriteLine("El area del triangulo en metros es: " + Area);
                    break;

                case 3: Console.WriteLine("----------Ejercicio Comercial----------");
                    Console.WriteLine("Ingrese el precio");
                    decimal Precio = decimal.Parse(Console.ReadLine());
                    decimal descuento = Precio * 0.20m;
                    decimal total = Precio - descuento;
                    Console.WriteLine("El descuento es de: " + descuento);
                    Console.WriteLine("El total con descuento es de: " + total);
                    break;

                default: Console.WriteLine("Error");
                    break;
            }
            Console.ReadKey();
        }
    }
}
