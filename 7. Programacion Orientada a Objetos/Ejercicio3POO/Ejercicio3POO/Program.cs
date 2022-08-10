using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno oAlumno = new Alumno();
            oAlumno.setNmbreAlumno("ELPEPE");
            oAlumno.setNota1(6);
            oAlumno.setNota2(9);
            oAlumno.setNota3(10);
            oAlumno.setNota4(8);

            Console.WriteLine("Promedio dos primeras notas " + oAlumno.promPrimNotas());
            Console.WriteLine("Promedio dos ultimas notas " + oAlumno.promUltNotas());
            Console.WriteLine("Promedio de todas las notas " + oAlumno.promTotal());

            Console.ReadKey();
        }
    }
}
