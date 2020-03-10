using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System;

namespace GendocsForms.Forms
{
    public partial class frmEmpleadosFML : Form
    {

        public int IdEmpleado { get; set; }
        public frmEmpleadosFML()
        {
            InitializeComponent();
        }

        #region "Eventos Privados"
        private void frmEmpleadosFML_Load(object sender, EventArgs e)
        {
            CargarGrid();
            FormatearGrid();
            txtIntroduzcaTexto.Focus();
        }

        private void btnEditarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                clsEmpFml cEmp = new clsEmpFml();
                using (GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext())
                {
                    var lst = (from d in db.GdEmpleadosFml
                               where (d.Nombre.Contains(txtIntroduzcaTexto.Text) || d.Apellidos.Contains(txtIntroduzcaTexto.Text))
                               select d.IdEmpleadoFml

                           ).ToList();

                    cEmp.lstId = lst;
                    cEmp.CargarFrmEmpleadosFML();
                }
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }
        }


        private void dgvEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                clsEmpFml cEmp = new clsEmpFml();
                using (GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext())
                {
                    var lst = (from d in db.GdEmpleadosFml
                               where (d.Nombre.Contains(txtIntroduzcaTexto.Text) || d.Apellidos.Contains(txtIntroduzcaTexto.Text))
                               select d.IdEmpleadoFml

                           ).ToList();

                    cEmp.lstId = lst;
                    cEmp.CargarFrmEmpleadosFML();
                }
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }
        }

        private void dgvEmpleados_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvEmpleados.CurrentRow != null)
            {
                //IdEmpleado = Convert.ToInt32(dgvEmpleados.Rows[0].Cells[1].Value);
                IdEmpleado = Convert.ToInt32(dgvEmpleados.CurrentRow.Cells[0].Value);
            }
        }

        #endregion

        #region "Métodos Privados"

        private void FormatearGrid()
        {
            try
            {   //Ocultar una columna de un datagridview 
                this.dgvEmpleados.Columns["IdEmpleadoFML"].Visible = false;
                this.dgvEmpleados.Columns["Direccion"].Visible = false;
                this.dgvEmpleados.Columns["User"].Visible = false;
                this.dgvEmpleados.Columns["Estado"].Visible = false;
                this.dgvEmpleados.Columns["CodigoPersona"].Visible = false;
                this.dgvEmpleados.Columns["Pass"].Visible = false;


                ////Modificar el ancho de una columna
                this.dgvEmpleados.Columns["Nombre"].Width = 130;
                this.dgvEmpleados.Columns["Apellidos"].Width = 160;
                this.dgvEmpleados.Columns["NIF"].Width = 100;
                this.dgvEmpleados.Columns["Telefono"].Width = 150;
                this.dgvEmpleados.Columns["Email"].Width = 150;
                this.dgvEmpleados.Columns["Etiquetas"].Width = 270;
                this.dgvEmpleados.Columns["TrelloIdMember"].Width = 190;


                ////Alinear las columnas 
                dgvEmpleados.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgvEmpleados.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;              
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }
        }


        private void CargarGrid(String TextoIntroducido = "")
        {
            try
            {
                using (GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext())
                {
                    var lst = (from a in db.GdEmpleadosFml
                               where (a.Nombre.Contains(TextoIntroducido) || a.Apellidos.Contains(TextoIntroducido))
                               select a

                           ).ToList();

                    dgvEmpleados.DataSource = lst;
                }
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }
        }

        #endregion

        #region "Control de evenetos"
        private void txtIntroduzcaTexto_TextChanged(object sender, EventArgs e)
        {
            CargarGrid(txtIntroduzcaTexto.Text);
        }
        #endregion
    }

}
