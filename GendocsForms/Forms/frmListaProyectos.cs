using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;

namespace GendocsForms
{
    public partial class FrmListaProyectos : Form
    {
        public static string TipoProyecto { get; set; } = string.Empty;

        public FrmListaProyectos()
        {
            InitializeComponent();
        }

        #region "Eventos Privados"
        private void FrmListaProyectos_Load(object sender, EventArgs e)
        {
            txtIntroduzcaTexto.Focus();
            CargarComboEstadosProyectos();
            CargarGrid();
            FormatearGrid();
            CargarComboAccesos();
            CargarComboUsuarios();
            lnklMetaframe.Links.Add(0, lnklMetaframe.Text.Length, "https://www5.iberdrola.com/logon/LogonPoint/tmindex.html");
        }
        private void btnCerrarForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region "Métodos Privados"
        private void FormatearGrid()
        {
            try
            {   //Ocultar una columna de un datagridview 
                this.dgvProyectos.Columns["IdProyecto"].Visible = false;

                //Modificar el ancho de una columna
                this.dgvProyectos.Columns["CodigoProyecto"].Width = 315;
                this.dgvProyectos.Columns["Alias"].Width = 450;
                this.dgvProyectos.Columns["TerminoMunicipal"].Width = 400;
                this.dgvProyectos.Columns["Gestor"].Width = 425;
                this.dgvProyectos.Columns["Responsable"].Width = 325;
                this.dgvProyectos.Columns["ProyectoEstado"].Width = 275;

                //Alinear las columnas 
                dgvProyectos.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvProyectos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //dgvProyectos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
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
                           select new { d.IdProyecto, d.CodigoProyecto, d.Alias, d.TipoProyecto, d.TerminoMunicipal, d.Gestor, d.Responsable, p.ProyectoEstado }

                           ).ToList();

                if (EstadoProyecto != 0)
                {
                    var lstFiltrada = (from d in db.GdProyectos
                                       join p in db.GdProyectoEstados on d.IdProyectoEstado equals p.IdProyectoEstado
                                       where (d.TipoProyecto.Contains(TipoProyecto) & ((d.CodigoProyecto.Contains(TextoIntroducido) || (d.Alias.Contains(TextoIntroducido))) & (d.IdProyectoEstado == EstadoProyecto)))
                                       select new { d.IdProyecto, d.CodigoProyecto, d.Alias, d.TipoProyecto, d.TerminoMunicipal, d.Gestor, d.Responsable, p.ProyectoEstado }
                                        ).ToList();

                    dgvProyectos.DataSource = lstFiltrada;
                }
                else
                    dgvProyectos.DataSource = lst;

            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }
        }


        private void CargarComboEstadosProyectos()
        {
            try
            {
                List<GendocsModeloDatos.models.GdProyectoEstados> lista = new List<GendocsModeloDatos.models.GdProyectoEstados>();
                lista.Add(new GendocsModeloDatos.models.GdProyectoEstados()
                {
                    IdProyectoEstado = 0,
                    ProyectoEstado = "Todos"
                });

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
                string mensaje = ex.Message;
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
                string mensaje = ex.Message;
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
                           select new { c.Acceso }).Distinct().ToList();

                cmbAccesos.DisplayMember = "Acceso";
                cmbAccesos.ValueMember = "IdAcceso";
                cmbAccesos.DataSource = lstFiltrada;
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
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
                else
                {
                    cnt.BackColor = Color.LightBlue;
                }
            }
        }

        #endregion

        #region "Control de evenetos"
        private void btnAT_Click(object sender, EventArgs e)
        {
            CambiarColorBotonSeleccionado(btnAT);
            TipoProyecto = "AT";
            CargarGrid(TipoProyecto, txtIntroduzcaTexto.Text, Convert.ToInt32(cmbEstadoProyecto.SelectedValue));
        }

        private void btnMediaTension_Click(object sender, EventArgs e)
        {
            CambiarColorBotonSeleccionado(btnMediaTension);
            TipoProyecto = "MT";
            CargarGrid(TipoProyecto, txtIntroduzcaTexto.Text, Convert.ToInt32(cmbEstadoProyecto.SelectedValue));
        }

        private void btnBajaTension_Click(object sender, EventArgs e)
        {
            CambiarColorBotonSeleccionado(btnBajaTension);
            TipoProyecto = "BT";
            CargarGrid(TipoProyecto, txtIntroduzcaTexto.Text, Convert.ToInt32(cmbEstadoProyecto.SelectedValue));
        }

        private void btnCartografia_Click(object sender, EventArgs e)
        {
            CambiarColorBotonSeleccionado(btnCartografia);
            TipoProyecto = "Ca";
            CargarGrid(TipoProyecto, txtIntroduzcaTexto.Text, Convert.ToInt32(cmbEstadoProyecto.SelectedValue));
        }

        private void btnOtros_Click(object sender, EventArgs e)
        {
            CambiarColorBotonSeleccionado(btnOtros);
            TipoProyecto = "Ot";
            CargarGrid(TipoProyecto, txtIntroduzcaTexto.Text, Convert.ToInt32(cmbEstadoProyecto.SelectedValue));
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            CambiarColorBotonSeleccionado(btnTodos);
            TipoProyecto = "";
            CargarGrid(TipoProyecto, txtIntroduzcaTexto.Text, Convert.ToInt32(cmbEstadoProyecto.SelectedValue));
        }

        private void cmbEstadoProyecto_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarGrid(TipoProyecto, txtIntroduzcaTexto.Text, Convert.ToInt32(cmbEstadoProyecto.SelectedValue));
        }

        private void txtIntroduzcaTexto_TextChanged(object sender, EventArgs e)
        {
            CargarGrid(TipoProyecto, txtIntroduzcaTexto.Text, Convert.ToInt32(cmbEstadoProyecto.SelectedValue));
        }


        #endregion

        private void dgvProyectos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvProyectos.CurrentRow != null)
                {
                    clsProyectos clsProy = new clsProyectos();
                    clsProy.IdProyecto = Convert.ToInt32(dgvProyectos.CurrentRow.Cells["IdProyecto"].Value);
                    clsProy.CargarFrmExpedientes();
                }
                else
                    MessageBox.Show("Debe seleccionar un proyecto para poder continuar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
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
                string mensaje = ex.Message;
            }
        }

        private void dgvProyectos_CurrentCellChanged(object sender, EventArgs e)
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
                string mensaje = ex.Message;
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

        private void lnklMetaframe_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                // Navigate to a URL.
                // System.Diagnostics.Process.Start("https://www5.iberdrola.com/logon/LogonPoint/tmindex.html");
                //lnklMetaframe.LinkVisited = true;
                ProcessStartInfo sinfo = new ProcessStartInfo(e.Link.LinkData.ToString());
                Process.Start("chrome.exe");
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }

        }

        private void cmbUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int IdEmpleadoFML = Convert.ToInt32(cmbUsuarios.SelectedValue);
                CargarComboAccesos(IdEmpleadoFML);
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }

        }

        private void cmbAccesos_SelectedIndexChanged(object sender, EventArgs e)
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
                string mensaje = ex.Message;
            }

        }

        private void txtUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                txtUsuario.SelectionStart = 0;
                txtUsuario.SelectionLength = txtUsuario.Text.Length;
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }
        }

        private void txtContraseña_Click(object sender, EventArgs e)
        {
            try
            {
                txtContraseña.SelectionStart = 0;
                txtContraseña.SelectionLength = txtContraseña.Text.Length;
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }
        }
    }
}
