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
        public clsProyectos cProy { get; set; }

        public static string RutaGlobal { get; set; } = @"C:\Gendocs\Proyectos";

        public FrmExpedientes(clsProyectos cpro)
        {
            cProy = cpro;
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
                txtCodExpediente.Text = cProy.CodigoProyecto.ToString();
                txtCarpeta.Text = RutaGlobal;
                txtCarpetaBase.Text = cProy.CarpetaBase;
                txtTituloCorto.Text = cProy.TituloCorto;
                txtTitulo.Text = cProy.Titulo;
                txtAlias.Text = cProy.Alias;
                txtProvincia.Text = cProy.Provincia;
                txtTerminoMunicipal.Text = cProy.TerminoMunicipal;
                cmbEstadoProyecto.SelectedValue = Convert.ToInt32(cProy.IdProyectoEstado);
                switch (cProy.TipoProyecto.ToString())
                {
                    case "BT":
                        cmbTipoExpediente.SelectedValue = 1;
                        break;
                    case "MT":
                        cmbTipoExpediente.SelectedValue = 2;
                        break;
                    case "AT":
                        cmbTipoExpediente.SelectedValue = 3;
                        break;
                    case "Ca":
                        cmbTipoExpediente.SelectedValue = 4;
                        break;
                    case "Ot":
                        cmbTipoExpediente.SelectedValue = 5;
                        break;
                    default:
                        cmbTipoExpediente.SelectedValue = 0;
                        break;
                }
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
                string mensaje = ex.Message;
            }    
        }
    }
}



//bool validarControles()
//{
//    bool EsValido = true;
//    string cadena = "Faltan los siguientes campos obligatorios:" + Environment.NewLine;
//    try
//    {
//        if (txtNIF.Text == string.Empty)
//        {
//            cadena += "NIF " + Environment.NewLine;
//            txtNIF.Focus();
//            EsValido = false;
//        }
//        if (txtNombre.Text == string.Empty)
//        {
//            cadena += "Nombre " + Environment.NewLine;
//            txtNombre.Focus();
//            EsValido = false;
//        }
//        if (txtApellidos.Text == string.Empty)
//        {
//            cadena += "Apellidos " + Environment.NewLine;
//            txtApellidos.Focus();
//            EsValido = false;
//        }
//        if (txtTelefono.Text == string.Empty)
//        {
//            cadena += "Teléfono " + Environment.NewLine;
//            txtTelefono.Focus();
//            EsValido = false;
//        }
//        if (txtEmail.Text == string.Empty)
//        {
//            cadena += "Email " + Environment.NewLine;
//            txtEmail.Focus();
//            EsValido = false;
//        }
//        if (!EsValido)
//        {
//            MessageBox.Show(cadena, "Empleados FML", MessageBoxButtons.OK, MessageBoxIcon.Information);
//        }
//    }
//    catch (Exception ex)
//    {
//        string mensaje = ex.Message;
//    }
//    return EsValido;
//}
#endregion

#region "Control de Eventos"

#endregion
