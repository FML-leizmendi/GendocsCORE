using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GendocsForms
{
    public partial class FrmMantenimientoEmpleados : Form
    {
        public ClsEmp CEmp { get; set; }

        public bool HanModificado = false;

        public 
            FrmMantenimientoEmpleados(ClsEmp cemp)
        {
            CEmp = cemp;
            InitializeComponent();
        }

        public FrmMantenimientoEmpleados()
        {
            InitializeComponent();
        }

        #region "Eventos Privados"

        private void FrmMantenimientoEmpleados_Load(object sender, EventArgs e)
        {
            CargarComboJefes();
            CargarComboClientes();
            CargarComboCargos();
            CargarForm();
            HanModificado = false;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
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
                txtIdEmpleado.Text = CEmp.IdEmpleado.ToString();
                txtNombre.Text = CEmp.Empleado;
                txtTelefono.Text = CEmp.Telefono;
                txtEmail.Text = CEmp.Email;
                if (CEmp.IdCliente == null)
                {
                    cmbClientes.SelectedValue = 0;
                }
                else
                    cmbClientes.SelectedValue = Convert.ToInt32(CEmp.IdCliente);
                if (CEmp.IdCargo == null)
                {
                    cmbCargo.SelectedValue = 0;
                }
                else
                    cmbCargo.SelectedValue = Convert.ToInt32(CEmp.IdCargo);
                if (CEmp.IdEmpleadoSuperior == null)
                {
                    cmbJefes.SelectedValue = 0;
                }
                else
                cmbJefes.SelectedValue = Convert.ToInt32(CEmp.IdEmpleadoSuperior);
                txtEtiquetas.Text = CEmp.Etiquetas;
                HanModificado = false;
                btnGuardar.Visible = false;
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
                _ = ex.Message;
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
                _ = ex.Message;
            }
        }

        private void CargarComboClientes()
        {
            try
            {
                List<GendocsModeloDatos.models.GdClientes> lista = new List<GendocsModeloDatos.models.GdClientes>
                {
                    new GendocsModeloDatos.models.GdClientes()
                    {
                        IdCliente = 0,
                        Cliente = "Otros"
                    }
                };

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
                _ = ex.Message;
            }
        }

        private void CargarComboCargos()
        {
            try
            {
                List<GendocsModeloDatos.models.GdCargos> lista = new List<GendocsModeloDatos.models.GdCargos>
                {
                    new GendocsModeloDatos.models.GdCargos()
                    {
                        IdCargo = 0,
                        Cargo = "Otros"
                    }
                };

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
                _ = ex.Message;
            }
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
            txtNombre.Focus();  
            cmbCargo.SelectedIndex = -1;
            cmbClientes.SelectedIndex = -1;
            cmbJefes.SelectedIndex = -1;
            CEmp.EsAlta = true;
            btnEliminar.Visible = false;
            btnGuardar.Visible = true;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (HanModificado)
            {
                if (ValidarControles())
                {
                    //cEmp.IdEmpleado = Int32.Parse(txtIdEmpleado.Text);
                    //cEmp.IdEmpleado = txtIdEmpleado.Text;
                    CEmp.Empleado = txtNombre.Text;
                    CEmp.Telefono = txtTelefono.Text;
                    CEmp.IdCargo = Convert.ToInt32(cmbCargo.SelectedValue);
                    CEmp.IdCliente = Convert.ToInt32(cmbClientes.SelectedValue);
                    CEmp.IdEmpleadoSuperior = Convert.ToInt32(cmbJefes.SelectedValue);
                    CEmp.Email = txtEmail.Text;
                    CEmp.Etiquetas = txtEtiquetas.Text;
                    CEmp.GuardarUsuario();
                    CEmp.EsAlta = false;
                    // txtIdEmpleado.Visible = false;
                    btnEliminar.Visible = false;
                    btnGuardar.Visible = false;
                }
            }
        }

        private void BtnEtiquetas_Click(object sender, EventArgs e)
        {
            ClsEmp CEmp = new ClsEmp
            {
                IdEmpleado = Int32.Parse(txtIdEmpleado.Text)
            };
            CEmp.AsignarEtiquetasFML();
            //CargarForm();
            txtEtiquetas.Text = CEmp.Etiquetas;
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            HanModificado = true;
        }

        private void TxtNombre_Leave(object sender, EventArgs e)
        {
            if (HanModificado)
            {
                btnGuardar.Visible = true;
            }
        }

        private void TxtTelefono_TextChanged(object sender, EventArgs e)
        {
            HanModificado = true;
        }

        private void TxtTelefono_Leave(object sender, EventArgs e)
        {
            if (HanModificado)
            {
                btnGuardar.Visible = true;
            }
        }

        private void CmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            HanModificado = true;
        }

        private void CmbClientes_Leave(object sender, EventArgs e)
        {
            if (HanModificado)
            {
                btnGuardar.Visible = true;
            }
        }

        private void CmbCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            HanModificado = true;
        }

        private void CmbCargo_Leave(object sender, EventArgs e)
        {
            if (HanModificado)
            {
                btnGuardar.Visible = true;
            }
        }

        private void CmbJefes_SelectedIndexChanged(object sender, EventArgs e)
        {
            HanModificado = true;
        }

        private void CmbJefes_Leave(object sender, EventArgs e)
        {
            if (HanModificado)
            {
                btnGuardar.Visible = true;
            }
        }
        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {
            HanModificado = true;
        }

        private void TxtEmail_Leave(object sender, EventArgs e)
        {
            if (HanModificado)
            {
                btnGuardar.Visible = true;
            }
        }

        private void TxtEtiquetas_TextChanged(object sender, EventArgs e)
        {
            HanModificado = true;
        }

        private void TxtEtiquetas_Leave(object sender, EventArgs e)
        {
            if (HanModificado)
            {
                btnGuardar.Visible = true;
            }
        }
        #endregion
    }
}
