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
using GendocsController;

namespace GendocsForms
{
    public partial class frmLogin : Form
    {
        public string Pass { get; set; }

        public string User { get; set; }
        public bool Recordar { get; set; }
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
            this.Visible=false;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            txtContraseña.PasswordChar = '*';
            Pass = txtContraseña.Text == null? "": txtContraseña.Text;
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            User = txtUsuario.Text == null ? "" : txtUsuario.Text;
        }

        private void chkRecordarUsuario_CheckedChanged(object sender, EventArgs e)
        {
            //if (chkRecordarUsuario.Checked)
            //{
            //    user = txtUsuario.Text;
            //}
            //else 
            //{
            //    pass = txtContraseña.Text;
            //}
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            bool ok;
            this.chkRecordarUsuario.Checked = (bool)G3.GetParam("frmLogin_chkRecordarUsuario", false, out ok,  true, 1);
            this.txtUsuario.Text = G3.GetParam("frmLogin_txtUsuario", false, out ok, true).ToString();
            this.txtContraseña.Text = G3.GetParam("frmLogin_txtContraseña", false, out ok, true).ToString();
            User = this.txtUsuario.Text;
            Pass = this.txtContraseña.Text;
        }
        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            G3.SetParam("frmLogin_txtUsuario", false, this.chkRecordarUsuario.Checked ? this.txtUsuario.Text : "", true, 10);
            G3.SetParam("frmLogin_txtContraseña", false, this.chkRecordarUsuario.Checked ? this.txtContraseña.Text : "", true, 10);
            G3.SetParam("frmLogin_chkRecordarUsuario", false, this.chkRecordarUsuario.Checked, true, 1);
        }
    }
}
