using GendocsForms.Forms;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace GendocsForms
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void BtnCerrarForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnExpedientes_Click(object sender, EventArgs e)
        {
            FrmListaProyectos frm = new FrmListaProyectos();
            _ = new FrmMDIGd();
            frm.MdiParent = this.MdiParent;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
            // this.Hide();
        }

        private void BtnPedidos_Click(object sender, EventArgs e)
        {
            //frmPoblaciones frm = new frmPoblaciones();
            //frm.Show();
            //IdAcceso();
            FrmPedidos frm = new FrmPedidos
            {
                MdiParent = this.MdiParent,
                WindowState = FormWindowState.Maximized
            };
            frm.Show();

            //clsPedidos clsPedido = new clsPedidos();
            //clsPedido.CargarFrmPedidos();

        }

        private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("¿Desea cerrar la aplicación?", "Gendocs", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    Application.Exit();
            //}
        }

        private void BtnFmlStaff_Click(object sender, EventArgs e)
        {
            frmEmpleadosFML frm = new frmEmpleadosFML
            {
                MdiParent = this.MdiParent,
                WindowState = FormWindowState.Maximized
            };
            frm.Show();
        }

        private void BtnContactos_Click(object sender, EventArgs e)
        {
            FrmContactos frm = new FrmContactos
            {
                MdiParent = this.MdiParent,
                WindowState = FormWindowState.Maximized
            };
            frm.Show();
        }


        private void BtnRecursos_Click(object sender, EventArgs e)
        {
            FrmRecursos frm = new FrmRecursos
            {
                // frm.EsEdicion = true;
                MdiParent = this.MdiParent,
                WindowState = FormWindowState.Maximized
            };
            frm.Show();
        }


        private void BtnAgenda_Click(object sender, EventArgs e)
        {
            try
            {
                Utiles.AbrirArchivo("https://trello.com/b/f3Pt4ytE/fml-pedidos");
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        private void BtnLeerPedidos_Click(object sender, EventArgs e)
        {
            try
            {
                FrmRedimensionarImagenes frm = new FrmRedimensionarImagenes();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }

        }

        private void BtnUnidadesContructivas_Click(object sender, EventArgs e)
        {
            try
            {
                FrmUnidadesConstructivas frm = new FrmUnidadesConstructivas();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        private void BtnParametros_Click(object sender, EventArgs e)
        {
            try
            {
                FrmParametros frm = new FrmParametros();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            try
            {
                FrmClientes frm = new FrmClientes
                {
                    MdiParent = this.MdiParent,
                    WindowState = FormWindowState.Maximized
                };
                frm.Show();
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FrmAyuda frm = new FrmAyuda
            {
                CodBusqueda = "ETRA1"
            };
            frm.ShowDialog();
        }
    }
}
