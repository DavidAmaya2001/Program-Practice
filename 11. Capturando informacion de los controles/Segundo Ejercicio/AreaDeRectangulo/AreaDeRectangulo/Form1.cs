namespace AreaDeRectangulo
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void picture2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculo_Click(object sender, EventArgs e)
        {
            decimal numero1 = txtNum1.Value;
            decimal numero2 = txtNum2.Value;
            decimal resultado = numero1 * numero2;
            

            if (numero1 == numero2)
            {
                lblResult.Text = "> El area del cuadrado es de: " + resultado.ToString();
                lblBase.Text = numero1.ToString();
                lblaltura.Text = numero2.ToString();
                return;
            }
            else if (numero1 > numero2)
            {
                picture2.Visible = true;
                picture1.Visible = false;
                lblBase.Text = numero1.ToString();
                lblaltura.Text = numero2.ToString();
                lblResult.Text = "> El area del rectangulo es de: " + resultado.ToString();

            }
            else if (numero1 < numero2)
            {
                picture3.Visible = true;
                picture1.Visible = false;
                lblBase.Text = numero1.ToString();
                lblaltura.Text = numero2.ToString();
                lblResult.Text = "> El area del rectangulo es de: " + resultado.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNum1.Value = 0;
            txtNum2.Value = 0;
            lblResult.Text = ">";
            picture1.Visible = true;
            picture2.Visible = false;
            picture3.Visible = false;
            lblBase.Text = "Base";
            lblaltura.Text = "Altura";
        }
    }
}