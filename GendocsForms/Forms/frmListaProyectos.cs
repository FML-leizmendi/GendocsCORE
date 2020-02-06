using System;
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
    public partial class frmListaProyectos : Form
    {
        public frmListaProyectos()
        {
            InitializeComponent();
        }

        private void btnCerrarForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximizarForm_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void btnMinimizarForm_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
