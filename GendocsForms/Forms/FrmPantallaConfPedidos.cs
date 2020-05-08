using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using System.Windows;

namespace GendocsForms
{
    public partial class FrmPantallaConfPedidos : Form
    {
        public FrmPantallaConfPedidos()
        {
            InitializeComponent();
        }

        private void FrmPantallaConfPedidos_Load(object sender, EventArgs e)
        {
            CargarListaDisponibles();
            CargarListaAsignadas();
        }

        private void CargarListaDisponibles()
        {
            try
            {
                using (GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext())
                {
                    lstvDisponibles.Items.Clear();

                    var lst = (from a in db.GdColumnasC
                               join b in db.GdColumnasD on a.IdColumnaC equals b.IdColumnaC
                               where (b.Visible == true)
                               select new { a.IdColumnaC, b.NumCol, b.NameField, b.Ancho, b.OrderBy , b.Visible}
                               
                               ).ToList();

                    foreach (var etiqueta in lst)
                    {
                        ListViewItem item = new ListViewItem();
                        item = lstvDisponibles.Items.Add(etiqueta.NumCol.ToString());
                        item.SubItems.Add(etiqueta.NameField);
                    }
                }

            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }
        }

        private void CargarListaAsignadas()
        {
            try
            {
                using (GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext())
                {
                    lstvAsignadas.Items.Clear();

                    var lst = (from a in db.GdColumnasC
                               join b in db.GdColumnasD on a.IdColumnaC equals b.IdColumnaC
                               where (b.Visible == false)
                               select new { a.IdColumnaC, b.NumCol, b.NameField, b.Ancho, b.OrderBy, b.Visible }

                               ).ToList();

                    foreach (var etiqueta in lst)
                    {
                        ListViewItem item = new ListViewItem();
                        item = lstvAsignadas.Items.Add(etiqueta.NumCol.ToString());
                        item.SubItems.Add(etiqueta.NameField);
                    }
                }

            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (lstvDisponibles.SelectedItems.Count < 1)
            //    {
            //        MessageBox.Show("Debe seleccionar al menos un campo para añadir a la lista de Asignadas", "Configurar Formulario Pedidos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    else
            //    {
            //        using (GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext())
            //        {
            //            foreach (ListViewItem itemRow in lstvDisponibles.SelectedItems)
            //            {
            //                GdEmpleadosFmlEtiquetas EtiFml = new GdEmpleadosFmlEtiquetas();

            //                EtiFml.IdEmpleadoFml = CEmp.IdEmpleado;
            //                EtiFml.IdEtiqueta = Convert.ToInt32(itemRow.SubItems[0].Text);

            //                db.GdEmpleadosFmlEtiquetas.Add(EtiFml);
            //                db.SaveChanges();

            //                EtiFml = null;
            //            }

            //            CargarListaDisponibles();
            //            CargarListaAsignadas(CEmp.IdEmpleado);
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    string mensaje = ex.Message;
            //}
        }
    }
}
