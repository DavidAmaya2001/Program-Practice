using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_Propiedades_y_Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente oCliente1 = new Cliente("Pedro", "Garcia", "Romero", 17, "ABC SoyaPobre");
            Cliente oCliente2 = new Cliente("Luis", "de la Cruz", "Garma", 19, "ABC ApoPobre");
            Cliente oCliente3 = new Cliente("Jorge", "Peceros", "Aurelio", 21, "ABC IlopanPobres");
            Cliente oCliente4 = new Cliente("Lucho", "Carmona", "Pedrico", 28, "ABC Ciudad Pobre");
            Cliente oCliente5 = new Cliente("Tilin", "El Pepe", "Ete Sech", 17, "ABC Paseo General Escalon");

            List<Cliente> listaCliente = new List<Cliente> { oCliente1, oCliente2, oCliente3, oCliente4, oCliente5 };

            listaCliente.Add(new Cliente("Nelly", "Sarmiento", "Garcia", 40, "ABC Residencia Carisima"));

            foreach(Cliente oCliente in listaCliente)
            {
                Console.WriteLine(oCliente.nombre);
            }

            List<Cliente> listaCliente2 = new List<Cliente>
            {
                new Cliente("Adrian", "Ugariza", "Perez", 20, "ABC CojutePobre"),
                new Cliente("Rodrigo", "Cuba", "Affonso", 25, "ABC Estadio Cusca")
            };

            Console.WriteLine("\nAddRange -->\n");
            listaCliente.AddRange(listaCliente2);

            foreach (Cliente oCliente in listaCliente)
            {
                Console.WriteLine(oCliente.nombre);
            }

            Console.WriteLine("\nNumero de elementos: " + listaCliente.Count + "\n");

            // ------------------------------------------------- Metodos de una Lista ------------------------------------------------- //

            // Encontrar elemento de una lista ( busqueda )
            Cliente oClienteResultado = listaCliente.Find(p => p.nombre.Equals("Adrian"));
            if (oClienteResultado != null)
            {
                Console.WriteLine("Find --> " + oClienteResultado.apPaterno + "\n");
            }
            else
            {
                Console.WriteLine("No se encontro");
            }

            // Encontrar todos los elementos de una lista con FindAll
            List<Cliente> Lista = listaCliente.FindAll(p => p.nombre.StartsWith("L"));
            Console.WriteLine("\nFind All -->\n");
            foreach (Cliente oClienteF in Lista)
            {
                Console.WriteLine(oClienteF.nombre + " " + oClienteF.apPaterno + " " + oClienteF.apMaterno);
            }

            // Agregar un objeto en la posicion que se quiera
            listaCliente.Insert(0, new Cliente("El Pepe", "Ete Sech", "Potaxio", 45, "San Pobrertin"));
            Console.WriteLine("\nInsert -->\n");
            foreach (Cliente oCliente in listaCliente)
            {
                Console.WriteLine(oCliente.nombre);
            }

            // Agregar determinado rango en la posicion que se quiera
            List<Cliente> listaCliente3 = new List<Cliente>
            {
                new Cliente("Josepo", "Rubiola", "Pacon", 12, "ABC CojutePobre"),
                new Cliente("Rubi", "Ramirez", "Melgar", 70, "ABC Estadio Cusca")
            };
            listaCliente.InsertRange(1, listaCliente3); // Despues de el pepe
            Console.WriteLine("\nInsertRange -->\n");
            foreach (Cliente oCliente in listaCliente)
            {
                Console.WriteLine(oCliente.nombre);
            }

            // Eliminar un objeto o varios objetos
            listaCliente.RemoveAll(p => p.nombre.EndsWith("n"));
            Console.WriteLine("\nRemoveAll -->\n");
            foreach (Cliente oCliente in listaCliente)
            {
                Console.WriteLine(oCliente.nombre);
            }

            listaCliente.Remove(listaCliente.Find(p => p.nombre.EndsWith("o")));
            Console.WriteLine("\nRemove -->\n");
            foreach (Cliente oCliente in listaCliente)
            {
                Console.WriteLine(oCliente.nombre);
            }

            listaCliente.RemoveAt(0);
            Console.WriteLine("\nRemoveAt -->\n");
            foreach (Cliente oCliente in listaCliente)
            {
                Console.WriteLine(oCliente.nombre);
            }


            // Limpiar elementos de una lista
            listaCliente.Clear();

            Console.ReadKey();
        }
    }
}
