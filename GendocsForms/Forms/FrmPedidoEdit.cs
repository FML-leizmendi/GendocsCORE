using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GendocsForms
{
    public partial class FrmPedidoEdit : Form
    {
        public int IdPedidoCab;
        public DateTime FechaPlazoEntrega;

        public clsPedidoCab CPedCab { get; set; }

        public FrmPedidoEdit(clsPedidoCab cpcab)
        {
            CPedCab = cpcab;
            InitializeComponent();
        }

        public FrmPedidoEdit()
        {
            InitializeComponent();
        }

        #region "Eventos Privados"
        private void FrmPedidoEdit_Load(object sender, EventArgs e)
        {
            CargarComboClientes();
            CargarGrid();
            CargarForm();
            FormatearGrid();
            RealizarSuma();
        }

        private void BtnAgregarRecurso_Click(object sender, EventArgs e)
        {
            try
            {
                clsUnidadesContructivas clsUnds = new clsUnidadesContructivas();
                clsUnds.CargarFrmUnidadesContructivas();
                //CPedCab.IdUC = clsUnds.IdUc;
                //CPedCab.Cantidad = clsUnds.Cantidad;
                //CPedCab.EsAlta = true;
                //CPedCab.GuardarUnidadContructiva();
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        private void BtnSubir_Click(object sender, EventArgs e)
        {
            int index = dgvPedidosEdit.SelectedRows[0].Index;
            _ = index - 1;

            try
            {
                if (dgvPedidosEdit.CurrentRow != null)
                {
                    //dgvPedidosEdit.
                }
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPedidosEdit.CurrentRow != null)
                {
                    CPedCab.IdPedidoDet = Convert.ToInt32(dgvPedidosEdit.CurrentRow.Cells["IdPedidoDet"].Value); // ALEX Obtener el valor de una columna de la fila seleccionada
                    CPedCab.EliminarUnidadContructiva();
                }
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        private void DgvPedidosEdit_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
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

        private void TsmConfigurarGrid_Click(object sender, EventArgs e)
        {
            try
            {
                FrmConfigPedido frm = new FrmConfigPedido();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region "Métodos Privados"
        private void RealizarSuma()
        {
            try
            {
                Double ImporteTotal = 0;
                if (dgvPedidosEdit.Rows.Count > 0)
                {
                    for (int i = 0; i < dgvPedidosEdit.Rows.Count; i++)
                    {
                        ImporteTotal += Convert.ToDouble(dgvPedidosEdit.Rows[i].Cells["Importe"].Value);
                    }
                }
                txtImporteTotal.Text = (Convert.ToDouble(ImporteTotal)).ToString() + "€";
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        private void FormatearGrid()
        {
            try
            {
                // TODO Asignar la opción de ordenación automática a cada una de las columnas de un grid
                foreach (DataGridViewColumn dgvCol in dgvPedidosEdit.Columns)
                {
                    dgvCol.SortMode = DataGridViewColumnSortMode.Automatic;
                    //dgvPedidosEdit.Columns["CodigoUC"].SortMode = DataGridViewColumnSortMode.Automatic;
                }

                //Ocultar una columna de un datagridview 
                this.dgvPedidosEdit.Columns["IdPedidoDet"].Visible = false;
                this.dgvPedidosEdit.Columns["IdPedidoCab"].Visible = false;
                //this.dgvPedidosEdit.Columns["IdUC"].Visible = false;
                //this.dgvPedidosEdit.Columns["IdPedidoCabNavigation"].Visible = false;

                //Modificar el ancho de una columna
                this.dgvPedidosEdit.Columns["CodigoUC"].Width = 300;
                this.dgvPedidosEdit.Columns["DescripcionUC"].Width = 500;
                this.dgvPedidosEdit.Columns["Cantidad"].Width = 75;
                this.dgvPedidosEdit.Columns["Unidad"].Width = 75;
                this.dgvPedidosEdit.Columns["Precio"].Width = 75;
                this.dgvPedidosEdit.Columns["Importe"].Width = 75;
                this.dgvPedidosEdit.Columns["PlazoEntrega"].Width = 75;
                this.dgvPedidosEdit.Columns["NombreCompleto"].Width = 200;
                this.dgvPedidosEdit.Columns["EstadoTrabajo"].Width = 175;


                //Alinear las columnas 
                dgvPedidosEdit.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvPedidosEdit.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //dgvProyectos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvPedidosEdit.Columns["Importe"].DefaultCellStyle.Format = "C2";
                dgvPedidosEdit.Columns["Precio"].DefaultCellStyle.Format = "C2";
                dgvPedidosEdit.Columns["Cantidad"].DefaultCellStyle.Format = "c";
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }


        private void CargarGrid()
        {
            try
            {
                GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext();
                if (IdPedidoCab != 0)
                {
                    var lst = (from a in db.GdPedidosDet
                               join b in db.GdEmpleadosFml on a.IdResponsableFml equals b.IdEmpleadoFml
                               join c in db.GdTrabajoEstados on a.IdEstadoTrabajo equals c.IdEstadoTrabajo
                               let NombreCompleto = b.Nombre + " " + b.Apellidos
                               where a.IdPedidoCab == IdPedidoCab
                               orderby a.PlazoEntrega ascending
                               select new
                               {
                                   a.IdPedidoDet,
                                   a.IdPedidoCab,
                                   a.CodigoUc,
                                   a.DescripcionUc,
                                   a.Cantidad,
                                   a.Unidad,
                                   a.Precio,
                                   a.Importe,
                                   a.PlazoEntrega,
                                   NombreCompleto,
                                   c.EstadoTrabajo
                               }).ToList();


                    //List<GdPedidosDet> lst = (from a in db.GdPedidosDet
                    //                          where a.IdPedidoCab == IdPedidoCab
                    //                          select a).ToList();

                    DataTable dt = FormUtiles.ToDataTable(lst); // TODO CARGAR EL DATASOURCE CON UN DATATABLE

                    dgvPedidosEdit.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }


        public void CargarForm()
        {
            try
            {
                GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext();
                if (IdPedidoCab != 0)
                {

                    var query = (from a in db.GdPedidosCab
                                 where a.IdPedidoCab == this.IdPedidoCab
                                 select a).FirstOrDefault();

                    if (query != null)
                    {
                        txtPedidoCab.Text = query.IdPedidoCab.ToString();
                        txtNumRef.Text = query.NumRef;
                        txtNumContrato.Text = query.NumContrato.ToString();
                        txtNumObra.Text = query.NumObra;
                        txtDescripcionUC.Text = query.DescripcionObra;
                        txtFechaPedido.Text = query.FechaPedido.ToString();
                        txtFechaEntrega.Text = query.FechaEntrega.ToString();
                        txtActuacion.Text = query.Actuacion;
                        txtIdGestor.Text = Convert.ToInt32(query.IdEmpleadoGestor).ToString();
                        txtGestor.Text = query.Gestor;
                        txtArchivoPDF.Text = query.FilePdf;
                        txtProvincia.Text = query.Provincia;
                        txtPoblacion.Text = query.Poblacion;
                        txtDireccion.Text = query.Direccion;
                        txtCoefFacturacion.Text = query.CoeficienteFacturacion.ToString();
                        txtCoefPrecio.Text = query.CoeficientePrecio.ToString();

                        if (query.IdCliente == null)
                        {
                            cmbClientes.SelectedValue = 0;
                        }
                        else
                            cmbClientes.SelectedValue = Convert.ToInt32(query.IdCliente);
                    }
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

                foreach (DataGridViewColumn column in dgvPedidosEdit.Columns)
                {

                    column.SortMode = DataGridViewColumnSortMode.Automatic;
                }
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        private void BtnCalendario_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPedidosEdit.CurrentRow != null)
                {
                    FrmCalendario frm = new FrmCalendario();
                    frm.ShowDialog();
                    FechaPlazoEntrega = Convert.ToDateTime(frm.FechaPlazoEntrega);

                    if (FechaPlazoEntrega != Convert.ToDateTime("01/01/0001 0:00:00"))
                    {
                        foreach (DataGridViewRow dgvr in dgvPedidosEdit.SelectedRows)
                        {
                            GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext();
                            var query = (from a in db.GdPedidosDet
                                         where a.IdPedidoDet == Convert.ToInt32( dgvr.Cells["IdPedidoDet"].Value.ToString())
                                         select a).FirstOrDefault();

                            query.PlazoEntrega = FechaPlazoEntrega;
                            db.SaveChanges();
                        }
                        frm.Close();
                        CargarGrid();
                        FormatearGrid();
                    }
                }
                else
                {
                    MessageBox.Show("No hay ninguna fila de pedido seleccionada", "Detalle de Pedido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        private void btnModificarEstadoTrabajo_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAyuda frm = new FrmAyuda();
                frm.ShowDialog();
            }
            catch(Exception ex)
            {
                _ = ex.Message;
            }
        }

        #endregion

        #region "Control de Eventos"

        #endregion

        //private void BtnCalendario_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (dgvPedidosEdit.CurrentRow != null)
        //        {
        //            FrmCalendario frm = new FrmCalendario();
        //            frm.ShowDialog();
        //        }
        //        else
        //        {
        //            MessageBox.Show("No hay ninguna fila de pedido seleccionada", "Detalle de Pedido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        _ = ex.Message;
        //    }
        //}
    }
}
