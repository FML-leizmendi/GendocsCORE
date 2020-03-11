using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System;

namespace GendocsForms
{
    public partial class FrmEtiquetarEmpleado : Form
    {
        public clsEmp CEmp { get; set; }

        public FrmEtiquetarEmpleado(clsEmp cemp)
        {
            CEmp = cemp;
            InitializeComponent();
        }

        public FrmEtiquetarEmpleado()
        {
            InitializeComponent();
        }

        #region "Eventos Privados"

        #endregion

        #region "Métodos Privados"
        
        #endregion

        #region "Control de Eventos"
        private void btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Desea salir?", "Etiquetar Empleado FML", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }
        }

        #endregion
    }
}
