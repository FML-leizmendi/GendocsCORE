using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GendocsForms
{
    public partial class FrmPedidoEdit : Form
    {
        public int IdPedidoCab;
       
        public clsPedidoCab cPedCab { get; set; }

        public FrmPedidoEdit(clsPedidoCab cpcab)
        {
            cPedCab = cpcab;
            InitializeComponent();
        }

        public FrmPedidoEdit()
        {
            InitializeComponent();
        }

        private void FrmPedidoEdit_Load(object sender, EventArgs e)
        {
            CargarComboClientes();
            CargarGrid();
            CargarForm();
            FormatearGrid();
            RealizarSuma();
        }

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
                txtImporteTotal.Text = (Convert.ToDouble (ImporteTotal)).ToString() + "€";
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
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
                this.dgvPedidosEdit.Columns["CodigoUC"].Width = 350;
                this.dgvPedidosEdit.Columns["DescripcionUC"].Width = 650;
                this.dgvPedidosEdit.Columns["Cantidad"].Width = 150;
                this.dgvPedidosEdit.Columns["Unidad"].Width = 125;
                this.dgvPedidosEdit.Columns["Precio"].Width = 175;
                this.dgvPedidosEdit.Columns["Importe"].Width = 175;
                this.dgvPedidosEdit.Columns["PlazoEntrega"].Width = 200;
                this.dgvPedidosEdit.Columns["NombreCompleto"].Width = 300;
                this.dgvPedidosEdit.Columns["EstadoTrabajo"].Width = 225;


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
                string mensaje = ex.Message;
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
                string mensaje = ex.Message;
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

                foreach (DataGridViewColumn column in dgvPedidosEdit.Columns)
                {

                    column.SortMode = DataGridViewColumnSortMode.Automatic;
                }
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }
        }

        private void btnAgregarRecurso_Click(object sender, EventArgs e)
        {
            try
            {
                clsUnidadesContructivas clsUnds = new clsUnidadesContructivas();
                clsUnds.CargarFrmUnidadesContructivas();
                //cPedCab.IdUC = clsUnds.IdUc;
                //cPedCab.Cantidad = clsUnds.Cantidad;
                //cPedCab.EsAlta = true;
                //cPedCab.GuardarUnidadContructiva();
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            int index = dgvPedidosEdit.SelectedRows[0].Index;
            int PosicionModificada = index - 1;

            try
            {
                if (dgvPedidosEdit.CurrentRow != null)
                {
                    //dgvPedidosEdit.
                }
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPedidosEdit.CurrentRow != null)
                {
                    cPedCab.IdPedidoDet = Convert.ToInt32(dgvPedidosEdit.CurrentRow.Cells["IdPedidoDet"].Value); // ALEX Obtener el valor de una columna de la fila seleccionada
                    cPedCab.EliminarUnidadContructiva();
                }
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }
        }

        private void dgvPedidosEdit_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
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
                string mensaje = ex.Message;
            }
        }

        private void tsmConfigurarGrid_Click(object sender, EventArgs e)
        {
            try
            {
                FrmPantallaConfPedidos frm = new FrmPantallaConfPedidos();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }
        }

        private void tsmOrdenarAsc_Click(object sender, EventArgs e)
        {
            try
            {
                //detallePedido = (List<GdPedidosDet>)lst.OrderBy(i => i.IdPedidoDet);


                //dgvPedidosEdit.DataSource = detallePedido;

                //dgvPedidosEdit.Sort(new RowComparer(SortOrder.Ascending));

                DataGridViewColumn gridViewColumn = new DataGridViewColumn();



                dgvPedidosEdit.Sort(gridViewColumn, ListSortDirection.Ascending);
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
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
    }
}
