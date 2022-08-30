using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_y_Pilas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Antes de usarlas hay que colocar using.System.Collections;
            // ------------------------------------------------------ ArrayList ------------------------------------------------------ //
            ArrayList lista = new ArrayList();     // Tamben se puede con tipo de dato ArrayList<string> lista = new ArrayList<string> ();
            lista.Add("Matematicas");
            lista.Add("Comunicacion");
            lista.Add("Lenguaje");
            lista.Add(50);
            lista.Add(45.6);

            //Imprimir primer valor
            Console.WriteLine("Primer valor: " + lista[0]);

            //Imprimir cuarto valor
            Console.WriteLine("Cuarto valor: " + lista[3]);

            //Cantidad de elementos de un ArrayList
            Console.WriteLine("Numero de elementos: " + lista.Count);

            //Ingresar un valor en la posicion 0
            lista.Insert(0, "Educacion fisica");

            //Recorriendo todos los elementos
            // var almacena cualquier tipo de valor ya que soporta todos los tipos de datos
            foreach (var list in lista)
            {
                Console.WriteLine(list);
            }
            Console.WriteLine("\n\n");

            // ---------------------------------------------------- Pilas / Stack ---------------------------------------------------- //
            Stack pilas = new Stack();             // Tamben se puede con tipo de dato Stack<string> lista = new Stack<string> ();
            pilas.Push("Lunes");
            pilas.Push("Martes");
            pilas.Push("Miercoles");
            pilas.Push("Jueves");
            pilas.Push("Viernes");
            pilas.Push("Sabado");
            pilas.Push("Domingo");

            foreach(var item in pilas)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");

            // Numero de elementos de una pila
            Console.WriteLine("Numero de elementos: " + pilas.Count);

            //CopyTo
            string[] diasSemana = new string[7];
            pilas.CopyTo(diasSemana, 0);            // CopyTo manda elementos a un Array indicando desde que posicion se empieza a almacenar

            foreach (var item in diasSemana)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");

            // Elimina y devuelve el elemento de la parte superior de la pila
            pilas.Pop();

            foreach (var item in pilas)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");

            // Elimina los elementos de una pila
            pilas.Clear();


            // ------------------------------------------------------ Diccionarios ------------------------------------------------------ //

            Dictionary<int, string> diasSemanas = new Dictionary<int, string>();   // --->  Dictionary < n° llave, valor >

            // Añadir elementos al dicionario
            diasSemanas.Add(1, "Domingo");
            diasSemanas.Add(2, "Lunes");
            diasSemanas.Add(3, "Martes");
            diasSemanas.Add(4, "Miercoles");
            diasSemanas.Add(5, "Jueves");
            diasSemanas.Add(6, "Viernes");

            // Agregando elementos con corchetes
            diasSemanas[7] = "Sabado";

            // Numero de elementos en un diccionario
            Console.WriteLine("\n" + diasSemanas.Count + "\n");

            // Imprimiendo solo los valores ( no las llaves int )
            foreach (string val in diasSemanas.Values)
            {
                Console.WriteLine(val);
            }

            // Determinar si el diccionario contiene determinada llave
            if (diasSemanas.ContainsKey(8))
            {
                Console.WriteLine("Existe llave");
            }
            else
            {
                Console.WriteLine("No existe llave");
            }

            // Determinar si el diccionario contiene determinado valor
            if (diasSemanas.ContainsValue("Sabado"))
            {
                Console.WriteLine("Existe el valor");
            }
            else
            {
                Console.WriteLine("No existe el valor");
            }

            // Eliminar una clave de un diccionario
            diasSemanas.Add(8, "Febrero");
            diasSemanas.Remove(8);


            // Eliminar todos los elementos de un diccionario
            diasSemanas.Clear();


            Console.ReadKey();
        }
    }
}
