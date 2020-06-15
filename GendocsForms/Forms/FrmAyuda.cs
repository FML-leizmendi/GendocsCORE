using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GendocsForms
{
    public partial class FrmAyuda : Form
    {
        public FrmAyuda()
        {
            InitializeComponent();
        }

        private void FrmAyuda_Load(object sender, EventArgs e)
        {
            try
            {
                //BuscaAyuda("ETRA1");
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }
    }
}
