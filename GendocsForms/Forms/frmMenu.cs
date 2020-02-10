using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GendocsForms.Forms
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnCerrarForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExpedientes_Click(object sender, EventArgs e)
        {
            frmListaProyectos frm = new frmListaProyectos();
            frm.Show();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            //frmPoblaciones frm = new frmPoblaciones();
            //frm.Show();
            IdAcceso();
        }

        private void IdAcceso()
        {
            int IdPoblacion = 0;
            frmPoblaciones frm = new frmPoblaciones();
            frm.ShowDialog();
            IdPoblacion = frm.IdPoblacion;
            frm.Dispose();
            MessageBox.Show("El idPoblacion dentro del acceso es :" + IdPoblacion);
          
            //return IdPoblacion;

        }
    }
}
