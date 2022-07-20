using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Si se tiene un Array de numeros: int[] numeros ={31,37,34,46,20,42} , mostrar solo aquellos que son mayores a 18 pero menores a 35
            int[] numeros = { 31, 37, 34, 46, 20, 42 };
            foreach(int num in numeros)
            {
                if (num > 18 && num < 35)
                {
                    Console.WriteLine(num);
                }
                else
                {

                }
            }

            // Se tiene un array de numeros, indicar cuantos son positivos (igual o mayor a 0)
            int[] numeros2 = { -100, 56, -20, 15, -12, -20 };
            int cont = 0;
            foreach(int num2 in numeros2)
            {
                if(num2 >= 0)
                {
                    cont++;
                }
                else
                {

                }
            }
            Console.WriteLine("Numeros positivos en el array: " + cont);

            // Se tiene un array de numeros hallar la suma de los numeros pares
            int[] numeros3 = { 1, 3, 2, 4, 11, 19 };
            int suma = 0;
            foreach(int num3 in numeros3)
            {
                if (num3 % 2 == 0)
                {
                    suma += num3;
                }
            }
            Console.WriteLine("La suma de los numeros pares del array es: " + suma);

            // Calcular cuantos numeros positivos y negativos hay en el array
            int[] numeros4 = { 4, 5, -4, 7, 8, -2, 12, 176, -6 };
            int contp = 0, contn = 0;
            int sumaPos = 0, sumaNeg = 0;
            foreach(int num4 in numeros4)
            {
                if (num4 >= 0)
                {
                    contp++;
                    sumaPos += num4;
                }
                else
                {
                    contn++;
                    sumaNeg += num4;
                }
            }
            Console.WriteLine("La cantidad de numeros negativos es de: " + contn + " La cantidad de numeros positivos es de: " + contp);
            Console.WriteLine("La suma de los numeros negativos es de: " + sumaNeg + " La suma de los numeros positivos es de: " + sumaPos);

            // Indiar cuantos numeros de 1 cifra y 2 cifras positivos hay
            int[] numeros5 = { 10, 4, 6, 11, 145, 3453, 22, 44, 1, -6, -8 };
            int Unacifra = 0, Doscifras = 0;
            foreach(int num5 in numeros5)
            {
                if (num5 >= 0)
                {
                    if (num5 >= 10)
                    {
                        Doscifras++;
                    }
                    else
                    {
                        Unacifra++;
                    }
                }
            }
            Console.WriteLine("Cantidad de numeros de una cifra en el array son: " + Unacifra + " Cantidad de numeros de dos cifras en el array son: " + Doscifras);



            Console.ReadKey();
        }
    }
}
