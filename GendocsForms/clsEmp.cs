using GendocsModeloDatos.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GendocsForms
{
    public class ClsEmp
    {
        public int IdEmpleado { get; set; }
        public string Empleado { get; set; }
        public int? IdCliente { get; set; }
        public int? IdCargo { get; set; }
        public int? CodigoPersona { get; set; }
        public int? IdEmpleadoSuperior { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Etiquetas { get; set; }
        public List<int> LstId { get; set; }
        public bool EsNuevo { get; set; } = false;
        public bool EsAlta { get; set; } = false;

        public void CargarFrmEmpleados()
        {
            FrmMantenimientoEmpleados frm = new FrmMantenimientoEmpleados(this);
            IdEmpleado = LstId[0];
            CargarEmpleado();
            frm.ShowDialog();
        }

        public void CargarFrmEmpleados2()
        {
            FrmMantenimientoEmpleados2 frm = new FrmMantenimientoEmpleados2(this);
            if (EsNuevo)
            {
                IdEmpleado = 0;
                EsAlta = true;
            }
            else
            {
                IdEmpleado = LstId[0];
                CargarEmpleado();
            }
            frm.ShowDialog();
        }
        public void AsignarEtiquetasFML()
        {
            FrmEtiquetarEmpleado frm = new FrmEtiquetarEmpleado(this);
            CargarEmpleado();
            frm.CargarListaAsignadas(IdEmpleado);
            frm.CargarListaDisponibles();
            frm.ShowDialog();
            Etiquetame();
        }

        public void CargarEmpleado()
        {
            using GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext();
            var lst = (from d in db.GdEmpleados
                       where (d.IdEmpleado == this.IdEmpleado)
                       select d

                   ).ToList();

            if (lst.Count() != 0)
            {
                foreach (var item in lst)
                {
                    Empleado = item.Empleado;
                    IdCliente = item.IdCliente;
                    IdCargo = item.IdCargo;
                    CodigoPersona = item.CodigoPersona;
                    IdEmpleadoSuperior = item.IdEmpleadoSuperior;
                    Telefono = item.Telefono;
                    Email = item.Email;
                    Etiquetas = item.Etiquetas;
                }
            }
            else
            {
                Empleado = String.Empty;
                IdCliente = 0;
                IdCargo = 0;
                CodigoPersona = 0;
                IdEmpleadoSuperior = 0;
                Etiquetas = string.Empty;
                Email = string.Empty;
                Telefono = string.Empty;
            }
        }

        public void CargarListaAsignadas()
        {
            try
            {
                using GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext();
                var lst = (from d in db.GdEmpleados
                           where (d.IdEmpleado == this.IdEmpleado)
                           select d.Etiquetas

                       ).ToList();
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
                using GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext();
                var lst = (from d in db.GdEmpleados
                           select d.Etiquetas

                       ).ToList();
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
                using GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext();
                Etiquetas = string.Empty;

                var lst = (from d in db.GdEmpleadosEtiquetas
                           join f in db.GdEtiquetas
                           on d.IdEtiqueta equals f.IdEtiqueta
                           where d.IdEmpleado == IdEmpleado
                           select new { f.Etiqueta }

                              ).ToList();

                foreach (var list in lst)
                {
                    Etiquetas += list.Etiqueta + "~";
                }
                GuardarUsuario();
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }
        }

        public void IrSiguiente()
        {
            int i = LstId.IndexOf(IdEmpleado);

            if (i != -1 && i + 1 < LstId.Count())
            {
                IdEmpleado = LstId[i + 1];
                CargarEmpleado();
            }
        }

        public void IrAnterior()
        {
            int i = LstId.IndexOf(IdEmpleado);

            if (i != -1 && i > 0)
            {
                IdEmpleado = LstId[i - 1];
                CargarEmpleado();
            }
        }

        public void IrPrimero()
        {
            IdEmpleado = LstId[0];
            CargarEmpleado();
        }

        public void IrUltimo()
        {
            IdEmpleado = LstId.Count() - 1;
            CargarEmpleado();
        }

        public void EliminarUsuario()
        {
            DialogResult result = MessageBox.Show("¿Desea eliminar este usuario?", "Empleados FML", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using (GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext())
                {
                    var cSelect = from x in db.GdEmpleados
                                  where x.IdEmpleado == IdEmpleado
                                  select x;

                    db.GdEmpleados.RemoveRange(cSelect);
                    LstId.Remove(IdEmpleado);
                    db.SaveChanges();
                }
                CargarEmpleado();
            }
        }

        public void EliminarEmpleado()
        {
            using (GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext())
            {
                var cSelect = from x in db.GdEmpleados
                              where x.IdEmpleado == IdEmpleado
                              select x;

                db.GdEmpleados.RemoveRange(cSelect);
                db.SaveChanges();
            }
            CargarEmpleado();
        }
        public void GuardarUsuario()
        {
            try
            {
                {
                    using (GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext())
                        if (EsAlta)
                        {
                            GdEmpleados Emp = new GdEmpleados
                            {
                                Empleado = Empleado,
                                IdCliente = IdCliente,
                                IdCargo = IdCargo,
                                //Emp.CodigoPersona = CodigoPersona;
                                IdEmpleadoSuperior = IdEmpleadoSuperior,
                                Telefono = Telefono,
                                Email = Email,
                                Etiquetas = Etiquetas
                            };

                            db.GdEmpleados.Add(Emp);
                            db.SaveChanges();

                            //MessageBox.Show("Los cambios han sido guardados correctamente", "Guardar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            {
                                var query = (from a in db.GdEmpleados
                                             where a.IdEmpleado == IdEmpleado
                                             select a).FirstOrDefault();

                                query.IdEmpleado = IdEmpleado;
                                query.Empleado = Empleado;
                                query.IdCargo = IdCargo;
                                query.IdCliente = IdCliente;
                                query.IdEmpleadoSuperior = IdEmpleadoSuperior;
                                query.IdCliente = IdCliente;
                                query.Telefono = Telefono;
                                query.Email = Email;
                                query.Etiquetas = Etiquetas;

                                db.SaveChanges();

                                //MessageBox.Show("Los cambios han sido modificados correctamente", "Modificar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

