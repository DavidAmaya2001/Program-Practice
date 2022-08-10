using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento___Get_y_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            // --------------------------------------- Con Private y encapsulamiento --------------------------------------- //

            Empleado obEmpleado = new Empleado();
            Empleado obEmpleado2 = new Empleado();
            // Se asigna al setSueldo para comprobar si es mayor a 0
            obEmpleado.setSueldo(500);
            obEmpleado2.setSueldo(-500);
            // Una vez asignado el valor segun la comprobacion se puede leer el valor de la propiedad
            Console.WriteLine(obEmpleado.getSueldo());
            Console.WriteLine(obEmpleado2.getSueldo());

            

            // ----------------------------------- Metodos get y set de la clase Persona ----------------------------------- //

            Persona oPersona = new Persona();

            //Asignando informacion en set
            oPersona.setNombre("Rodrigo");
            oPersona.setApPaterno("Gonzales");
            oPersona.setApMaterno("Padilla");
            oPersona.setEdad(10);
            oPersona.setSueldo(1700);

            //Leer la informacion en get

            Console.WriteLine(oPersona.getEdad());
            Console.WriteLine(oPersona.getSueldo());

            Console.ReadKey();
        }
    }
}
