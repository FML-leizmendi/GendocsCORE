using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GendocsForms
{
    public partial class FrmMantenimientoRecursos : Form
    {
        public clsRecursos cRec { get; set; }

        public bool HanModificado = false;

        public FrmMantenimientoRecursos(clsRecursos crecu)
        {
            cRec = crecu;
            InitializeComponent();
        } 

        public FrmMantenimientoRecursos()
        {
            InitializeComponent();
        }

        #region "Eventos Privados"

        private void FrmMantenimientoRecursos_Load(object sender, EventArgs e)
        {
            //LimpiarControles();
            //CargarComboUnidad();
            //CargarComboProhibido();
            CargarForm();
            if (cRec.esNuevo == true)
            {
                OcultarBotonesNavegacion();
            }
            txtCodRecurso.Focus();
            cRec.EsAlta = true;
            HanModificado = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimpiarControles()
        {
            txtCodRecurso.Text = string.Empty;
            txtRecContratacion.Text = string.Empty;
            cmbUnidad.SelectedIndex = -1;
            cmbProhibido.SelectedIndex = -1;
            txtCosteManoObra.Text = string.Empty;
            txtCosteMateriales.Text = string.Empty;
            txtCosteTotal.Text = string.Empty;
        }
        #endregion

        #region "Métodos Privados"

        public void OcultarBotonesNavegacion()
        {
            try
            {
                btnPrimero.Visible = false;
                btnSiguiente.Visible = false;
                btnAnterior.Visible = false;
                btnUltimo.Visible = false;
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }
        }

        public void CargarForm()
        {
            try
            {
                txtCodRecurso.Text = cRec.CodRecurso;
                txtRecContratacion.Text = cRec.RecursoContratacion.ToString();
                txtCosteManoObra.Text = cRec.CosteManodeObra.ToString();
                txtCosteMateriales.Text = cRec.CosteMateriales.ToString();
                txtCosteTotal.Text = cRec.CosteTotal.ToString();
                //TODO
                //if (cRec.Unidad == null)
                //{
                //    cmbUnidad.SelectedValue = 0;
                //}
                //else
                //    cmbUnidad.SelectedValue = Convert.ToInt32(cRec.Unidad);
                //if (cRec.Prohibido == null)
                //{
                //    cmbProhibido.SelectedValue = 0;
                //}
                //else
                //    cmbProhibido.SelectedValue = Convert.ToInt32(cRec.Prohibido);
                HanModificado = false;
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }
        }

        bool validarControles()
        {
            bool EsValido = true;
            string cadena = "Faltan los siguientes campos obligatorios:" + Environment.NewLine;
            try
            {
                if (txtCodRecurso.Text == string.Empty)
                {
                    cadena += "Código Recurso " + Environment.NewLine;
                    txtCodRecurso.Focus();
                    EsValido = false;
                }
                if (txtRecContratacion.Text == string.Empty)
                {
                    cadena += "Teléfono " + Environment.NewLine;
                    txtRecContratacion.Focus();
                    EsValido = false;
                }
                if (cmbProhibido.SelectedIndex == 0)
                {
                    cadena += "Prohibido " + Environment.NewLine;
                    cmbProhibido.Focus();
                    EsValido = false;
                }
                if (cmbUnidad.SelectedIndex == 0)
                {
                    cadena += "Unidad " + Environment.NewLine;
                    cmbUnidad.Focus();
                    EsValido = false;
                }
                if (txtCosteManoObra.Text == string.Empty)
                {
                    cadena += "Coste de mano de obra " + Environment.NewLine;
                    txtCosteManoObra.Focus();
                    EsValido = false;
                }
                if (txtCosteMateriales.Text == string.Empty)
                {
                    cadena += "Coste de materiales " + Environment.NewLine;
                    txtCosteMateriales.Focus();
                    EsValido = false;
                }
                if (txtCosteTotal.Text == string.Empty)
                {
                    cadena += "Coste de total" + Environment.NewLine;
                    txtCosteTotal.Focus();
                    EsValido = false;
                }

                if (!EsValido)
                {
                    MessageBox.Show(cadena, "Empleados FML", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }
            return EsValido;
        }


        //private void CargarComboUnidad()
        //{
        //    try
        //    {
        //        List<GendocsModeloDatos.models.GdRecursos_Unidad> lista = new List<GendocsModeloDatos.models.GdRecursos_Unidad>();
        //        lista.Add(new GendocsModeloDatos.models.GdRecursos_Unidad()
        //        {
        //            IdUnidad = 0,
        //            Unidad = ""
        //        });

        //        GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext();
        //        List<GendocsModeloDatos.models.GdRecursos_Unidad> lstUnidades;
        //        lstUnidades = db.GdRecursos_Unidad.Select(e => new GendocsModeloDatos.models.GdRecursos_Unidad()
        //        {
        //            IdUnidad = e.IdUnidad,
        //            Unidad = e.Unidad
        //        }
        //        ).ToList();

        //        lista.AddRange(lstUnidades);

        //        cmbUnidad.DisplayMember = "Unidad";
        //        cmbUnidad.ValueMember = "IdUnidad";
        //        cmbUnidad.DataSource = lista;

        //    }
        //    catch (Exception ex)
        //    {
        //        string mensaje = ex.Message;
        //    }
        //}

        //private void CargarComboProhibido()
        //{
        //    try
        //    {
        //        List<GendocsModeloDatos.models.gdRecursos> lista = new List<GendocsModeloDatos.models.GdRecursos>();
        //        lista.Add(new GendocsModeloDatos.models.GdRecursos()
        //        {
        //            IdRecurso = 0,
        //            Prohibido = ""
        //        });

        //        GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext();
        //        List<GendocsModeloDatos.models.GdRecursos> lstProhibidos;
        //        lstProhibidos = db.GdRecursos.Select(e => new GendocsModeloDatos.models.GdRecursos()
        //        {
        //            IdRecurso = e.IdRecurso,
        //            Prohibido = e.Prohibido
        //        }
        //        ).ToList();

        //        lista.AddRange(lstProhibidos);

        //        cmbProhibido.DisplayMember = "Prohibido";
        //        cmbProhibido.ValueMember = "IdRecurso";
        //        cmbProhibido.DataSource = lista;

        //    }
        //    catch (Exception ex)
        //    {
        //        string mensaje = ex.Message;
        //    }
        //}

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (HanModificado)
            {
                if (validarControles())
                {
                    cRec.CodRecurso = txtCodRecurso.Text;
                    cRec.RecursoContratacion = txtRecContratacion.Text;
                    cRec.CosteManodeObra = Convert.ToDecimal(txtCosteManoObra.Text);
                    cRec.CosteMateriales = Convert.ToDecimal(txtCosteMateriales.Text);
                    cRec.CosteTotal = Convert.ToDecimal(txtCosteTotal.Text);
                    //cRec.Unidad = cmbUnidad.SelectedValue.ToString();
                    // TODO 
                    //if (cmbProhibido.SelectedValue.ToString = 0)
                    //{
                    //    cRec.Prohibido = false;
                    //}
                    //else
                    //    cRec.Prohibido = true;
                    cRec.EsAlta = false;
                    cRec.GuardarUsuario();
                }
            }
        }
        #endregion

        #region "Control de Eventos"

        private void txtCodRecurso_TextChanged(object sender, EventArgs e)
        {
            HanModificado = true;
        }

        private void txtRecContratacion_TextChanged(object sender, EventArgs e)
        {
            HanModificado = true;
        }

        private void txtCosteManoObra_TextChanged(object sender, EventArgs e)
        {
            HanModificado = true;
        }

        private void txtCosteMateriales_TextChanged(object sender, EventArgs e)
        {
            HanModificado = true;
        }

        private void txtCosteTotal_TextChanged(object sender, EventArgs e)
        {
            HanModificado = true;
        }

        private void cmbUnidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            HanModificado = true;
        }

        private void cmbProhibido_SelectedIndexChanged(object sender, EventArgs e)
        {
            HanModificado = true;
        }

        #endregion

        private void btnPrimero_Click_1(object sender, EventArgs e)
        {
            cRec.IrPrimero();
            CargarForm();
        }

        private void btnAnterior_Click_1(object sender, EventArgs e)
        {
            cRec.IrAnterior();
            CargarForm();
        }

        private void btnSiguiente_Click_1(object sender, EventArgs e)
        {
            cRec.IrSiguiente();
            CargarForm();
        }

        private void btnUltimo_Click_1(object sender, EventArgs e)
        {
            cRec.IrUltimo();
            CargarForm();
        }
    }
}

