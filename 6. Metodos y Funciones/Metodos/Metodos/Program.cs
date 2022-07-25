using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    internal class Program
    {
        // ----------------------------------------- Metodos ----------------------------------------- //
        static void Main(string[] args)
        {
            mensaje("hola amigos");
            mensaje("Ojo");

            string[] nombres = { "Pepe", "Lucho", "Felipe" };
            string[] Apellidos = { "Gomez", "Perez", "Mejia" };
            imprimirArray(nombres);
            imprimirArray(Apellidos);

            imprimirRango(10, 15);
            imprimirRango(80, 85);

            noCerrarVentana();
        }

        // Metodo
        static void noCerrarVentana()
        {
            Console.ReadKey();
        }
        static void mensaje(string cadena)
        {
            Console.WriteLine(cadena);
        }
        static void imprimirArray(string[] Array)
        {
            foreach (string item in Array)
            {
                mensaje(item);
            }
        }
        static void imprimirRango(int inicio, int fin)
        {
            for(int i=inicio; i<=fin; i++)
            {
                mensaje(i.ToString());
            }
        }
    }
}
