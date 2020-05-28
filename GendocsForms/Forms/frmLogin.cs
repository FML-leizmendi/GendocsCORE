using System;
using System.Linq;
using System.Windows.Forms;

namespace GendocsForms
{
    public partial class frmLogin : Form
    {
        public string Pass { get; set; }

        public string User { get; set; }
        public frmLogin()
        {
            InitializeComponent();
        }

        #region "Eventos Privados"
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PbMinimizarForm_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region "Métodos Privados"
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarAcceso())
                {
                    Utiles.IdEmpleadoFML = CargarIdEmpleadoFML();
                    Utiles.User = txtUsuario.Text;
                    this.Close();
                }
                else
                {
                    this.Close();
                }


            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        private bool ValidarAcceso()
        {
            bool TieneAcceso = false;
            try
            {
                if (txtUsuario.Text.Equals(string.Empty))
                {
                    MessageBox.Show("Debe introducir el usuario para continuar", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TieneAcceso = false;
                }
                else if (txtUsuario.Text.Equals(string.Empty))
                {
                    MessageBox.Show("Debe introducir la contraseña para continuar", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TieneAcceso = false;
                }
                else
                    TieneAcceso = true;
            }

            catch (Exception ex)
            {
                _ = ex.Message;
            }
            return TieneAcceso;
        }

        private int CargarIdEmpleadoFML()
        {
            int IdEmpleadoFML = 0;
            try
            {
                using GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext();
                var lst = (from a in db.GdEmpleadosFml
                           where a.User.Equals(txtUsuario.Text)
                           select a.IdEmpleadoFml).ToList();

                IdEmpleadoFML = Convert.ToInt32(lst[0]);

            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
            return IdEmpleadoFML;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtContraseña_TextChanged(object sender, EventArgs e)
        {
            txtContraseña.PasswordChar = '*';
            if (txtContraseña.Text is null)
            {
                Pass = "";
            }
            else
            {
                Pass = txtContraseña.Text;
            }

        }

        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text is null)
            {
                User = "";
            }
            else
            {
                User = txtUsuario.Text;
            }
        }

        private void ChkRecordarUsuario_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRecordarUsuario.Checked)
            {
                User = txtUsuario.Text;
            }
            else
            {
                Pass = txtContraseña.Text;
            }
        }
        #endregion

        #region "Control de Eventos"

        #endregion
    }
}
