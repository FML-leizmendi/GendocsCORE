using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                //this.dgvEmpleados.Columns["IdProyecto"].Visible = false;
      
                //Modificar el ancho de una columna
                this.dgvProyectos.Columns["CodigoProyecto"].Width = 120;
                this.dgvProyectos.Columns["Alias"].Width = 200;
                this.dgvProyectos.Columns["TerminoMunicipal"].Width = 200;
                this.dgvProyectos.Columns["Gestor"].Width = 200;
                this.dgvProyectos.Columns["Responsable"].Width = 180;
                this.dgvProyectos.Columns["EstadoProyecto"].Width = 60;
                //Alinear las columnas 
                dgvProyectos.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvProyectos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvProyectos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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
                           where (d.TipoProyecto.Contains(TipoProyecto) & (d.CodigoProyecto.Contains(TextoIntroducido) || (d.Alias.Contains(TextoIntroducido) & (d.IdProyectoEstado == EstadoProyecto))))
                           select new { d.CodigoProyecto, d.Alias, d.TipoProyecto, d.TerminoMunicipal, d.Gestor, d.Responsable, p.ProyectoEstado }

                           ).ToList();

                if (EstadoProyecto != 0)
                {
                    var lstFiltrada = (from d in db.GdProyectos
                                       join p in db.GdProyectoEstados on d.IdProyectoEstado equals p.IdProyectoEstado
                                       where (d.TipoProyecto.Contains(TipoProyecto) & ((d.CodigoProyecto.Contains(TextoIntroducido) || (d.Alias.Contains(TextoIntroducido))) & (d.IdProyectoEstado == EstadoProyecto)))
                                       select new { d.CodigoProyecto, d.Alias, d.TipoProyecto, d.TerminoMunicipal, d.Gestor, d.Responsable, p.ProyectoEstado }
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


    }
}
