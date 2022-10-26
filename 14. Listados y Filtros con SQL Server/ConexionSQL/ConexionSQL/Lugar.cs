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
    public partial class Lugar : Form
    {
        public Lugar()
        {
            InitializeComponent();
        }

        private void Lugar_Load(object sender, EventArgs e)
        {
            BDPasajeEntities db = new BDPasajeEntities();

            var consulta = (from lugar in db.Lugar
                            where lugar.BHABILITADO == 1
                            select new
                            {
                                lugar.IIDLUGAR,
                                lugar.NOMBRE,
                                lugar.DESCRIPCION,
                            }).ToList();

            dgvListadoLugar.DataSource = consulta;
        }
    }
}
