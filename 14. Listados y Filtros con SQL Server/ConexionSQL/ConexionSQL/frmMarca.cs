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

        private void Form1_Load(object sender, EventArgs e)
        {
            BDPasajeEntities oBDPasajeEntities = new BDPasajeEntities();
            var consulta = (from marca in oBDPasajeEntities.Marca
                           where marca.BHABILITADO==1
                           select new
                           {
                               marca.IIDMARCA,
                               marca.NOMBRE,
                               marca.DESCRIPCION
                           }).ToList();

            dgvTabla.DataSource = consulta;
        }
    }
}
