using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace GendocsForms
{
    public partial class FrmPedidos : Form
    {
        public clsPedidos cPed { get; set; }

        public FrmPedidos(clsPedidos cped)
        {
            cPed = cped;
            InitializeComponent();
        }

        public FrmPedidos()
        {
            InitializeComponent();
        }

        #region "Eventos Privados"
        private void FrmPedidos_Load(object sender, EventArgs e)
        {
            CargarGrid();
            FormatearGrid();
            txtIntroduzcaTexto.Focus();
            //HabilitarBotonera();
        }

        #endregion

        #region "Métodos Privados"

        private void FormatearGrid()
        {
            try
            {   //Ocultar una columna de un datagridview 
                this.dgvPedidos.Columns["IdPedidoCab"].Visible = false;

                ////Modificar el ancho de una columna
                this.dgvPedidos.Columns["NumRef"].Width = 200;
                this.dgvPedidos.Columns["NumRef"].HeaderText = "Num. Referencia";
                this.dgvPedidos.Columns["Gestor"].Width = 400;
                this.dgvPedidos.Columns["NumObra"].Width = 200;
                this.dgvPedidos.Columns["NumObra"].HeaderText = "Núm. Obra";
                this.dgvPedidos.Columns["FechaPedido"].Width = 200;
                this.dgvPedidos.Columns["FechaPedido"].HeaderText = "Fecha Pedido";
                this.dgvPedidos.Columns["DescripcionObra"].Width = 650;
                this.dgvPedidos.Columns["DescripcionObra"].HeaderText = "Descrip. Obra";
                this.dgvPedidos.Columns["Actuacion"].Width = 450;
                this.dgvPedidos.Columns["Actuacion"].HeaderText = "Alias(Actuación)";
                this.dgvPedidos.Columns["Poblacion"].Width = 225;

                ////Alinear las columnas 
                dgvPedidos.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvPedidos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvPedidos.Columns["DescripcionObra"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgvPedidos.Columns["Gestor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgvPedidos.Columns["Actuacion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }
        }


        private void CargarGrid(String TextoIntroducido = "", bool EsProhibido = false)
        {
            try
            {
                using (GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext())
                {
                    var lst = (
                        from a in db.GdProyectos
                        join b in db.GdPedidosCab on a.IdProyecto equals b.IdProyecto
                        where ((b.NumRef.Contains(TextoIntroducido)  && b.NumRef != null)|| (b.Gestor.Contains(TextoIntroducido) && b.NumRef != null)|| (b.NumObra.Contains(TextoIntroducido) && b.NumRef != null) || (b.DescripcionObra.Contains(TextoIntroducido) && b.NumRef != null) 
                        || (b.Actuacion.Contains(TextoIntroducido) && b.NumRef != null)  || (b.Poblacion.Contains(TextoIntroducido) && b.NumRef != null))
                        orderby b.IdPedidoCab descending
                        select new {b.IdPedidoCab, b.NumRef, b.Gestor, b.NumObra, b.FechaPedido, b.DescripcionObra, b.Actuacion, b.Poblacion}

                        ).ToList();

                    dgvPedidos.DataSource = null;
                    dgvPedidos.DataSource = lst;
                }
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }
        }

        #endregion

        #region "Control de Eventos"
        private void txtIntroduzcaTexto_TextChanged(object sender, EventArgs e)
        {
            CargarGrid(txtIntroduzcaTexto.Text);
            FormatearGrid();
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            try
            {
                txtIntroduzcaTexto.Text = String.Empty;
                txtIntroduzcaTexto.Focus();
            }
            catch (Exception Ex)
            {
                string mensaje = Ex.Message;
            }
        }

        #endregion
    }
}

