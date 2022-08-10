using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2POO
{
    public class Ticket
    {
        private string color;
        private double tamaño;
        private int tipo;
        private int cantidad;

        //Metodos de acceso al color
        public string getColor()
        {
            return color;
        }
        public void setColor(string color)
        {
            this.color = color;
        }
        //Metodos de acceso al tamaño
        public double getTamaño()
        {
            return tamaño;
        }
        public void setTamaño(double tamaño)
        {
            this.tamaño = tamaño;
        }
        //Metodos de acceso a tipo
        public int getTipo()
        {
            return tipo;
        }
        public void setTipo(int tipo)
        {
            if(tipo==1 || tipo==2 || tipo == 3)
            {
                this.tipo = tipo;
            }
            else
            {
                this.tipo = 1;
            }
        }
        //Metodos de acceso a cantidad
        public int getCantidad()
        {
            return cantidad;
        }
        public void setCantidad(int cantidad)
        {
            if (cantidad > 0)
            {
                this.cantidad= cantidad;
            }
            else
            {
                this.cantidad = 1;
            }
        }
        //Funcion
        public double calcularPrecio()
        {
            int tipo = this.tipo;
            switch (tipo)
            {
                case 1: return 5; 
                case 2: return 8;
                case 3: return 10;
                default: return 0;
            }
        }
        public double ToTalaPagar()
        {
            double precio = calcularPrecio();
            return precio * this.cantidad;
        }
    }
}
