using System.ComponentModel;

namespace Calculador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            decimal numero1 = txtnum1.Value;
            decimal numero2 = txtnum2.Value;
            decimal numero3 = txtnum3.Value;

            if (numero1 == 0)
            {
                MessageBox.Show("No se puede calcular debido a que el numero 1 es 0", "Dato Erroneo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (numero2 == 0)
            {
                MessageBox.Show("No se puede calcular debido a que el numero 2 es 0", "Dato Erroneo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (numero3 == 0)
            {
                MessageBox.Show("No se puede calcular debido a que el numero 3 es 0", "Dato Erroneo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            decimal suma = numero1 + numero2 + numero3;
            MessageBox.Show("Resultado de la sumatoria: " + suma.ToString(), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnclean_Click(object sender, EventArgs e)
        {
            txtnum1.Value = 0;
            txtnum2.Value = 0;
            txtnum3.Value = 0;
        }
    }
}