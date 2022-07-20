using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 1
            // Se tiene el siguiente array de numeros. Calcular cuantos elementos son pares y cuantos son impares
            int[] valores = { 7, 9, 23, 56, 23, 34, 66, 78, 79, 34, 12, 16, 15 };
            int Par = 0, Impar = 0;
            foreach(int val in valores)
            {
                if (val % 2 == 0)
                {
                    Par++;
                }
                else
                {
                    Impar++;
                }
            }
            Console.WriteLine("Cantidad de pares en el array: " + Par + " Cantidad de Impares en el array: " + Impar);


            // Ejercicio 2
            // Se tiene el siguiente array de numeros indicar cuantos numeros de tres cifras positivos hay
            int[] valores1 = { 721, 9, 423, 56, 23, 34, 966, 78, 79, 3664, 12, 5516, 15 };
            int TresC = 0;
            foreach(int val1 in valores1)
            {
                if (val1 >= 100)
                {
                    TresC++;
                }
            }
            Console.WriteLine("Cantidad de numeros de 3 cifras positivos en al array: " + TresC);


            // Ejercicio 3
            // Se tiene el siguiente array, hallar la suma de los elementos que son mayores a 15
            int[] numeros = { 5, 8, 6, 4, 8, 25, 4, 2, 8, 12, 45, 12, 6, 7, 8 };
            int suma = 0;
            foreach(int num in numeros)
            {
                if (num > 15)
                {
                    suma += num;
                }
            }
            Console.WriteLine("La suma de los valores que son mayores a 15 es de: " + suma);


            Console.ReadKey();

            
        }
    }
}
