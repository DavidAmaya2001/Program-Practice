using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DirectoriosEjercicio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivos de programa |*jpg;*jpeg;*png";
            if (ofd.ShowDialog().Equals(DialogResult.OK))
            {
                txtRuta.Text = ofd.FileName;

                byte[] buffer = File.ReadAllBytes(ofd.FileName);
                using (MemoryStream ms = new MemoryStream(buffer))
                {

                    pbImagen.Image = Image.FromStream(ms);
                }
            }
        }

        private void btnMover_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Archivo de programa | *jpg;*jpeg;*png";
            if (sfd.ShowDialog().Equals(DialogResult.OK))
            {
                string rutaDestino = sfd.FileName;
                string rutaOrigen = txtRuta.Text;
                File.Move(rutaOrigen, rutaDestino);
            }
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Archivo de programa | *jpg;*jpeg;*png";
            if (sfd.ShowDialog().Equals(DialogResult.OK))
            {
                string rutaDestino = sfd.FileName;
                string rutaOrigen = txtRuta.Text;
                File.Copy(rutaOrigen, rutaDestino);
            }
        }
    }
}
