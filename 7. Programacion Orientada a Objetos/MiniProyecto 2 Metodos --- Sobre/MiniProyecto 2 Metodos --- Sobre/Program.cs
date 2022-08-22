using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MiniProyecto_2_Metodos_____Sobre
{
    class Program
    {
        static void Main(string[] args)
        {
            DatosGenerales oDatosgenerales = new DatosGenerales();
            Usuario oUsuario = new Usuario();
            Empleado oEmpleado = new Empleado();
            bool verific = true;

            do
            {
                Console.WriteLine("--------------------------------------------------------------------------------------------");
                Console.WriteLine("------------------------------- Banco de Conversión de Moneda ------------------------------");
                Console.WriteLine("--------------------------------------------------------------------------------------------");
                Console.WriteLine("-------------------------------------- Cobros por Uso --------------------------------------");
                Console.WriteLine("--------- Cliente: 30% de la conversión ----------- Empleado: 15% de la conversión ---------");
                Console.WriteLine("--------- Cliente: monto maximo ($1000) ----------- Empleado: monto maximo ($5000) ---------");
                Console.WriteLine("--------------------------------------------------------------------------------------------");
                Console.WriteLine("\n\n\tIngrese 'C' si es cliente o 'E' si es empleado");

                bool ver;
                string tipo = Console.ReadLine();
                if (tipo == "C" || tipo == "c")
                {
                    Console.WriteLine("\nIngrese su nombre: ");
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

                    Console.WriteLine("\nIngrese su apellido paterno: ");
                    do
                    {
                        oUsuario.setapPaterno(Console.ReadLine());
                        string apPaterno = oUsuario.getapPaterno();
                        if (apPaterno != null)
                        {
                            ver = true;

                        }
                        else
                        {
                            ver = false;
                        }
                    } while (ver == false);

                    Console.WriteLine("\nIngrese su apellido materno");
                    do
                    {
                        oUsuario.setapMaterno(Console.ReadLine());
                        string apMaterno = oUsuario.getapMaterno();
                        if (apMaterno != null)
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

                    Console.Clear();
                    oUsuario.imprimir();

                    Console.WriteLine("\n\n-------------------------------- Desea ingresar otro Empleado o Usuario --------------------------------");
                    Console.WriteLine("------------------------------------ escribir (si, si desea continuar) -------------------------------------");
                    string verifico = Console.ReadLine();
                    if (verifico == "si" || verifico == "SI" || verifico == "Si" || verifico == "sI")
                    {
                        verific = true;
                        Console.Clear();
                    }
                    else
                    {
                        verific = false;
                        Console.WriteLine("Presione cualquier tecla para cerrar");
                    }
                }
                else if (tipo == "E" || tipo == "e")
                {
                    Console.WriteLine("\nIngrese su nombre: ");
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

                    Console.WriteLine("\nIngrese su apellido paterno: ");
                    do
                    {
                        oEmpleado.setapPaterno(Console.ReadLine());
                        string apPaterno = oEmpleado.getapPaterno();
                        if (apPaterno != null)
                        {
                            ver = true;

                        }
                        else
                        {
                            ver = false;
                        }
                    } while (ver == false);

                    Console.WriteLine("\nIngrese su apellido materno");
                    do
                    {
                        oEmpleado.setapMaterno(Console.ReadLine());
                        string apMaterno = oEmpleado.getapMaterno();
                        if (apMaterno != null)
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

                    Console.Clear();
                    oEmpleado.imprimir();
                    Console.WriteLine("\n\n-------------------------------- Desea ingresar otro Empleado o Usuario --------------------------------");
                    Console.WriteLine("------------------------------------ escribir (si, si desea continuar) -------------------------------------");
                    string verifico = Console.ReadLine();
                    if (verifico == "si" || verifico == "SI" || verifico == "Si" || verifico == "sI")
                    {
                        verific = true;
                        Console.Clear();
                    }
                    else
                    {
                        verific = false;
                        Console.WriteLine("Presione cualquier tecla para cerrar");
                    }
                }
                else
                {
                    Console.WriteLine("\n\n---------- Tipo de usuario ingresado es incorrecto ----------");
                    Console.WriteLine("\n\n-------------------------------- Desea ingresar otro Empleado o Usuario --------------------------------");
                    Console.WriteLine("------------------------------------ escribir (si, si desea continuar) -------------------------------------");
                    string verifico = Console.ReadLine();
                    if (verifico == "si" || verifico == "SI" || verifico == "Si" || verifico == "sI")
                    {
                        verific = true;
                        Console.Clear();
                    }
                    else
                    {
                        verific = false;
                        Console.WriteLine("Presione cualquier tecla para cerrar");
                    }
                }
            }
            while (verific == true);




            oDatosgenerales.Mantener();
        }
    }
}
