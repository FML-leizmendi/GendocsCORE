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
                                       select new {d.IdProyecto, d.CodigoProyecto, d.Alias, d.TipoProyecto, d.TerminoMunicipal, d.Gestor, d.Responsable, p.ProyectoEstado }
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
            catch
            {

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
                    clsProy.IdProyecto  = Convert.ToInt32(dgvProyectos.CurrentRow.Cells["IdProyecto"].Value);
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
    }
}
