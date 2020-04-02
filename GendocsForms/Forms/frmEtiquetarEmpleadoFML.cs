using GendocsModeloDatos.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GendocsForms.Forms
{
    public partial class frmEtiquetarEmpleadoFML : Form
    {
        public clsEmpFml CEmp { get; set; }

        public frmEtiquetarEmpleadoFML(clsEmpFml cemp)
        {
            CEmp = cemp;
            InitializeComponent();
        }

        public frmEtiquetarEmpleadoFML()
        {
            InitializeComponent();
        }

        #region "Eventos Privados"

        #endregion

        #region "Métodos Privados"

        public void CargarListaDisponibles()
        {
            try
            {
                using (GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext())
                {
                    lstvDisponibles.Items.Clear();

                    var lst = (from d in db.GdEtiquetasFml
                               join f in (from e in db.GdEmpleadosFmlEtiquetas
                                          where e.IdEmpleadoFml == CEmp.IdEmpleado
                                          select e)
                               on d.IdEtiqueta equals f.IdEtiqueta into joinedT
                               from result in joinedT.DefaultIfEmpty()
                               where result.Id == null
                               //orderby d.IdEtiqueta
                               select new
                               {
                                   d.IdEtiqueta,
                                   d.EtiquetaFml
                               }

                           ).ToList();

                    foreach (var etiqueta in lst)
                    {
                        ListViewItem item = new ListViewItem();
                        item = lstvDisponibles.Items.Add(etiqueta.IdEtiqueta.ToString());
                        item.SubItems.Add(etiqueta.EtiquetaFml);
                    }
                }
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }

        }

        public void CargarListaAsignadas(int IdEmp)
        {
            try
            {
                using (GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext())
                {
                    lstvAsignadas.Items.Clear();

                    var lst = (from d in db.GdEtiquetasFml
                               join x in db.GdEmpleadosFmlEtiquetas
                               on d.IdEtiqueta equals x.IdEtiqueta
                               where x.IdEmpleadoFml == IdEmp
                               orderby d.IdEtiqueta
                               select new { x.Id, d.IdEtiqueta, d.EtiquetaFml }

                           ).ToList();

                    foreach (var etiqueta in lst)
                    {
                        ListViewItem item = new ListViewItem();
                        item = lstvAsignadas.Items.Add(etiqueta.Id.ToString());
                        item.SubItems.Add(etiqueta.EtiquetaFml);
                        //item.SubItems.Add(etiqueta.IdEtiqueta);

                    }
                }
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }

        }
        #endregion

        #region "Control de Eventos"
        private void btnAnadir_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstvDisponibles.SelectedItems.Count < 1)
                {
                    MessageBox.Show("Debe seleccionar al menos una etiqueta para añadir a la lista de Asignadas", "Etiquetar Empleado FML", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    using (GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext())
                    {
                        foreach (ListViewItem itemRow in lstvDisponibles.SelectedItems)
                        {
                            GdEmpleadosFmlEtiquetas EtiFml = new GdEmpleadosFmlEtiquetas();

                            EtiFml.IdEmpleadoFml = CEmp.IdEmpleado;
                            EtiFml.IdEtiqueta = Convert.ToInt32(itemRow.SubItems[0].Text);

                            db.GdEmpleadosFmlEtiquetas.Add(EtiFml);
                            db.SaveChanges();

                            EtiFml = null;
                        }

                        CargarListaDisponibles();
                        CargarListaAsignadas(CEmp.IdEmpleado);
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
                using (GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext())
                {
                    foreach (ListViewItem itemRow in lstvAsignadas.SelectedItems)
                    {

                        GdEmpleadosFmlEtiquetas EtiFml = new GdEmpleadosFmlEtiquetas();
                        EtiFml.IdEmpleadoFml = CEmp.IdEmpleado;
                        EtiFml.Id = Convert.ToInt32(itemRow.SubItems[0].Text);

                        db.GdEmpleadosFmlEtiquetas.Remove(EtiFml);
                        db.SaveChanges();

                        EtiFml = null;
                    }

                    CargarListaDisponibles();
                    CargarListaAsignadas(CEmp.IdEmpleado);
                }
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }

        }

        private void lstvDisponibles_DoubleClick(object sender, EventArgs e)
        {
            btnAnadir.PerformClick();
        }

        private void lstvAsignadas_DoubleClick(object sender, EventArgs e)
        {
            btnQuitar.PerformClick();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Desea salir?", "Etiquetar Empleado FML", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }
        }

        #endregion
    }
}
