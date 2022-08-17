using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado emp = new Empleado();
            emp.nombre = "Julio";
            emp.apaterno = "Fernandez";
            emp.amaterno = "Felipe";
            emp.fechaContrato = DateTime.Now;
            emp.sueldo = 3000;
            string nombreCompleto = emp.nombrecompleto();
            Console.WriteLine(nombreCompleto);
            Console.WriteLine("Fecha de contrato: " + emp.fechaContrato + " sueldo: " + emp.sueldo);


            Cliente oCliente = new Cliente();
            oCliente.nombre = "Joseph";
            oCliente.apaterno = "De la Cruz";
            oCliente.amaterno = "Aurelio";
            oCliente.edad = 22;
            oCliente.dirección = "abc";
            oCliente.fechaNacimiento = DateTime.Now;
            string nombreComp = oCliente.nombrecompleto();
            Console.WriteLine(nombreComp);


            Console.ReadKey();
        }
    }
}
