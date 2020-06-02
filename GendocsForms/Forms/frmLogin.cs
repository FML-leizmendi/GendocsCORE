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
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PbMinimizarForm_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            this.Visible=false;
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtContraseña_TextChanged(object sender, EventArgs e)
        {
            txtContraseña.PasswordChar = '*';
            Pass = txtContraseña.Text ?? "";
        }

        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {
            User = txtUsuario.Text ?? "";
        }

        private void ChkRecordarUsuario_CheckedChanged(object sender, EventArgs e)
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

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.chkRecordarUsuario.Checked = (bool)G3.GetParam("frmLogin_chkRecordarUsuario", false, out _,  true, 1);
            this.txtUsuario.Text = G3.GetParam("frmLogin_txtUsuario", false, out _, true).ToString();
            this.txtContraseña.Text = G3.GetParam("frmLogin_txtContraseña", false, out _, true).ToString();
            User = this.txtUsuario.Text;
            Pass = this.txtContraseña.Text;
        }
        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            G3.SetParam("frmLogin_txtUsuario", false, this.chkRecordarUsuario.Checked ? this.txtUsuario.Text : "", true, 10);
            G3.SetParam("frmLogin_txtContraseña", false, this.chkRecordarUsuario.Checked ? this.txtContraseña.Text : "", true, 10);
            G3.SetParam("frmLogin_chkRecordarUsuario", false, this.chkRecordarUsuario.Checked, true, 1);
        }
    }
}
