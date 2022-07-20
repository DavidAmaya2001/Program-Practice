using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ------------------------------------ Arrays ------------------------------------ //

            // String[] nombres = {"Pedro","Maria","Luis","Benito","Sabrina","Lucho","Josefina"};   // Insertar datos a un Array
            //          Indices:      0       1       2       3        4        5         6         // Indice de los elementos
            //          
            // Acceder a Luis -> nombres[2]                   
            // Acceder a Lucho -> nombres[5]
            // Longitud de un array -> int nLongitud = nombre.length;
            // Acceder al ultimo dato -> Console.WriteLine( nombre[nombre.length - 1]);


            // Recorrer array con For
            //
            // for (int i = 0; i < nLongitud ; i++)
            //     {
            //         Console.WriteLine(nombres[i]);
            //     }

            // Recorrer array con Foreach
            //
            // foreach ( string nom in nombres )
            //     {
            //         Console.WriteLine(nom);
            //     }

            // ------------------------- Imprimir elementos de un Array ------------------------- //

            String[] nombres = { "Pedro", "Maria", "Luis", "Benito", "Sabrina", "Lucho", "Josefina" };

            // Forma 1
            int nelementos = nombres.Length;
            Console.WriteLine("Array usando For ");
            for (int i = 0; i < nelementos; i++)
            {
                Console.WriteLine(nombres[i]);
            }

            // Forma 2
            Console.WriteLine("\nArray usando Foreach ");
            foreach (string name in nombres)
            {
                Console.WriteLine(name);
            }

            int[] notas = { 10, 15, 20, 25, 30 };
            Console.WriteLine("\nArray de int usando Foreach ");
            foreach (int notes in notas)
            {
                Console.WriteLine(notes);
            }

            // ------------------------ Matrices Array (Array de Array) ------------------------ //

            int[] calificaciones = new int[5];
            calificaciones[0] = 5;
            calificaciones[1] = 10;
            calificaciones[2] = 15;
            calificaciones[3] = 20;
            calificaciones[4] = 25;
            Console.WriteLine("\n");

            foreach(int numero in calificaciones)
            {
                Console.WriteLine(numero);
            }

            //Array de Array deben tener misma longitud
            string[,] NombreCompleto = 
            { 
                {"Julio","Nieves","Sandoval" },        // Posicion 0
                {"Ricardo","De la Cruz","Murayari"},   // Posicion 1
                {"Rolando","Garcia","Peceros"}         // Posicion 2
            };

            Console.WriteLine("\n");
            Console.WriteLine(NombreCompleto[0, 0]);   // Imprimiendo Julio
            Console.WriteLine(NombreCompleto[0, 2]);   // Imprimiendo Sandoval
            Console.WriteLine(NombreCompleto[2, 1]);   // Imprimiendo Garcia

            // ------------------------ Llenar un Array Dinamicamente ------------------------ //

            int[] numerales = new int[5];

            for(int i=0; i <= 4; i++)
            {
                Console.WriteLine("\n");
                Console.WriteLine("Ingrese el " + (i + 1) + "° numero: ");
                numerales[i] = int.Parse(Console.ReadLine());
            }
            
            //Suma del primer y ultimo valor
            int suma = numerales[0] + numerales[numerales.Length-1];
            Console.WriteLine("\nSuma: " + suma);



            Console.ReadKey();

        }
    }
}
