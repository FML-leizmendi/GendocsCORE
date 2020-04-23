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
        public bool EsEdicion = false;
        public clsRecursos cRec { get; set; }

        public FrmRecursos(clsRecursos crec)
        {
            cRec = crec;
            InitializeComponent();
        }

        public FrmRecursos()
        {
            InitializeComponent();
        }

        #region "Eventos Privados"
        private void FrmRecursos_Load(object sender, EventArgs e)
        {
            CargarComboClientes();
            CargarComboAreas();
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
                this.dgvRecursos.Columns["Area"].Visible = false;
                this.dgvRecursos.Columns["Activo"].Visible = false;
                this.dgvRecursos.Columns["IdRecurso"].Visible = false;
                this.dgvRecursos.Columns["IdCliente"].Visible = false;
                this.dgvRecursos.Columns["Orden"].Visible = false;
                this.dgvRecursos.Columns["IdRecursosArea"].Visible = false;
                this.dgvRecursos.Columns["IdRecursosActivo"].Visible = false;
                this.dgvRecursos.Columns["Prohibido"].Visible = false;

                ////Modificar el ancho de una columna
                this.dgvRecursos.Columns["CodRecurso"].Width = 300;
                this.dgvRecursos.Columns["CodRecurso"].HeaderText = "Código Recurso";
                this.dgvRecursos.Columns["RecursoContratacion"].Width = 750;
                this.dgvRecursos.Columns["RecursoContratacion"].HeaderText = "Recurso Contratación";
                this.dgvRecursos.Columns["Unidad"].Width = 250;
                this.dgvRecursos.Columns["CosteTotal"].Width = 350;
                this.dgvRecursos.Columns["CosteTotal"].HeaderText = "Coste Total";

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
                        where (b.CodRecurso.Contains(TextoIntroducido) || b.RecursoContratacion.Contains(TextoIntroducido))
                        orderby c.IdCliente, c.Orden, a.Orden, b.CodRecurso
                        select new { b.IdRecurso, c.Area, a.Activo, b.CodRecurso, b.RecursoContratacion, b.Unidad, b.CosteTotal, c.IdCliente, c.Orden, c.IdRecursosArea, a.IdRecursosActivo, b.Prohibido }

                        ).ToList();

                    var listaFiltrada = lst.Where(i => (IdCliente != 0 && IdCliente == i.IdCliente) || IdCliente == 0)
                                           .Where(i => (IdArea != 0 && IdArea == i.IdRecursosArea) || IdArea == 0)
                                           .Where(i => (i.Prohibido == EsProhibido))
                                           .Where(i => (IdActivo != 0 && IdActivo == i.IdRecursosActivo) || IdActivo == 0).ToList();

                    dgvRecursos.DataSource = null;
                    dgvRecursos.DataSource = listaFiltrada;
                    //textBox1.Text = dgvRecursos.Rows.Count.ToString();

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

        private void HabilitarBotonera()
        {
            try
            {
                if (EsEdicion)
                {
                    PnlLateralPrincipal.Visible = true;
                    pnlLateralSecundario.Visible = false;
                }
                else
                {
                    PnlLateralPrincipal.Visible = false;
                    pnlLateralSecundario.Visible = true;
                }
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }
        }

        #endregion

        #region "Control de Eventos"

        #endregion

        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbArea.SelectedIndex = -1;
            cmbActivos.SelectedIndex = -1;
            CargarGrid(txtIntroduzcaTexto.Text, EsProhibido);
            FormatearGrid();
        }

        private void cmbArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarComboActivos();
            cmbActivos.SelectedIndex = 0;
            CargarGrid(txtIntroduzcaTexto.Text, EsProhibido);
            FormatearGrid();
        }

        private void cmbActivos_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarGrid(txtIntroduzcaTexto.Text, EsProhibido);
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
                if (btnProhibidos.Text.Contains("MOSTRAR"))
                {
                    EsProhibido = false;
                }
                else
                    EsProhibido = true;
                CargarGrid(txtIntroduzcaTexto.Text, EsProhibido);
                FormatearGrid();
                ColorearGrid();
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
                    btnHabilitarProhibidos.Text = "QUITAR DE PROHIBIDOS";
                    btnProhibidos.Image = imageList1.Images[0];
                }
                else
                {
                    EsProhibido = false;
                    txtIntroduzcaTexto.Text = string.Empty;
                    CargarGrid(txtIntroduzcaTexto.Text, EsProhibido);
                    btnProhibidos.Text = "MOSTRAR PROHIBIDOS";
                    btnHabilitarProhibidos.Text = "AÑADIR A PROHIBIDOS";
                    btnProhibidos.Image = imageList1.Images[1];
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

        private void btnHabilitarProhibidos_Click(object sender, EventArgs e)
        {
            try
            {
                clsRecursos cRecu = new clsRecursos();
                using (GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext())
                {
                    List<int> miLista = new List<int>();
                    for (int i = 0; i < dgvRecursos.SelectedRows.Count; i++)
                    {
                        miLista.Add(Convert.ToInt32(dgvRecursos.SelectedRows[i].Cells["IdRecurso"].Value));
                    }
                    cRecu.lstId = miLista;

                    if (btnProhibidos.Text.Contains("MOSTRAR"))
                    {
                        DialogResult result = MessageBox.Show("¿Marcar " + dgvRecursos.SelectedRows.Count + " recurso/s como PROHIBIDO/S?", "Recursos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            cRecu.EsProhibido = true;
                            cRecu.ModificarProhibidos();
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Marcar " + dgvRecursos.SelectedRows.Count + " recurso/s como NO PROHIBIDO/S?", "Recursos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            cRecu.EsProhibido = false;
                            cRecu.ModificarProhibidos();
                        }
                    }
                    miLista = null;
                    CargarGrid(txtIntroduzcaTexto.Text, EsProhibido);
                    FormatearGrid();
                    ColorearGrid();
                }
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }
        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                clsRecursos cRecu = new clsRecursos();

                DialogResult result = MessageBox.Show("¿Desea eliminar el recurso seleccionado?", "Recursos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    cRecu.IdRecurso = Convert.ToInt32(dgvRecursos.CurrentRow.Cells["IdRecurso"].Value);
                    cRecu.EliminarRecurso();
                }
                CargarGrid(txtIntroduzcaTexto.Text, EsProhibido);
                FormatearGrid();
                ColorearGrid();

            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                clsRecursos cRec = new clsRecursos();
                using (GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext())
                {
                    var lst = (from d in db.GdRecursos
                               where (d.CodRecurso.Contains(txtIntroduzcaTexto.Text) || d.RecursoContratacion.Contains(txtIntroduzcaTexto.Text))
                               select d.IdRecurso

                           ).ToList();

                    cRec.lstId = lst;
                    cRec.CargarFrmMantenimientoRecursos();
                }
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (cmbActivos.SelectedIndex == -1 || cmbActivos.SelectedIndex == 0)
            {
                MessageBox.Show("Debe seleccionar un recurso activo antes de continuar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbActivos.Focus();
            }
            else
            {
                clsRecursos cRec = new clsRecursos();
                cRec.EsAlta = true;
                cRec.IdRecursosActivo = ((GendocsModeloDatos.models.GdRecursosActivos)cmbActivos.SelectedItem).IdRecursosActivo;
                cRec.CargarFrmMantenimientoRecursos();
            }
                

        }
    }
}
