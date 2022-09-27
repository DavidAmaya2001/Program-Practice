namespace Descuento_de_Precio
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //
            decimal PrecioReal = txtPrecio.Value;
            txtReal.Text = "$ " + Math.Round(PrecioReal,2);
            //
            decimal Descuento = Math.Round(PrecioReal * 0.2m,2);
            txtDescuento.Text = "$ " + Descuento.ToString();
            //
            decimal ConDescuento = Math.Round(PrecioReal - Descuento,2);
            txtPrecioDesc.Text = "$ " + ConDescuento.ToString();


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPrecio.Value = 0;
            txtReal.Text = "";
            txtDescuento.Text = "";
            txtPrecioDesc.Text = "";
        }
    }
}