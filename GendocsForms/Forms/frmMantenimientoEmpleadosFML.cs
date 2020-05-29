using System;
using System.Windows.Forms;


namespace GendocsForms
{
    public partial class frmMantenimientoEmpleadosFML : Form
    {
        public clsEmpFml CEmp { get; set; }

        public frmMantenimientoEmpleadosFML(clsEmpFml cemp)
        {
            CEmp = cemp;
            InitializeComponent();
        }

        public frmMantenimientoEmpleadosFML()
        {
            InitializeComponent();

        }

        #region "Eventos Privados"
        private void FrmMantenimientoEmpleadosFML_Load(object sender, EventArgs e)
        {
            CargarForm();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LimpiarControles()
        {
            txtApellidos.Text = String.Empty;
            txtEmail.Text = string.Empty;
            txtEtiquetas.Text = string.Empty;
            // txtIdEmpleado.Text = string.Empty;
            txtNIF.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtTelefono.Text = string.Empty;
        }

        #endregion

        #region "Métodos Privados"

        public void CargarForm()
        {
            try
            {
                txtIdEmpleado.Text = CEmp.IdEmpleado.ToString();
                txtNIF.Text = CEmp.Nif;
                txtNombre.Text = CEmp.Nombre;
                txtApellidos.Text = CEmp.Apellidos;
                txtTelefono.Text = CEmp.Telefono;
                txtEmail.Text = CEmp.Email;
                txtEtiquetas.Text = CEmp.Etiquetas;
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        bool ValidarControles()
        {
            bool EsValido = true;
            string cadena = "Faltan los siguientes campos obligatorios:" + Environment.NewLine;
            try
            {
                if (txtNIF.Text == string.Empty)
                {
                    cadena += "NIF " + Environment.NewLine;
                    txtNIF.Focus();
                    EsValido = false;
                }
                if (txtNombre.Text == string.Empty)
                {
                    cadena += "Nombre " + Environment.NewLine;
                    txtNombre.Focus();
                    EsValido = false;
                }
                if (txtApellidos.Text == string.Empty)
                {
                    cadena += "Apellidos " + Environment.NewLine;
                    txtApellidos.Focus();
                    EsValido = false;
                }
                if (txtTelefono.Text == string.Empty)
                {
                    cadena += "Teléfono " + Environment.NewLine;
                    txtTelefono.Focus();
                    EsValido = false;
                }
                if (txtEmail.Text == string.Empty)
                {
                    cadena += "Email " + Environment.NewLine;
                    txtEmail.Focus();
                    EsValido = false;
                }
                if (!EsValido)
                {
                    MessageBox.Show(cadena, "Empleados FML", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
            return EsValido;
        }

        #endregion

        #region "Control de Eventos"
        private void BtnPrimero_Click(object sender, EventArgs e)
        {
            CEmp.IrPrimero();
            CargarForm();
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            CEmp.IrAnterior();
            CargarForm();
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            CEmp.IrSiguiente();
            CargarForm();
        }

        private void BtnUltimo_Click(object sender, EventArgs e)
        {
            CEmp.IrUltimo();
            CargarForm();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            CEmp.EliminarUsuario();
            CargarForm();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            txtNIF.Focus();
            // txtIdEmpleado.Visible = true;
            CEmp.EsAlta = true;
            btnEliminar.Visible = false;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarControles())
            {
                //CEmp.IdEmpleado = Int32.Parse(txtIdEmpleado.Text);
                CEmp.Nif = txtNIF.Text;
                CEmp.Nombre = txtNombre.Text;
                CEmp.Apellidos = txtApellidos.Text;
                CEmp.Telefono = txtTelefono.Text;
                CEmp.Email = txtEmail.Text;
                CEmp.Etiquetas = txtEtiquetas.Text;
                CEmp.GuardarUsuario();
                CEmp.EsAlta = false;
                // txtIdEmpleado.Visible = false;
                //btnEliminar.Visible = true;
            }
        }

        private void BtnEtiquetas_Click(object sender, EventArgs e)
        {
            clsEmpFml CEmp = new clsEmpFml
            {
                IdEmpleado = Int32.Parse(txtIdEmpleado.Text)
            };
            CEmp.AsignarEtiquetasFML();
            //CargarForm();
            txtEtiquetas.Text = CEmp.Etiquetas;

        }
        #endregion
    }
}
