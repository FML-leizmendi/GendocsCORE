using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GendocsForms.Forms
{
    public partial class frmEmpleadosFML : Form
    {
        public frmEmpleadosFML()
        {
            InitializeComponent();
        }

        #region "Eventos Privados"
        private void frmEmpleadosFML_Load(object sender, EventArgs e)
        {

            FormatearGrid();
        }

        #endregion

        #region "Métodos Privados"

        private void FormatearGrid()
        {
            try
            {   //Ocultar una columna de un datagridview 
                this.dgvEmpleados .Columns["IdEmpleadoFML"].Visible = false;
                //this.dgvEmpleados.Columns["IdProyecto"].Visible = false;


                ////Modificar el ancho de una columna
                this.dgvEmpleados.Columns["IdEmpleadoFML"].Width = 150;
                this.dgvEmpleados.Columns["IdEmpleadoFML"].Width = 150;
                this.dgvEmpleados.Columns["IdEmpleadoFML"].Width = 150;
                this.dgvEmpleados.Columns["IdEmpleadoFML"].Width = 150;
                this.dgvEmpleados.Columns["IdEmpleadoFML"].Width = 150;
                this.dgvEmpleados.Columns["IdEmpleadoFML"].Width = 150;

                ////Alinear las columnas 
                dgvEmpleados.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvEmpleados.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch

            {
                //Mostrar mensaje
            }
        }


        private void CargarGrid(String TextoIntroducido = "")
        {
            try
            {
                using (GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext())
                {
                    var lst = (from d in db.GdEmpleadosFml
                               where (d.Nombre.Contains(TextoIntroducido) || d.Apellidos.Contains(TextoIntroducido))
                               select d

                           ).ToList();
                }

            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }
        }
        #endregion

        #region "Control de evenetos"


        #endregion
    }
}
