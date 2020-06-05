using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GendocsForms
{
    public partial class FrmInputBox : Form
    {
        public String DatosIntroducidos;
        public FrmInputBox()
        {
            InitializeComponent();
        }

        private void FrmCantidadRecursos_Load(object sender, EventArgs e)
        {
           
        }
 
        private void TxtCantidadRecursos_KeyPress(object sender, KeyPressEventArgs e)
        {
            //FormUtiles.SoloNumeros(e);
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCantidadRecursos.Text != string.Empty)
                {
                    DatosIntroducidos = txtCantidadRecursos.Text;
                }
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }
    }
}
