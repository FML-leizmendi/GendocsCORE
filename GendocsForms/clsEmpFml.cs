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
            // frm.cEmp = this;
            IdEmpleado = lstId[0];
            CargarEmpleado();
            frm.ShowDialog();
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
                //int IdEmpleadoFml = lstId.IndexOf(IdEmpleado);
                DialogResult result = DialogResult.No;
                if (EsAlta)
                {
                    result = MessageBox.Show("¿Desea crear un nuevo Usuario?", "Empleados FML", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }
                else
                {
                    result = MessageBox.Show("¿Desea modificar los datos?", "Empleados FML", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }


                if (result == DialogResult.Yes)
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
