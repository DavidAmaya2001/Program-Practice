using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01_Herencia_POO
{
    public class Repartidor:Empleado
    {
        public string zona { get; set; }

        public override double plus()
        {
            if(edad<35 && zona.Equals("zona 3"))
            {
                salario = salario + PLUS;
            }
            return salario;
        }
    }
}
