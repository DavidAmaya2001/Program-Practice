using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProyecto_2_Metodos_____Sobre
{
    public class DatosGenerales
    {
        private string nombre { get; set; }
        private string apMaterno { get; set; }
        private string apPaterno { get; set; }
        private double moneda { get; set; }
        
        //----------------------------------------------------------------------------------------------------------------------//
        public string getnombre()
        {
            return nombre;
        }
        public virtual void setnombre(string nombre)
        {
            if (nombre != "")
            {
                set2nombre(nombre);

            }
            else
            {
                Console.WriteLine("Nombre invalido -- Ingrese su nombre nuevamente");

            } 
        }
        public void set2nombre(string nombre)
        {
            this.nombre = nombre;
        }
        //----------------------------------------------------------------------------------------------------------------------//

        public string getapPaterno()
        {
            return apPaterno;
        }
        public void setapPaterno(string apPaterno)
        {
            if (apPaterno != "")
            {
                set2apPaterno(apPaterno);

            }
            else
            {
                Console.WriteLine("Apellido Invalido -- Ingrese su apellido nuevamente");

            }
        }
        public void set2apPaterno(string apPaterno)
        {
            this.apPaterno= apPaterno;
        }

        //----------------------------------------------------------------------------------------------------------------------//

        public string getapMaterno()
        {
            return apMaterno;
        }
        public void setapMaterno(string apMaterno)
        {
            if (apMaterno != "")
            {
                set2apMaterno(apMaterno);

            }
            else
            {
                Console.WriteLine("Apellido Invalido -- Ingrese su apellido nuevamente");

            }
        }
        public void set2apMaterno(string apMaterno)
        {
            this.apMaterno = apMaterno;
        }

        //----------------------------------------------------------------------------------------------------------------------//
        public double getmoneda()
        {
            return moneda;
        }
        public virtual void setmoneda (double moneda)
        {
                if (moneda > 0)
                {
                    set2moneda(moneda);
                }
                else
                {
                    this.moneda = 0;
                    Console.WriteLine("Cantidad Invalida -- Ingrese la cantidad a intercambiar nuevamente");
                }
        }
        public void set2moneda(double moneda)
        {
            this.moneda = moneda;
        }

        public virtual double getCalculo()
        {
            double result = 0;
            return result;
        }
        public virtual double getResultBruto()
        {
            double result = 0;
            return result;
        }
        //-----------------------------------------------------------------------------------------------------------------------//

        public void imprimir()
        {
            Console.WriteLine("------------------------------------------- Registro General -------------------------------------------");
            Console.WriteLine("-------------------------                                                      -------------------------");
            Console.WriteLine("-----------------                                                                      -----------------");
            Console.WriteLine("---------                                                                                      ---------");
            Console.WriteLine("\t\t\t\tUsuario con nombre: " + getnombre() + " " + getapPaterno() + " " + getapMaterno());
            Console.WriteLine("\t\t\t\tCantidad a intercambiar: $" + getmoneda());
            Console.WriteLine("\t\t\t\tCantidad a descontar por el uso: $" + getCalculo());
            Console.WriteLine("\t\t\t\tCantidad que recibira: $" + getResultBruto());


        }

        //-----------------------------------------------------------------------------------------------------------------------//

        public void Mantener()
        {
            Console.ReadKey();
        }

    }
}
