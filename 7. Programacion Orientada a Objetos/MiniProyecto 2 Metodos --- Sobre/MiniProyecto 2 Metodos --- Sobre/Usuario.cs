using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProyecto_2_Metodos_____Sobre
{
    public class Usuario:DatosGenerales
    {
        
        public override void setnombre(string nombre)
        {
            if (nombre != "")
            {
                set2nombre(nombre);
            }
            else
            {
                Console.WriteLine("Nombre de Usuario Invalido -- Ingrese su nombre nuevamente");

            }
        }

        public override void setmoneda(double moneda)
        {
            if (moneda > 0 && moneda <= 1000)
            {
                set2moneda(moneda);
            }
            else if (moneda > 1000)
            {
                Console.WriteLine("Cantidad Invalida para un Usuario -- Ingrese la cantidad a intercambiar nuevamente dentro del rengo ($0.01 - $1000");
            }
            else
            {
                Console.WriteLine("Cantidad Invalida del Usuario -- Ingrese la cantidad a intercambiar nuevamente");
            }
        }
        public override double getCalculo()
        {
            double neto = getmoneda();
            double retencion = neto * 0.3;
            return retencion;
        }
        public override double getResultBruto()
        {
            double neto = getmoneda();
            double retencion = getCalculo();
            return neto - retencion;
        }
        
    }
}
