using System.Drawing.Printing;

namespace Pruebas
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = CajaTextoUsuario.Text;
            string password = CajaTextoContrase�a.Text;


            if (nombre == "Juan" || password == "123")
            {
                MessageBox.Show("Bienvenido " + nombre);
                PaginaInicio paginaInicio = new PaginaInicio();
                paginaInicio.Show();
                this.Hide();
            }
            else if (nombre == null || password == null)
            {
                MessageBox.Show("Por favor, ingrese un nombre de usuario y una contrase�a");
            }
            else
            {
                MessageBox.Show("Usuario o contrase�a incorrectos");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

