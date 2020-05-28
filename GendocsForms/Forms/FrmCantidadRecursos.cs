using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GendocsForms
{
    public partial class FrmCantidadRecursos : Form
    {
        public int Cantidad;
        public FrmCantidadRecursos()
        {
            InitializeComponent();
        }

        private void FrmCantidadRecursos_Load(object sender, EventArgs e)
        {
           
        }
 
        private void txtCantidadRecursos_KeyPress(object sender, KeyPressEventArgs e)
        {
           FormUtiles.SoloNumeros(e);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCantidadRecursos.Text != string.Empty)
                {
                    Cantidad = Convert.ToInt32(txtCantidadRecursos.Text);
                }
                else
                    MessageBox.Show("Introduzca una cantidad para la Unidad Constructiva seleccionada", "Unidad Constructiva", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }
        }
    }
}
