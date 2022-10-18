using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // Para trabajar con directorios
using System.Diagnostics; // Abrir rutas 

namespace FolderBrowserDialog_Controlador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<TiposArchivos> listaArchivos = new List<TiposArchivos>
            {
                new TiposArchivos{extension=".txt", nombreArchivo="Archivos de Texto"},
                new TiposArchivos{extension=".docx", nombreArchivo="Archivos de Word"},
                new TiposArchivos{extension=".pdf", nombreArchivo="Archivos de PDF"}
            };
            cmbFiltros.DataSource=listaArchivos;
            cmbFiltros.DisplayMember = "nombreArchivo";
            cmbFiltros.ValueMember = "extension"; // Muncionara como value del cmb
        }

        private void btnRuta_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog().Equals(DialogResult.OK)) // este if es por si se da en cancelar la ruta no sea tomada
            {
                txtruta.Text = fbd.SelectedPath;
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (txtruta.Text.Equals(""))
            {
                errorDatos.SetError(txtruta, "Tiene que ingresar una ruta");
                return;
            }
            else 
            {
                errorDatos.SetError(txtruta, "");
            }
                string rutaDirectorio = txtruta.Text;
                string extension = cmbFiltros.SelectedValue.ToString(); // se usa el value guardado antes en el cmb
                lbArchivos.DataSource = Directory.GetFiles(rutaDirectorio, "*" + extension);
                // filtrara y tomara los archivos segun la extension

            
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lbArchivos.DataSource = null; //Limpiando ListBox
        }

        private void mostrarArchivo(object sender, EventArgs e)
        {
            if (lbArchivos.Items.Count > 0)
            {
                string Item = lbArchivos.SelectedItem.ToString();
                Process.Start(Item);
            }
        }
    }
}
