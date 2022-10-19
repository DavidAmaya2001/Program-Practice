using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_LinQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Origen de Datos
            List<Empleado> listaEmpleado = new List<Empleado>{
               new Empleado {nombre="Pedro" , añosExperiencia=18 },
               new Empleado {nombre="Luis" , añosExperiencia=29 },
               new Empleado {nombre="Juan" , añosExperiencia=5 },
               new Empleado {nombre="Jose" , añosExperiencia=7 },
               new Empleado {nombre="Gerardo" , añosExperiencia=9 }
            };

            // Consulta de Datos
            var consulta = from lista in listaEmpleado
                           where lista.añosExperiencia > 10
                           select lista;

            // Ejecucion de Consulta
            foreach(var item in consulta)
            {
                Console.WriteLine(item.nombre);
            }

            Console.ReadKey();
        }
    }
}
