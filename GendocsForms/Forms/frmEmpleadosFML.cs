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
using System.Text.RegularExpressions;
using System.Globalization;

namespace GendocsForms.Forms
{
    public partial class frmEmpleadosFML : Form
    {

        public int IdEmpleado { get; set; }

    }

namespace GendocsForms
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
                CargarGrid();
                FormatearGrid();
                txtIntroduzcaTexto.Focus();
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
                    //this.dgvEmpleados.Columns["Etiquetas"].Visible = false;
                    //this.dgvEmpleados.Columns["TrelloMember"].Visible = false;
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

                        dgvEmpleados.DataSource = lst;
                    }
                }
                catch (Exception ex)
                {
                    string mensaje = ex.Message;
                }
            }

            private static String textoSinAcentos(String TextoIntroducido)
            {
                string palabaSinTildes = string.Empty;
                try
                {
                    palabaSinTildes = Regex.Replace(TextoIntroducido.Normalize(NormalizationForm.FormD), @"[^a-zA-z0-9 ]+", "");
                }
                catch (Exception ex)
                {
                    string mensaje = ex.Message;
                }

                return palabaSinTildes;
            }

            static string EliminarAcentos(string text)
            {
                string formD = text.Normalize(NormalizationForm.FormD);
                StringBuilder sb = new StringBuilder();

                foreach (char ch in formD)
                {
                    UnicodeCategory uc = CharUnicodeInfo.GetUnicodeCategory(ch);
                    if (uc != UnicodeCategory.NonSpacingMark)
                    {
                        sb.Append(ch);
                    }
                }

                return sb.ToString().Normalize(NormalizationForm.FormC);
            }

            #endregion

            #region "Control de evenetos"
            private void txtIntroduzcaTexto_TextChanged(object sender, EventArgs e)
            {
                CargarGrid(txtIntroduzcaTexto.Text);
            }

            private void btnEditarEmpleado_Click(object sender, EventArgs e)
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

            private void dgvEmpleados_CurrentCellChanged(object sender, EventArgs e)
            {

                if (dgvEmpleados.CurrentRow != null)
                {
                    //IdEmpleado = Convert.ToInt32(dgvEmpleados.Rows[0].Cells[1].Value);
                    IdEmpleado = Convert.ToInt32(dgvEmpleados.CurrentRow.Cells[0].Value);
                }
            }

            private void dgvEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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
        }
        #endregion
    }
}
