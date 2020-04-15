using GendocsModeloDatos.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GendocsForms
{
    public partial class clsRecursos
    {
        public int IdRecurso { get; set; }
        public int? IdRecursosActivo { get; set; }
        public string CodRecurso { get; set; }
        public string RecursoContratacion { get; set; }
        public string Unidad { get; set; }
        public decimal? CosteManodeObra { get; set; }
        public decimal? CosteMateriales { get; set; }
        public decimal? CosteTotal { get; set; }
        public bool? Prohibido { get; set; }

        public bool EsProhibido { get; set; } = false;

        public List<int> lstId = new List<int>();

        public void CargarFrmRecursos()
        {
            FrmRecursos frm = new FrmRecursos(this);
            IdRecurso = lstId[0];
            frm.ShowDialog();
        }

        public void ModificarProhibidos()
        {
            try
            {
                {
                    using (GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext())
                        if (EsProhibido)
                        {
                            var lst = from a in db.GdRecursos
                                                  where (lstId.Contains(a.IdRecurso))
                                                  select a;
                            lst.ToList();
                            foreach (var item in lst)
                            {
                                item.Prohibido = true;
                            }
                            db.SaveChanges();
                        }
                        else
                        {
                            var lst = from a in db.GdRecursos
                                      where (lstId.Contains(a.IdRecurso))
                                      select a;
                            lst.ToList();
                            foreach (var item in lst)
                            {
                                item.Prohibido = false;
                            }
                            db.SaveChanges();
                        }         
                } 
             MessageBox.Show("Los cambios han sido guardados correctamente", "Modificar Recursos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }

        }

        public void EliminarRecurso ()
        {
            try
            {
                using (GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext())
                {
                    var cSelect = from x in db.GdRecursos
                                  where x.IdRecurso == IdRecurso
                                  select x;

                    db.GdRecursos.RemoveRange(cSelect);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }
        }
    }
}
