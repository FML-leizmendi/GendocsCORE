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
        public ClsPedidos CPed { get; set; }

        public FrmPedidos(ClsPedidos cped)
        {
            CPed = cped;
            InitializeComponent();
        }

        public FrmPedidos()
        {
            InitializeComponent();
        }

        #region "Eventos Privados"
        private void FrmPedidos_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            //this.MdiParent = MdiParent.MdiParent;
            CargarGrid();
            FormatearGrid();
            CargarComboAccesos();
            CargarComboUsuarios();
            txtIntroduzcaTexto.Focus();
            //HabilitarBotonera();
        }

        private void DgvPedidos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvPedidos.CurrentCell != null) // Se valida que la fila actual no esté vacía
                {
                    //int IdPedidoCab = Convert.ToInt32(dgvPedidos.Rows[e.RowIndex].Cells[0].Value.ToString());
                    //clsPedidoCab clsPedCab = new clsPedidoCab();
                    //clsPedCab.IdPedidoCab = IdPedidoCab;
                    FrmPedidoEdit frm = new FrmPedidoEdit
                    {
                        MdiParent = this.MdiParent,
                        WindowState = FormWindowState.Maximized,
                        IdPedidoCab = Convert.ToInt32(dgvPedidos.Rows[e.RowIndex].Cells[0].Value.ToString())
                    };
                    frm.Show();
                    //clsPedCab.CargarFrmPedidoCab();
                }

            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        private void CmbUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int IdEmpleadoFML = Convert.ToInt32(cmbUsuarios.SelectedValue);
                CargarComboAccesos(IdEmpleadoFML);
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        private void CmbAccesos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext();

                string Acceso = cmbAccesos.Text.Replace(" ", string.Empty);
                int IdEmpleadoFML = Convert.ToInt32(cmbUsuarios.SelectedValue);

                var lst = (from a in db.GD_EmpleadosFML_Accesos
                           where a.IdEmpleadoFML == IdEmpleadoFML && a.Acceso.Contains(Acceso)
                           select new { a.Usuario, a.Password }).ToList();

                if (lst.Count() != 0)
                {
                    foreach (var item in lst)
                    {
                        if (item.Usuario != null)
                        {
                            txtUsuario.Text = item.Usuario.Replace(" ", string.Empty);
                        }
                        else
                            txtUsuario.Text = string.Empty;
                        if (item.Password != null)
                        {
                            txtContraseña.Text = item.Password.Replace(" ", string.Empty);
                        }
                        else
                            txtContraseña.Text = string.Empty;

                    }
                }
                txtUsuario.Focus();

            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }

        }

        protected override bool ProcessDialogKey(Keys keyData) // TODO cerrar el formulario con el boton ESCAPE
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
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
                this.dgvPedidos.Columns["Poblacion"].Width = 275;

                ////Alinear las columnas 
                dgvPedidos.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvPedidos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvPedidos.Columns["DescripcionObra"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgvPedidos.Columns["Gestor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgvPedidos.Columns["Actuacion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                foreach (DataGridViewColumn dgvCol in dgvPedidos.Columns)
                {
                    dgvCol.SortMode = DataGridViewColumnSortMode.Automatic;
                }
            }
            catch (Exception ex)
            {
               _ = ex.Message;
            }
        }


        private void CargarGrid(String TextoIntroducido = "")
        {
            try
            {
                using GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext();
                var lst = (
                    from a in db.GdProyectos
                    join b in db.GdPedidosCab on a.IdProyecto equals b.IdProyecto
                    where ((b.NumRef.Contains(TextoIntroducido) && b.NumRef != null) || (b.Gestor.Contains(TextoIntroducido) && b.NumRef != null) || (b.NumObra.Contains(TextoIntroducido) && b.NumRef != null) || (b.DescripcionObra.Contains(TextoIntroducido) && b.NumRef != null)
                    || (b.Actuacion.Contains(TextoIntroducido) && b.NumRef != null) || (b.Poblacion.Contains(TextoIntroducido) && b.NumRef != null))
                    orderby b.IdPedidoCab descending
                    select new { b.IdPedidoCab, b.NumRef, b.Gestor, b.NumObra, b.FechaPedido, b.DescripcionObra, b.Actuacion, b.Poblacion }

                    ).ToList();

                DataTable dt = FormUtiles.ToDataTable(lst);

                dgvPedidos.DataSource = null;
                dgvPedidos.DataSource = dt;
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        private void CargarComboAccesos(int IdEmpleadoFML = 0)
        {
            try
            {
                GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext();

                var lst = (from a in db.GD_EmpleadosFML_Accesos
                           where a.IdEmpleadoFML == IdEmpleadoFML && IdEmpleadoFML != 0
                           select new { a.Acceso }).ToList();

                var lstFiltrada = (from c in lst
                                   select new { c.Acceso }).Distinct().ToList(); // TODO DISTINCT

                cmbAccesos.DisplayMember = "Acceso";
                cmbAccesos.ValueMember = "IdAcceso";
                cmbAccesos.DataSource = lstFiltrada;
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        private void CargarComboUsuarios()
        {
            try
            {
                GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext();
                var lst = (from a in db.GdEmpleadosFml
                           join b in db.GD_EmpleadosFML_Accesos on a.IdEmpleadoFml equals b.IdEmpleadoFML
                           let NombreCompleto = a.Nombre + " | " + b.Usuario
                           orderby a.IdEmpleadoFml
                           select new { a.IdEmpleadoFml, NombreCompleto }
                           ).Distinct().ToList();

                //foreach (var elemento in lst)
                //{
                //    cmbUsuarios.Items.Add(elemento);
                //}

                cmbUsuarios.DisplayMember = "NombreCompleto";
                cmbUsuarios.ValueMember = "IdEmpleadoFML";
                cmbUsuarios.DataSource = lst;
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        #endregion

        #region "Control de Eventos"
        private void TxtIntroduzcaTexto_TextChanged(object sender, EventArgs e)
        {
            CargarGrid(txtIntroduzcaTexto.Text);
            FormatearGrid();
        }

        private void BtnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            try
            {
                txtIntroduzcaTexto.Text = String.Empty;
                txtIntroduzcaTexto.Focus();
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        #endregion
    }
}

