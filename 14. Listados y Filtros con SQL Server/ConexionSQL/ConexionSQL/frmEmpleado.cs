using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConexionSQL.Models;

namespace ConexionSQL
{
    public partial class frmEmpleado : Form
    {
        public frmEmpleado()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            BDPasajeEntities db = new BDPasajeEntities();

            var consulta = (from empleado in db.Empleado
                            where empleado.BHABILITADO == 1
                            select new
                            {
                                empleado.IIDEMPLEADO,
                                NOMBRECOMPLETO = empleado.NOMBRE + " " + empleado.APPATERNO + " " + empleado.APMATERNO,
                                empleado.FECHACONTRATO,
                                empleado.SUELDO,
                            }).ToList();

            dgvEmpleado.DataSource = consulta;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNomCompleto.Text = "";
            Listar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nomCompleto = txtNomCompleto.Text;
            BDPasajeEntities db = new BDPasajeEntities();

            var consulta = (from empleado in db.Empleado
                            where empleado.BHABILITADO == 1
                            && (empleado.NOMBRE + " " + empleado.APPATERNO + " " + empleado.APMATERNO).Contains(nomCompleto)
                            select new
                            {
                                empleado.IIDEMPLEADO,
                                NOMBRECOMPLETO = empleado.NOMBRE + " " + empleado.APPATERNO + " " + empleado.APMATERNO,
                                empleado.FECHACONTRATO,
                                empleado.SUELDO,
                            }).ToList();

            dgvEmpleado.DataSource = consulta;
        }
    }
}
