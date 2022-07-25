using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_5_parte_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mensaje("Ingrese el precio que se descontara");
            decimal Precio = int.Parse(Console.ReadLine());

            Calculo(Precio);

            Console.ReadKey();
        }
        static void Calculo(decimal precio)
        {
            decimal Descuento = precio * 0.2m;
            decimal PrecioDesc = precio - Descuento;
            Mensaje("El precio con el descuento es de: " + PrecioDesc);
        }
        static void Mensaje(string cadena)
        {
            Console.WriteLine(cadena);
        }
    }
}
