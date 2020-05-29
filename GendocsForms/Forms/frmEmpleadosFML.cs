using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

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
        private void FrmEmpleadosFML_Load(object sender, EventArgs e)
        {
            CargarGrid();
            FormatearGrid();
            txtIntroduzcaTexto.Focus();
        }

        private void BtnEditarEmpleado_Click(object sender, EventArgs e)
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
                CargarGrid();
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        private void BtnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            try
            {
                txtIntroduzcaTexto.Text = string.Empty;
                txtIntroduzcaTexto.Focus();
                CargarGrid(txtIntroduzcaTexto.Text);
                FormatearGrid();
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        private void DgvEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                clsEmpFml cEmp = new clsEmpFml();
                using GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext();
                var lst = (from d in db.GdEmpleadosFml
                           where (d.Nombre.Contains(txtIntroduzcaTexto.Text) || d.Apellidos.Contains(txtIntroduzcaTexto.Text))
                           select d.IdEmpleadoFml

                       ).ToList();

                cEmp.lstId = lst;
                cEmp.CargarFrmEmpleadosFML();
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        private void DgvEmpleados_CurrentCellChanged(object sender, EventArgs e)
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
                this.dgvEmpleados.Columns["Nombre"].Width = 250;
                this.dgvEmpleados.Columns["Apellidos"].Width = 250;
                this.dgvEmpleados.Columns["NIF"].Width = 150;
                this.dgvEmpleados.Columns["Telefono"].Width = 150;
                this.dgvEmpleados.Columns["Email"].Width = 250;
                this.dgvEmpleados.Columns["Etiquetas"].Width = 270;
                this.dgvEmpleados.Columns["TrelloIdMember"].Width = 285;


                ////Alinear las columnas 
                dgvEmpleados.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgvEmpleados.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;              
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }


        private void CargarGrid(String TextoIntroducido = "")
        {
            try
            {
                using GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext();
                var lst = (from a in db.GdEmpleadosFml
                           where (a.Nombre.Contains(TextoIntroducido) || a.Apellidos.Contains(TextoIntroducido))
                           select a

                       ).ToList();

                dgvEmpleados.DataSource = lst;
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        #endregion

        #region "Control de evenetos"
        private void TxtIntroduzcaTexto_TextChanged(object sender, EventArgs e)
        {
            CargarGrid(txtIntroduzcaTexto.Text);
        }
        #endregion
    }

}
