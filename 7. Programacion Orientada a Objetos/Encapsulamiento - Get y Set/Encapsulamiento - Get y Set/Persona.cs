using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento___Get_y_Set
{
    public class Persona
    {
        private string nombre { get; set; }
        private string apPaterno { get; set; }
        private string apMaterno { get; set; }
        private int edad { get; set; }
        private double sueldo { get; set; }

        //Modificadores get y set por cada propiedad
        //Nombre
        public string getNombre()
        {
            return nombre;
        }
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        //apPaterno
        public string getApPaterno()
        {
            return apPaterno;
        }
        public void setApPaterno(string apPaterno)
        {
            this.apPaterno = apPaterno;
        }
        //apMaterno
        public string getApMaterno()
        {
            return apMaterno;
        }
        public void setApMaterno(string apMaterno)
        {
            this.apMaterno = apMaterno;
        }
        //Edad
        public int getEdad()
        {
            return edad;
        }
        public void setEdad(int edad)
        {
            if (edad > 0)
            {
                this.edad = edad;
            }
            else
            {
                this.edad = 0;
            }
        }
        //Sueldo
        public double getSueldo()
        {
            return sueldo;
        }
        public void setSueldo(double sueldo)
        {
            if (sueldo > 0)
            {
                this.sueldo = sueldo;
            }
            else
            {
                this.sueldo= 0;
            }
        }

    }
}
