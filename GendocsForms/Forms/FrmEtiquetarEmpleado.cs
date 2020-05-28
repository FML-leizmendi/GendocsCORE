using GendocsModeloDatos.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GendocsForms
{
    public partial class FrmEtiquetarEmpleado : Form
    {
        public ClsEmp CEmp { get; set; }

        public FrmEtiquetarEmpleado(ClsEmp cemp)
        {
            CEmp = cemp;
            InitializeComponent();
        }

        public FrmEtiquetarEmpleado()
        {
            InitializeComponent();
        }

        #region "Eventos Privados"

        private void BtnAnadir_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstvDisponibles.SelectedItems.Count < 1)
                {
                    MessageBox.Show("Debe seleccionar al menos una etiqueta para añadir a la lista de Asignadas", "Etiquetar Empleado FML", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    using GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext();
                    foreach (ListViewItem itemRow in lstvDisponibles.SelectedItems)
                    {
                        GdEmpleadosEtiquetas Eti = new GdEmpleadosEtiquetas
                        {
                            IdEmpleado = CEmp.IdEmpleado,
                            IdEtiqueta = Convert.ToInt32(itemRow.SubItems[0].Text)
                        };

                        db.GdEmpleadosEtiquetas.Add(Eti);
                        db.SaveChanges();

                        Eti = null;
                    }

                    CargarListaDisponibles();
                    CargarListaAsignadas(CEmp.IdEmpleado);
                }
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        private void BtnQuitar_Click(object sender, EventArgs e)
        {
            try
            {
                using GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext();
                foreach (ListViewItem itemRow in lstvAsignadas.SelectedItems)
                {

                    GdEmpleadosEtiquetas Eti = new GdEmpleadosEtiquetas
                    {
                        IdEmpleado = CEmp.IdEmpleado,
                        Id = Convert.ToInt32(itemRow.SubItems[0].Text)
                    };

                    db.GdEmpleadosEtiquetas.Remove(Eti);
                    db.SaveChanges();

                    Eti = null;
                }

                CargarListaDisponibles();
                CargarListaAsignadas(CEmp.IdEmpleado);
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        private void LstvDisponibles_DoubleClick(object sender, EventArgs e)
        {
            btnAnadir.PerformClick();
        }

        private void LstvAsignadas_DoubleClick(object sender, EventArgs e)
        {
            btnQuitar.PerformClick();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
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
                _ = ex.Message;
            }
        }
        #endregion

        #region "Métodos Privados"
        public void CargarListaDisponibles()
        {
            try
            {
                using GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext();
                lstvDisponibles.Items.Clear();

                var lst = (from d in db.GdEtiquetas
                           join f in (from e in db.GdEmpleadosEtiquetas
                                      where e.IdEmpleado == CEmp.IdEmpleado
                                      select e)
                           on d.IdEtiqueta equals f.IdEtiqueta into joinedT
                           from result in joinedT.DefaultIfEmpty()
                           where result.Id == null
                           //orderby d.IdEtiqueta
                           select new
                           {
                               d.IdEtiqueta,
                               d.Etiqueta
                           }

                       ).ToList();

                foreach (var etiqueta in lst)
                {
                    ListViewItem item = new ListViewItem();
                    item = lstvDisponibles.Items.Add(etiqueta.IdEtiqueta.ToString());
                    item.SubItems.Add(etiqueta.Etiqueta);
                }
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }

        }

        public void CargarListaAsignadas(int IdEmp)
        {
            try
            {
                using GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext();
                lstvAsignadas.Items.Clear();

                var lst = (from d in db.GdEtiquetas
                           join x in db.GdEmpleadosEtiquetas
                           on d.IdEtiqueta equals x.IdEtiqueta
                           where x.IdEmpleado == IdEmp
                           orderby d.IdEtiqueta
                           select new { x.Id, d.IdEtiqueta, d.Etiqueta }

                       ).ToList();

                foreach (var etiqueta in lst)
                {
                    ListViewItem item = new ListViewItem();
                    item = lstvAsignadas.Items.Add(etiqueta.Id.ToString());
                    item.SubItems.Add(etiqueta.Etiqueta);
                    //item.SubItems.Add(etiqueta.IdEtiqueta);

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
