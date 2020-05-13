using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            CargarListaDisponibles(NumColumna(26, "dgvPedidosEdit"));
            CargarListaAsignadas(NumColumna(26, "dgvPedidosEdit"));
        }

        private void CargarListaDisponibles(int IdColumna = 0)
        {
            try
            {
                using (GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext())
                {
                    lstvDisponibles.Items.Clear();

                    if (IdColumna != 0)
                    {
                        var lst = (from a in db.GdColumnasC
                                   join b in db.GdColumnasD on a.IdColumnaC equals b.IdColumnaC
                                   where (b.Visible == true) && (b.IdColumnaC == IdColumna)
                                   select new { a.IdColumnaC, b.NumCol, b.NameField, b.Ancho, b.OrderBy, b.Visible }

                              ).ToList();

                        foreach (var etiqueta in lst)
                        {
                            ListViewItem item = new ListViewItem();
                            item = lstvDisponibles.Items.Add(etiqueta.NameField.ToString());
                            item.SubItems.Add(etiqueta.IdColumnaC.ToString());
                            item.SubItems.Add(etiqueta.NumCol.ToString());
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }
        }

        private void CargarListaAsignadas(int IdColumna=0)
        {
            try
            {
                using (GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext())
                {
                    lstvAsignadas.Items.Clear();

                    if (IdColumna != 0)
                    {
                        var lst = (from a in db.GdColumnasC
                                   join b in db.GdColumnasD on a.IdColumnaC equals b.IdColumnaC
                                   where (b.Visible == false) && (b.IdColumnaC == IdColumna)
                                   select new { a.IdColumnaC, b.NumCol, b.NameField, b.Ancho, b.OrderBy, b.Visible }

                               ).ToList();

                        foreach (var etiqueta in lst)
                        {
                            ListViewItem item = new ListViewItem();
                            item = lstvAsignadas.Items.Add(etiqueta.IdColumnaC.ToString());
                            item.SubItems.Add(etiqueta.NameField.ToString());
                            item.SubItems.Add(etiqueta.NumCol.ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }
        }


        private int NumColumna(int IdEmpleadoFML=0, string NomnbreGrid="")
        {
            int NumColumna = 0;
            try
            {
                using (GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext())
                {
                    var query = (from a in db.GdColumnasC
                               where (a.IdEmpleadoFMl == IdEmpleadoFML) & (a.ListName.Contains(NomnbreGrid))
                               select new { a.IdColumnaC}).ToList();
 
                  NumColumna = Convert.ToInt32( query[0].IdColumnaC);
                }        
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }
            return NumColumna;
        }
        private void btnAnadir_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstvDisponibles.SelectedItems.Count < 1)
                {
                    MessageBox.Show("Debe seleccionar al menos un campo para añadir a la lista de Asignadas", "Configurar Formulario Pedidos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    using (GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext())
                    {
                        var query = (from a in db.GdColumnasD
                                     where a.IdColumnaC == 1
                                     select a).FirstOrDefault();

                        query.Visible = false;
                        db.SaveChanges();

                        CargarListaDisponibles(NumColumna(26, "dgvPedidosEdit"));
                        CargarListaAsignadas(NumColumna(26, "dgvPedidosEdit"));
                    }
                }
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstvDisponibles.SelectedItems.Count < 1)
                {
                    MessageBox.Show("Debe seleccionar al menos un campo para añadir a la lista de Asignadas", "Configurar Formulario Pedidos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    using (GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext())
                    {
                        var query = (from a in db.GdColumnasD
                                     where a.IdColumnaC == 1
                                     select a).FirstOrDefault();

                        query.Visible = true;
                        db.SaveChanges();

                        CargarListaDisponibles(NumColumna(26, "dgvPedidosEdit"));
                        CargarListaAsignadas(NumColumna(26, "dgvPedidosEdit"));
                    }
                }
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }
        }
    }
}
