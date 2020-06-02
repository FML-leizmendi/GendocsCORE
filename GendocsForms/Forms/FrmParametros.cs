using System;
using System.Windows.Forms;

namespace GendocsForms.Forms
{
    public partial class FrmParametros : Form
    {
        public FrmParametros()
        {
            InitializeComponent();
        }

        #region "Eventos Privados"
        private void FrmParametros_Load(object sender, EventArgs e)
        {
            try
            {
                G3Forms.CargarParam(this, "");
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        private void PbCarpetaBaseProyecto_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog CarpetaBaseProyecto = new FolderBrowserDialog();
                if (CarpetaBaseProyecto.ShowDialog() == DialogResult.OK)
                {
                    CarpetaBaseProyectos.Text = CarpetaBaseProyecto.SelectedPath;
                }
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        private void PbCarpetaGendocs_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog CarpetaGendocs = new FolderBrowserDialog();
                if (CarpetaGendocs.ShowDialog() == DialogResult.OK)
                {
                    CarpertaGen3.Text = CarpetaGendocs.SelectedPath;
                }
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        private void FrmParametros_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                G3Forms.GrabarParam(this, "");
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        #endregion

        #region "Méotodos Privados"

        #endregion

        #region "Control de Eventos"

        #endregion
    }
}
