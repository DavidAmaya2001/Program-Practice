using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;                       // Se instancia este using.System.IO 

namespace Propiedades_de_los_Directorios
{
    class Program
    {
        static void Main(string[] args)
        {
            // ------------------------------------------------- Metodos de Directory ------------------------------------------------- //
            string ruta = @"D:\Users\Documentos\GitHub\Program-Practice\9. Manejo de Directorios y Archivos\ClaseArchivo\Estudiantes";
            // se coloca un @ ya que los \ son caracter especial y con el @ se indica que es direccion             se crea la carpeta Estudiantes

            string ruta2 = @"D:\Users\Documentos\GitHub\Program-Practice\9. Manejo de Directorios y Archivos\ClaseArchivo\Profesores";

            string ruta3 = @"D:\Users\Documentos\GitHub\Program-Practice\9. Manejo de Directorios y Archivos\ClaseArchivo\Alumnos";

            // Saber si un directorio existe o no
            // Directory.Exists(ruta);

            // Creacion de un directorio vacio
            // Directory.CreateDirectory(ruta);

            // Eliminar un directorio vacio
            // Directory.Delete(ruta)

            //Eliminar un directorio con contenido
            // Directory.Delete(ruta, true);     // con true se eliminara la carpeta contenga o no contenga subcarpetas dentro

            // Saber que directorios tiene la ruta
            List<string> lista =Directory.EnumerateDirectories(ruta2).ToList();     // ToList lo convierte en una lista
            foreach (string element in lista)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("\n");

            // Saber que directorios tiene la ruta (filtro de letra inicial)
            List<string> lista2 = Directory.EnumerateDirectories(ruta2,"C*").ToList();     // ToList lo convierte en una lista
            foreach (string element in lista2)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("\n");

            // Saber que directorios tiene la ruta (filtro de letra final)
            List<string> lista3 = Directory.EnumerateDirectories(ruta2, "*a").ToList();     // ToList lo convierte en una lista
            foreach (string element in lista3)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("\n");

            // Saber que archivos tiene la ruta
            List<string> listado = Directory.EnumerateFiles(ruta3).ToList();
            foreach(string item in listado)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");

            // Saber que archivos tiene la ruta (filtro de letra inicial)
            List<string> listado2 = Directory.EnumerateFiles(ruta3, "T*").ToList();
            foreach (string item in listado2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");

            // Saber que archivos tiene la ruta (filtro de letra final)
            List<string> listado3 = Directory.EnumerateFiles(ruta3, "*e").ToList();
            foreach (string item in listado3)
            {
                Console.WriteLine(item);
            }

            // ------------------------------------------------- Clase DirectoryInfo ----------------------------------------------------- //

            DirectoryInfo dir = new DirectoryInfo(ruta2);
            if (dir.Exists)
            {
                Console.WriteLine("Existe el directorio");
            }
            else
            {
                Console.WriteLine("No existe el directorio");
            }

            // Saber el nombre del directorio padre
            Console.WriteLine("\n" + dir.Parent);

            string ruta4 = @"D:\Users\Documentos\GitHub\Program-Practice\9. Manejo de Directorios y Archivos\ClaseArchivo\Csharp.txt";

            // Crear un archivo
            // File.Create(ruta4);

            // Eliminar un archivo
            // File.Delete(ruta4);

            // Crear contenido en lista dentro de un archivo
            List<string> nombres = new List<string>();
            nombres.Add("Pedro");
            nombres.Add("Luis");
            nombres.Add("Jose");
            nombres.Add("Santiago");
            nombres.Add("Nelly");

            File.AppendAllLines(ruta4, nombres);

            // Crear contenido directo dentro de una lista
            string contenido = "Pedro Luis Jose Santiago Nelly";
            File.AppendAllText(ruta4, contenido);


            Console.ReadKey();

        }
    }
}
