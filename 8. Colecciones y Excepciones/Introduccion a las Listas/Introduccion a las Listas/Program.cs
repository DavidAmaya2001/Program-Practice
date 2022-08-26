using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion_a_las_Listas
{
    public class Program
    {
        static void Main(string[] args)
        {
            // ------------------------------------------ Declaracion de una Lista ------------------------------------------ //

            List<int> numeros = new List<int> { 19, 15, 17, 20 };  // Definiendo una Lista
            //                         Indices:  0   1   2   3

            //Añadiendo elementos a la lista desde afuera 
            numeros.Add(8);
            numeros.Add(65);

            Console.WriteLine(numeros[0]);                         // Imprimiendo el primer valor
            Console.WriteLine(numeros[2]);                         // Imprimiendo el tercer valor
            Console.WriteLine(numeros[5] + "\n");                         // Imprimiendo el quinto valor que fue agregado desde fuera

            // Recorrer todos los elementos que estan almacenados en la lista
            foreach (int numbers in numeros)
            {
                Console.WriteLine(numbers);
            }

            // Metodos para Listas (Count)
            int numerosElementos = numeros.Count;
            Console.WriteLine("\n" + numerosElementos);


            // -------------------------------------------- Listas usando clases -------------------------------------------- //

            Estudiante oEstudiante1 = new Estudiante("Luis", 15, 17);
            Estudiante oEstudiante2 = new Estudiante("Felipe", 18, 15);
            Estudiante oEstudiante3 = new Estudiante("Erick", 11, 13);

            // Dos maneras de agregar datos en objetos a una lista
            List<Estudiante> ListaEstudiantes = new List<Estudiante> { oEstudiante1, oEstudiante2, oEstudiante3 };
            List<Estudiante> ListaEstudiantes2 = new List<Estudiante> { new Estudiante("Luis", 15, 17), new Estudiante("Felipe", 18, 15), new Estudiante("Erick", 11, 13) };

            //Accediento a los elementos de la lista

            double promedio = (ListaEstudiantes[1].nota1 + ListaEstudiantes[1].nota2) / 2.0;
            Console.WriteLine("\n" + promedio);

            // Agregando un rango de Valores 
            List<Estudiante> lista1 = new List<Estudiante> { new Estudiante("Santiago", 10, 12), new Estudiante("Benito", 18, 15) };

            //Añadiendo un valor a la lista de objetos
            lista1.Add(new Estudiante("Pedro", 11, 16));
            Console.WriteLine("\n" + lista1.Count);

            List<Estudiante> lista2 = new List<Estudiante> { new Estudiante("Felipe", 10, 12), new Estudiante("Luis", 18, 15), new Estudiante("Jorge", 18, 15) };
            //Añadiendo varios valores a la lista de objetos
            
            lista2.AddRange(lista1);
            Console.WriteLine("\n" + lista2.Count + "\n");

            // Recorriendo una lista de objetos
            foreach(Estudiante oEstudiante in lista2)
            {
                Console.WriteLine(oEstudiante.nombre);
            }

            Console.ReadKey();
        }
    }
}
