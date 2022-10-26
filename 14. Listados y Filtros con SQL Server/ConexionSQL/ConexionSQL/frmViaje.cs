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
    public partial class frmViaje : Form
    {
        public frmViaje()
        {
            InitializeComponent();
        }
        private void Listar()
        {
            BDPasajeEntities db = new BDPasajeEntities();
            var consulta = (from viaje in db.Viaje
                            join lugarorigen in db.Lugar
                            on viaje.IIDLUGARORIGEN equals lugarorigen.IIDLUGAR
                            join lugardestino in db.Lugar
                            on viaje.IIDLUGARDESTINO equals lugardestino.IIDLUGAR
                            where viaje.BHABILITADO==1
                            select new
                            {
                                viaje.IIDVIAJE,
                                origen = lugarorigen.NOMBRE,
                                destino = lugardestino.NOMBRE,
                                viaje.PRECIO,
                                viaje.FECHAVIAJE,
                            }).ToList();

            dgvViajes.DataSource = consulta;
        }
        private void ListarCMB()
        {
            BDPasajeEntities db = new BDPasajeEntities();
            var listarcombo = (from lugar in db.Lugar
                               where lugar.BHABILITADO == 1
                               select new
                               {
                                   lugar.IIDLUGAR,
                                   lugar.NOMBRE,
                               }).ToList();
            cmbBuscar.DataSource = listarcombo;
            cmbBuscar.DisplayMember = "NOMBRE";
            cmbBuscar.ValueMember = "IIDLUGAR";
        }
        private void frmViaje_Load(object sender, EventArgs e)
        {
            ListarCMB();
            Listar();
        }

        private void filtrarViaje(object sender, EventArgs e)
        {
            int valor = (int)cmbBuscar.SelectedValue;
            BDPasajeEntities db = new BDPasajeEntities();
            var consulta = (from viaje in db.Viaje
                            join lugarorigen in db.Lugar
                            on viaje.IIDLUGARORIGEN equals lugarorigen.IIDLUGAR
                            join lugardestino in db.Lugar
                            on viaje.IIDLUGARDESTINO equals lugardestino.IIDLUGAR
                            where viaje.BHABILITADO == 1 && viaje.IIDLUGARDESTINO == valor
                            select new
                            {
                                viaje.IIDVIAJE,
                                origen = lugarorigen.NOMBRE,
                                destino = lugardestino.NOMBRE,
                                viaje.PRECIO,
                                viaje.FECHAVIAJE,
                            }).ToList();

            dgvViajes.DataSource = consulta;
        }
    }
}
