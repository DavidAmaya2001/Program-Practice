namespace Calculadora_con_Form
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        List<string> dataUnitario = new List<string>();
        List<decimal> dataConjunto = new List<decimal>();
        List<string> operacion = new List<string>();
        
        string Unitario = string.Empty;
        decimal resultado = 0;
       
        

        public void Habilitar()
        {
            btnPunto.Enabled = true;
            btnMultiplicacion.Enabled = true;
            btnDivision.Enabled = true;
            btnSuma.Enabled = true;
            btnResta.Enabled = true;
            btnPorcentaje.Enabled = true;
            btnResultado.Enabled = true;
            btnCuadrado.Enabled = true;
            btnCubico.Enabled = true;
            btnPotencia.Enabled = true;
            btnAbsoluto.Enabled = true;
            btnFactorial.Enabled = true;

        }
        public void Deshabilitar()
        {
            btnPunto.Enabled = false;
            btnMultiplicacion.Enabled = false;
            btnDivision.Enabled = false;
            btnSuma.Enabled = false;
            btnResta.Enabled = false;
            btnPorcentaje.Enabled = false;
            btnResultado.Enabled = false;
            btnCuadrado.Enabled = false;
            btnCubico.Enabled = false;
            btnPotencia.Enabled = false;
            btnAbsoluto.Enabled = false;
            btnFactorial.Enabled = false;
        }
        public void DesabilitarTodo()
        {
            btnUno.Enabled = false;
            btnDos.Enabled = false;
            btnTres.Enabled = false;
            btnCuatro.Enabled = false;
            btnCinco.Enabled = false;
            btnSeis.Enabled = false;
            btnSiete.Enabled = false;
            btnOcho.Enabled = false;
            btnNueve.Enabled = false;
            btnCero.Enabled = false;
            btnPunto.Enabled = false;
            btnMultiplicacion.Enabled = false;
            btnDivision.Enabled = false;
            btnSuma.Enabled = false;
            btnResta.Enabled = false;
            btnPorcentaje.Enabled = false;
            btnResultado.Enabled = false;
            btnLog.Enabled = false;
            btnLn.Enabled = false;
            btnExp.Enabled = false;
            btnSin.Enabled = false;
            btnCos.Enabled = false;
            btnTan.Enabled = false;
            btnCuadrado.Enabled = false;
            btnCubico.Enabled = false;
            btnPotencia.Enabled = false;
            btnRaiz.Enabled = false;
            btnAbsoluto.Enabled = false;
            btnFactorial.Enabled = false;

        }
        public void BtnPuntoDesabilitar()
        {
            btnPunto.Enabled = false;
            btnPi.Enabled = false;
        }



        // ---------------------------------------------------------- Botones Numericos ----------------------------------------------------------- //

        private void btnUno_Click(object sender, EventArgs e)
        {
            //Añadido a la Lista string
            dataUnitario.Add("1");

            //Impresion en la pantalla
            txtContain.Text = txtContain.Text + "1";

            //Habilitando calculadora completa
            Habilitar();
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            //Añadido a la Lista string
            dataUnitario.Add("2");

            //Impresion en la pantalla
            txtContain.Text = txtContain.Text + "2";

            //Habilitando calculadora completa
            Habilitar();
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            //Añadido a la Lista string
            dataUnitario.Add("3");

            //Impresion en la pantalla
            txtContain.Text = txtContain.Text + "3";

            //Habilitando calculadora completa
            Habilitar();
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            //Añadido a la Lista string
            dataUnitario.Add("4");

            //Impresion en la pantalla
            txtContain.Text = txtContain.Text + "4";

            //Habilitando calculadora completa
            Habilitar();
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            //Añadido a la Lista string
            dataUnitario.Add("5");

            //Impresion en la pantalla
            txtContain.Text = txtContain.Text + "5";

            //Habilitando calculadora completa
            Habilitar();
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            //Añadido a la Lista string
            dataUnitario.Add("6");

            //Impresion en la pantalla
            txtContain.Text = txtContain.Text + "6";

            //Habilitando calculadora completa
            Habilitar();
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            //Añadido a la Lista string
            dataUnitario.Add("7");

            //Impresion en la pantalla
            txtContain.Text = txtContain.Text + "7";

            //Habilitando calculadora completa
            Habilitar();
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            //Añadido a la Lista string
            dataUnitario.Add("8");

            //Impresion en la pantalla
            txtContain.Text = txtContain.Text + "8";

            //Habilitando calculadora completa
            Habilitar();
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            //Añadido a la Lista string
            dataUnitario.Add("9");

            //Impresion en la pantalla
            txtContain.Text = txtContain.Text + "9";

            //Habilitando calculadora completa
            Habilitar();
        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            //Añadiendo a la Lista string
            dataUnitario.Add("0");

            //Impresion en la pantalla
            txtContain.Text = txtContain.Text + "0";

            //Habilitando calculadora completa
            Habilitar();
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            // Añadiendo a la lista string
            dataUnitario.Add("3.1415926535897931");

            //Impresion en la patalla
            txtContain.Text = txtContain.Text + "π";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            // Añdiendo a la lista string
            dataUnitario.Add(".");

            //Impresion en la pantalla
            txtContain.Text = txtContain.Text + ".";

            // Desabilitando el uso del doble punto
            BtnPuntoDesabilitar();
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            // Eliminando todo
            txtContain.Text = "";
            LimpiezaDeDatos();
            LimpiezaDeConjunto();

        }

        // ----------------------------------------------------- Funciones Operacionales ------------------------------------------------------------ //

        public void AlmacenDeDatos()
        {
            // Almacenando dato en Lista de conjunto
            
            foreach (var item in dataUnitario)
            {
                Unitario = Unitario + item;
            }
            //MessageBox.Show(Unitario);
            dataConjunto.Add(decimal.Parse(Unitario)); 
        }

        public void LimpiezaDeDatos()
        {
            // Limpieza de mediadores
            dataUnitario.Clear();
            Unitario = string.Empty;
        }
        public void LimpiezaDeConjunto()
        {
            //Limpieza del conjunto solo usado en btnResultado
            resultado = 0;
            dataConjunto.Clear();
            operacion.Clear();
        }
        


        private void btnSuma_Click(object sender, EventArgs e)
        {

            AlmacenDeDatos();
            operacion.Add("+");
            LimpiezaDeDatos();
            Deshabilitar();
            // Impresion en la pantalla
            txtContain.Text = txtContain.Text + "+";
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            // Calculo de operaciones

            // Inserción del ultimo numero ingresado
            AlmacenDeDatos();
            LimpiezaDeDatos();     


            //Primera operación          
            for(int i=0; i < 1; i++)
            {
                switch (operacion[i])
                {
                    case "+":
                        resultado = dataConjunto[0] + dataConjunto[1];
                        break;
                    default:
                        MessageBox.Show("Primera quebrada");
                        break;
                }
            }
            //Siguientes operaciones
            for(int i = 1; i < operacion.Count; i++)
            {
                switch (operacion[i])
                {
                    case "+":
                        resultado = resultado + dataConjunto[i + 1];
                        break;
                    default:
                        MessageBox.Show("Segunda quebrada");
                        break;
                }
            }
            // Desabilitando todos los botones
            DesabilitarTodo();

            //Impresion en Pantalla
            txtContain.Text = "= " + resultado.ToString();
            LimpiezaDeConjunto();
            


            
        }
    }
}