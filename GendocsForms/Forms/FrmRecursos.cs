using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GendocsForms
{
    public partial class FrmRecursos : Form
    {
        public FrmRecursos()
        {
            InitializeComponent();
        }

        #region "Eventos Privados"
        private void FrmRecursos_Load(object sender, EventArgs e)
        {
            CargarComboClientes();
            CargarGrid();
        }

        #endregion

        #region "Métodos Privados"

        private void FormatearGrid()
        {
            try
            {   //Ocultar una columna de un datagridview 
                this.dgvRecursos.Columns["IdEmpleado"].Visible = false;

                ////Modificar el ancho de una columna
                this.dgvRecursos.Columns["Empleado"].Width = 300;
                this.dgvRecursos.Columns["Cliente"].Width = 200;
                this.dgvRecursos.Columns["Cargo"].Width = 200;
                this.dgvRecursos.Columns["Telefono"].Width = 400;
                this.dgvRecursos.Columns["Email"].Width = 250;
                this.dgvRecursos.Columns["Etiquetas"].Width = 300;


                ////Alinear las columnas 
                dgvRecursos.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgvRecursos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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

                    var lstFiltrada = (from a in db.GdRecursos
                                       select a
                                        ).ToList();

                    dgvRecursos.DataSource = lstFiltrada;

                }
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }
        }

        private void CargarComboClientes()
        {
            try
            {
                List<GendocsModeloDatos.models.GdClientes> lista = new List<GendocsModeloDatos.models.GdClientes>();
                lista.Add(new GendocsModeloDatos.models.GdClientes()
                {
                    IdCliente = 0,
                    Cliente = "Todos"
                });

                GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext();
                List<GendocsModeloDatos.models.GdClientes> lstClientes;
                lstClientes = db.GdClientes.Select(e => new GendocsModeloDatos.models.GdClientes()
                {
                    IdCliente = e.IdCliente,
                    Cliente = e.Cliente
                }
                ).ToList();

                lista.AddRange(lstClientes);

                cmbClientes.DisplayMember = "Cliente";
                cmbClientes.ValueMember = "IdCliente";
                cmbClientes.DataSource = lista;
            }
            catch
            {

            }
        }
        #endregion

        #region "Control de Eventos"

        #endregion


    }
}
