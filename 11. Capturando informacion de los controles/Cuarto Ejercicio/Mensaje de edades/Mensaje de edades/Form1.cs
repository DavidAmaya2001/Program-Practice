namespace Mensaje_de_edades
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDeterminar_Click(object sender, EventArgs e)
        {
            decimal edad = txtEdad.Value;
            if (edad >= 18)
            {
                lbltext.Text = "Es un mayor de edad";
            }
            else if(edad<=18 && edad > 0)
            {
                lbltext.Text = "Es un menor de edad";
            }
            else if (edad <= 0)
            {
                errorDato.SetError(txtEdad, "La edad no puede ser 0 u inferior");
                return;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEdad.Value = 0;
            lbltext.Text = ">";
            errorDato.Clear();
        }
    }
}