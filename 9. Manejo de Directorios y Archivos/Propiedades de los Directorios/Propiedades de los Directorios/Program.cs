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
            List<string> lista = Directory.EnumerateDirectories(ruta2).ToList();     // ToList lo convierte en una lista
            foreach (string element in lista)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("1 \n");

            // Saber que directorios tiene la ruta (filtro de letra inicial)
            List<string> lista2 = Directory.EnumerateDirectories(ruta2, "C*").ToList();     // ToList lo convierte en una lista
            foreach (string element in lista2)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("2 \n");

            // Saber que directorios tiene la ruta (filtro de letra final)
            List<string> lista3 = Directory.EnumerateDirectories(ruta2, "*a").ToList();     // ToList lo convierte en una lista
            foreach (string element in lista3)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("3 \n");

            // Saber que archivos tiene la ruta
            List<string> listado = Directory.EnumerateFiles(ruta3).ToList();
            foreach (string item in listado)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("4 \n");

            // Saber que archivos tiene la ruta (filtro de letra inicial)
            List<string> listado2 = Directory.EnumerateFiles(ruta3, "T*").ToList();
            foreach (string item in listado2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("5 \n");

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

            // Saber el nombre del directorio padre --------------------------------------------------------------------------------
            Console.WriteLine("6 \n" + dir.Parent);

            string ruta4 = @"D:\Users\Documentos\GitHub\Program-Practice\9. Manejo de Directorios y Archivos\ClaseArchivo\Csharp.txt";

            // Crear un archivo ------------------------------------------------------------------------------------------------
            // File.Create(ruta4);

            // Eliminar un archivo ----------------------------------------------------------------------------------------------
            // File.Delete(ruta4);

            // Crear contenido en lista dentro de un archivo -----------------------------------------------------------------------
            List<string> nombres = new List<string>();
            nombres.Add("Pedro");
            nombres.Add("Luis");
            nombres.Add("Jose");
            nombres.Add("Santiago");
            nombres.Add("Nelly");

            File.AppendAllLines(ruta4, nombres);

            // Crear contenido directo dentro de una lista ----------------------------------------------------------------------------------
            string contenido = "Pedro Luis Jose Santiago Nelly";
            File.AppendAllText(ruta4, contenido);                       // Si existe el archivo se escribira lo nuevo hasta el final

            // Muestra listado de las rutas tanto de directorios como de archivos -----------------------------------------------------------
            List<string> LISTA = new List<string>(Directory.EnumerateFileSystemEntries(ruta3).ToList());
            foreach (string item in LISTA)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("7 \n");

            // Filtrar entre directorios y archivos (terminando en x) ------------------------------------------------------------------------
            List<string> LISTA2 = new List<string>(Directory.EnumerateFileSystemEntries(ruta3, "*x").ToList());
            foreach (string item in LISTA2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("8 \n");

            // Encontrar el directorio actual (donde se ejecutara la consola) ---------------------------------------------------------------
            string rutaActual = Directory.GetCurrentDirectory();
            Console.WriteLine("Directorio Actual: " + rutaActual + "\n");

            // Encontrar en que unidad nos encontramos -------------------------------------------------------------------------------------------
            string unidad = Directory.GetDirectoryRoot(rutaActual);
            Console.WriteLine("Unidad de ejecución: " + unidad + "\n");

            // Mover archivo o directorio a un nuevo directorio padre (ctrl+x) ( la ruta final no debe existir ya que la creará ) -------------
            string rutaInicio = @"D:\Users\Documentos\GitHub\Program-Practice\9. Manejo de Directorios y Archivos\ClaseArchivo\Alumnos";
            string rutaFinal = @"D:\Users\Documentos\GitHub\Program-Practice\9. Manejo de Directorios y Archivos\ClaseArchivo\AlumnosFinal";
            // Directory.Move(rutaInicio, rutaFinal);  // .Move ( donde se encuentra, donde se pegara )

            // Copar un archivo a un nuevo directorio (ctrl+c) ---------------------------------------------------------------------------
            string rutaOrigin = @"D:\Users\Documentos\GitHub\Program-Practice\9. Manejo de Directorios y Archivos\ClaseArchivo\Movimiento.txt";
            string rutaDestino = @"D:\Users\Documentos\GitHub\Program-Practice\9. Manejo de Directorios y Archivos\ClaseArchivo\Mover\Movimiento.txt";
            // File.Copy(rutaOrigin, rutaDestino);  // RutaDestino debe tener el nombre al final del archivo que se copiara

            // Crear un archivo y llenarlo -------------------------------------------------------------------------------------------
            string rutacreate = @"D:\Users\Documentos\GitHub\Program-Practice\9. Manejo de Directorios y Archivos\ClaseArchivo\Prueba de Creacion.txt";
            using (StreamWriter sw = File.CreateText(rutacreate))  // using abre el archivo y lo cierra
            {
                sw.Write("Hola");                                 // Esta propiedad elimina el archivo del mismo nombre y crea uno nuevo con
                sw.Write("Amigos");                               // lo que se le ha pasado (reescribir)
            }

            // Eliminar Archivo
            // File.Delete(rutacreate);

            // Encriptar un archivo para que solo el usuario actual lo pueda abrir -------------------------------------------------------
            string fileencrypt = @"D:\Users\Documentos\GitHub\Program-Practice\9. Manejo de Directorios y Archivos\ClaseArchivo\Encriptado.txt";
            // File.Encrypt(fileencrypt);

            // Mover archivo a un nuevo directorio (ctrl+x) ----------------------------------------------------------------------------
            string moving = @"D:\Users\Documentos\GitHub\Program-Practice\9. Manejo de Directorios y Archivos\ClaseArchivo\Move.txt";
            string pasting = @"D:\Users\Documentos\GitHub\Program-Practice\9. Manejo de Directorios y Archivos\ClaseArchivo\Moviendo\Move.txt";
            // File.Move(moving, pasting);

            // Sacar los Bytes de un archivo ( imagen ) --------------------------------------------------------------------------------
            string rutaimg = @"D:\Users\Documentos\GitHub\Program-Practice\9. Manejo de Directorios y Archivos\ClaseArchivo\Imagenes\gil.png";
            //byte[] archivo = File.ReadAllBytes(rutaimg);

            // Mover una imagen o archivo a otro directorio ----------------------------------------------------------------------------
            string rutaimgFinal = @"D:\Users\Documentos\GitHub\Program-Practice\9. Manejo de Directorios y Archivos\ClaseArchivo\Imagen\gil.png";
            // File.WriteAllBytes(rutaimgFinal, archivo);

            // Llenar un archivo con una cadena ---------------------------------------------------------------------------------
            string roote = @"D:\Users\Documentos\GitHub\Program-Practice\9. Manejo de Directorios y Archivos\ClaseArchivo\Examen.txt";
            string contein = "Escribiendo una cadena en un archivo de texto";
            // File.WriteAllText(roote, contein);

            // Mover el contenido de un archivo de texto a otro --------------------------------------------------------------
            string rooteOrigen = @"D:\Users\Documentos\GitHub\Program-Practice\9. Manejo de Directorios y Archivos\ClaseArchivo\Examen.txt";
            string rooteDestino = @"D:\Users\Documentos\GitHub\Program-Practice\9. Manejo de Directorios y Archivos\ClaseArchivo\ExamenCopy.txt";
            string contenido1 = File.ReadAllText(rooteOrigen);
            // File.WriteAllText(rooteDestino, contenido1);

            // Leer e imprimir todas las lineas de un archivo de texto ------------------------------------------------------------
            string ruteDestino = @"D:\Users\Documentos\GitHub\Program-Practice\9. Manejo de Directorios y Archivos\ClaseArchivo\ExamenCopy.txt";
            string[] lineas = File.ReadAllLines(ruteDestino);
            foreach(string line in lineas)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine("9 \n");

            // Obtener informacion de un archivo (FileInfo) --------------------------------------------------------------------
            string ruteDestinox = @"D:\Users\Documentos\GitHub\Program-Practice\9. Manejo de Directorios y Archivos\ClaseArchivo\ExamenCopy.txt";
            FileInfo f = new FileInfo(ruteDestinox);

            // Conocer si existe (FileInfo)
            Console.WriteLine("\n" + f.Exists);
            // Peso en kb que tiene el archivo
            Console.WriteLine("\n" + f.Length);
            // Conocer el directorio donde se encuentra el archivo
            Console.WriteLine("\n" + f.Directory);
            // Conocer el nombre del archivo con su extension
            Console.WriteLine("\n" + f.Name);


            Console.ReadKey();

        }
    }
}
