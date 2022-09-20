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


                            // ----------------------- IndexOf, Find y FindAll  ----------------------- //

            int[] numeros = { 5, 18, 21, 4, 13 };
            //    Indices     0   1   2  3   4
            string[] nombres = { "Pedro", "Luis", "Jose", "Felipe" };
            int Longitud = numeros.Length;

            
            int Primer = Array.Find(numeros, p => p > 15);          // .Find extrae de un array el primer elemento que cumpla la condicion
                                                                    // p es la variable de rango que recorre el array y luego de => es la condicion

            int[] todos = Array.FindAll(numeros, p => p > 15);      // .FindAll extrae todos los elementos que cumplan la condicion
                                                                    // p es la variable de rango que recorre el array y luego de => es la condicion

            int indice = Array.IndexOf(numeros, 20);                // .IndexOf solo busa en el array si existe la condición y si no regresa valor -1
            if(indice > 0)
            {
                Console.WriteLine("Existe el valor");
            }
            else
            {
                Console.WriteLine("No existe");
            }

            int ultimo = Array.FindLast(numeros, p => p > 15);      // .FindLast extrae de un array el ultimo elemento que cumpla la condicion
                                                                    // p es la variable de rango que recorre el array y luego de => es la condicion

            int Indice = Array.FindIndex(numeros, p => p > 10);     // .FindIndex extrae el indice de donde se cumple la primera condicion en el array

            int Ultimo = Array.FindLastIndex(numeros, p => p > 15); // .FindLastIndex extrae el indice de donde se cumple la ultima condicion

            bool Verf = Array.Exists(nombres, p => p.StartsWith("J"));
            if (exito)
            {
                Console.WriteLine("Hay elementos que cumplen");     // .Exist regresa un true si hay elementos que cumplen la condicion y false si no
            }


            // ------------------------------ TimeSpan  ------------------------------ //

            TimeSpan oTimeSpan = new TimeSpan(4, 10, 29);           // TimeSpan genera un tipo de dato de tiempo
            TimeSpan oTimeSpan2 = new TimeSpan(5, 15, 10);          // TimeSpan time1 = new TimeSpan(1,0,0,0);
                                                                    // TimeSpan time2 = new TimeSpan(13,0,0);
            TimeSpan oTimeSpan3 = oTimeSpan + oTimeSpan2;
            Console.WriteLine(oTimeSpan3);                          // Regresa 09, 25, 39    (Horas, Minutos, Segundos)
            TimeSpan oTimeSpan4 = oTimeSpan2 - oTimeSpan;
            Console.WriteLine(oTimeSpan4);                          // Regresa 01, 04, 41    (Horas, Minutos, Segundos)

            TimeSpan objeto1 = new TimeSpan(5, 4, 3, 2, 1);         // ( Dias, Horas, Minutos, Segundos, Milisegundos )

            // Propiedades
            Console.WriteLine(objeto1.Days);                        // .Days obtiene los dias de un TimeSpan
            Console.WriteLine(objeto1.Hours);                       // .Hours obtiene las horas de un TimeSpan
            Console.WriteLine(objeto1.Minutes);                     // .Minutes obtiene los minutos de un TimeSpan
            Console.WriteLine(objeto1.Seconds);                     // .Seconds obtiene los segundos de un TimeSpan
            Console.WriteLine(objeto1.Milliseconds);                // .Miliseconds obtiene los milisegundos de un TimeSpan

            // Metodos
            TimeSpan fecha1 = new TimeSpan(15, 12, 15, 15, 15);
            TimeSpan fecha2 = new TimeSpan(5, 48, 15, 45, 45);
            TimeSpan fecha3 = fecha1 + fecha2;

            Console.WriteLine(fecha3.TotalDays);                    // .TotalDays convierte la fecha a los dias totales que contiene el TimeSpan
            Console.WriteLine(fecha3.TotalHours);                   // .TotalHours convierte la fecha a las horas totales que contiene el TimeSpan
            Console.WriteLine(fecha3.TotalMinutes);                 // .TotalMinutes convierte la fecha a los minutos totales que contiene el TimeSpan
            Console.WriteLine(fecha3.TotalSeconds);                 // .TotalSeconds convierte la fecha a los segundos totales que contiene el TimeSpan
            Console.WriteLine(fecha3.TotalMilliseconds);            // .TotalMiliseconds convierte la fecha a los milisegundos totales que contiene el TimeSpan

            TimeSpan fecha4 = fecha2.Add(fecha1);                   // .Add cumple la funcion de (fecha1 + fecha2)

            Console.WriteLine(fecha2.CompareTo(fecha1));            // .CompareTo si fecha1 es mayor regresa -1 y si fecha1 es menor regresa 1 como valor

            Console.WriteLine(TimeSpan.FromDays(1));                // .FromDays convierte el valor a un TimeSpan de 01: 00: 00: 000
            Console.WriteLine(TimeSpan.FromHours(2));               // .FromHours convierte el valor a un TimeSpan de 02: 00: 00
            Console.WriteLine(TimeSpan.FromMinutes(3));             // .FromMinutes convierte el valor a un TimeSpan de 00: 03: 00
            Console.WriteLine(TimeSpan.FromSeconds(4));             // .FromSeconds convierte el valor a un TimeSpan de 00: 00: 04
            Console.WriteLine(TimeSpan.FromMilliseconds(5));        // .FromMiliseconds convierte el valor a un TimeSpan de 00: 00: 00.0050000

            string Fecha = "17:20:10";
            TimeSpan.ParseExact(Fecha, @"h\:mm\:ss", null);         // .ParseExact convierte una cadena a un formato de TimeSpan
                                                                    // formato ( variable, @"h\:mm\:ss" , null)


            Console.ReadKey();
        }
    }
}
