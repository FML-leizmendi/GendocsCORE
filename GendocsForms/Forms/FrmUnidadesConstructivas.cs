using GendocsModeloDatos.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace GendocsForms
{
    public partial class FrmUnidadesConstructivas : Form
    {
        public bool EsEdicion = false;
        public clsUnidadesContructivas CUnds { get; set; }

        public FrmUnidadesConstructivas(clsUnidadesContructivas cund)
        {
            CUnds = cund;
            InitializeComponent();
        }

        public FrmUnidadesConstructivas()
        {
            InitializeComponent();
        }

        #region "Eventos Privados"
        private void FrmUnidadesConstructivas_Load(object sender, EventArgs e)
        {
            CargarComboClientes();
            CargarComboTipoTrabajo();
            CargarGrid();
            FormatearGrid();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext();
                List<GdUnidadesConstructivas> lstUnds = new List<GdUnidadesConstructivas>();
                if (dgvUndsContructivas.SelectedRows.Count > 0)
                {
                    for (int i = 0; i < dgvUndsContructivas.SelectedRows.Count; i++)
                    {
                        int IdUC = Convert.ToInt32(dgvUndsContructivas.SelectedRows[i].Cells["IdUC"].Value.ToString());
                        var lst = (from a in db.GdUnidadesConstructivas
                                   where a.IdUc == IdUC
                                   select a).FirstOrDefault();

                        int PlazoEntregaDias = 0;
                        if (lst.PlazoEntregaDias != null)
                        {
                            PlazoEntregaDias = (int)lst.PlazoEntregaDias;
                        }
                        else
                        {
                            PlazoEntregaDias = DamePlazoEntregaDias((int)lst.IdTipoTrabajo);
                        }

                        GdUnidadesConstructivas unds = new GdUnidadesConstructivas()
                        {
                            IdUc = lst.IdUc,
                            IdCliente = lst.IdCliente,
                            CodigoUc = lst.CodigoUc,
                            CodigoUc2 = lst.CodigoUc2,
                            DescripcionUc = lst.DescripcionUc,
                            Ud = lst.Ud,
                            PrecioUnidad = lst.PrecioUnidad,
                            IdTipoTrabajo = lst.IdTipoTrabajo,
                            PlazoEntregaDias = PlazoEntregaDias
                        };

                        lstUnds.Add(unds);
                    }
                }
                CUnds.lstUnds = lstUnds;
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        private int DamePlazoEntregaDias(int IdTipoTrabajo)
        {
            int PlazoEntregaDias;
            try
            {
                GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext();
                var lst = (from a in db.GdTiposTrabajo
                           where a.IdTipoTrabajo == IdTipoTrabajo
                           select a).FirstOrDefault();

                if (lst.PlazoEntregaDias != null)
                {
                    PlazoEntregaDias = Convert.ToInt32(lst.PlazoEntregaDias);
                }
                else
                    PlazoEntregaDias = 0;


            }
            catch (Exception ex)
            {
                _ = ex.Message;
                return 0;
            }
            return PlazoEntregaDias;

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            try
            {
                txtIntroduzcaTexto.Text = string.Empty;
                cmbClientes.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }
        #endregion

        #region "Métodos Privados"

        private void FormatearGrid()
        {
            try
            {   //Ocultar una columna de un datagridview 
                this.dgvUndsContructivas.Columns["IdUc"].Visible = false;
                this.dgvUndsContructivas.Columns["IdCliente"].Visible = false;
                this.dgvUndsContructivas.Columns["IdTipoTrabajo"].Visible = false;

                ////Modificar el ancho de una columna
                this.dgvUndsContructivas.Columns["Cliente"].Width = 150;
                this.dgvUndsContructivas.Columns["TipoTrabajo"].Width = 200;
                this.dgvUndsContructivas.Columns["TipoTrabajo"].HeaderText = "Tipo de Trabajo";
                this.dgvUndsContructivas.Columns["CodigoUC"].Width = 400;
                this.dgvUndsContructivas.Columns["CodigoUC"].HeaderText = "Código UC";
                this.dgvUndsContructivas.Columns["DescripcionUC"].Width = 720;
                this.dgvUndsContructivas.Columns["DescripcionUC"].HeaderText = "Descripción UC";
                this.dgvUndsContructivas.Columns["PrecioUnidad"].Width = 200;
                this.dgvUndsContructivas.Columns["PrecioUnidad"].HeaderText = "Precio Unidad";

                ////Alinear las columnas 
                dgvUndsContructivas.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvUndsContructivas.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvUndsContructivas.Columns["DescripcionUC"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgvUndsContructivas.Columns["PrecioUnidad"].DefaultCellStyle.Format = "C2";
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
                int IdCliente = Convert.ToInt32(cmbClientes.SelectedValue);
                int IdTipoTrabajo = Convert.ToInt32(cmbTipoTrabajo.SelectedValue);
                var lst = (
                    from a in db.GdUnidadesConstructivas
                    join b in db.GdTiposTrabajo on a.IdTipoTrabajo equals b.IdTipoTrabajo
                    join c in db.GdClientes on a.IdCliente equals c.IdCliente
                    where (b.TipoTrabajo.Contains(TextoIntroducido) || a.CodigoUc.Contains(TextoIntroducido) || a.DescripcionUc.Contains(TextoIntroducido))
                    orderby a.IdUc
                    select new { a.IdUc, c.Cliente, b.TipoTrabajo, a.CodigoUc, a.DescripcionUc, a.Ud, a.PrecioUnidad, a.IdCliente, b.IdTipoTrabajo }
                    ).ToList();

                var listaFiltrada = lst.Where(i => (IdCliente != 0 && IdCliente == i.IdCliente) || IdCliente == 0)
                                        .Where(i => (IdTipoTrabajo != 0 && IdTipoTrabajo == i.IdTipoTrabajo) || IdTipoTrabajo == 0).ToList();

                dgvUndsContructivas.DataSource = null;
                dgvUndsContructivas.DataSource = listaFiltrada;
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        private void CargarComboClientes()
        {
            try
            {
                List<GendocsModeloDatos.models.GdClientes> lista = new List<GendocsModeloDatos.models.GdClientes>
                {
                    new GendocsModeloDatos.models.GdClientes()
                    {
                        IdCliente = 0,
                        Cliente = "Todos"
                    }
                };

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
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        private void CargarComboTipoTrabajo()
        {
            try
            {
                List<GendocsModeloDatos.models.GdTiposTrabajo> lista = new List<GendocsModeloDatos.models.GdTiposTrabajo>
                {
                    new GendocsModeloDatos.models.GdTiposTrabajo()
                    {
                        IdTipoTrabajo = 0,
                        TipoTrabajo = "Todos"
                    }
                };

                GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext();
                List<GendocsModeloDatos.models.GdTiposTrabajo> lstTiposTrabajo;
                lstTiposTrabajo = db.GdTiposTrabajo.Select(e => new GendocsModeloDatos.models.GdTiposTrabajo()
                {
                    IdTipoTrabajo = e.IdTipoTrabajo,
                    TipoTrabajo = e.TipoTrabajo
                }
                ).ToList();

                lista.AddRange(lstTiposTrabajo);

                cmbTipoTrabajo.DisplayMember = "TipoTrabajo";
                cmbTipoTrabajo.ValueMember = "IdTipoTrabajo";
                cmbTipoTrabajo.DataSource = lista;
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        #endregion

        #region "Control de Eventos"
        private void TxtIntroduzcaTexto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CargarGrid(txtIntroduzcaTexto.Text);
                FormatearGrid();
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        private void CmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CargarGrid(txtIntroduzcaTexto.Text);
                FormatearGrid();
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        private void CmbTipoTrabajo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CargarGrid(txtIntroduzcaTexto.Text);
                FormatearGrid();
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }


        #endregion
    }
}
