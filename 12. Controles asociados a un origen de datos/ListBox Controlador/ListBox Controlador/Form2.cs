using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox_Controlador
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void lbCursos_SelectedIndexChanged(object sender, EventArgs e)
        {}

        private void Form2_Load(object sender, EventArgs e)
        {
            /*
            string[] Cursos = { "Matematicas", "Religion", "Comunicación", "Educación Fisica" };
            lbCursos.DataSource = Cursos;
            */

            List<string> Cursos = new List<string> { "Matematicas", "Religion", "Comunicación", "Educación Fisica" };
            lbCursos.DataSource = Cursos;

        }
    }
}
