﻿using GendocsModeloDatos.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GendocsForms
{
    public partial class FrmListaProyectos : Form
    {
        public static string TipoProyecto { get; set; } = string.Empty;
        public string NombreGrid = string.Empty;
        public int IdEmpFML = 0;

        public FrmListaProyectos()
        {
            InitializeComponent();
        }

        #region "Eventos Privados"
        private void FrmListaProyectos_Load(object sender, EventArgs e)
        {
            txtIntroduzcaTexto.Focus();
            CargarGrid();
            FormatearGrid();
            CargarComboEstadosProyectos();
            CargarComboAccesos();
            CargarComboUsuarios();
        }
        private void BtnCerrarForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DgvProyectos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvProyectos.CurrentRow != null)
                {
                    ClsProyecto clsProy = new ClsProyecto
                    {
                        IdProyecto = Convert.ToInt32(dgvProyectos.CurrentRow.Cells["IdProyecto"].Value)
                    };
                    clsProy.CargarFrmExpedientes();
                }
                else
                    MessageBox.Show("Debe seleccionar un proyecto para poder continuar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        private void BtnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            try
            {
                txtIntroduzcaTexto.Text = string.Empty;
                cmbEstadoProyecto.SelectedIndex = 0;
                CargarGrid(txtIntroduzcaTexto.Text);
                FormatearGrid();
                CambiarColorBotonSeleccionado(btnTodos);
                txtIntroduzcaTexto.Focus();
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        private void DgvProyectos_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvProyectos.CurrentRow != null)
                {
                    txtCodProyecto.Text = dgvProyectos.CurrentRow.Cells["CodigoProyecto"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        private void SeleccionarTextoTextBox(object sender, System.EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtCodProyecto.Text))
            {
                txtCodProyecto.SelectionStart = 0;
                txtCodProyecto.SelectionLength = txtCodProyecto.Text.Length;
            }
        }

        private void LnklMetaframe_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Utiles.AbrirArchivo("https://www5.iberdrola.com/logon/LogonPoint/tmindex.html");
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

        private void TxtUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                txtUsuario.SelectionStart = 0;
                txtUsuario.SelectionLength = txtUsuario.Text.Length;
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        private void TxtContraseña_Click(object sender, EventArgs e)
        {
            try
            {
                txtContraseña.SelectionStart = 0;
                txtContraseña.SelectionLength = txtContraseña.Text.Length;
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

        private void DgvProyectos_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
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
                FrmConfigPedido frm = new FrmConfigPedido
                {
                    //frm.IdEmpFML = Utiles.IdEmpleadoFML;
                    NombreGrid = this.dgvProyectos.Name
                };
                frm.ShowDialog();
                CargarGrid();
                FormatearGrid();
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        private void FrmListaProyectos_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                using GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext();
                foreach (DataGridViewColumn itemCol in dgvProyectos.Columns)
                {
                    var query = (from a in db.GdColumnasD
                                 where a.IdColumnaC == Utiles.DimeIdColumnaC(Utiles.IdEmpleadoFML, NombreGrid) && a.NameField.Equals(itemCol.Name)
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
                    //else
                    //{
                    //    GdColumnasD colD = new GdColumnasD
                    //    {
                    //        IdColumnaC = Utiles.NumColumna(IdEmpFML, NombreGrid),                           
                    //        NumCol =5,
                    //        NameField = itemCol.Name,
                    //        Ancho = itemCol.Width,
                    //        OrderBy = "A",
                    //        Visible = itemCol.Visible
                    //    };

                    //    db.GdColumnasD.Add(colD);
                    //    db.SaveChanges();
                    //}

                }
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        #endregion

        #region "Métodos Privados"
        private List<GdColumnasD> CargarConfiguarcionIncial()
        {
            List<GdColumnasD> ListaInicial = new List<GdColumnasD>();
            try
            {
                int numColC = Utiles.DimeIdColumnaC(IdEmpFML, NombreGrid);
                ListaInicial.Add(new GdColumnasD() { IdColumnaC = numColC, NumCol = 0, NameField = "IdProyectoEstado", Ancho = 0, OrderBy = "A", Visible = false });
                ListaInicial.Add(new GdColumnasD() { IdColumnaC = numColC, NumCol = 1, NameField = "CodigoProyecto", Ancho = 145, OrderBy = "A", Visible = true });
                ListaInicial.Add(new GdColumnasD() { IdColumnaC = numColC, NumCol = 2, NameField = "Alias", Ancho = 235, OrderBy = "A", Visible = true });
                ListaInicial.Add(new GdColumnasD() { IdColumnaC = numColC, NumCol = 3, NameField = "TipoProyecto", Ancho = 100, OrderBy = "A", Visible = true });
                ListaInicial.Add(new GdColumnasD() { IdColumnaC = numColC, NumCol = 4, NameField = "TerminoMunicipal", Ancho = 250, OrderBy = "A", Visible = true });
                ListaInicial.Add(new GdColumnasD() { IdColumnaC = numColC, NumCol = 5, NameField = "Gestor", Ancho = 275, OrderBy = "A", Visible = true });
                ListaInicial.Add(new GdColumnasD() { IdColumnaC = numColC, NumCol = 6, NameField = "Responsable", Ancho = 225, OrderBy = "A", Visible = true });
                ListaInicial.Add(new GdColumnasD() { IdColumnaC = numColC, NumCol = 7, NameField = "Provincia", Ancho = 120, OrderBy = "A", Visible = true });
                ListaInicial.Add(new GdColumnasD() { IdColumnaC = numColC, NumCol = 8, NameField = "EmailResponsable", Ancho = 100, OrderBy = "A", Visible = false });
                ListaInicial.Add(new GdColumnasD() { IdColumnaC = numColC, NumCol = 9, NameField = "ProyectoEstado", Ancho = 210, OrderBy = "A", Visible = true });
                ListaInicial.Add(new GdColumnasD() { IdColumnaC = numColC, NumCol = 10, NameField = "IdProyecto", Ancho = 0, OrderBy = "A", Visible = false });
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
                NombreGrid = this.dgvProyectos.Name;
                IdEmpFML = Utiles.IdEmpleadoFML;
                List<GdColumnasD> ListaInicial = new List<GdColumnasD>();
                // Comprobamos si el usuario tiene registros guardados en la tabla ColumnaC, en caso de que no los guardamos
                GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext();
                if (Utiles.DimeIdColumnaC(IdEmpFML, NombreGrid) == 0)
                {
                    GdColumnasC colC = new GdColumnasC
                    {
                        ListName = this.dgvProyectos.Name,
                        IdEmpleadoFMl = this.IdEmpFML
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

                    //Y se le asigna la configuración inicial del DataGridView
                    this.dgvProyectos.Columns["IdProyecto"].Visible = false;
                    this.dgvProyectos.Columns["EmailResponsable"].Visible = false;

                    //DataGridViewImageColumn columna = new DataGridViewImageColumn();
                    //columna.Name = "Imagen";
                    //dgvProyectos.Columns.Add(columna);
                    //dgvProyectos.Rows[0].Cells["Imagen"].Value = Image.FromFile(@"C:\Users\Alex Mota\source\repos\GendocsCORE\GendocsForms\Resources\fml_ingenieria_logo_194x89");

                    //Modificar el ancho de una columna
                    this.dgvProyectos.Columns["CodigoProyecto"].Width = 145;
                    //this.dgvProyectos.Columns["CodigoProyecto"].c = 145;
                    this.dgvProyectos.Columns["Alias"].Width = 235;
                    this.dgvProyectos.Columns["TerminoMunicipal"].Width = 250;
                    this.dgvProyectos.Columns["Gestor"].Width = 275;
                    this.dgvProyectos.Columns["Responsable"].Width = 225;
                    this.dgvProyectos.Columns["ProyectoEstado"].Width = 210;
                    this.dgvProyectos.Columns["Provincia"].Width = 120;
                    this.dgvProyectos.Columns["TipoProyecto"].Width = 100;
                }
                else
                {
                    var lstFiltro = (from a in db.GdColumnasD
                                     where a.IdColumnaC == Utiles.DimeIdColumnaC(IdEmpFML, NombreGrid)
                                     select a).ToList();

                    if (lstFiltro.Count != 0)
                    {
                        foreach (var item in lstFiltro)
                        {
                            if (item.NameField == "IdProyectoEstado")
                            {
                                this.dgvProyectos.Columns["ProyectoEstado"].Visible = item.Visible;
                                this.dgvProyectos.Columns["ProyectoEstado"].Width = Convert.ToInt32(item.Ancho);
                            }
                            else if (item.NameField == "Provincia")
                            {
                                this.dgvProyectos.Columns["Provincia"].Visible = item.Visible;
                                this.dgvProyectos.Columns["Provincia"].Width = Convert.ToInt32(item.Ancho);
                            }
                            else
                            {
                                this.dgvProyectos.Columns[item.NameField].Visible = item.Visible;
                                if (Convert.ToInt32(item.Ancho) > 0)
                                {
                                    this.dgvProyectos.Columns[item.NameField].Width = Convert.ToInt32(item.Ancho);
                                }
                                else
                                    this.dgvProyectos.Columns[item.NameField].Visible = false;
                            }
                        }
                    }
                }

                //Alinear las columnas 
                dgvProyectos.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvProyectos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //dgvProyectos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }

            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        private void CargarGrid(String TipoProyecto = "", String TextoIntroducido = "", int EstadoProyecto = 0)
        {
            try
            {
                GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext();
                var lst = (from d in db.GdProyectos
                           join p in db.GdProyectoEstados on d.IdProyectoEstado equals p.IdProyectoEstado
                           where (d.TipoProyecto.Contains(TipoProyecto) & (d.CodigoProyecto.Contains(TextoIntroducido) ||
                                  d.TipoProyecto.Contains(TipoProyecto) & (d.Alias.Contains(TextoIntroducido)) ||
                                  d.TipoProyecto.Contains(TipoProyecto) & (d.IdProyectoEstado == EstadoProyecto)))

                           select new { d.IdProyecto, d.CodigoProyecto, d.Alias, d.TipoProyecto, d.TerminoMunicipal, d.Gestor, d.Responsable, d.Provincia, d.EmailResponsable, p.ProyectoEstado }

                           ).ToList();

                if (EstadoProyecto != 0)
                {
                    var lstFiltrada = (from d in db.GdProyectos
                                       join p in db.GdProyectoEstados on d.IdProyectoEstado equals p.IdProyectoEstado
                                       where (d.TipoProyecto.Contains(TipoProyecto) & ((d.CodigoProyecto.Contains(TextoIntroducido) || (d.Alias.Contains(TextoIntroducido))) & (d.IdProyectoEstado == EstadoProyecto)))
                                       select new { d.IdProyecto, d.CodigoProyecto, d.Alias, d.TipoProyecto, d.TerminoMunicipal, d.Gestor, d.Responsable, p.ProyectoEstado }
                                        ).ToList();

                    DataTable dtFilrado = Utiles.ToDataTable(lstFiltrada);

                    dgvProyectos.DataSource = dtFilrado;
                }
                else
                {
                    DataTable dt = Utiles.ToDataTable(lst);
                    dgvProyectos.DataSource = dt;
                }


            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }


        private void CargarComboEstadosProyectos()
        {
            try
            {
                List<GendocsModeloDatos.models.GdProyectoEstados> lista = new List<GendocsModeloDatos.models.GdProyectoEstados>
                {
                    new GendocsModeloDatos.models.GdProyectoEstados()
                    {
                        IdProyectoEstado = 0,
                        ProyectoEstado = "Todos"
                    }
                };

                GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext();
                List<GendocsModeloDatos.models.GdProyectoEstados> lstEstadoProyectos;
                lstEstadoProyectos = db.GdProyectoEstados.Select(e => new GendocsModeloDatos.models.GdProyectoEstados()
                {
                    IdProyectoEstado = e.IdProyectoEstado,
                    ProyectoEstado = e.ProyectoEstado
                }
                ).ToList();

                lista.AddRange(lstEstadoProyectos);

                cmbEstadoProyecto.DisplayMember = "ProyectoEstado";
                cmbEstadoProyecto.ValueMember = "IdProyectoEstado";
                cmbEstadoProyecto.DataSource = lista;
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

        private void CambiarColorBotonSeleccionado(Button button)
        {
            foreach (Control cnt in this.pnlLateral.Controls)
            {
                if (cnt is Button && cnt == button)
                {
                    cnt.BackColor = Color.Yellow;
                }
                else if (cnt is Label || cnt is PictureBox)
                {

                }
                else
                {
                    cnt.BackColor = Color.LightBlue;
                }
            }
        }

        #endregion

        #region "Control de evenetos"
        private void BtnAT_Click(object sender, EventArgs e)
        {
            CambiarColorBotonSeleccionado(btnAT);
            TipoProyecto = "AT";
            CargarGrid(TipoProyecto, txtIntroduzcaTexto.Text, Convert.ToInt32(cmbEstadoProyecto.SelectedValue));
        }

        private void BtnMediaTension_Click(object sender, EventArgs e)
        {
            CambiarColorBotonSeleccionado(btnMediaTension);
            TipoProyecto = "MT";
            CargarGrid(TipoProyecto, txtIntroduzcaTexto.Text, Convert.ToInt32(cmbEstadoProyecto.SelectedValue));
        }

        private void BtnBajaTension_Click(object sender, EventArgs e)
        {
            CambiarColorBotonSeleccionado(btnBajaTension);
            TipoProyecto = "BT";
            CargarGrid(TipoProyecto, txtIntroduzcaTexto.Text, Convert.ToInt32(cmbEstadoProyecto.SelectedValue));
        }

        private void BtnCartografia_Click(object sender, EventArgs e)
        {
            CambiarColorBotonSeleccionado(btnCartografia);
            TipoProyecto = "Ca";
            CargarGrid(TipoProyecto, txtIntroduzcaTexto.Text, Convert.ToInt32(cmbEstadoProyecto.SelectedValue));
        }

        private void BtnOtros_Click(object sender, EventArgs e)
        {
            CambiarColorBotonSeleccionado(btnOtros);
            TipoProyecto = "Ot";
            CargarGrid(TipoProyecto, txtIntroduzcaTexto.Text, Convert.ToInt32(cmbEstadoProyecto.SelectedValue));
        }

        private void BtnTodos_Click(object sender, EventArgs e)
        {
            CambiarColorBotonSeleccionado(btnTodos);
            TipoProyecto = "";
            CargarGrid(TipoProyecto, txtIntroduzcaTexto.Text, Convert.ToInt32(cmbEstadoProyecto.SelectedValue));
        }

        private void CmbEstadoProyecto_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarGrid(TipoProyecto, txtIntroduzcaTexto.Text, Convert.ToInt32(cmbEstadoProyecto.SelectedValue));
        }

        private void TxtIntroduzcaTexto_TextChanged(object sender, EventArgs e)
        {
            CargarGrid(TipoProyecto, txtIntroduzcaTexto.Text, Convert.ToInt32(cmbEstadoProyecto.SelectedValue));
        }


        #endregion

    }
}
