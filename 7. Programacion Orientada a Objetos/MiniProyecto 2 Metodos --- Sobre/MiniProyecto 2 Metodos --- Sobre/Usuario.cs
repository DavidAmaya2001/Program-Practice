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
            if (moneda > 0)
            {
                set2moneda(moneda);
            }
            else
            {
                Console.WriteLine("Cantidad Invalida del Usuario -- Ingrese la cantidad a intercambiar nuevamente");
            }
        }
    }
}
