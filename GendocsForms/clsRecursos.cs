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

        public bool esNuevo = false;

        public bool EsAlta = false;

        public void CargarFrmRecursos()
        {
            FrmRecursos frm = new FrmRecursos(this);
            frm.WindowState = FormWindowState.Maximized;
            IdRecurso = lstId[0];
            frm.ShowDialog();
        }

        public void CargarFrmMantenimientoRecursos()
        {
            FrmMantenimientoRecursos frm = new FrmMantenimientoRecursos(this);
            if (!EsAlta)
            {
                IdRecurso = lstId[0];
                CargarRecurso();
            }
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

        public void GuardarUsuario()
        {
            try
            {
                {
                    using (GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext())
                        if (EsAlta)
                        {
                            GdRecursos recu = new GdRecursos();
                            //EmpFml.IdEmpleadoFml = UltimoIdRegistrado();
                            recu.CodRecurso = CodRecurso;
                            recu.RecursoContratacion = RecursoContratacion;
                            recu.Unidad = Unidad;
                            recu.Prohibido = Prohibido;
                            recu.CosteManodeObra = CosteManodeObra;
                            recu.CosteMateriales = CosteMateriales;
                            recu.CosteTotal = CosteTotal;

                            db.GdRecursos.Add(recu);
                            db.SaveChanges();

                            MessageBox.Show("Los cambios han sido guardados correctamente", "Guardar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            {
                                var query = (from a in db.GdRecursos
                                             where a.IdRecurso == IdRecurso
                                             select a).FirstOrDefault();

                                query.CodRecurso = CodRecurso;
                                query.RecursoContratacion = RecursoContratacion;
                                query.Unidad = Unidad;
                                query.Prohibido = Prohibido;
                                query.CosteManodeObra = CosteManodeObra;
                                query.CosteMateriales = CosteMateriales;
                                query.CosteTotal = CosteTotal;

                                db.SaveChanges();
                            }
                        }
                    CargarRecurso();
                }
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }
          }

        public void EliminarRecurso()
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

        public void CargarRecurso()
        {
            using (GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext())
            {
                var lst = (from d in db.GdRecursos
                           where (d.IdRecurso == this.IdRecurso)
                           select d

                       ).ToList();

                if (lst.Count() != 0)
                {
                    foreach (var item in lst)
                    {
                        IdRecursosActivo = item.IdRecursosActivo;
                        CodRecurso = item.CodRecurso;
                        RecursoContratacion = item.RecursoContratacion;
                        Unidad = item.Unidad;
                        CosteManodeObra = item.CosteManodeObra;
                        CosteMateriales = item.CosteMateriales;
                        CosteTotal = item.CosteTotal;
                        Prohibido = item.Prohibido;
                    }
                }
                else
                {
                    IdRecurso = 0;
                    CodRecurso = string.Empty;
                    RecursoContratacion = string.Empty;
                    Unidad = string.Empty;
                    CosteManodeObra = 0;
                    CosteMateriales = 0;
                    CosteTotal = 0;
                    Prohibido = true;
                }

            }
        }

        public void IrSiguiente()
        {
            int i = lstId.IndexOf(IdRecurso);

            if (i != -1 && i + 1 < lstId.Count())
            {
                IdRecurso = lstId[i + 1];
                CargarRecurso();
            }
        }

        public void IrAnterior()
        {
            int i = lstId.IndexOf(IdRecurso);

            if (i != -1 && i > 0)
            {
                IdRecurso = lstId[i - 1];
                CargarRecurso();
            }
        }

        public void IrPrimero()
        {
            IdRecurso = lstId[0];
            CargarRecurso();
        }

        public void IrUltimo()
        {
            IdRecurso = lstId[lstId.Count() - 1];
            CargarRecurso();
        }
    }
}
