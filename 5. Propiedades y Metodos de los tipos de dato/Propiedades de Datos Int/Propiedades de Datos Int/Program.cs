using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propiedades_de_Datos_Int
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ---------------------------------------- Metodos de losNumeros ---------------------------------------- //

            string numero = "15";
            int resultado;

            // Int16 es Short             // Int32 es Int             // Int64 es Long

                           // ------------------------------- TryParse  ------------------------------- //

            bool exito = Int32.TryParse(numero, out resultado);
            // .TryParse convierte una variable a tipo Int pero como resultado solo devuelve True o False

            if (exito == true)
            {
                Console.WriteLine("Es un numero");
            }
            else
            {
                Console.WriteLine("No es un numero");
            }

            int suma = resultado + 5;
            Console.WriteLine("La suma es: " + suma);

                            // ----------------------------- To String  ----------------------------- //

            short a = 10;
            int b = 20;
            long c = 30;
            int d = -5;

            Console.WriteLine(a.ToString() + " " + b.ToString() + " " + c.ToString());  // .ToString para que todos sean tipo cadena 

                            // -------------------------------- Math  -------------------------------- //

            double precio = 20.6;
            Console.WriteLine(Math.Floor(precio));          // Math.Floor() convierte una variable a tipo entero desechando todos sus decimales

            Console.WriteLine(Math.Ceiling(precio));        // Math.Ceiling() toma la parte entera de la variable y le suma 1

            Console.WriteLine(Math.Round(precio));          // Math.Round() redondea el valor de la variable al siguiente o anterior numero entero

            Console.WriteLine(Math.Pow(a, b));              // Math.Pow() elava la variable "a" (base) a la variable "b" (potencia)

            Console.WriteLine(Math.Sqrt(c));                // Math.Sqrt() saca la raiz cuadrada de una variable

            Console.WriteLine(Math.Max(a, b));              // Math.Max() regresa el mayor valor entre dos variables

            Console.WriteLine(Math.Min(b, c));              // Math.Min() regresa el menor valor entre dos variables

            Console.WriteLine(Math.Abs(d));                 // Math.Abs() regresa el valor absoluto de una variable



            Console.ReadKey();
        }
    }
}
