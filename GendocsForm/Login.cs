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

namespace GendocsForm
{
    public partial class Login : Form
    {
        public Login()
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

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            frmListaProyectos frm = new frmListaProyectos();
            frm.Show();
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            txtContraseña.PasswordChar = '*';
        }
    }
}
