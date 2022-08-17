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
        
        //-----------------------------------------------------------------------------------------------------------------------//
        public void Mantener()
        {
            Console.ReadKey();
        }

    }
}
