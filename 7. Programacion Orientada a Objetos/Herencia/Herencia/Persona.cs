using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    // Superclase (de esta van a heredar los hijos las propiedades y metodos) (se hace para que las clases eviten repetir las mismas propiedades)
    public class Persona
    {
        public string nombre { get; set; }
        public string apPaterno { get; set; }
        public string apMaterno { get; set; }
        public int edad { get; set; }

        public string nombreCompleto()
        {
            return this.nombre + " " + this.apPaterno + " " + this.apMaterno;
        }
    }
}
