using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento___Get_y_Set
{
    // -------------------------------------------- Utilizando Private / Get y Set -------------------------------------------- //
    public class Empleado
    {
        private int idEmpleado { get; set; }
        private string nombre { get; set; }
        private string apPaterno { get; set; }
        private string apMaterno { get; set; }
        // El sueldo no puede ser negativo por lo que se utiliza el encapsulamiento get y set
        private double sueldo { get; set; }

        public double getSueldo()
        {
            return sueldo;                         // Luego de pasar el control se guarda en esta propiedad para ser utilizada
        }
        public void setSueldo(double sueldo)
        {
            if (sueldo > 0)
            {
                this.sueldo = sueldo;
            }
            else
            {
                this.sueldo = 0;                    // Con esto se toma el valor para pasarlo por un control antes de ser guardado en la propiedad
            }
        }
    }
}
