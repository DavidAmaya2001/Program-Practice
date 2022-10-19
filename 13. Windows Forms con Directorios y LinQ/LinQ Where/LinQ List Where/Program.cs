using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_List_Where
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Empleados> listEmpleado = new List<Empleados>     // Fuente de Datos
            {
                new Empleados {IdEmpleado=1, nombre="Vanessa", sueldo=1000},
                new Empleados {IdEmpleado=2, nombre="Jorge", sueldo=800},
                new Empleados {IdEmpleado=3, nombre="Carmen", sueldo=1500},
                new Empleados {IdEmpleado=4, nombre="Aurora", sueldo=1200},
            };

            // Definicion de la consulta

            var consulta = from empleados in listEmpleado 
                           where empleados.sueldo > 1100
                           select empleados;

            // Ejecucion de consulta

            foreach (var item in consulta)
            {
                Console.WriteLine("El empleado con nombre: " + item.nombre + " y su sueldo es de: " + item.sueldo);
            }

            Console.ReadKey();
        }
    }
}
