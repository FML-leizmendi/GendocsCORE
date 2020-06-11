using GendocsController;
using GendocsModeloDatos.models;
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
        public clsRecursos CRec { get; set; }

        public FrmRecursos(clsRecursos crec)
        {
            CRec = crec;
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
            G3Forms.CargarParam(this, this.Name + "_");
            //HabilitarBotonera();
        }

        private void BtnLimpiarFiltros_Click(object sender, EventArgs e)
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
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        private void BtnProhibidos_Click(object sender, EventArgs e)
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
                _ = ex.Message;
            }
        }


        private void BtnHabilitarProhibidos_Click(object sender, EventArgs e)
        {
            try
            {
                clsRecursos CRecu = new clsRecursos();
                using GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext();
                List<int> miLista = new List<int>();
                for (int i = 0; i < dgvRecursos.SelectedRows.Count; i++)
                {
                    miLista.Add(Convert.ToInt32(dgvRecursos.SelectedRows[i].Cells["IdRecurso"].Value));
                }
                CRecu.lstId = miLista;

                if (btnProhibidos.Text.Contains("MOSTRAR"))
                {
                    DialogResult result = MessageBox.Show("¿Marcar " + dgvRecursos.SelectedRows.Count + " recurso/s como PROHIBIDO/S?", "Recursos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        CRecu.EsProhibido = true;
                        CRecu.ModificarProhibidos();
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("¿Marcar " + dgvRecursos.SelectedRows.Count + " recurso/s como NO PROHIBIDO/S?", "Recursos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        CRecu.EsProhibido = false;
                        CRecu.ModificarProhibidos();
                    }
                }
                miLista = null;
                CargarGrid(txtIntroduzcaTexto.Text, EsProhibido);
                FormatearGrid();
                ColorearGrid();
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
                clsRecursos CRecu = new clsRecursos();

                DialogResult result = MessageBox.Show("¿Desea eliminar el recurso seleccionado?", "Recursos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    CRecu.IdRecurso = Convert.ToInt32(dgvRecursos.CurrentRow.Cells["IdRecurso"].Value);
                    CRecu.EliminarRecurso();
                }
                CargarGrid(txtIntroduzcaTexto.Text, EsProhibido);
                FormatearGrid();
                ColorearGrid();

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
                clsRecursos CRec = new clsRecursos();
                using GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext();
                var lst = (from d in db.GdRecursos
                           where (d.CodRecurso.Contains(txtIntroduzcaTexto.Text) || d.RecursoContratacion.Contains(txtIntroduzcaTexto.Text))
                           select d.IdRecurso

                       ).ToList();

                CRec.lstId = lst;
                CRec.CargarFrmMantenimientoRecursos();
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            if (cmbActivos.SelectedIndex == -1 || cmbActivos.SelectedIndex == 0)
            {
                MessageBox.Show("Debe seleccionar un recurso activo antes de continuar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbActivos.Focus();
            }
            else
            {
                clsRecursos CRec = new clsRecursos
                {
                    EsAlta = true,
                    IdRecursosActivo = ((GendocsModeloDatos.models.GdRecursosActivos)cmbActivos.SelectedItem).IdRecursosActivo
                };
                CRec.CargarFrmMantenimientoRecursos();
            }
        }
        #endregion

        #region "Métodos Privados"

        private List<GdColumnasD> CargarConfiguarcionIncial()
        {
            List<GdColumnasD> ListaInicial = new List<GdColumnasD>();
            try
            {
                int numColC = G3.DimeIdColumnaC((int)G3.IdEmpleadoFML_Logged, this.dgvRecursos.Name);
                ListaInicial.Add(new GdColumnasD() { IdColumnaC = numColC, NumCol = 0, NameField = "IdRecurso", Ancho = 0, OrderBy = "A", Visible = false });
                ListaInicial.Add(new GdColumnasD() { IdColumnaC = numColC, NumCol = 1, NameField = "Area", Ancho = 0, OrderBy = "A", Visible = false });
                ListaInicial.Add(new GdColumnasD() { IdColumnaC = numColC, NumCol = 2, NameField = "Activo", Ancho = 0, OrderBy = "A", Visible = false });
                ListaInicial.Add(new GdColumnasD() { IdColumnaC = numColC, NumCol = 3, NameField = "CodRecurso", Ancho = 300, OrderBy = "A", Visible = true });
                ListaInicial.Add(new GdColumnasD() { IdColumnaC = numColC, NumCol = 4, NameField = "RecursoContratacion", Ancho = 750, OrderBy = "A", Visible = true });
                ListaInicial.Add(new GdColumnasD() { IdColumnaC = numColC, NumCol = 5, NameField = "Unidad", Ancho = 250, OrderBy = "A", Visible = true });
                ListaInicial.Add(new GdColumnasD() { IdColumnaC = numColC, NumCol = 6, NameField = "CosteTotal", Ancho = 350, OrderBy = "A", Visible = true });
                ListaInicial.Add(new GdColumnasD() { IdColumnaC = numColC, NumCol = 7, NameField = "IdCliente", Ancho = 0, OrderBy = "A", Visible = false });
                ListaInicial.Add(new GdColumnasD() { IdColumnaC = numColC, NumCol = 8, NameField = "Orden", Ancho = 0, OrderBy = "A", Visible = false });
                ListaInicial.Add(new GdColumnasD() { IdColumnaC = numColC, NumCol = 9, NameField = "IdRecursosArea", Ancho = 0, OrderBy = "A", Visible = false });
                ListaInicial.Add(new GdColumnasD() { IdColumnaC = numColC, NumCol = 10, NameField = "IdRecursosActivo", Ancho = 0, OrderBy = "A", Visible = false });
                ListaInicial.Add(new GdColumnasD() { IdColumnaC = numColC, NumCol = 11, NameField = "Prohibido", Ancho = 0, OrderBy = "A", Visible = false });
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
            return ListaInicial;
        }


        private void FormatearGrid()
        {
            try
            {
                List<GdColumnasD> ListaInicial = new List<GdColumnasD>();
                // Comprobamos si el usuario tiene registros guardados en la tabla ColumnaC, en caso de que no los guardamos
                GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext();
                if (G3.DimeIdColumnaC(G3.IdEmpleadoFML_Logged, this.dgvRecursos.Name) == 0)
                {
                    GdColumnasC colC = new GdColumnasC
                    {
                        ListName = this.dgvRecursos.Name,
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
                    this.dgvRecursos.Columns["IdRecurso"].Visible = false;
                    this.dgvRecursos.Columns["Area"].Visible = false;
                    this.dgvRecursos.Columns["Activo"].Visible = false;
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
                }
                else
                {
                    var lstFiltro = (from a in db.GdColumnasD
                                     where a.IdColumnaC == G3.DimeIdColumnaC((int)G3.IdEmpleadoFML_Logged, this.dgvRecursos.Name)
                                     select a).ToList();

                    if (lstFiltro.Count() != 0)
                    {
                        foreach (var item in lstFiltro)
                        {
                            this.dgvRecursos.Columns[item.NameField].Visible = item.Visible;
                            if (Convert.ToInt32(item.Ancho) > 0)
                            {
                                this.dgvRecursos.Columns[item.NameField].Width = Convert.ToInt32(item.Ancho);
                            }
                            else
                                this.dgvRecursos.Columns[item.NameField].Visible = false;
                        }
                    }
                }

                ////Alinear las columnas 
                dgvRecursos.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvRecursos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvRecursos.Columns["RecursoContratacion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgvRecursos.Columns["CosteTotal"].DefaultCellStyle.Format = "C2";
                //dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;          
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }


        private void CargarGrid(String TextoIntroducido = "", bool EsProhibido = false)
        {
            try
            {
                using GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext();
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
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        private void CargarComboAreas()
        {
            List<GendocsModeloDatos.models.GdRecursosAreas> lista = new List<GendocsModeloDatos.models.GdRecursosAreas>
            {
                new GendocsModeloDatos.models.GdRecursosAreas()
                {
                    IdRecursosArea = 0,
                    Area = "Todos"
                }
            };

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
                List<GendocsModeloDatos.models.GdRecursosActivos> lista = new List<GendocsModeloDatos.models.GdRecursosActivos>
                {
                    new GendocsModeloDatos.models.GdRecursosActivos()
                    {
                        IdRecursosArea = 0,
                        Activo = "Todos"
                    }
                };

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
                _ = ex.Message;
            }
        }


        #endregion

        #region "Control de Eventos"
        private void CmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbArea.SelectedIndex = -1;
            cmbActivos.SelectedIndex = -1;
            CargarGrid(txtIntroduzcaTexto.Text, EsProhibido);
            FormatearGrid();
        }

        private void CmbArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarComboActivos();
            cmbActivos.SelectedIndex = 0;
            CargarGrid(txtIntroduzcaTexto.Text, EsProhibido);
            FormatearGrid();
        }

        private void CmbActivos_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarGrid(txtIntroduzcaTexto.Text, EsProhibido);
            Validate();
            FormatearGrid();
        }

        private void TxtIntroduzcaTexto_TextChanged(object sender, EventArgs e)
        {
            CargarGrid(txtIntroduzcaTexto.Text, EsProhibido);
            FormatearGrid();
            ColorearGrid();
        }

        #endregion

        private void FrmRecursos_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                using GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext();
                foreach (DataGridViewColumn itemCol in dgvRecursos.Columns)
                {
                    var query = (from a in db.GdColumnasD
                                 where a.IdColumnaC == G3.DimeIdColumnaC(G3.IdEmpleadoFML_Logged, this.dgvRecursos.Name) && a.NameField.Equals(itemCol.Name)
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
    }
}
