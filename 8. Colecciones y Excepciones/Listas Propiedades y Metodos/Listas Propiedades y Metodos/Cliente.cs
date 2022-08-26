using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_Propiedades_y_Metodos
{
    public class Cliente
    {
        public Cliente(string nombre, string apPaterno, string apMaterno, int edad, string direccion)
        {
            this.nombre = nombre;
            this.apPaterno = apPaterno;
            this.apMaterno = apMaterno;
            this.edad = edad;
            this.direccion = direccion;
        }

        public string nombre { get; set; }
        public string apPaterno { get; set; }
        public string apMaterno { get; set; }
        public int edad { get; set; }
        public string direccion { get; set; }
    }
}
