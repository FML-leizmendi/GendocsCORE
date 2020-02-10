using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GendocsForms.Forms
{
    
    public partial class frmPoblaciones : Form
    {
        public int IdPoblacion { get; set; }
        public frmPoblaciones()
        {
            InitializeComponent();
        }
          
        private void frmPoblaciones_Load(object sender, EventArgs e)
        {
            String[] arrayMadrid = new String[] { "1", "Madrid", "Comunidad de Madrid"};
            String[] arrayBarcelona = new String[] { "2", "Barcelona", "Cataluña" };
            String[] arrayValencia = new String[] { "3", "Valencia", "Comunidad de Valencia" };
            String[] arraySevilla = new String[] { "4", "Sevilla", "Andalucia" };
            dgvPoblaciones.Rows.Add(arrayMadrid);
            dgvPoblaciones.Rows.Add(arrayBarcelona);
            dgvPoblaciones.Rows.Add(arrayValencia);
            dgvPoblaciones.Rows.Add(arraySevilla);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvPoblaciones.CurrentRow != null)
            {
                MessageBox.Show("El id seleccionado es: " + dgvPoblaciones.CurrentRow.Cells[0].Value);
                IdPoblacion = Convert.ToInt32(dgvPoblaciones.CurrentRow.Cells[0].Value);
                this.Close();
            }
            else
            {
                MessageBox.Show("NO hay elemento seleccionado");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            IdPoblacion = 0;
        }
    }
}
