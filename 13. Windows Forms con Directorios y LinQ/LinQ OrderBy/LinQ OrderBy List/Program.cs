using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_OrderBy_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Persona> listaPersona = new List<Persona>
            {
                new Persona {idPersona = 1, nombre="Julio", aPaterno="Perez"},
                new Persona {idPersona = 1, nombre="Jorge", aPaterno="Jimenez"},
                new Persona {idPersona = 1, nombre="Lucho", aPaterno="Ameida"},
            };

            var consulta = from lista in listaPersona
                           orderby lista.aPaterno
                           select lista;

            foreach(var item in consulta)
            {
                Console.WriteLine("La persona " + item.nombre + " su apellido es " + item.aPaterno);
            }

            Console.ReadKey();
        }
    }
}
