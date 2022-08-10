using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Ticket oTicket = new Ticket();
            oTicket.setColor("verde");
            oTicket.setTamaño(2);
            oTicket.setTipo(1);
            oTicket.setCantidad(2);

            Console.WriteLine("Precio " + oTicket.calcularPrecio());
            Console.WriteLine("Cantidad " + oTicket.getCantidad());
            Console.WriteLine("Total " + oTicket.ToTalaPagar());

            Console.ReadKey();
        }
    }
}
