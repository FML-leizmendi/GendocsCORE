using GendocsController;
using GendocsModeloDatos.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GendocsForms
{
    public partial class FrmContactos : Form
    {
        public int IdEmpleado { get; set; }
        public FrmContactos()
        {
            InitializeComponent();
        }

        #region "Eventos Privados"
        private void FrmContactos2_Load(object sender, EventArgs e)
        {
            CargarComboClientes();
            CargarGrid();
            FormatearGrid();
            G3Forms.CargarParam(this, this.Name + "_");
            txtIntroduzcaTexto.Focus();
        }

        private void BtnEditarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                ClsEmp cEmp = new ClsEmp();
                using (GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext())
                {
                    var lst = (from d in db.GdEmpleados
                               where (d.Empleado.Contains(txtIntroduzcaTexto.Text))
                               orderby d.IdEmpleado
                               select d.IdEmpleado

                           ).ToList();

                    cEmp.LstId = lst;
                    cEmp.CargarFrmEmpleados();
                }
                cmbClientes.SelectedIndex = -1;
                txtIntroduzcaTexto.Text = string.Empty;
                txtIntroduzcaTexto.Focus();
                CargarGrid();
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        private void FrmContactos_FormClosing(object sender, FormClosingEventArgs e)
        {

            try
            {
                using GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext();
                foreach (DataGridViewColumn itemCol in dgvContactos.Columns)
                {
                    var query = (from a in db.GdColumnasD
                                 where a.IdColumnaC == G3.DimeIdColumnaC(G3.IdEmpleadoFML_Logged, this.dgvContactos.Name) && a.NameField.Equals(itemCol.Name)
                                 select a).ToList();

                    if (query.Count() > 0)
                    {
                        foreach (var item in query)
                        {
                            item.Visible = itemCol.Visible;
                            item.Ancho = itemCol.Width;
                        }

                        db.SaveChanges();
                    }

                    G3Forms.GrabarParam(this, this.Name + "_");
                }
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                ClsEmp cEmp = new ClsEmp
                {
                    EsAlta = true,
                    EsNuevo = true
                };
                cEmp.CargarFrmEmpleados();
                cmbClientes.SelectedIndex = -1;
                txtIntroduzcaTexto.Text = string.Empty;
                txtIntroduzcaTexto.Focus();
                CargarGrid();
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }


        private void BtnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                ClsEmp cEmp = new ClsEmp();
                using (GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext())
                {
                    List<int> miLista = new List<int>();
                    for (int i = 0; i < dgvContactos.SelectedRows.Count; i++)
                    {
                        miLista.Add(Convert.ToInt32(dgvContactos.SelectedRows[i].Cells[0].Value.ToString()));
                    }
                    cEmp.LstId = miLista.ToList();
                    cEmp.EsNuevo = false;
                    cEmp.CargarFrmEmpleados();
                }
                cmbClientes.SelectedIndex = 0;
                txtIntroduzcaTexto.Text = string.Empty;
                txtIntroduzcaTexto.Focus();
                CargarGrid();
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        private void BtnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                ClsEmp cEmp = new ClsEmp();
                DialogResult result = MessageBox.Show("¿Desea eliminar los contactos seleccionados?", "Contactos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (dgvContactos.SelectedRows.Count > 0)
                    {
                        DataGridViewSelectedRowCollection Seleccionados = dgvContactos.SelectedRows;

                        foreach (DataGridViewRow item in Seleccionados)
                        {
                            Type type = item.DataBoundItem.GetType();
                            cEmp.IdEmpleado = (int)type.GetProperty("IdEmpleado")
                                                    .GetValue(item.DataBoundItem, null);

                            cEmp.EliminarEmpleado();
                        }
                        CargarGrid(txtIntroduzcaTexto.Text, Convert.ToInt32(cmbClientes.SelectedValue));
                    }
                    else
                    {
                        MessageBox.Show("No hay contactos seleccionado", "Contactos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    }
                }
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        private void BtnLimpiarFiltros_Click(object sender, EventArgs e)
        {
           
        }

        private void DgvContactos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ClsEmp cEmp = new ClsEmp();
                using GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext();
                var lst = (from d in db.GdEmpleados
                           where (d.IdEmpleado == Convert.ToInt32(dgvContactos.Rows[e.RowIndex].Cells[0].Value))
                           select d.IdEmpleado

                       ).ToList();

                cEmp.LstId = lst;
                cEmp.CargarFrmEmpleados();
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        private void tsmConfigurarGrid_Click(object sender, EventArgs e)
        {
            try
            {
                FrmConfigPedido frm = new FrmConfigPedido();
                frm.NombreGrid = dgvContactos.Name;
                frm.ShowDialog();
                CargarGrid();
                FormatearGrid();
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        private void DgvContactos_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvContactos.CurrentRow != null)
            {
                IdEmpleado = Convert.ToInt32(dgvContactos.CurrentRow.Cells[0].Value);
            }
        }

        #endregion

        #region "Métodos Privados"

        private List<GdColumnasD> CargarConfiguarcionIncial()
        {
            List<GdColumnasD> ListaInicial = new List<GdColumnasD>();
            try
            {
                int numColC = G3.DimeIdColumnaC((int)G3.IdEmpleadoFML_Logged, this.dgvContactos.Name);
                ListaInicial.Add(new GdColumnasD() { IdColumnaC = numColC, NumCol = 0, NameField = "IdEmpleado", Ancho = 0, OrderBy = "A", Visible = false });
                ListaInicial.Add(new GdColumnasD() { IdColumnaC = numColC, NumCol = 1, NameField = "Etiquetas", Ancho = 0, OrderBy = "A", Visible = false });
                ListaInicial.Add(new GdColumnasD() { IdColumnaC = numColC, NumCol = 2, NameField = "Empleado", Ancho = 350, OrderBy = "A", Visible = true });
                ListaInicial.Add(new GdColumnasD() { IdColumnaC = numColC, NumCol = 3, NameField = "Cliente", Ancho = 200, OrderBy = "A", Visible = true });
                ListaInicial.Add(new GdColumnasD() { IdColumnaC = numColC, NumCol = 4, NameField = "Cargo", Ancho = 400, OrderBy = "A", Visible = true });
                ListaInicial.Add(new GdColumnasD() { IdColumnaC = numColC, NumCol = 5, NameField = "Telefono", Ancho = 275, OrderBy = "A", Visible = true });
                ListaInicial.Add(new GdColumnasD() { IdColumnaC = numColC, NumCol = 6, NameField = "Email", Ancho = 450, OrderBy = "A", Visible = true });
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
            return ListaInicial;
        }

        private void BtnLimpiarControles_Click(object sender, EventArgs e)
        {
            try
            {
                txtIntroduzcaTexto.Text = string.Empty;
                txtIntroduzcaTexto.Focus();
                cmbClientes.SelectedIndex = 0;
                CargarGrid(txtIntroduzcaTexto.Text);
                FormatearGrid();
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }
        protected override bool ProcessDialogKey(Keys keyData) // cerrar formulario con ESCAPE
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void FormatearGrid()
        {
            try
            {
                List<GdColumnasD> ListaInicial = new List<GdColumnasD>();
                // Comprobamos si el usuario tiene registros guardados en la tabla ColumnaC, en caso de que no los guardamos
                GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext();
                if (G3.DimeIdColumnaC(G3.IdEmpleadoFML_Logged, this.dgvContactos.Name) == 0)
                {
                    GdColumnasC colC = new GdColumnasC
                    {
                        ListName = this.dgvContactos.Name,
                        IdEmpleadoFMl = (int)G3.IdEmpleadoFML_Logged
                    };

                    db.GdColumnasC.Add(colC);
                    db.SaveChanges();

                    // Se carga en una lista una configuracion general para la primera vez que el usuario accede al grid
                    ListaInicial = CargarConfiguarcionIncial();

                    foreach (GdColumnasD item in ListaInicial)
                    {
                        GdColumnasD colD = new GdColumnasD
                        {
                            IdColumnaC = item.IdColumnaC,
                            NumCol = item.NumCol,
                            NameField = item.NameField,
                            Ancho = item.Ancho,
                            OrderBy = item.OrderBy,
                            Visible = item.Visible
                        };

                        db.GdColumnasD.Add(colD);
                        db.SaveChanges();
                    }

                    //Ocultar una columna de un datagridview 
                    this.dgvContactos.Columns["IdEmpleado"].Visible = false;
                    this.dgvContactos.Columns["Etiquetas"].Visible = false;

                    ////Modificar el ancho de una columna
                    this.dgvContactos.Columns["Empleado"].Width = 350;
                    this.dgvContactos.Columns["Cliente"].Width = 200;
                    this.dgvContactos.Columns["Cargo"].Width = 400;
                    this.dgvContactos.Columns["Telefono"].Width = 500;
                    this.dgvContactos.Columns["Telefono"].HeaderText = "Teléfono";
                    this.dgvContactos.Columns["Email"].Width = 450;
                }
                else
                {
                    var lstFiltro = (from a in db.GdColumnasD
                                     where a.IdColumnaC == G3.DimeIdColumnaC((int)G3.IdEmpleadoFML_Logged, this.dgvContactos.Name)
                                     select a).ToList();

                    if (lstFiltro.Count() != 0)
                    {
                        foreach (var item in lstFiltro)
                        {
                            this.dgvContactos.Columns[item.NameField].Visible = item.Visible;
                            if (Convert.ToInt32(item.Ancho) > 0)
                            {
                                this.dgvContactos.Columns[item.NameField].Width = Convert.ToInt32(item.Ancho);
                            }
                            else
                                this.dgvContactos.Columns[item.NameField].Visible = false;
                        }
                    }
                }
                //Alinear las columnas 
                dgvContactos.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvContactos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //dgvProyectos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }

        }

        private void CargarGrid(String TextoIntroducido = "", int IdCliente = 0)
        {
            try
            {
                using GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext();
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
                        Cliente = "Todos"
                    }
                };

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
            catch(Exception ex)
            {
                _ = ex.Message;
            }
        }
        #endregion

        #region "Control de evenetos"
        private void TxtIntroduzcaTexto_TextChanged(object sender, EventArgs e)
        {
            CargarGrid(txtIntroduzcaTexto.Text, Convert.ToInt32(cmbClientes.SelectedValue));
        }

        private void CmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarGrid(txtIntroduzcaTexto.Text, Convert.ToInt32(cmbClientes.SelectedValue));
        }


        #endregion

        private void dgvContactos_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    cmsMenuColumnas.Show(Cursor.Position.X, Cursor.Position.Y);
                }
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

       
    }
}
