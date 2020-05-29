using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GendocsForms
{
    public partial class FrmExpedientes : Form
    {
        public clsProyecto CProy { get; set; }

        public static string RutaGlobal { get; set; } = @"C:\Gendocs\Proyectos";

        public FrmExpedientes(clsProyecto cpro)
        {
            CProy = cpro;
            InitializeComponent();
        }

        public FrmExpedientes()
        {
            InitializeComponent();
        }

        #region "Eventos Privados"
        private void FrmExpedientes_Load(object sender, EventArgs e)
        {
            CargarComboEstadosProyectos();
            CargarComboTipoExpediente();
            CargarForm();
        }

        public void LimpiarControles()
        {
            txtCodExpediente.Text = String.Empty;
            cmbEstadoProyecto.SelectedIndex = -1;
            cmbTipoExpediente.SelectedIndex = -1;
            txtCarpeta.Text = string.Empty;
            txtCarpetaBase.Text = string.Empty;
            txtTitulo.Text = string.Empty;
            txtTituloCorto.Text = string.Empty;
            txtAlias.Text = string.Empty;
            txtProvincia.Text = string.Empty;
            txtTerminoMunicipal.Text = string.Empty;
        }

        #endregion

        #region "Métodos Privados"

        public void CargarForm()
        {
            try
            {
                txtCodExpediente.Text = CProy.CodigoProyecto.ToString();
                txtCarpeta.Text = RutaGlobal;
                txtCarpetaBase.Text = CProy.CarpetaBase;
                txtTituloCorto.Text = CProy.TituloCorto;
                txtTitulo.Text = CProy.Titulo;
                txtAlias.Text = CProy.Alias;
                txtProvincia.Text = CProy.Provincia;
                txtTerminoMunicipal.Text = CProy.TerminoMunicipal;
                cmbEstadoProyecto.SelectedValue = Convert.ToInt32(CProy.IdProyectoEstado);
                cmbTipoExpediente.SelectedValue = (CProy.TipoProyecto.ToString()) switch
                {
                    "BT" => 1,
                    "MT" => 2,
                    "AT" => 3,
                    "Ca" => 4,
                    "Ot" => 5,
                    _ => 0,
                };
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

        public void CargarComboTipoExpediente()
        {
            try
            {
                GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext();
                List<GendocsModeloDatos.models.GdProyectoTipos> lstProyectosTipo;
                lstProyectosTipo = db.GdProyectoTipos.Select(e => new GendocsModeloDatos.models.GdProyectoTipos()
                {
                    Orden = e.Orden,
                    CodTipoProyecto = e.CodTipoProyecto
                }
                ).ToList();

                cmbTipoExpediente.DisplayMember = "CodTipoProyecto";
                cmbTipoExpediente.ValueMember = "Orden";
                cmbTipoExpediente.DataSource = lstProyectosTipo;
            }
            catch(Exception ex)
            {
                _ = ex.Message;
            }    
        }
    }

    #endregion

        #region "Control de Eventos"

    #endregion
}
