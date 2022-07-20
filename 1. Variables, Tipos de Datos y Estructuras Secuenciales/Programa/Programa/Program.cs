using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // --------------------------- Tipos de Datos --------------------------- //

            short a = 1;           // Soporta de -32768 a 32767
            int b = 200000;        // Soporta de -2147483648 a 2147483647 
            long c = 10000000;     // Soporta de -9223372036854775808 a -9223372036854775807
            double d = 10.5d;      // Soporta numeros y decimales (7 digitos)
            float e = 18.66f;      // Soporta numeros y decimales (15-16 digitos)
            decimal f = 305.887m;  // Soporta numeros y decimales (28-29 digitos)
            char g = 'a';          // Representa un caracter
            string h = "hola";     // Soporta uno o mas caracteres
            bool i = true;         // Soporta valores true o false;

            // ------------------------- Operaciones Basicas ------------------------ //

            int valor1 = 5;
            int valor2 = 30;
            double valor3 = 4.5;
                                                                                            
            int suma = valor1 + valor2;                       // Sumatoria (+)                 
            int resta = valor1 - valor2;                      // Resta (-)
            int multiplicacion = valor1 * valor2;             // Multiplicacion (*)
            double division = (valor1 * 1.0) / valor2;        // Division (/)
            double sumadecimal = valor1 + valor3;
            int residuo = valor2 % valor1;                    // Residuo (%)

            // Imprimiendo
            Console.WriteLine("Sumatoria entre " + valor1 + " y " + valor2 + " es: " + suma);
            Console.WriteLine("Resta entre " + valor1 + " y " + valor2 + " es: " + resta);
            Console.WriteLine("Multiplicación entre " + valor1 + " y " + valor2 + " es: " + multiplicacion);
            Console.WriteLine("Division entre " + valor1 + " y " + valor2 + " es: " + division);
            Console.WriteLine("La suma entre el entero " + valor1 + " y el decimal " + valor3 + " es: " + sumadecimal);
            Console.WriteLine("Residuo entre " + valor2 + " y " + valor1 + " es: " + residuo);

            // ------------------- Operciones Basicas con Cadena ------------------- //

            string cad1 = "ABC";
            string cad2 = "DEF";
            int numero = 20;

            string SumaCadena = cad1 + cad2;         // Se juntan ambos datos
            string SumaNumero = cad1 + numero;       // Se junta el dato y el numero
            Console.WriteLine(SumaCadena);
            Console.WriteLine(SumaNumero);

            // -------------------- Conversión de Tipo de Dato --------------------- //

            string Numero = "20";
            string Resultado = Numero + 10;          // Tipo String y  un numero se juntan

            int NumeroConv = int.Parse(Numero);      // Conversion de String a Int
            int ResultadoConv = NumeroConv + 10;     // Tipo numero y numero se suman

            Console.WriteLine(ResultadoConv);

            int aa = 30;
            string Cadena = aa.ToString();           // Conversion de Int a String
            Console.WriteLine(Cadena);

            // ---------------------- Estructuras Selectivas ---------------------- //

            //   ( > Mayor que ) ( < Menor que ) ( >= Mayor o igual que ) ( <= Menor o igual que ) ( == igual que ) ( equals() Comparar cadena )

            Console.WriteLine("Ingrese un numero para calcular si es par o impar");
            string parImpar = Console.ReadLine();
            int ParImpar = int.Parse(parImpar);
            
            if (ParImpar % 2 ==0)
            {
                // Si se cumple la condición entra aquí
                // Par
            }
            else if (ParImpar % 2 ==1)
            {
                // Si no se cumple la primera condición, entra aquí
                // Impar
            }
            else
            {
                // Si no se cumple ninguna condición, entra aquí
            }

            int Calculo = ParImpar % 2;
            if (ParImpar.Equals(0))
            {
                // Condición aplicando Equals
            }

            // ------------------------ If- Else anidado ------------------------ //

            Console.WriteLine("Ingrese una nota (A B C)");
            string valor = Console.ReadLine();
            if (valor.Equals("A"))
            {
                // Cumple la condicion de ser igual a A entonces aprobo
            }
            else if (valor.Equals("B"))
            {
                // Cumple la condición de ser igual a B entonces necesita refuerzo
            }
            else if (valor.Equals("C"))
            {
                // Cumple la condición de ser igual a C entonces desaprobo
            }
            else
            {
                // Si no cumple las 3 condiciones anteriores entonces entrara al else
            }

            // ------------------------ Estructura Switch ------------------------ //

            Console.WriteLine("Ingrese una nota");
            string notaswitch = Console.ReadLine();

            switch (notaswitch)
            {
                case "A": // Entra al case y muestra al usuario que aprobo
                    break;
                case "B": // Entra al case 2 y muestra al usuario que necesita refuerzo
                    break;
                case "C": // Entra al case 3 y muestra al usuario que desaprobo
                    break;
                default: //  Case por defecto como un else
                    break;
            }



            Console.ReadKey();
        }
    }
}
