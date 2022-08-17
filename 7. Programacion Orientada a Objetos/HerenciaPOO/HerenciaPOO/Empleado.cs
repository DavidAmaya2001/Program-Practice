using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaPOO
{
    public class Empleado:Persona
    {
        public double sueldo { get; set; }
        public DateTime fechaContrato { get; set; }
    }
}
