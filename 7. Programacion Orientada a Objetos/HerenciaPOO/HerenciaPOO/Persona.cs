using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaPOO
{
    // Superclase (Porque de aquí se heredaran las propiedades y metodos)
    public class Persona
    {
        public string nombre { get; set; }
        public string apaterno { get; set; }
        public string amaterno { get; set; }  
        public int edad { get; set; }

        public string nombrecompleto()
        {
            return this.nombre + " " + this.apaterno + " " + this.amaterno;
        }
    }
}
