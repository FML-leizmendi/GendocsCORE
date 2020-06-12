using GendocsController;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GendocsForms
{
    public partial class FrmConfigPedido : Form
    {
        public string NombreGrid = string.Empty;
        public FrmConfigPedido()
        {
            InitializeComponent();
        }


        #region "Eventos Privados"
        private void FrmPantallaConfPedidos_Load(object sender, EventArgs e)
        {
            CargarListaDisponibles(G3.DimeIdColumnaC(G3.IdEmpleadoFML_Logged, NombreGrid));
            CargarListaAsignadas(G3.DimeIdColumnaC(G3.IdEmpleadoFML_Logged, NombreGrid));
        }


        private void BtnAnadir_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstvAsignadas.SelectedItems.Count < 1)
                {
                    MessageBox.Show("Debe seleccionar al menos un campo para añadir a la lista de Asignadas", "Configurar Pantalla", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    using GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext();
                    foreach (ListViewItem itemRow in lstvAsignadas.SelectedItems)
                    {
                        var query = (from a in db.GdColumnasD
                                     where a.IdColumnaD == Convert.ToInt32(itemRow.SubItems[2].Text)
                                     select a).ToList();

                        foreach (var item in query)
                        {
                            item.Visible = false;
                        }

                        db.SaveChanges();
                    }

                    CargarListaDisponibles(G3.DimeIdColumnaC(G3.IdEmpleadoFML_Logged, NombreGrid));
                    CargarListaAsignadas(G3.DimeIdColumnaC(G3.IdEmpleadoFML_Logged, NombreGrid));
                }
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        private void BtnQuitar_Click(object sender, EventArgs e)
        {
            if (lstvDisponibles1.SelectedItems.Count < 1)
            {
                MessageBox.Show("Debe seleccionar al menos un campo para añadir a la lista de Disponibles", "Configurar Pantalla", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                using GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext();
                foreach (ListViewItem itemRow in lstvDisponibles1.SelectedItems)
                {
                    var query = (from a in db.GdColumnasD
                                 where a.IdColumnaD == Convert.ToInt32(itemRow.SubItems[2].Text)
                                 select a).ToList();

                    foreach (var item in query)
                    {
                        item.Visible = true;
                    }

                    db.SaveChanges();
                }

                CargarListaDisponibles(G3.DimeIdColumnaC(G3.IdEmpleadoFML_Logged, NombreGrid));
                CargarListaAsignadas(G3.DimeIdColumnaC(G3.IdEmpleadoFML_Logged, NombreGrid));
            }
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region "Métodos Privados"
        private void CargarListaDisponibles(int IdColumna = 0)
        {
            try
            {
                using GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext();
                lstvAsignadas.Items.Clear();
                if (IdColumna != 0)
                {
                    var lst = (from a in db.GdColumnasC
                               join b in db.GdColumnasD on a.IdColumnaC equals b.IdColumnaC
                               where (b.Visible == true) && (b.IdColumnaC == IdColumna)
                               select new { a.IdColumnaC, b.NumCol, b.NameField, b.Ancho, b.OrderBy, b.Visible, b.IdColumnaD }

                          ).ToList();

                    foreach (var etiqueta in lst)
                    {
                        ListViewItem item = new ListViewItem();
                        item = lstvAsignadas.Items.Add(etiqueta.IdColumnaC.ToString());
                        item.SubItems.Add(etiqueta.NameField.ToString());
                        item.SubItems.Add(etiqueta.IdColumnaD.ToString());
                    }
                }

            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }


        private void CargarListaAsignadas(int IdColumna = 0)
        {
            try
            {
                using GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext();
                lstvDisponibles1.Items.Clear();
                if (IdColumna != 0)
                {
                    var lst = (from a in db.GdColumnasC
                               join b in db.GdColumnasD on a.IdColumnaC equals b.IdColumnaC
                               where (b.IdColumnaC == IdColumna && b.Visible == false)
                               select new { a.IdColumnaC, b.NumCol, b.NameField, b.Ancho, b.OrderBy, b.Visible, b.IdColumnaD }

                           ).ToList();

                    foreach (var etiqueta in lst)
                    {
                        ListViewItem item = new ListViewItem();
                        item = lstvDisponibles1.Items.Add(etiqueta.IdColumnaC.ToString());
                        item.SubItems.Add(etiqueta.NameField.ToString());
                        item.SubItems.Add(etiqueta.IdColumnaD.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        #endregion

        #region "Control de Eventos"

        #endregion
    }
}
