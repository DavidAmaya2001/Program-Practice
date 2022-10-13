using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controlador_DataGridView
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            List<Empleado> listaEmpleado = new List<Empleado>
            {
                new Empleado{nombre="Pedro", sueldo=1550.5, diasATrabajarEnElMes=20},
                new Empleado{nombre="Julio", sueldo=1400.32, diasATrabajarEnElMes=15},
                new Empleado{nombre="Beto", sueldo=1200, diasATrabajarEnElMes=10}
            };
            dgvEmpleados.DataSource = listaEmpleado;

            dgvEmpleados.Columns[0].HeaderText = "Nombre Empleado";
            dgvEmpleados.Columns[0].Width = 150;
            dgvEmpleados.Columns[1].HeaderText = "Sueldo";
            dgvEmpleados.Columns[1].Width = 100;
            dgvEmpleados.Columns[2].HeaderText = "Dias Trabajados";
            dgvEmpleados.Columns[2].Width = 150;
        }
    }
}
