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

        //public static bool EsPrimerGarga { get; set; } = true;


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
            CargarEstilosBotonesLateral();
            CargarEstilosBotonera();
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
                this.dgvProyectos.Columns["CarpetaBase"].Visible = false;
                this.dgvProyectos.Columns["IdCliente"].Visible = false;
                this.dgvProyectos.Columns["Titulo"].Visible = false;
                this.dgvProyectos.Columns["TituloCorto"].Visible = false;
                this.dgvProyectos.Columns["Autor"].Visible = false;
                this.dgvProyectos.Columns["Colegiado"].Visible = false;
                this.dgvProyectos.Columns["Provincia"].Visible = false;
                this.dgvProyectos.Columns["LineaAereaSn"].Visible = false;
                this.dgvProyectos.Columns["LineaSubterraneaSn"].Visible = false;
                this.dgvProyectos.Columns["CentroTransformadorSn"].Visible = false;
                this.dgvProyectos.Columns["IdEmpleadoGestor"].Visible = false;
                this.dgvProyectos.Columns["EmailGestor"].Visible = false;

                this.dgvProyectos.Columns["IdEmpleadoResponsable"].Visible = false;
                this.dgvProyectos.Columns["EmailResponsable"].Visible = false;
                this.dgvProyectos.Columns["FModificado"].Visible = false;
                this.dgvProyectos.Columns["UModificado"].Visible = false;
                this.dgvProyectos.Columns["FCreado"].Visible = false;
                this.dgvProyectos.Columns["UCreado"].Visible = false;
                this.dgvProyectos.Columns["Notas"].Visible = false;
                this.dgvProyectos.Columns["Historico"].Visible = false;
                this.dgvProyectos.Columns["IdProyectoEstadoNavigation"].Visible = false;
                this.dgvProyectos.Columns["TipoProyectoNavigation"].Visible = false;
                this.dgvProyectos.Columns["NotasG"].Visible = false;
                this.dgvProyectos.Columns["GdPedidosCab"].Visible = false;

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
            catch

            {
                //Mostrar mensaje
            }
        }

        private void CargarGrid(String TipoProyecto = "", String TextoIntroducido = "", int EstadoProyecto = 0)
        {

            try
            {
                GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext();
                //var linq = from a in bd_alq.actor
                //           join p in bd_alq.pais on a.pais_ID equals p.pais_ID
                //           join dt in bd_alq.det_act_pel on dt.ID equals p.ID
                //           join x in bd_alq.otro on x.otro_ID equals a.otro_ID
                //           select;
                List<GendocsModeloDatos.models.GdProyectos> lst = (from d in db.GdProyectos
                                                                   join pEstados in db.GdProyectoEstados on d.IdProyectoEstado equals pEstados.IdProyectoEstado
                                                                   where (d.TipoProyecto.Contains(TipoProyecto) & (d.CodigoProyecto.Contains(TextoIntroducido) || (d.Alias.Contains(TextoIntroducido))))
                                                                   select d
                                                                    ).ToList();

                if (EstadoProyecto != 0)
                {
                    List<GendocsModeloDatos.models.GdProyectos> lstFiltrada = (from d in db.GdProyectos
                                                                               where (d.TipoProyecto.Contains(TipoProyecto) & ((d.CodigoProyecto.Contains(TextoIntroducido) || (d.Alias.Contains(TextoIntroducido)))  & (d.IdProyectoEstado == EstadoProyecto)))
                                                                               select d
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

                // lstEstadoProyectos = db.GdProyectos.Select(p => new GendocsModeloDatos.models.GdProyectos_Reducida());
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

        private void CargarEstilosBotonesLateral()
        {
            //GendocsForms.clsBordesRedondeados clsBordes = new GendocsForms.clsBordesRedondeados();
            foreach (Control cnt in this.pnlLateral.Controls)
            {
                if (cnt is Button)
                {
                    clsBordesRedondeados.RedondearBordeBoton(cnt);
                }
            }
        }

        private void CargarEstilosBotonera()
        {
            //GendocsForms.clsBordesRedondeados clsBordes = new GendocsForms.clsBordesRedondeados();
            foreach (Control cnt in this.flpBotonera.Controls)
            {
                if (cnt is Button)
                {
                    clsBordesRedondeados.RedondearBordeBoton(cnt);
                }
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
            //cmbEstadoProyecto.SelectedIndex = 0;
            CargarGrid(TipoProyecto, "", Convert.ToInt32(cmbEstadoProyecto.SelectedValue));
        }

        private void btnMediaTension_Click(object sender, EventArgs e)
        {
            CambiarColorBotonSeleccionado(btnMediaTension);
            TipoProyecto = "MT";
            //cmbEstadoProyecto.SelectedIndex = 0;
            CargarGrid(TipoProyecto, "", Convert.ToInt32(cmbEstadoProyecto.SelectedValue));
        }

        private void btnBajaTension_Click(object sender, EventArgs e)
        {
            CambiarColorBotonSeleccionado(btnBajaTension);
            TipoProyecto = "BT";
            //cmbEstadoProyecto.SelectedIndex = 0;
            CargarGrid(TipoProyecto, "", Convert.ToInt32(cmbEstadoProyecto.SelectedValue));
        }

        private void btnCartografia_Click(object sender, EventArgs e)
        {
            CambiarColorBotonSeleccionado(btnCartografia);
            TipoProyecto = "Ca";
            //cmbEstadoProyecto.SelectedIndex = 0;
            CargarGrid(TipoProyecto, "", Convert.ToInt32(cmbEstadoProyecto.SelectedValue));
        }

        private void btnOtros_Click(object sender, EventArgs e)
        {
            CambiarColorBotonSeleccionado(btnOtros);
            TipoProyecto = "Ot";
            //cmbEstadoProyecto.SelectedIndex = 0;
            CargarGrid(TipoProyecto, "", Convert.ToInt32(cmbEstadoProyecto.SelectedValue));
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            CambiarColorBotonSeleccionado(btnTodos);
            TipoProyecto = "";
           // cmbEstadoProyecto.SelectedIndex = 0;
            CargarGrid(TipoProyecto, "", Convert.ToInt32(cmbEstadoProyecto.SelectedValue));
        }

        #endregion

        private void cmbEstadoProyecto_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarGrid(TipoProyecto,txtIntroduzcaTexto.Text, Convert.ToInt32(cmbEstadoProyecto.SelectedValue));
        }

        //private void txtIntroduzcaTexto_lostFocus(object sender, EventArgs e)
        //{
        //    CargarGrid(TipoProyecto, txtIntroduzcaTexto.Text, Convert.ToInt32(cmbEstadoProyecto.SelectedValue));
        //}

        private void txtIntroduzcaTexto_TextChanged(object sender, EventArgs e)
        {
            CargarGrid(TipoProyecto, txtIntroduzcaTexto.Text, Convert.ToInt32(cmbEstadoProyecto.SelectedValue));
        }


        //private void txtIntroduzcaTexto_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    CargarGrid(TipoProyecto, txtIntroduzcaTexto.Text , Convert.ToInt32(cmbEstadoProyecto.SelectedValue));
        //}


    }
}
