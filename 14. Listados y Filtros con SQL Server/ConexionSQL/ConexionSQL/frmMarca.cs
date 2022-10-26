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
    public partial class frmMarca : Form
    {
        public frmMarca()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            BDPasajeEntities oBDPasajeEntities = new BDPasajeEntities();
            var consulta = (from marca in oBDPasajeEntities.Marca
                            where marca.BHABILITADO == 1
                            select new
                            {
                                marca.IIDMARCA,
                                marca.NOMBRE,
                                marca.DESCRIPCION
                            }).ToList();

            dgvTabla.DataSource = consulta;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Capturando valor del TextBox
            string nombreMarca = txtNombre.Text;

            // Llamando a la base de datos
            BDPasajeEntities oBDPasajeEntities = new BDPasajeEntities();

            // Haciendo la consulta
            var consulta = (from marca in oBDPasajeEntities.Marca
                            where marca.BHABILITADO == 1
                            // Filtro por el nombre de textbox
                            && marca.NOMBRE.Contains(nombreMarca)
                            select new
                            {
                                marca.IIDMARCA,
                                marca.NOMBRE,
                                marca.DESCRIPCION
                            }).ToList();

            dgvTabla.DataSource = consulta;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            Limpiar();
        }
    }
}
