namespace Calculadora_con_Form
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        List<string> dataUnitario = new List<string>();
        List<double> dataConjunto = new List<double>();
        List<string> operacion = new List<string>();
        string Unitario = string.Empty;
        double resultado = 0;

        List<string> operacionpot = new List<string>();
        List<string> dataUnitPot = new List<string>();
        List<double> dataConjPot = new List<double>();
        string UnitarioPot = string.Empty;
        double resultadopot = 0;

        string botonEspecial = "Defect";
        string validacion = "";
        string command = "";



        // ---------------------------------------------------------- Botones Numericos ----------------------------------------------------------- //

        private void btnUno_Click(object sender, EventArgs e)
        {
            //Añadido a la Lista string
            dataUnitario.Add("1");

            //Impresion en la pantalla
            txtContain.Text = txtContain.Text + "1";

            //Habilitando calculadora completa

        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            //Añadido a la Lista string
            dataUnitario.Add("2");

            //Impresion en la pantalla
            txtContain.Text = txtContain.Text + "2";

            //Habilitando calculadora completa

        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            //Añadido a la Lista string
            dataUnitario.Add("3");

            //Impresion en la pantalla
            txtContain.Text = txtContain.Text + "3";

            //Habilitando calculadora completa

        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            //Añadido a la Lista string
            dataUnitario.Add("4");

            //Impresion en la pantalla
            txtContain.Text = txtContain.Text + "4";

            //Habilitando calculadora completa

        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            //Añadido a la Lista string
            dataUnitario.Add("5");

            //Impresion en la pantalla
            txtContain.Text = txtContain.Text + "5";

            //Habilitando calculadora completa

        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            //Añadido a la Lista string
            dataUnitario.Add("6");

            //Impresion en la pantalla
            txtContain.Text = txtContain.Text + "6";

            //Habilitando calculadora completa

        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            //Añadido a la Lista string
            dataUnitario.Add("7");

            //Impresion en la pantalla
            txtContain.Text = txtContain.Text + "7";

            //Habilitando calculadora completa

        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            //Añadido a la Lista string
            dataUnitario.Add("8");

            //Impresion en la pantalla
            txtContain.Text = txtContain.Text + "8";

            //Habilitando calculadora completa

        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            //Impresion en la pantalla y guardado de datos
            if (command == "")
            {
                dataUnitario.Add("9");
                txtContain.Text = txtContain.Text + "9";
            }
            else if(command == "Expo") // con expo se puede agregar operaciones basicas
            { 
                txtContain.Text = txtContain.Text + "⁹";
            }
            else if(command == "Pot") // Con pot no se podra añadir operaciones
            {
                dataUnitPot.Add("9");
                txtContain.Text = txtContain.Text + "⁹";
            }

            //Habilitando calculadora completa
            btnSuma.Enabled = true;
            btnResultado.Enabled = true;
        }


        private void btnCero_Click(object sender, EventArgs e)
        {
            //Añadiendo a la Lista string
            dataUnitario.Add("0");

            //Impresion en la pantalla
            txtContain.Text = txtContain.Text + "0";

            //Habilitando calculadora completa

        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            // Añadiendo a la lista string
            dataUnitario.Add("3.1415926535897931");

            //Impresion en la patalla
            txtContain.Text = txtContain.Text + "π";


            // Habilitando calculadora completa

        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            // Añdiendo a la lista string
            dataUnitario.Add(".");

            //Impresion en la pantalla
            txtContain.Text = txtContain.Text + ".";

            // Desabilitando el uso del doble punto

        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            // Eliminando todo
            txtContain.Text = "";
            LimpiezaDeDatos();
            LimpiezaDeConjunto();
        }

        // ---------------------------------------------- Funciones Operacionales ----------------------------------------------------- //

        public void AlmacenDeDatos()
        {
            // Almacenando dato en Lista de conjunto

            foreach (var item in dataUnitario)
            {
                Unitario = Unitario + item;
            }
            //MessageBox.Show(Unitario);
            dataConjunto.Add(double.Parse(Unitario));
        }
        public void AlmacenDeDatosPot()
        {
            // Almacenando dato en Lista de conjunto

            foreach (var item in dataUnitPot)
            {
                UnitarioPot = UnitarioPot + item;
            }
            //MessageBox.Show(UnitarioPot);
            dataConjPot.Add(double.Parse(UnitarioPot));
        }
        public void LimpiezaDeDatos()
        {
            // Limpieza de mediadores
            dataUnitario.Clear();
            Unitario = string.Empty;
        }
        public void LimpiezaDeDatosPot()
        {
            // Limpieza de mediadores
            dataUnitPot.Clear();
            UnitarioPot = string.Empty;
        }
        public void LimpiezaDeConjunto()
        {
            //Limpieza del conjunto solo usado en btnResultado
            resultado = 0;
            dataConjunto.Clear();
            operacion.Clear();
        }
        public void LimpiezaDeConjuntoPot()
        {
            //Limpieza del conjunto solo usado en btnResultado
            resultadopot = 0;
            dataConjPot.Clear();
            operacionpot.Clear();
        }
        // --------------------------------------------------------------------------------------------------------------------------- //
        // --------------------------------------------------------------------------------------------------------------------------- //
        // --------------------------------------------------------------------------------------------------------------------------- //
        public void CalculoResultado()
        {
            //Primera operación          
            for (int i = 0; i < 1; i++)
            {
                if (operacion.Count > 0)
                {
                    switch (operacion[i])
                    {
                        case "+":
                            resultado = dataConjunto[0] + dataConjunto[1];
                            break;
                        case "-":
                            resultado = dataConjunto[0] - dataConjunto[1];
                            break;
                        case "*":
                            resultado = dataConjunto[0] * dataConjunto[1];
                            break;
                        case "/":
                            try
                            {
                                resultado = dataConjunto[0] / dataConjunto[1];
                            }
                            catch (DivideByZeroException)
                            {
                                MessageBox.Show("Se ha producido un error al tratar de dividir entre 0", "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                validacion = "error";
                            }
                            break;
                        default:
                            MessageBox.Show("Error de ingreso de simbolo en ciclo 1");
                            break;
                    }
                }
                else
                {
                    resultado = dataConjunto[0];
                }
            }
            //Siguientes operaciones
            for (int i = 1; i < operacion.Count; i++)
            {
                switch (operacion[i])
                {
                    case "+":
                        resultado = resultado + dataConjunto[i + 1];
                        break;
                    case "-":
                        resultado = resultado - dataConjunto[i + 1];
                        break;
                    case "*":
                        resultado = resultado * dataConjunto[i + 1];
                        break;
                    case "/":
                        try
                        {
                            resultado = resultado / dataConjunto[i + 1];
                        }
                        catch (DivideByZeroException)
                        {
                            MessageBox.Show("Se ha producido un error al tratar de dividir entre 0", "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            validacion = "error";
                        }
                        break;
                    default:
                        MessageBox.Show("Error de ingreso de simbolo en ciclo 2");
                        break;
                }
            }
        }
        public void CalculoResultadoPot()
        {
            //Primera operación          
            for (int i = 0; i < 1; i++)
            {
                if (operacionpot.Count > 0)
                {
                    switch (operacionpot[i])
                    {
                        case "+":
                            resultadopot = dataConjPot[0] + dataConjPot[1];
                            break;
                        case "-":
                            resultadopot = dataConjPot[0] - dataConjPot[1];
                            break;
                        case "*":
                            resultadopot = dataConjPot[0] * dataConjPot[1];
                            break;
                        case "/":
                            try
                            {
                                resultadopot = dataConjPot[0] / dataConjPot[1];
                            }
                            catch (DivideByZeroException)
                            {
                                MessageBox.Show("Se ha producido un error al tratar de dividir entre 0", "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                validacion = "error";
                            }
                            break;
                        default:
                            MessageBox.Show("Error de ingreso de simbolo en ciclo 1");
                            break;
                    }
                }
                else
                {
                    resultadopot = dataConjPot[0];
                }
            }
            //Siguientes operaciones
            for (int i = 1; i < operacionpot.Count; i++)
            {
                switch (operacionpot[i])
                {
                    case "+":
                        resultadopot = resultadopot + dataConjPot[i + 1];
                        break;
                    case "-":
                        resultadopot = resultadopot - dataConjPot[i + 1];
                        break;
                    case "*":
                        resultadopot = resultadopot * dataConjPot[i + 1];
                        break;
                    case "/":
                        try
                        {
                            resultadopot = resultadopot / dataConjPot[i + 1];
                        }
                        catch (DivideByZeroException)
                        {
                            MessageBox.Show("Se ha producido un error al tratar de dividir entre 0", "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            validacion = "error";
                        }
                        break;
                    default:
                        MessageBox.Show("Error de ingreso de simbolo en ciclo 2");
                        break;
                }
            }
        }
        // --------------------------------------------------------------------------------------------------------------------------- //
        // --------------------------------------------------------------------------------------------------------------------------- //
        // --------------------------------------------------------------------------------------------------------------------------- //

        public void ImpresionResultado(double result)
        {
            if (validacion == "")
            {
                txtContain.Text = "= " + Math.Round(result, 6);
            }
            else if (validacion == "error")
            {
                txtContain.Text = "Math ERROR";
            }
            else if (validacion == "errorS")
            {
                txtContain.Text = "Syntax ERROR";
            }
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            // Inserción del ultimo numero ingresado
            AlmacenDeDatos();
            LimpiezaDeDatos();

            // Calculos general de resultado
            CalculoResultado();

            // Calculos signos base
            if (botonEspecial == "Defect")
            {
                ImpresionResultado(resultado);
            }
            // Calculo del logaritmo base 10
            else if (botonEspecial == "LogBase10")
            {
                double resultadoLog;
                if (resultado > 0)
                {
                    resultadoLog = Math.Log10(resultado);
                    ImpresionResultado(resultadoLog);
                }
                else
                {
                    MessageBox.Show("Se ha excedido el limite del calculo del Logaritmo base 10", "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtContain.Text = "Math ERROR";
                }
            }
            // Calculo del logaritmo natural
            else if (botonEspecial == "LogNatural")
            {
                double resultadoLn;
                if (resultado > 0)
                {
                    resultadoLn = Math.Log(resultado);
                    ImpresionResultado(resultadoLn);
                }
                else
                {
                    MessageBox.Show("Se ha excedido el limite del calculo del Logaritmo natural", "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtContain.Text = "Math ERROR";
                }
            }
            // Calculo del exponencial
            else if (botonEspecial == "Expo")
            {
                double resultadoexp;
                if (resultado <= 230.2585)
                {
                    resultadoexp = Math.Exp(resultado);
                    ImpresionResultado(resultadoexp);
                }
                else
                {
                    MessageBox.Show("Se ha excedido el limite a la que se puede elevar el exponencial", "Error del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtContain.Text = "Math ERROR";
                }
            }
            // Calculo del Seno
            else if (botonEspecial == "Seno")
            {
                double resultadosin;
                resultadosin = Math.Sin(resultado);
                ImpresionResultado(resultadosin);
            }
            // Calculo del Coseno
            else if (botonEspecial == "Coseno")
            {
                double resultadocos;
                resultadocos = Math.Cos(resultado);
                ImpresionResultado(resultadocos);
            }
            // Calculo de la Tangente
            else if (botonEspecial == "Tangente")
            {
                double resultadotan;
                resultadotan = Math.Tan(resultado);
                ImpresionResultado(resultadotan);
            }
            // Calculo del exponente cuadrado en su boton
            else if (botonEspecial == "Cuadrado")
            {
                double resultadocuad;
                resultadocuad = Math.Pow(resultado, 2);
                ImpresionResultado(resultadocuad);
            }
            // Calculo del exponente cubico
            else if (botonEspecial == "Cubo")
            {
                double resultadocubo;
                resultadocubo = Math.Pow(resultado, 3);
                ImpresionResultado(resultadocubo);
            }
            else if (botonEspecial == "Potencia")
            {
                AlmacenDeDatosPot();
                LimpiezaDeDatosPot();
                CalculoResultadoPot();

                double resultpotencia;
                resultpotencia = Math.Pow(resultado, resultadopot);
                ImpresionResultado(resultpotencia);
            }


            // Desabilitando todos los botones

            LimpiezaDeConjunto();
            LimpiezaDeConjuntoPot();
            

        }

        // ---------------------------------------------------- Botones Generales ---------------------------------------------------- //
        private void btnSuma_Click(object sender, EventArgs e)
        {
            // Impresion en la pantalla y calculo
            if (command == "")
            {
                AlmacenDeDatos();
                operacion.Add("+");
                LimpiezaDeDatos();
                txtContain.Text = txtContain.Text + "+";
            }
            else if (command == "Expo")
            {
                AlmacenDeDatos();
                operacion.Add("+");
                LimpiezaDeDatos();
                txtContain.Text = txtContain.Text + "⁺";
            }
            else if (command == "Pot")
            {
                AlmacenDeDatosPot();
                operacionpot.Add("+");
                LimpiezaDeDatosPot();
                txtContain.Text = txtContain.Text + "⁺";
            }
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            AlmacenDeDatos();
            operacion.Add("-");
            LimpiezaDeDatos();
            

            // Impresion en la pantalla
            txtContain.Text = txtContain.Text + "-";
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            AlmacenDeDatos();
            operacion.Add("*");
            LimpiezaDeDatos();
            

            // Impresion en la pantalla
            txtContain.Text = txtContain.Text + "×";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            AlmacenDeDatos();
            operacion.Add("/");
            LimpiezaDeDatos();
            

            // Impresion en pantalla
            txtContain.Text = txtContain.Text + "÷";
        }

        // ---------------------------------------------------- Botones Especiales ---------------------------------------------------- //

        private void btnPorcentaje_Click(object sender, EventArgs e)
        {
            AlmacenDeDatos();
            operacion.Add("%");                  // Reesctructurar
            LimpiezaDeDatos();
            

            // Impresion en pantalla
            txtContain.Text = txtContain.Text + "%";
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            botonEspecial = "LogBase10";
            txtContain.Text = "Log(";
        }

        private void btnLn_Click(object sender, EventArgs e)
        {
            botonEspecial = "LogNatural";
            txtContain.Text = "Ln(";
        }

        private void btnExp_Click(object sender, EventArgs e)
        {
            botonEspecial = "Expo";
            command = "Expo";
            txtContain.Text = "e^⁽";
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            botonEspecial = "Seno";
            txtContain.Text = "Sin(";
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            botonEspecial = "Coseno";
            txtContain.Text = "Cos(";
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            botonEspecial = "Tangente";
            txtContain.Text = "Tan(";
        }

        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            botonEspecial = "Cuadrado";
            txtContain.Text = txtContain.Text + ")^²";
        }

        private void btnCubico_Click(object sender, EventArgs e)
        {
            botonEspecial = "Cubo";
            txtContain.Text = txtContain.Text + ")^³";
        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            
            botonEspecial = "Potencia";
            txtContain.Text = txtContain.Text + ")^";
            command = "Pot";
        }
    }
}