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
using GendocsModeloDatos.models;
using GendocsForms.Forms;

namespace GendocsForms
{
    public class clsEmpFml
    {
        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Nif { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public string User { get; set; }
        public int? Estado { get; set; }
        public string Etiquetas { get; set; }
        public string TrelloIdMember { get; set; }
        public int? CodigoPersona { get; set; }
        public string Pass { get; set; }
        public List<int> lstId { get; set; }

        public bool EsAlta { get; set; } = false;

        public void CargarFrmEmpleadosFML()
        {
            frmMantenimientoEmpleadosFML frm = new frmMantenimientoEmpleadosFML(this);
            IdEmpleado = lstId[0];
            CargarEmpleado();
            frm.ShowDialog();
        }

        public void AsignarEtiquetasFML()
        {
            frmEtiquetarEmpleadoFML frm = new frmEtiquetarEmpleadoFML(this);
            CargarEmpleado();
            frm.CargarListaAsignadas(IdEmpleado);
            frm.CargarListaDisponibles();
            frm.ShowDialog();
            Etiquetame();
        }


        public void CargarEmpleado()
        {
            using (GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext())
            {
                var lst = (from d in db.GdEmpleadosFml
                           where (d.IdEmpleadoFml == this.IdEmpleado)
                           select d

                       ).ToList();

                if (lst.Count() != 0)
                {
                    foreach (var item in lst)
                    {
                        Nombre = item.Nombre;
                        Apellidos = item.Apellidos;
                        Nif = item.Nif;
                        Telefono = item.Telefono;
                        Email = item.Email;
                        Direccion = item.Direccion;
                        User = item.User;
                        Etiquetas = item.Etiquetas;
                        TrelloIdMember = item.TrelloIdMember;
                        CodigoPersona = item.CodigoPersona;
                        Pass = item.Pass;
                    }
                }
                else
                {
                    Nombre = String.Empty;
                    Email = string.Empty;
                    Etiquetas = string.Empty;
                    Nif = string.Empty;
                    Telefono = string.Empty;
                }

            }
        }

        public void CargarListaAsignadas()
        {
            try
            {
                using (GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext())
                {
                    var lst = (from d in db.GdEmpleadosFml
                               where (d.IdEmpleadoFml == this.IdEmpleado)
                               select d.Etiquetas

                           ).ToList();
                }
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }

        }

        public void CargarListaDisponibles()
        {
            try
            {
                using (GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext())
                {
                    var lst = (from d in db.GdEmpleadosFml
                               select d.Etiquetas

                           ).ToList();
                }
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }

        }

        public void Etiquetame()
        {
            try
            {
                using (GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext())
                {
                    Etiquetas = string.Empty;

                    var lst = (from d in db.GdEmpleadosFmlEtiquetas
                               join f in db.GdEtiquetasFml
                               on d.IdEtiqueta equals f.IdEtiqueta
                               where d.IdEmpleadoFml == IdEmpleado
                               select new { f.EtiquetaFml }

                                  ).ToList();

                    foreach (var list in lst)
                    {
                        Etiquetas += list.EtiquetaFml + "~";
                        GuardarUsuario();

                    }
                }
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }
        }

        public void IrSiguiente()
        {
            int i = lstId.IndexOf(IdEmpleado);

            if (i != -1 && i + 1 < lstId.Count())
            {
                IdEmpleado = lstId[i + 1];
                CargarEmpleado();
            }
        }

        public void IrAnterior()
        {
            int i = lstId.IndexOf(IdEmpleado);

            if (i != -1 && i > 0)
            {
                IdEmpleado = lstId[i - 1];
                CargarEmpleado();
            }
        }

        public void IrPrimero()
        {
            IdEmpleado = lstId[0];
            CargarEmpleado();
        }

        public void IrUltimo()
        {
            IdEmpleado = lstId[lstId.Count() - 1];
            CargarEmpleado();
        }

        public void EliminarUsuario()
        {
            DialogResult result = MessageBox.Show("¿Desea eliminar este usuario?", "Empleados FML", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using (GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext())
                {
                    var cSelect = from x in db.GdEmpleadosFml
                                  where x.IdEmpleadoFml == IdEmpleado
                                  select x;

                    db.GdEmpleadosFml.RemoveRange(cSelect);
                    lstId.Remove(IdEmpleado);
                    db.SaveChanges();
                }
                CargarEmpleado();
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
                            GdEmpleadosFml EmpFml = new GdEmpleadosFml();
                            //EmpFml.IdEmpleadoFml = UltimoIdRegistrado();
                            EmpFml.Nif = Nif;
                            EmpFml.Nombre = Nombre;
                            EmpFml.Apellidos = Apellidos;
                            EmpFml.Telefono = Telefono;
                            EmpFml.Email = Email;
                            EmpFml.Etiquetas = Etiquetas;

                            db.GdEmpleadosFml.Add(EmpFml);
                            db.SaveChanges();

                            MessageBox.Show("Los cambios han sido guardados correctamente", "Guardar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            {
                                var query = (from a in db.GdEmpleadosFml
                                             where a.IdEmpleadoFml == IdEmpleado
                                             select a).FirstOrDefault();

                                query.Nif = Nif;
                                query.Nombre = Nombre;
                                query.Apellidos = Apellidos;
                                query.Telefono = Telefono;
                                query.Email = Email;
                                query.Etiquetas = Etiquetas;

                                db.SaveChanges();

                                //MessageBox.Show("Los cambios han sido guardados correctamente", "Modificar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    CargarEmpleado();
                }
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }

        }

    }


}
