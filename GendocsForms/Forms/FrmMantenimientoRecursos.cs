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
        public clsRecursos CRec { get; set; }

        public bool HanModificado = false;

        public FrmMantenimientoRecursos(clsRecursos crecu)
        {
            CRec = crecu;
            InitializeComponent();
        } 

        public FrmMantenimientoRecursos()
        {
            InitializeComponent();
        }

        #region "Eventos Privados"

        private void FrmMantenimientoRecursos_Load(object sender, EventArgs e)
        {
            //CargarComboUnidad();
            //CargarComboProhibido();
            if (CRec.esNuevo == true)
            {
                OcultarBotonesNavegacion();
            }
            if (CRec.EsAlta)
            {
                LimpiarControles();
            }
            else
                CargarForm();
            txtCodRecurso.Focus();
            HanModificado = false;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
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
                _ = ex.Message;
            }
        }

        public void CargarForm()
        {
            try
            {
                txtCodRecurso.Text = CRec.CodRecurso;
                txtRecContratacion.Text = CRec.RecursoContratacion.ToString();
                txtCosteManoObra.Text = CRec.CosteManodeObra.ToString();
                txtCosteMateriales.Text = CRec.CosteMateriales.ToString();
                txtCosteTotal.Text = CRec.CosteTotal.ToString();
                //TODO
                //if (CRec.Unidad == null)
                //{
                //    cmbUnidad.SelectedValue = 0;
                //}
                //else
                //    cmbUnidad.SelectedValue = Convert.ToInt32(CRec.Unidad);
                //if (CRec.Prohibido == null)
                //{
                //    cmbProhibido.SelectedValue = 0;
                //}
                //else
                //    cmbProhibido.SelectedValue = Convert.ToInt32(CRec.Prohibido);
                HanModificado = false;
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        bool ValidarControles()
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
                _ = ex.Message;
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
        //        _ = ex.Message;
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
        //        _ = ex.Message;
        //    }
        //}

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (HanModificado)
            {
                if (ValidarControles())
                {
                    CRec.CodRecurso = txtCodRecurso.Text;
                    CRec.RecursoContratacion = txtRecContratacion.Text;
                    CRec.CosteManodeObra = Convert.ToDecimal(txtCosteManoObra.Text);
                    CRec.CosteMateriales = Convert.ToDecimal(txtCosteMateriales.Text);
                    CRec.CosteTotal = Convert.ToDecimal(txtCosteTotal.Text);
                    //CRec.Unidad = cmbUnidad.SelectedValue.ToString();
                    // TODO 
                    //if (cmbProhibido.SelectedValue.ToString = 0)
                    //{
                    //    CRec.Prohibido = false;
                    //}
                    //else
                    //    CRec.Prohibido = true;
                    //CRec.EsAlta = false;
                    CRec.GuardarUsuario();
                }
            }
        }
        #endregion

        #region "Control de Eventos"

        private void TxtCodRecurso_TextChanged(object sender, EventArgs e)
        {
            HanModificado = true;
        }

        private void TxtRecContratacion_TextChanged(object sender, EventArgs e)
        {
            HanModificado = true;
        }

        private void TxtCosteManoObra_TextChanged(object sender, EventArgs e)
        {
            HanModificado = true;
        }

        private void TxtCosteMateriales_TextChanged(object sender, EventArgs e)
        {
            HanModificado = true;
        }

        private void TxtCosteTotal_TextChanged(object sender, EventArgs e)
        {
            HanModificado = true;
        }

        private void CmbUnidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            HanModificado = true;
        }

        private void CmbProhibido_SelectedIndexChanged(object sender, EventArgs e)
        {
            HanModificado = true;
        }


        private void BtnPrimero_Click_1(object sender, EventArgs e)
        {
            CRec.IrPrimero();
            CargarForm();
        }

        private void BtnAnterior_Click_1(object sender, EventArgs e)
        {
            CRec.IrAnterior();
            CargarForm();
        }

        private void BtnSiguiente_Click_1(object sender, EventArgs e)
        {
            CRec.IrSiguiente();
            CargarForm();
        }

        private void BtnUltimo_Click_1(object sender, EventArgs e)
        {
            CRec.IrUltimo();
            CargarForm();
        }

        private void TxtCosteMateriales_Leave(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(txtCosteMateriales.Text);
            int x = Convert.ToInt32(txtCosteManoObra.Text);
            int z = i + x;
            txtCosteTotal.Text = z.ToString();
        }
        #endregion
    }
}

