using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProyecto_2_Metodos_____Sobre
{
    class Program
    {
        static void Main(string[] args)
        {
            DatosGenerales oDatosgenerales = new DatosGenerales();
            Usuario oUsuario = new Usuario();
            Empleado oEmpleado = new Empleado();

            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.WriteLine("--------------------------- Banco de Conversión de Moneda --------------------------");
            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.WriteLine("---------------------------------- Cobros por Uso ----------------------------------");
            Console.WriteLine("------ Cliente: 30% de la conversión --------- Empleado: 15% de la conversión ------");
            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.WriteLine("\n\nIngrese 'C' si es cliente o 'E' si es empleado");

            bool ver;
            string tipo = Console.ReadLine();
            Console.WriteLine("\nIngrese su nombre: ");

            if (tipo == "C" || tipo == "c")
            {
                do
                {
                    oUsuario.setnombre(Console.ReadLine());
                    string name = oUsuario.getnombre();
                    if (name != null)
                    {
                        ver = true;
                    }
                    else
                    {
                        ver = false;
                    }

                } while (ver == false);

                Console.WriteLine("\nIngrese la cantidad que desea intercambiar");
                
                do
                {
                    oUsuario.setmoneda(double.Parse(Console.ReadLine()));
                    double moneda = oUsuario.getmoneda();
                    if (moneda > 0)
                    {
                        ver = true;
                    }
                    else
                    {
                        ver = false;
                    }

                } while (ver == false);

                Console.WriteLine("--------------------------------- Registro General ---------------------------------");
            }
            else if(tipo == "E" || tipo == "e")
            {
                do
                {
                    oEmpleado.setnombre(Console.ReadLine());
                    string name = oEmpleado.getnombre();
                    if (name != null)
                    {
                        ver = true;
                    }
                    else
                    {
                        ver = false;
                    }

                } while (ver == false);

                Console.WriteLine("\nIngrese la cantidad que desea intercambiar");

                do
                {
                    oEmpleado.setmoneda(double.Parse(Console.ReadLine()));
                    double moneda = oEmpleado.getmoneda();
                    if (moneda > 0)
                    {
                        ver = true;
                    }
                    else
                    {
                        ver = false;
                    }

                } while (ver == false);

                Console.WriteLine("--------------------------------- Registro General ---------------------------------");
            }
            else
            {

            }
             





            oDatosgenerales.Mantener();
        }
    }
}
