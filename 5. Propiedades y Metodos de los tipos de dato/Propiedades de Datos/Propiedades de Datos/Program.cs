using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propiedades_de_Datos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ------------------------------ Metodos de los String ------------------------------ //
            
            String nombre = "Jorge";                             // ---------------------------- .Length ---------------------------- //
            Console.WriteLine(nombre.Length);                    // .Length saca el numero de caracteres que tiene la variable
                                                                 // si la variable tiene espacios el .Length lo contara igual como caracter

            String a = "Papa";
            String b = "Mama";                                   // ---------------------------- .Equals ---------------------------- //
            if (a.Equals(b))                                     // .Equals compara ambas variables para comprobar si son iguales
            {
                Console.WriteLine("Son iguales");
            }
            else
            {
                Console.WriteLine("Son diferentes");
            }


            string Apellido = " Gonzales Parada ";               // ---------------------------- .Trim ---------------------------- //
            Console.WriteLine(Apellido.Length);                  // Regresa 10 caracteres con .Length (contando los espacios)
            Console.WriteLine(Apellido.Trim().Length);           // .Trim elimina los espacios de al frente y atras de una variable ( 8 caracteres )


            string objeto = " Meza ";
            Console.WriteLine(objeto.TrimStart().Length);        // .TrimStart solo elimina los espacios de al frente de la variable
            Console.WriteLine(objeto.TrimEnd().Length);          // .TrimEnd solo elimina los espacios del final de la variable


            string utiles = "Cartuchera";                        // ---------------------- .ToUpper .ToLower ---------------------- //
            Console.WriteLine(utiles.ToUpper());                 // .ToUpper convierte todos los caracteres de la variable a mayuscula
            Console.WriteLine(utiles.ToLower());                 // .ToLower convierte todos los caracteres de la variable a minuscula 


            string Nombre = "Pepe";                              // ------------------------ .ToCharArray ------------------------- //
            char[] array = Nombre.ToCharArray();                 // .ToCharArray convierte los caracteres a un Array de char
            int c = 0;
            foreach(char item in array)
            {
                if (item.Equals('e'))
                {
                    c++;
                }
            }
            Console.WriteLine("Se repite la letra e: " + c);


            string codigo = "12345678";                          // -------------------------- .SubString -------------------------- //
            string name = "Pepe lucho";
            string codigoT = codigo.Substring(0, 3);             // .SubString(a,b) toma los caracteres que se solicited de una variable 
            string nameT = name.Substring(0, 3);                 // a = la posición donde empezara a tomar y b = los caracteres que tomara desde a
                                                                 // comenzara desde la posicion a = 0 y tomara los siguientes b = 3 caracteres
            Console.WriteLine("Su codigo es: " + codigoT + nameT);


            string code = "A20221528";                           // --------------------------- .Remove --------------------------- //
            string newcode = code.Remove(0, 2);                  // .Remove(a,b) elimina los caracteres solicitados de una variable
            Console.WriteLine("Nueva cadena: " + newcode);       // a = posicion donde empezara a eliminar y  b = los caracteres que eliminara desde a


            string[] names = { "Pepe", "Pedro", "Damian" };      // ------------------------- .StartsWith ------------------------- //
            int count = 0;
            foreach(string nom in names)                         
            {
                if (nom.StartsWith("P"))                         // .StartsWith verifica si cierta cadena inicia con ciertos caracteres
                {                                                // .StartsWith("Pe") igual detectaria 2 similitudes
                    count++;
                }
            }
            Console.WriteLine("Numero de veces: " + count);


            int count2 = 0;
            foreach(string nom in names)
            {
                if (nom.EndsWith("n"))                           // .EndsWith verifica si cierta cadena finaliza con ciertos caracteres
                {                                                // .EndsWith("an") igual detectaria 1 similitud
                    count2++;
                }
                else
                {
                    // string ultimaLetra = nom.Substring(nom.Length - 1 , 1)
                    // Console.WriteLine("No termina con n, termina con " + ultimaLetra);
                }
            }
            Console.WriteLine("Numero de veces: " + count2);


            string mensaje = "Me fui a comprar al cine";         // ------------------------- .Contains ------------------------- //
            if (mensaje.Contains("cine"))                        // .Contains verifica si el caracter/caracteres estan dentro de la variable
            {
                Console.WriteLine("Se encuentra");
            }


            string palabra = "cartuchera";                       // ------------------------- .Split ------------------------- //
            string[] array2 = palabra.Split('a');                // .Split separa el string en varios string en forma de array dependiendo
            foreach(string item in array2)                       // de la variable que se le ha colocado
            {
                Console.WriteLine(item);                         // regresa:  { "c" , "rtucher" }
            }

            string message = "Hola gente del furuto";
            string[] Array3 = message.Split(' ');                // regresa: { "Hola" , "gente" , "del" , "futuro" }
            foreach(string item in Array3)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Numero de palabras: " + Array3.Length);


            Console.ReadKey();
            
        }
    }
}
