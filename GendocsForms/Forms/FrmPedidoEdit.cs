using GendocsModeloDatos.models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace GendocsForms
{
    public partial class FrmPedidoEdit : Form
    {
        public int IdPedidoCab;
        public string cadena = "Server=PC-ALEXMOTA;Initial Catalog =GenDocs;Integrated Security=True;";
        public SqlConnection sqlConnection = new SqlConnection();
        //private List<GdPedidosDet> detallePedido;

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
            CargarForm();
            CargarGrid();
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
                txtImporteTotal.Text = ImporteTotal.ToString() + "€";
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }
        }

        public void ConectarBD()
        {
            sqlConnection.ConnectionString = cadena;
            sqlConnection.Open();
        }

        private void FormatearGrid()
        {
            try
            {
                dgvPedidosEdit.Columns["CodigoUC"].SortMode = DataGridViewColumnSortMode.Automatic;
                //Ocultar una columna de un datagridview 
                this.dgvPedidosEdit.Columns["IdPedidoDet"].Visible = false;
                this.dgvPedidosEdit.Columns["IdPedidoCab"].Visible = false;
                //this.dgvPedidosEdit.Columns["IdUC"].Visible = false;
                //this.dgvPedidosEdit.Columns["IdPedidoCabNavigation"].Visible = false;

                //Modificar el ancho de una columna
                this.dgvPedidosEdit.Columns["CodigoUC"].Width = 350;
                this.dgvPedidosEdit.Columns["DescripcionUC"].Width = 600;
                this.dgvPedidosEdit.Columns["Cantidad"].Width = 150;
                this.dgvPedidosEdit.Columns["Unidad"].Width = 100;
                this.dgvPedidosEdit.Columns["Precio"].Width = 150;
                this.dgvPedidosEdit.Columns["Importe"].Width = 150;
                this.dgvPedidosEdit.Columns["PlazoEntrega"].Width = 200;
                //this.dgvPedidosEdit.Columns["NombreCompleto"].Width = 250;
                //this.dgvPedidosEdit.Columns["EstadoTrabajo"].Width = 200;


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
        

        private void CargarGrid(string ColumnaOrden = "")
        {
            try
            {
                GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext();
                if (cPedCab.IdPedidoCab != 0)
                {
                    //List<GdPedidosDet> lst = (from a in db.GdPedidosDet
                    //           join b in db.GdEmpleadosFml on a.IdResponsableFml equals b.IdEmpleadoFml
                    //           join c in db.GdTrabajoEstados on a.IdEstadoTrabajo equals c.IdEstadoTrabajo
                    //           let NombreCompleto = b.Nombre + " " + b.Apellidos
                    //           select new
                    //           {
                    //               a.IdPedidoDet,
                    //               a.IdPedidoCab,
                    //               a.CodigoUc,
                    //               a.DescripcionUc,
                    //               a.Cantidad,
                    //               a.Unidad,
                    //               a.Precio,
                    //               a.Importe,
                    //               a.PlazoEntrega,
                    //              // NombreCompleto,
                    //               c.EstadoTrabajo
                    //           }).ToList();

            

                    

                    List<GdPedidosDet> lst = (from a in db.GdPedidosDet
                                              where a.IdPedidoCab == cPedCab.IdPedidoCab
                                              select a).ToList();

                    DataTable dt = Utiles.ToDataTable(lst);

                    dgvPedidosEdit.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }
        }

        //private class RowComparer : System.Collections.IComparer
        //{
        //    private static int sortOrderModifier = 1;

        //    public RowComparer(SortOrder sortOrder)
        //    {
        //        if (sortOrder == SortOrder.Descending)
        //        {
        //            sortOrderModifier = -1;
        //        }
        //        else if (sortOrder == SortOrder.Ascending)
        //        {
        //            sortOrderModifier = 1;
        //        }
        //    }

        //    public int Compare(object x, object y)
        //    {
        //        DataGridViewRow DataGridViewRow1 = (DataGridViewRow)x;
        //        DataGridViewRow DataGridViewRow2 = (DataGridViewRow)y;

        //        // Try to sort based on the Last Name column.
        //        int CompareResult = System.String.Compare(
        //            DataGridViewRow1.Cells[1].Value.ToString(),
        //            DataGridViewRow2.Cells[1].Value.ToString());

        //        // If the Last Names are equal, sort based on the First Name.
        //        if (CompareResult == 0)
        //        {
        //            CompareResult = System.String.Compare(
        //                DataGridViewRow1.Cells[0].Value.ToString(),
        //                DataGridViewRow2.Cells[0].Value.ToString());
        //        }
        //        return CompareResult * sortOrderModifier;
        //    }

        //}


        public void CargarForm()
        {
            try
            {
                txtPedidoCab.Text = cPedCab.IdPedidoCab.ToString();
                txtNumRef.Text = cPedCab.NumRef;
                txtNumContrato.Text = cPedCab.NumContrato.ToString();
                txtNumObra.Text = cPedCab.NumObra;
                txtDescripcionUC.Text = cPedCab.DescripcionObra;
                txtFechaPedido.Text = cPedCab.FechaPedido.ToString();
                txtFechaEntrega.Text = cPedCab.FechaEntrega.ToString();
                txtActuacion.Text = cPedCab.Actuacion;
                txtIdGestor.Text = Convert.ToInt32(cPedCab.IdEmpleadoGestor).ToString();
                txtGestor.Text = cPedCab.Gestor;
                txtArchivoPDF.Text = cPedCab.FilePdf;
                txtProvincia.Text = cPedCab.Provincia;
                txtPoblacion.Text = cPedCab.Poblacion;
                txtDireccion.Text = cPedCab.Direccion;
                txtCoefFacturacion.Text = cPedCab.CoeficienteFacturacion.ToString();
                txtCoefPrecio.Text = cPedCab.CoeficientePrecio.ToString();
                if (cPedCab.IdCliente == null)
                {
                    cmbClientes.SelectedValue = 0;
                }
                else
                    cmbClientes.SelectedValue = Convert.ToInt32(cPedCab.IdCliente);

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
                cPedCab.IdUC = clsUnds.IdUc;
                cPedCab.Cantidad = clsUnds.Cantidad;
                cPedCab.EsAlta = true;
                cPedCab.GuardarUnidadContructiva();
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
    }
}
