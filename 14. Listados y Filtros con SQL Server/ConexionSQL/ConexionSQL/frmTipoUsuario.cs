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
    public partial class frmTipoUsuario : Form
    {
        public frmTipoUsuario()
        {
            InitializeComponent();
        }
        private void Listar()
        {
            BDPasajeEntities db = new BDPasajeEntities();
            var consulta = (from tipousuario in db.TipoUsuario
                            where tipousuario.BHABILITADO == 1
                            select new
                            {
                                tipousuario.IIDTIPOUSUARIO,
                                tipousuario.NOMBRE,
                                tipousuario.DESCRIPCION,
                            }).ToList();
            dgvTipoUsuario.DataSource = consulta;

        }
        private void frmTipoUsuario_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void filtrarTipoUsuario(object sender, EventArgs e)
        {
            string nombre = txtTipoUsuario.Text;
            BDPasajeEntities db = new BDPasajeEntities();
            var consulta = (from tipousuario in db.TipoUsuario
                            where tipousuario.BHABILITADO == 1
                            && tipousuario.NOMBRE.Contains(nombre)
                            select new
                            {
                                tipousuario.IIDTIPOUSUARIO,
                                tipousuario.NOMBRE,
                                tipousuario.DESCRIPCION,
                            }).ToList();
            dgvTipoUsuario.DataSource = consulta;
        }
    }
}
