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

            Console.WriteLine("\n");
            listaCliente.AddRange(listaCliente2);

            foreach (Cliente oCliente in listaCliente)
            {
                Console.WriteLine(oCliente.nombre);
            }

            Console.WriteLine("\nNumero de elementos: " + listaCliente.Count);

            // Limpiar elementos de una lista
            listaCliente.Clear();

            Console.ReadKey();
        }
    }
}
