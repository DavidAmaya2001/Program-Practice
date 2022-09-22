namespace frmCapturarDatosTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            string valor = txtvalor.Text;
            lblvalor.Text = "El valor ingresado es: " + valor;
        }

        private void btnmostrar2_Click(object sender, EventArgs e)
        {
            decimal valor2 = txtnumvalor.Value;
            //lblrespuesta.Text = valor2.ToString(); // La conversion es cuando no esta concatenado con ninguna cadena
            lblrespuesta.Text = "El valor a mostrar es: " + valor2;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            lblrespuesta.Text = ">";
            txtnumvalor.Value = 0;
        }

        private void btnmostrar3_Click(object sender, EventArgs e)
        {
            string valor3 = cmbDia.Text;
            lbleleccion.Text = "El dia es: " + valor3;
        }

        private void btnclear2_Click(object sender, EventArgs e)
        {
            lbleleccion.Text = ">";
            cmbDia.Text = "";
        }

        private void btnmostrar4_Click(object sender, EventArgs e)
        {
            DateTime fecha = dtpFecha.Value;
            lblfecha.Text = "Fecha elegida: " + fecha.ToString();
        }

        private void btnclear3_Click(object sender, EventArgs e)
        {
            dtpFecha.Value = DateTime.Today;
            lblfecha.Text = ">";
        }
    }
}