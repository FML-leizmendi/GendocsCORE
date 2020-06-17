using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GendocsForms
{
    public partial class FrmCalendario : Form
    {
        public String FechaPlazoEntrega;
        public FrmCalendario()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, System.EventArgs e)
        {
            FechaPlazoEntrega = monthCalendar1.SelectionRange.Start.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
