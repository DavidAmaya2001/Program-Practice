using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_y_Propiedades
{
    public class Persona
    {
        public string nombre { get; set; }
        public string apaterno { get; set; }
        public string amaterno { get; set; }
        public int edad { get; set; }
        public double sueldo { get; set; }

        public string nombreCompleto()
        {
            return nombre + " " + apaterno + " " + amaterno;
        }

        public double calcularSueldoAnual()
        {
            return sueldo * 12;
        }
        public static string saludo(string nombre)                        // Dentro de metodos estaticos no se pueden llamar otros metodos 
        {                                                                 // que no sean estaticos
            return "Que pasaaa causa " + nombre + " gaaaaaa";
        }
        public static string saludo(string apellidopaterno, string apellidomaterno)
        {
            return "Hola como estas: " + apellidomaterno + " " + apellidopaterno;                 // Para declarar otro metodo que tenga el mismo nombre que un metodo
        }                                                                 // creado anteriormente, este debe tener o mas parametros u otro tipo
                                                                          // de dato de la variable (int, string, double, etc)
        public static string saludo(int edad)
        {
            return edad.ToString() + 12;
        }
    }
}
