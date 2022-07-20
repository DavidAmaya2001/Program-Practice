using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("                                Tarea 1                               ");
            Console.WriteLine("----------------------------------------------------------------------");
            
            Console.WriteLine("\n 1. Elaborar un programa que me permita ingresar un numero de semanas, y convertirlo a días.");
            Console.WriteLine("\n 2. Elaborar un programa que permita ingresar el numero de horas trabajadas por un empleado, por hora gana 20 soles.");
            Console.WriteLine("\n 3. Elaborar un programa que me permita calcular el total a pagar por un producto y se le aumentara 18 % del precio, debido al IGV");
            Console.WriteLine("\n\n Elija la pregunta de la tarea que desea desarrollar");
            int Opcion = int.Parse(Console.ReadLine());

            switch (Opcion)
            {
                case 1:Console.WriteLine("\nPregunta 1. Convertidor de Semanas a dias.");
                    Console.WriteLine("Ingrese el numero de semanas: ");
                    int Semanas = int.Parse(Console.ReadLine());
                    int dias = Semanas * 7;
                    Console.WriteLine("En " + Semanas + " semanas hay un total de: " + dias + " dias.");
                    break;

                case 2:Console.WriteLine("\nPregunta 2. Calculo de salario por horas trabajadas.");
                    Console.WriteLine("Ingrese el numero de horas trabajadas: ");
                    int horas = int.Parse(Console.ReadLine());
                    int ganancia = horas * 20;
                    Console.WriteLine("El empleado con "+horas+" horas trabajadas obtiene un salario de: "+ganancia+" soles.");
                    break;

                case 3:Console.WriteLine("\nPregunta 3. Calculo de total a pagar por producto");
                    Console.WriteLine("Ingrese el precio del producto: ");
                    decimal precio = decimal.Parse(Console.ReadLine());
                    decimal igv = precio * 0.18m;
                    Console.WriteLine("IGV: " + igv);
                    decimal total = igv + precio;
                    Console.WriteLine("El precio sumado al IGV calculado da un total de: " + total);
                    break;

                default: Console.WriteLine("Error de ejercicio ingresado");
                    break;
            }
            Console.ReadKey();
        }
    }
}
