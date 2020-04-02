using GendocsForms.Forms;
using System;
using System.Windows.Forms;

namespace GendocsForms
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnCerrarForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExpedientes_Click(object sender, EventArgs e)
        {
            FrmListaProyectos frm = new FrmListaProyectos();
            FrmMDIGd frmMDI = new FrmMDIGd();
            frm.MdiParent = this.MdiParent;
            frm.Show();
            // this.Hide();
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

        private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("¿Desea cerrar la aplicación?", "Gendocs", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    Application.Exit();
            //}
        }

        private void btnFmlStaff_Click(object sender, EventArgs e)
        {
            frmEmpleadosFML frm = new frmEmpleadosFML();
            frm.MdiParent = this.MdiParent;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnContactos_Click(object sender, EventArgs e)
        {
            FrmContactos frm = new FrmContactos();
            frm.MdiParent = this.MdiParent;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmContactos2 frm = new FrmContactos2();
            frm.MdiParent = this.MdiParent;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnRecursos_Click(object sender, EventArgs e)
        {
            FrmRecursos frm = new FrmRecursos();
            frm.MdiParent = this.MdiParent;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
    }
}
