using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fase3CarlosSoriano
{
    public partial class IngresoDatos : Form
    {
        private int ReporteDatosPila;
        private int ReporteDatosCola;
        private int ReporteDatosLista;

        Stack<EstructuraDatosUsuario> PilaUsuarios = new Stack<EstructuraDatosUsuario>();
        Queue<EstructuraDatosUsuario> ColaUsuarios = new Queue<EstructuraDatosUsuario>();
        List<EstructuraDatosUsuario> ListaUsuarios = new List<EstructuraDatosUsuario>();
        public IngresoDatos()
        {
            InitializeComponent();
            this.ReporteDatosPila = 0;
            this.ReporteDatosCola = 0;
            this.ReporteDatosLista = 0;
            this.btnReportePila.Enabled = false;
            this.btnReporteCola.Enabled = false;
            this.btnReporteLista.Enabled = false;
            this.btnEliminarPila.Enabled = false;
            this.btnEliminarCola.Enabled = false;
            this.btnEliminarLista.Enabled = false;
            // Conectar eventos
            this.cmbEstrato.SelectedIndexChanged += new EventHandler(this.ActualizarCopago);
            this.rbtnExamenLaboratorio.CheckedChanged += new EventHandler(this.ActualizarCopago);
            this.rbtnMedicinaGeneral.CheckedChanged += new EventHandler(this.ActualizarCopago);
            if (cmbEstrato.SelectedIndex != -1 && ( rbtnExamenLaboratorio.Checked || rbtnMedicinaGeneral.Checked))
            {
                this.txtValorCopago.Text = CalcularCopago().ToString();
            }
        }
        private void ActualizarCopago(object sender, EventArgs e)
        {
            if (cmbEstrato.SelectedIndex != -1 && (rbtnExamenLaboratorio.Checked || rbtnMedicinaGeneral.Checked))
            {
                this.txtValorCopago.Text = CalcularCopago().ToString();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        public void LimpiarCampos()
        {
            this.txtNumeroIdentificacion.Clear();
            this.txtNombre.Clear();
            this.txtEdad.Clear();
            this.txtValorCopago.Clear();
            this.rbtnExamenLaboratorio.Checked = false;
            this.rbtnMedicinaGeneral.Checked = false;
            this.cmbEstrato.SelectedIndex = -1;
            this.cmbTipoIdentificacion.SelectedIndex = -1;
            this.cmbTipoEstructuraDatos.SelectedIndex = -1;
            this.txtReporteDatos.Text = "";
        }

        public bool validarFormulario()
        {
            //Validar que el combobox no esté vacio
            if (this.cmbTipoIdentificacion.SelectedIndex == -1)
            {
                MessageBox.Show("El campo Tipo de Identificación es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.cmbTipoIdentificacion.Focus();
                return false;
            }

            //Validar que todos los campos marcados con (*) estén diligenciados
            if (this.txtNumeroIdentificacion.Text == "")
            {
                MessageBox.Show("El campo Número de Identificación es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtNumeroIdentificacion.Focus();
                return false;
            }
            if (this.txtNombre.Text == "")
            {
                MessageBox.Show("El campo Nombre Completo es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtNombre.Focus();
                return false;
            }
            if (this.txtEdad.Text == "")
            {
                MessageBox.Show("El campo Edad es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtEdad.Focus();
                return false;
            }
            if (this.cmbEstrato.SelectedIndex == -1)
            {
                MessageBox.Show("El campo Estrato es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.cmbEstrato.Focus();
                return false;
            }
            if (this.rbtnExamenLaboratorio.Checked == false && this.rbtnMedicinaGeneral.Checked == false)
            {
                MessageBox.Show("El campo Tipo de examen es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (this.cmbTipoEstructuraDatos.SelectedIndex == -1)
            {
                MessageBox.Show("El campo Tipo Estructura es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.cmbTipoEstructuraDatos.Focus();
                return false;
            }

            return true;
        }
        public int CalcularCopago()
        {
            int copago = 0;

            if (this.rbtnMedicinaGeneral.Checked)
            {
                switch (this.cmbEstrato.SelectedIndex)
                {
                    case 0: copago = 0; break;
                    case 1: copago = 0; break;
                    case 2: copago = 10000; break;
                    case 3: copago = 15000; break;
                    case 4: copago = 20000; break;
                    case 5: copago = 30000; break;
                }
                return copago;
            }

            if (this.rbtnExamenLaboratorio.Checked)
            {
                switch (this.cmbEstrato.SelectedIndex)
                {
                    case 0: copago = 0; break;
                    case 1: copago = 0; break;
                    case 2: copago = 0; break;
                    case 3: copago = 5000; break;
                    case 4: copago = 10000; break;
                    case 5: copago = 20000; break;
                }
                return copago;
            }
            return copago;


        }
        private void btnRegisrar_Click(object sender, EventArgs e)
        {
            if (!validarFormulario())
            {
                return;
            }
            EstructuraDatosUsuario usuario = new EstructuraDatosUsuario();
            usuario.TipoDocumento = this.cmbTipoIdentificacion.SelectedItem.ToString();
            usuario.NumeroDocumento = this.txtNumeroIdentificacion.Text;
            usuario.NombreCompleto = this.txtNombre.Text;
            usuario.Edad = this.txtEdad.Text;
            usuario.Estrato = Convert.ToInt32(this.cmbEstrato.SelectedItem);
            usuario.AtencionRequerida = this.rbtnMedicinaGeneral.Checked ? "Medicina General" : "Examen de Laboratorio";
            usuario.FechaRegistro = dtpFechaIngreso.Value;
            usuario.ValorCopago = CalcularCopago();
            this.txtValorCopago.Text = usuario.ValorCopago.ToString();

            if (this.cmbTipoEstructuraDatos.SelectedIndex == 0)
            {
                this.ReporteDatosPila = this.ReporteDatosPila + usuario.ValorCopago;
                this.PilaUsuarios.Push(usuario);
                dgPila.DataSource = null;
                dgPila.DataSource = this.PilaUsuarios.ToArray();
                this.tabEstructuras.SelectedIndex = 0;
                MessageBox.Show("El registro fue agragado a la pila correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.btnReportePila.Enabled = true;
                this.btnEliminarPila.Enabled = true;
            }
            if (this.cmbTipoEstructuraDatos.SelectedIndex == 1)
            {
                this.ReporteDatosCola += 1;
                this.ColaUsuarios.Enqueue(usuario);
                dgCola.DataSource = null;
                dgCola.DataSource = this.ColaUsuarios.ToArray();
                this.tabEstructuras.SelectedIndex = 1;
                MessageBox.Show("El registro fue agragado a la cola correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.btnReporteCola.Enabled = true;
                this.btnEliminarCola.Enabled = true;
            }
            if (this.cmbTipoEstructuraDatos.SelectedIndex == 2)
            {
                this.ReporteDatosLista += 1;
                this.ListaUsuarios.Add(usuario);
                dgLista.DataSource = null;
                dgLista.DataSource = this.ListaUsuarios.ToArray();
                this.tabEstructuras.SelectedIndex = 2;
                MessageBox.Show("El registro fue agragado a la lista correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.btnReporteLista.Enabled = true;
                this.btnEliminarLista.Enabled = true;
            }
            
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir de la aplicación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtNumeroIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void btnReportePila_Click(object sender, EventArgs e)
        {
          this.txtReporteDatos.Text = "Total copago: $" + this.ReporteDatosPila.ToString();
        }

        private void btnReporteCola_Click(object sender, EventArgs e)
        {
            this.txtReporteDatos.Text = "N° registros Cola: " + this.ReporteDatosCola.ToString();
        }

        private void btnReporteLista_Click(object sender, EventArgs e)
        {
            int SumaEdades = 0;
            float PromedioEdades = 0;
            foreach (EstructuraDatosUsuario usuario in this.ListaUsuarios)
            {
                SumaEdades += Convert.ToInt32(usuario.Edad);
            }
            PromedioEdades = SumaEdades / this.ListaUsuarios.Count;
            this.txtReporteDatos.Text = "Promedio edades: " + PromedioEdades.ToString();
        }

        private void btnEliminarPila_Click(object sender, EventArgs e)
        {
            if (this.PilaUsuarios.Count > 0 &&
                (MessageBox.Show("¿Seguro que quieres eliminar el primer registro de la pila?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information))== DialogResult.Yes)
            {
                
                EstructuraDatosUsuario usuario = new EstructuraDatosUsuario();
                usuario = this.PilaUsuarios.Pop();
                this.ReporteDatosPila = this.ReporteDatosPila - usuario.ValorCopago;
                this.txtReporteDatos.Text = "Total copago: $" + this.ReporteDatosPila.ToString();
                dgPila.DataSource = null;
                dgPila.DataSource = this.PilaUsuarios.ToArray();
                MessageBox.Show("El registro fue eliminado de la pila correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (this.PilaUsuarios.Count == 0)
                {
                    this.btnReportePila.Enabled = false;
                    this.btnEliminarPila.Enabled = false;
                   
                }
            }
        }

        private void btnEliminarCola_Click(object sender, EventArgs e)
        {
            if (this.ColaUsuarios.Count > 0 &&
                (MessageBox.Show("¿Seguro que quieres eliminar el registro de la cola?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information)) == DialogResult.Yes)
            {
                EstructuraDatosUsuario usuario = new EstructuraDatosUsuario();
                usuario = this.ColaUsuarios.Dequeue();
                this.ReporteDatosCola = this.ReporteDatosCola - 1;
                this.txtReporteDatos.Text = "N° registros Cola: " + this.ReporteDatosCola.ToString();
                dgCola.DataSource = null;
                dgCola.DataSource = this.ColaUsuarios.ToArray();
                MessageBox.Show("El registro fue eliminado de la cola correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (this.ColaUsuarios.Count == 0)
                {
                    this.btnReporteCola.Enabled = false;
                    this.btnEliminarCola.Enabled = false;
                   
                }
            }
        }
        private EstructuraDatosUsuario BuscarUsuario(string Cedula)
        {
            foreach (EstructuraDatosUsuario usuario in this.ListaUsuarios)
            {
                if (usuario.NumeroDocumento.Equals(Cedula))
                {
                    return usuario;
                }

            }
            return null;
        }

        private void btnEliminarLista_Click(object sender, EventArgs e)
        {
            if(this.ListaUsuarios.Count > 0)
            {
                string CedulaUsuario = txtNumeroIdentificacion.Text;
                if(CedulaUsuario == "")
                {
                    MessageBox.Show("El campo Número de Identificación es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtNumeroIdentificacion.Focus();
                    return;
                }
                else
                {
                    EstructuraDatosUsuario usuario = new EstructuraDatosUsuario();
                    usuario = BuscarUsuario(CedulaUsuario);
                    if (usuario != null)
                    {
                        MessageBox.Show("Desea elminar el usuario con identificación: " + CedulaUsuario + "?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        this.ListaUsuarios.Remove(usuario);
                        dgLista.DataSource = null;
                        dgLista.DataSource = this.ListaUsuarios.ToArray();
                        MessageBox.Show("Usuario eliminado con exito","Confirmacion",MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                    }
                    else
                    {
                        MessageBox.Show("El usuario con identificación: " + CedulaUsuario + " no existe","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.txtNumeroIdentificacion.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay registros en la lista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.btnReporteLista.Enabled = false;
                this.btnEliminarLista.Enabled = false;
            }
        }
    }
}
