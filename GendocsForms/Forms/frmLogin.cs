using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GendocsForms
{
    public partial class frmLogin : Form
    {
        public string pass { get; set; }

        public string user { get; set; }
        public frmLogin()
        {
            InitializeComponent();
        }

        #region "Form Behavior"
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbMinimizarForm_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("sender: " + sender.ToString());
            //MessageBox.Show("e: " + e.ToString());
            //CancelClose = true;

            this.Close();
            FrmMDIGd frm = new FrmMDIGd();
            frm.Show();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            txtContraseña.PasswordChar = '*';
            if (txtContraseña.Text is null)
            {
                pass = "";
            }
            else
            {
                pass = txtContraseña.Text;
            }

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text is null)
            {
                user = "";
            }
            else
            {
                user = txtUsuario.Text;
            }
        }

        private void chkRecordarUsuario_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRecordarUsuario.Checked)
            {
                user = txtUsuario.Text;
            }
            else 
            {
                pass = txtContraseña.Text;
            }
        }
    }
}
