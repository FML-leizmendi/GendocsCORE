using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GendocsForms
{
    public partial class FrmRecursos : Form
    {
        bool EsProhibido = false;
        public FrmRecursos()
        {
            InitializeComponent();
        }

        #region "Eventos Privados"
        private void FrmRecursos_Load(object sender, EventArgs e)
        {
            CargarComboClientes();
            CargarComboAreas();
            //CargarComboActivos();
            CargarGrid();
            FormatearGrid();
            txtIntroduzcaTexto.Focus();
        }

        #endregion

        #region "Métodos Privados"

        private void FormatearGrid()
        {
            try
            {   //Ocultar una columna de un datagridview 
                this.dgvRecursos.Columns["Area"].Visible = false;
                this.dgvRecursos.Columns["Activo"].Visible = false;
                this.dgvRecursos.Columns["IdRecurso"].Visible = false;
                this.dgvRecursos.Columns["IdCliente"].Visible = false;
                this.dgvRecursos.Columns["Orden"].Visible = false;
                this.dgvRecursos.Columns["IdRecursosArea"].Visible = false;
                this.dgvRecursos.Columns["IdRecursosActivo"].Visible = false;

                ////Modificar el ancho de una columna
                this.dgvRecursos.Columns["CodRecurso"].Width = 500;
                this.dgvRecursos.Columns["RecursoContratacion"].Width = 1000;
                this.dgvRecursos.Columns["Unidad"].Width = 225;
                this.dgvRecursos.Columns["CosteTotal"].Width = 225;

                ////Alinear las columnas 
                dgvRecursos.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvRecursos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvRecursos.Columns["RecursoContratacion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgvRecursos.Columns["CosteTotal"].DefaultCellStyle.Format = "C2";
                //dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;              
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
                    int IdCliente = Convert.ToInt32(cmbClientes.SelectedValue);
                    int IdArea = Convert.ToInt32(cmbArea.SelectedValue);
                    int IdActivo = 0;
                    if (cmbActivos.SelectedItem != null)
                    {
                        IdActivo = (((GendocsModeloDatos.models.GdRecursosActivos)cmbActivos.SelectedItem).IdRecursosActivo);
                    }

                    var lst = (
                        from a in db.GdRecursosActivos
                        join b in db.GdRecursos on a.IdRecursosActivo equals b.IdRecursosActivo
                        join c in db.GdRecursosAreas on a.IdRecursosArea equals c.IdRecursosArea
                        where (b.CodRecurso.Contains(TextoIntroducido))
                        orderby c.IdCliente, c.Orden, a.Orden, b.CodRecurso
                        select new { b.IdRecurso, c.Area, a.Activo, b.CodRecurso, b.RecursoContratacion, b.Unidad, b.CosteTotal, c.IdCliente, c.Orden, c.IdRecursosArea, a.IdRecursosActivo, b.Prohibido }

                        ).ToList();

                    var listaFiltrada = lst.Where(i => (IdCliente != 0 && IdCliente == i.IdCliente) || IdCliente == 0)
                                           .Where(i => (IdArea != 0 && IdArea == i.IdRecursosArea) || IdArea == 0)
                                           .Where(i => (i.Prohibido == EsProhibido))
                                           .Where(i => (IdActivo != 0 && IdActivo == i.IdRecursosActivo) || IdActivo == 0).ToList();

                    dgvRecursos.DataSource = null;
                    dgvRecursos.DataSource = listaFiltrada;
                    textBox1.Text = dgvRecursos.Rows.Count.ToString();

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
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }
        }

        private void CargarComboAreas()
        {
            List<GendocsModeloDatos.models.GdRecursosAreas> lista = new List<GendocsModeloDatos.models.GdRecursosAreas>();
            lista.Add(new GendocsModeloDatos.models.GdRecursosAreas()
            {
                IdRecursosArea = 0,
                Area = "Todos"
            });

            GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext();
            List<GendocsModeloDatos.models.GdRecursosAreas> lstAreas;

            lstAreas = (from a in db.GdRecursosAreas
                        join b in db.GdClientes on a.IdCliente equals b.IdCliente
                        where (Convert.ToInt32(cmbClientes.SelectedValue) != 0 && Convert.ToInt32(cmbClientes.SelectedValue) == a.IdCliente || Convert.ToInt32(cmbClientes.SelectedValue) == 0)
                        select a
                        ).ToList();

            lista.AddRange(lstAreas);

            cmbArea.DisplayMember = "Area";
            cmbArea.ValueMember = "IdRecursosArea";
            cmbArea.DataSource = lista;
        }

        private void CargarComboActivos()
        {
            try
            {
                List<GendocsModeloDatos.models.GdRecursosActivos> lista = new List<GendocsModeloDatos.models.GdRecursosActivos>();
                lista.Add(new GendocsModeloDatos.models.GdRecursosActivos()
                {
                    IdRecursosArea = 0,
                    Activo = "Todos"
                });

                GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext();
                List<GendocsModeloDatos.models.GdRecursosActivos> lstActivos;

                lstActivos = (from a in db.GdRecursosAreas
                              join b in db.GdRecursosActivos on a.IdRecursosArea equals b.IdRecursosArea
                              where (Convert.ToInt32(cmbClientes.SelectedValue) != 0 && Convert.ToInt32(cmbClientes.SelectedValue) == a.IdCliente || Convert.ToInt32(cmbClientes.SelectedValue) == 0) &&
                              (Convert.ToInt32(cmbArea.SelectedValue) != 0 && Convert.ToInt32(cmbArea.SelectedValue) == a.IdRecursosArea || Convert.ToInt32(cmbArea.SelectedValue) == 0)
                              select b
                        ).ToList();

                lista.AddRange(lstActivos);

                cmbActivos.DisplayMember = "Activo";
                cmbActivos.ValueMember = "IdRecursosArea";
                cmbActivos.DataSource = lista;
            }
            catch (Exception ex)
            {
                String mensaje = ex.Message;
            }
        }

        #endregion

        #region "Control de Eventos"

        #endregion

        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbArea.SelectedIndex = -1;
            cmbActivos.SelectedIndex = -1;
            CargarGrid();
            FormatearGrid();
        }

        private void cmbArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarComboActivos();
            cmbActivos.SelectedIndex = 0;
            CargarGrid();
            FormatearGrid();
        }

        private void cmbActivos_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarGrid();
            Validate();
            FormatearGrid();
        }

        private void txtIntroduzcaTexto_TextChanged(object sender, EventArgs e)
        {
            CargarGrid(txtIntroduzcaTexto.Text, EsProhibido);
            FormatearGrid();
            ColorearGrid();
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            try
            {
                cmbActivos.SelectedIndex = 0;
                cmbArea.SelectedIndex = 0;
                cmbClientes.SelectedIndex = 0;
                txtIntroduzcaTexto.Text = String.Empty;
                CargarGrid();
                FormatearGrid();
                txtIntroduzcaTexto.Focus();
            }
            catch (Exception Ex)
            {
                string mensaje = Ex.Message;
            }
        }

        private void btnProhibidos_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnProhibidos.Text.Contains("MOSTRAR"))
                {
                    EsProhibido = true;
                    txtIntroduzcaTexto.Text = string.Empty;
                    CargarGrid(txtIntroduzcaTexto.Text, EsProhibido);
                    btnProhibidos.Text = "OCULTAR PROHIBIDOS";
                }
                else
                {
                    EsProhibido = false;
                    txtIntroduzcaTexto.Text = string.Empty;
                    CargarGrid(txtIntroduzcaTexto.Text, EsProhibido);
                    btnProhibidos.Text = "MOSTRAR PROHIBIDOS";
                }
                FormatearGrid();
                ColorearGrid();
                txtIntroduzcaTexto.Focus();
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }
        }

        public void ColorearGrid()
        {
            try
            {
                foreach (DataGridViewRow rowp in dgvRecursos.Rows)
                {
                    if (EsProhibido)
                    {
                        Color myRgbColor = new Color();
                        myRgbColor = Color.FromArgb(229, 115, 115);
                        dgvRecursos.Rows[rowp.Index].DefaultCellStyle.BackColor = myRgbColor;
                    }
                    else
                        dgvRecursos.Rows[rowp.Index].DefaultCellStyle.BackColor = Color.White;
                }
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }
        }
    }
}
