using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GendocsForms
{
    public partial class FrmMantenimientoEmpleados2 : Form
    {
        public clsEmp cEmp { get; set; }

        public bool HanModificado = false;

        public FrmMantenimientoEmpleados2(clsEmp cemp)
        {
            cEmp = cemp;
            InitializeComponent();
        }


        public FrmMantenimientoEmpleados2()
        {
            InitializeComponent();
        }

        #region "Eventos Privados"
        private void FrmMantenimientoEmpleados2_Load(object sender, EventArgs e)
        {
            //LimpiarControles();
            CargarComboJefes();
            CargarComboClientes();
            CargarComboCargos();
            CargarForm();

            if (cEmp.esNuevo == true)
            {
                OcultarBotonesNavegacion();
            }
            txtNombre.Focus();
            cEmp.EsAlta = true;
            HanModificado = false;
            txtNombre.Focus();
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

        public void OcultarBotonesNavegacion()
        {
            try
            {
                btnPrimero.Visible = false;
                btnSiguiente.Visible = false;
                btnAnterior.Visible = false;
                btnUltimo.Visible = false;
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }
        }

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
                HanModificado = false;
                //btnGuardar.Visible = false;
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
                if (cmbClientes.SelectedIndex == 0)
                {
                    cadena += "Cliente " + Environment.NewLine;
                    cmbClientes.Focus();
                    EsValido = false;
                }
                if (cmbCargo.SelectedIndex == 0)
                {
                    cadena += "Tipo de Cargo " + Environment.NewLine;
                    cmbCargo.Focus();
                    EsValido = false;
                }

                if (cmbJefes.SelectedIndex == 0)
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
                List<GendocsModeloDatos.models.GdEmpleados> lista = new List<GendocsModeloDatos.models.GdEmpleados>();
                lista.Add(new GendocsModeloDatos.models.GdEmpleados()
                {
                    IdEmpleado = 0,
                    Empleado = ""
                });

                GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext();
                List<GendocsModeloDatos.models.GdEmpleados> lstEmpleados;
                lstEmpleados = db.GdEmpleados.Select(e => new GendocsModeloDatos.models.GdEmpleados()
                {
                    IdEmpleado = e.IdEmpleado,
                    Empleado = e.Empleado
                }
                ).ToList();

                lista.AddRange(lstEmpleados);

                cmbJefes.DisplayMember = "Empleado";
                cmbJefes.ValueMember = "IdEmpleado";
                cmbJefes.DataSource = lista;

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
                    Cliente = ""
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
                    Cargo = ""
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (HanModificado)
            {
                if (validarControles())
                {
                    //cEmp.IdEmpleado = Int32.Parse(txtIdEmpleado.Text);
                    //cEmp.IdEmpleado = txtIdEmpleado.Text;
                    cEmp.Empleado = txtNombre.Text;
                    cEmp.Telefono = txtTelefono.Text;
                    cEmp.IdCargo = Convert.ToInt32(cmbCargo.SelectedValue);
                    cEmp.IdCliente = Convert.ToInt32(cmbClientes.SelectedValue);
                    cEmp.IdEmpleadoSuperior = Convert.ToInt32(cmbJefes.SelectedValue);
                    cEmp.Email = txtEmail.Text;
                    cEmp.Etiquetas = txtEtiquetas.Text;
                    cEmp.EsAlta = true;
                    cEmp.GuardarUsuario();
                    this.Close();
                    //btnEliminar.Visible = false;
                    //btnGuardar.Visible = false;

                }
            }
        }

        private void btnEtiquetas_Click(object sender, EventArgs e)
        {
            clsEmp cEmp = new clsEmp();
            cEmp.IdEmpleado = Int32.Parse(txtIdEmpleado.Text);
            cEmp.AsignarEtiquetasFML();
            //CargarForm();
            txtEtiquetas.Text = cEmp.Etiquetas;
        }
        #endregion

        #region "Control de Eventos"
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            HanModificado = true;
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            HanModificado = true;
        }

        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            HanModificado = true;
        }

        private void cmbCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            HanModificado = true;
        }

        private void cmbJefes_SelectedIndexChanged(object sender, EventArgs e)
        {
            HanModificado = true;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            HanModificado = true;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            cEmp.IrSiguiente();
            CargarForm();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            cEmp.IrAnterior();
            CargarForm();
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            cEmp.IrPrimero();
            CargarForm();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            cEmp.IrUltimo();
            CargarForm();
        }
        #endregion
    }
}
