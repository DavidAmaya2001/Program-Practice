namespace Controladores_en_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Con esto se puede agregar dinamicamente a la lista del ComboBox por medio de una clase y listas

            List<Persona> listaPersona = new List<Persona>();
            listaPersona.Add(new Persona { id = 1, nombre = "Luis" });
            listaPersona.Add(new Persona { id = 2, nombre = "Pedro" });
            listaPersona.Add(new Persona { id = 3, nombre = "Jorge" });
            cmbPersonas.DataSource = listaPersona;
            cmbPersonas.DisplayMember = "nombre";
            cmbPersonas.ValueMember = "id";
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string NombrePersona = cmbPersonas.Text;
            lblMostrar.Text = NombrePersona;
        }

        private void btnValue_Click(object sender, EventArgs e)
        {
            string idPersona = cmbPersonas.SelectedValue.ToString();
            lblMostrarValue.Text = idPersona; 
        }

        private void btnValores_Click(object sender, EventArgs e)
        {
            Persona oPersona = (Persona)cmbPersonas.SelectedItem;
            lblValores.Text = ("Id: " + oPersona.id + " Nombre: " + oPersona.nombre);
        }
    }
}