using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Globalization;
namespace GendocsForms
{
    public partial class frmMantenimientoEmpleados : Form
    {
        public clsEmp cEmp { get; set; }

        public frmMantenimientoEmpleados(clsEmp cemp)
        {
            cEmp = cemp;
            InitializeComponent();
        }

        public frmMantenimientoEmpleados()
        {
            InitializeComponent();
        }

        #region "Eventos Privados"

        private void frmMantenimientoEmpleados_Load(object sender, EventArgs e)
        {
            CargarComboJefes();
            CargarComboClientes();
            CargarComboCargos();
            CargarForm();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimpiarControles()
        {
            txtEmail.Text = string.Empty;
            txtEtiquetas.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtTelefono.Text = string.Empty;
        }
        #endregion

        #region "Métodos Privados"

        public void CargarForm()
        {
            try
            {
                txtIdEmpleado.Text = cEmp.IdEmpleado.ToString();
                txtNombre.Text = cEmp.Empleado;
                txtTelefono.Text = cEmp.Telefono;
                txtEmail.Text = cEmp.Email;
                if (cEmp.IdCliente == null)
                {
                    cmbClientes.SelectedValue = 0;
                }
                else
                    cmbClientes.SelectedValue = Convert.ToInt32(cEmp.IdCliente);
                if (cEmp.IdCargo == null)
                {
                    cmbCargo.SelectedValue = 0;
                }
                else
                    cmbCargo.SelectedValue = Convert.ToInt32(cEmp.IdCargo);
                if (cEmp.IdEmpleadoSuperior == null)
                {
                    cmbJefes.SelectedValue = 0;
                }
                else
                    cmbJefes.SelectedValue = Convert.ToInt32(cEmp.IdEmpleadoSuperior);
                txtEtiquetas.Text = cEmp.Etiquetas;
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }
        }

        bool validarControles()
        {
            bool EsValido = true;
            string cadena = "Faltan los siguientes campos obligatorios:" + Environment.NewLine;
            try
            {
                if (txtNombre.Text == string.Empty)
                {
                    cadena += "Nombre " + Environment.NewLine;
                    txtNombre.Focus();
                    EsValido = false;
                }
                if (txtTelefono.Text == string.Empty)
                {
                    cadena += "Teléfono " + Environment.NewLine;
                    txtTelefono.Focus();
                    EsValido = false;
                }
                if (cmbClientes.SelectedIndex == -1)
                {
                    cadena += "Cliente " + Environment.NewLine;
                    cmbClientes.Focus();
                    EsValido = false;
                }
                if (cmbCargo.SelectedIndex == -1)
                {
                    cadena += "Tipo de Cargo " + Environment.NewLine;
                    cmbCargo.Focus();
                    EsValido = false;
                }
                
                if (cmbJefes.SelectedIndex == -1)
                {
                    cadena += "Jefe " + Environment.NewLine;
                    cmbJefes.Focus();
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
                string mensaje = ex.Message;
            }
            return EsValido;
        }
        private void CargarComboJefes()
        {
            try
            {
                GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext();
                List<GendocsModeloDatos.models.GdEmpleados> lstEmpleados;
                lstEmpleados = db.GdEmpleados.Select(e => new GendocsModeloDatos.models.GdEmpleados()
                {
                    IdEmpleado = e.IdEmpleado,
                    Empleado = e.Empleado
                }
                ).ToList();

                cmbJefes.DisplayMember = "Empleado";
                cmbJefes.ValueMember = "IdEmpleado";
                cmbJefes.DataSource = lstEmpleados;
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }
        }

        private void CargarComboClientes()
        {
            try
            {
                List<GendocsModeloDatos.models.GdClientes> lista = new List<GendocsModeloDatos.models.GdClientes>();
                lista.Add(new GendocsModeloDatos.models.GdClientes()
                {
                    IdCliente = 0,
                    Cliente = "Otros"
                });

                GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext();
                List<GendocsModeloDatos.models.GdClientes> lstCargos;
                lstCargos = db.GdClientes.Select(e => new GendocsModeloDatos.models.GdClientes()
                {
                    IdCliente = e.IdCliente,
                    Cliente = e.Cliente
                }
                ).ToList();

                lista.AddRange(lstCargos);

                cmbClientes.DisplayMember = "Cliente";
                cmbClientes.ValueMember = "IdCliente";
                cmbClientes.DataSource = lista;
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }
        }

        private void CargarComboCargos()
        {
            try
            {
                List<GendocsModeloDatos.models.GdCargos> lista = new List<GendocsModeloDatos.models.GdCargos>();
                lista.Add(new GendocsModeloDatos.models.GdCargos()
                {
                    IdCargo = 0,
                    Cargo = "Otros"
                });

                GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext();
                List<GendocsModeloDatos.models.GdCargos> lstCargos;
                lstCargos = db.GdCargos.Select(e => new GendocsModeloDatos.models.GdCargos()
                {
                    IdCargo = e.IdCargo,
                    Cargo = e.Cargo
                }
                ).ToList();

                lista.AddRange(lstCargos);

                cmbCargo.DisplayMember = "Cargo";
                cmbCargo.ValueMember = "IdCargo";
                cmbCargo.DataSource = lista;
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }
        }


        #endregion

        #region "Control de Eventos"
        private void btnPrimero_Click(object sender, EventArgs e)
        {
            cEmp.IrPrimero();
            CargarForm();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            cEmp.IrAnterior();
            CargarForm();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            cEmp.IrSiguiente();
            CargarForm();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            cEmp.IrUltimo();
            CargarForm();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            cEmp.EliminarUsuario();
            CargarForm();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            txtNombre.Focus();
            cmbCargo.SelectedIndex = -1;
            cmbClientes.SelectedIndex = -1;
            cEmp.EsAlta = true;
            btnEliminar.Visible = false;
            btnGuardar.Visible = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarControles())
            {
                //cEmp.IdEmpleado = Int32.Parse(txtIdEmpleado.Text);
                //cEmp.IdEmpleado = txtIdEmpleado.Text;
                cEmp.Empleado = txtNombre.Text;
                cEmp.Telefono = txtTelefono.Text;
                cEmp.IdCargo = Convert.ToInt32 ( cmbCargo.SelectedValue);
                cEmp.IdCliente = Convert.ToInt32 (cmbClientes.SelectedValue);
                cEmp.IdEmpleadoSuperior = Convert.ToInt32(cmbJefes.SelectedValue);
                cEmp.Email = txtEmail.Text;
                cEmp.Etiquetas = txtEtiquetas.Text;
                cEmp.GuardarUsuario();
                cEmp.EsAlta = false;
                // txtIdEmpleado.Visible = false;
                btnEliminar.Visible = false;
                btnGuardar.Visible = false;

            }
        }

        private void btnEtiquetas_Click(object sender, EventArgs e)
        {
            clsEmpFml cEmp = new clsEmpFml();
            cEmp.IdEmpleado = Int32.Parse(txtIdEmpleado.Text);
            cEmp.AsignarEtiquetasFML();
            //CargarForm();
            txtEtiquetas.Text = cEmp.Etiquetas;
        }
        #endregion

      
    }
}
