using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01_Herencia_POO
{
    public abstract class Empleado
    {
        public string nombre { get; set; }
        public int edad { get; set; }
        public double salario { get; set; }

        public readonly int PLUS = 400;    // ReadOnly indica que solo es una constancia (no se puede modificar desde otra parte este valor)

        public abstract double plus();
    }
}
