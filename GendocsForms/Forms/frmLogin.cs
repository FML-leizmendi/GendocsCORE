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
        Boolean CancelClose;
        public string user { get; set; }
        public string pass { get; set; }
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
            //frmListaProyectos frm = new frmListaProyectos();
            //frm.Show();
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

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CancelClose==true)
            {
                /*
                e.Cancel = true;
                System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
                messageBoxCS.AppendFormat("{0} = {1}", "CloseReason", e.CloseReason);
                messageBoxCS.AppendLine();
                messageBoxCS.AppendFormat("{0} = {1}", "Cancel", e.Cancel);
                messageBoxCS.AppendLine();
                MessageBox.Show(messageBoxCS.ToString(), "FormClosing Event");
                */
            }
        }
        private void frmLogin_FormClosed(Object sender, FormClosedEventArgs e)
        {
            /*
            System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
            messageBoxCS.AppendFormat("{0} = {1}", "CloseReason", e.CloseReason);
            messageBoxCS.AppendLine();
            MessageBox.Show(messageBoxCS.ToString(), "FormClosed Event");
            */
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
    }
}
