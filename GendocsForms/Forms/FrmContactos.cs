using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GendocsForms.Forms
{
    public partial class FrmContactos : Form
    {
        public int IdEmpleado { get; set; }

        public FrmContactos()
        {
            InitializeComponent();
        }

        #region "Eventos Privados"
        private void FrmContactos_Load(object sender, EventArgs e)
        {
            CargarComboClientes();
            CargarGrid();
            FormatearGrid();
            G3Forms.CargarParam(this, this.Name);
            txtIntroduzcaTexto.Focus();
        }

        private void btnEditarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                clsEmp cEmp = new clsEmp();
                using (GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext())
                {
                    int IdCliente = Convert.ToInt32(cmbClientes.SelectedValue);
                    if (IdCliente != 0)
                    {
                        var lst = (from d in db.GdEmpleados
                                   where (d.Empleado.Contains(txtIntroduzcaTexto.Text) & (d.IdCliente == IdCliente))
                                   orderby d.IdEmpleado
                                   select d.IdEmpleado

                          ).ToList();
                        cEmp.lstId = lst;
                    }
                    else
                    {
                        var lst = (from d in db.GdEmpleados
                                   where (d.Empleado.Contains(txtIntroduzcaTexto.Text))
                                   orderby d.IdEmpleado
                                   select d.IdEmpleado

                         ).ToList();
                        cEmp.lstId = lst;
                    }
                    cEmp.CargarFrmEmpleados();
                }
                cmbClientes.SelectedIndex = 0;
                txtIntroduzcaTexto.Text = string.Empty;
                txtIntroduzcaTexto.Focus();
                CargarGrid();
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }
        }

        private void dgvContactos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                clsEmp cEmp = new clsEmp();
                using (GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext())
                {
                    var lst = (from d in db.GdEmpleados
                               where (d.Empleado .Contains(txtIntroduzcaTexto.Text))
                               select d.IdEmpleado

                           ).ToList();

                    cEmp.lstId = lst;
                    cEmp.CargarFrmEmpleados();
                }
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }
        }

        private void dgvContactos_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvContactos.CurrentRow != null)
            {
                //IdEmpleado = Convert.ToInt32(dgvEmpleados.Rows[0].Cells[1].Value);
                IdEmpleado = Convert.ToInt32(dgvContactos.CurrentRow.Cells[0].Value);
            }
        }

        #endregion

        #region "Métodos Privados"

        private void FormatearGrid()
        {
            try
            {   //Ocultar una columna de un datagridview 
                this.dgvContactos.Columns["IdEmpleado"].Visible = false;
                //this.dgvContactos.Columns["CodigoPersona"].Visible = false;
                //this.dgvContactos.Columns["IdEmpleadoSuperior"].Visible = false;

                ////Modificar el ancho de una columna
                this.dgvContactos.Columns["Empleado"].Width = 300;
                this.dgvContactos.Columns["Cliente"].Width = 200;
                this.dgvContactos.Columns["Cargo"].Width = 200;
                this.dgvContactos.Columns["Telefono"].Width = 400;
                this.dgvContactos.Columns["Email"].Width = 250;
                this.dgvContactos.Columns["Etiquetas"].Width = 300;


                ////Alinear las columnas 
                dgvContactos.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgvContactos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;              
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }
        }


        private void CargarGrid(String TextoIntroducido = "", int IdCliente = 0)
        {
            try
            {
                using (GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext())
                {
                    if (IdCliente != 0)
                    {
                        var lstFiltrada = (from a in db.GdEmpleados
                                           join b in db.GdCargos on a.IdCargo equals b.IdCargo
                                           join c in db.GdClientes on a.IdCliente equals c.IdCliente into joinedT
                                           from result in joinedT.DefaultIfEmpty()
                                           where (a.Empleado.Contains(TextoIntroducido) & (a.IdCliente == IdCliente))
                                           select new { a.IdEmpleado, a.Empleado, result.Cliente, b.Cargo, a.Telefono, a.Email, a.Etiquetas }

                                            ).ToList();

                        dgvContactos.DataSource = lstFiltrada;
                    }
                    else
                    {
                        var lst = (from a in db.GdEmpleados
                                   join b in db.GdCargos on a.IdCargo equals b.IdCargo
                                   join c in db.GdClientes on a.IdCliente equals c.IdCliente into joinedT
                                   from result in joinedT.DefaultIfEmpty()
                                   where (a.Empleado.Contains(TextoIntroducido))
                                   select new { a.IdEmpleado, a.Empleado, result.Cliente, b.Cargo, a.Telefono, a.Email, a.Etiquetas }

                          ).ToList();

                        dgvContactos.DataSource = lst;
                    }         
                }
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
                    Cliente = "Todos"
                });

                GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext();
                List<GendocsModeloDatos.models.GdClientes> lstClientes;
                lstClientes = db.GdClientes.Select(e => new GendocsModeloDatos.models.GdClientes()
                {
                    IdCliente = e.IdCliente,
                    Cliente = e.Cliente
                }
                ).ToList();

                lista.AddRange(lstClientes);

                cmbClientes.DisplayMember = "Cliente";
                cmbClientes.ValueMember = "IdCliente";
                cmbClientes.DataSource = lista;
            }
            catch
            {

            }
        }
        #endregion

        #region "Control de evenetos"
        private void txtIntroduzcaTexto_TextChanged(object sender, EventArgs e)
        {
            CargarGrid(txtIntroduzcaTexto.Text, Convert.ToInt32(cmbClientes.SelectedValue));
        }
        #endregion

        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarGrid(txtIntroduzcaTexto.Text, Convert.ToInt32(cmbClientes.SelectedValue));
        }

        private void FrmContactos_Leave(object sender, EventArgs e)
        {
            G3Forms.GrabarParam(this, this.Name);
        }
    }
}
