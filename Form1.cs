namespace Fase3CarlosSoriano
{
    public partial class Form1 : Form
    {
        private const string clave = "unad";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void itemMenuAcercaDe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nombre Estudiante: Carlos Andres Soriano Gonzalez\n" +
                            "Curso Estructuras de Datos\n" +
                            "Grupo: 137");
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (this.txtClave != null)
            {
                if (!txtClave.Text.Equals(clave))
                {
                    MessageBox.Show("Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtClave.Clear();
                    this.txtClave.Focus();
                }
                else
                {
                    IngresoDatos ingreso = new IngresoDatos();
                    ingreso.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("El campo no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtClave.Clear();
                this.txtClave.Focus();
            }
        }

        private void itemMenuIniciarSesion_Click(object sender, EventArgs e)
        {
            this.txtClave.Enabled = true;
            this.btnIngresar.Enabled = true;
        }
    }
}
