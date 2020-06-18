using GendocsModeloDatos.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace GendocsForms
{
    public partial class ClsPedidoCab
    {
        public int IdPedidoCab { get; set; }
        public int IdPedidoDet { get; set; }
        public int IdUC { get; set; }
        public int Cantidad { get; set; }
        public string NumRef { get; set; }
        public int? IdCliente { get; set; }
        public DateTime? FechaPedido { get; set; }
        public int? IdEmpleadoGestor { get; set; }
        public string Gestor { get; set; }
        public string NumContrato { get; set; }
        public DateTime? FechaEntrega { get; set; }
        public string NumObra { get; set; }
        public string DescripcionObra { get; set; }
        public string Actuacion { get; set; }
        public string Provincia { get; set; }
        public string Poblacion { get; set; }
        public string Direccion { get; set; }
        public int? IdProyecto { get; set; }
        public int? IvaSn { get; set; }
        public decimal? TotalImporte { get; set; }
        public string FilePdf { get; set; }
        public string Txt1 { get; set; }
        public string Txt2 { get; set; }
        public decimal? CoeficientePrecio { get; set; }
        public decimal? CoeficienteFacturacion { get; set; }

        public List<int> lstIdPedido = new List<int>();

        public bool esNuevo = false;

        public bool EsAlta = false;

        public void CargarFrmPedidoCab()
        {
            FrmPedidoEdit frm = new FrmPedidoEdit(this);
            if (!EsAlta)
            {
                CargarPedido();
            }
            frm.ShowDialog();
        }

        public void CargarPedido()
        {
            using GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext();
            var lst = (from d in db.GdPedidosCab
                       where (d.IdPedidoCab == this.IdPedidoCab)
                       select d).ToList();

            if (lst.Count() != 0)
            {
                foreach (var item in lst)
                {
                    IdPedidoCab = item.IdPedidoCab;
                    NumContrato = item.NumContrato;
                    NumRef = item.NumRef;
                    NumObra = item.NumObra;
                    IdCliente = item.IdCliente;
                    DescripcionObra = item.DescripcionObra;
                    FechaPedido = item.FechaPedido;
                    FechaEntrega = item.FechaEntrega;
                    Actuacion = item.Actuacion;
                    Gestor = item.Gestor;
                    FilePdf = item.FilePdf;
                    Provincia = item.Provincia;
                    IdEmpleadoGestor = item.IdEmpleadoGestor;
                    Txt1 = item.Txt1;
                    Txt2 = item.Txt2;
                    Poblacion = item.Poblacion;
                    Direccion = item.Direccion;
                    CoeficientePrecio = item.CoeficientePrecio;
                    CoeficienteFacturacion = item.CoeficienteFacturacion;
                }
            }
            else
            {
                IdPedidoCab = 0;
                NumContrato = string.Empty;
                NumRef = string.Empty;
                NumObra = string.Empty;
                IdCliente = 0;
                DescripcionObra = string.Empty;
                FechaPedido = null;
                FechaEntrega = null;
                Gestor = string.Empty;
                FilePdf = string.Empty;
                Provincia = string.Empty;
                IdEmpleadoGestor = 0;
                Txt2 = string.Empty;
                Poblacion = string.Empty;
                Direccion = string.Empty;
                CoeficientePrecio = 0;
                CoeficienteFacturacion = 0;
            }
        }

        public void EliminarUnidadContructiva()
        {
            DialogResult result = MessageBox.Show("¿Desea eliminar la linea seleccionada?", "Unidad Constructiva", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext();
                var cSelect = from x in db.GdPedidosDet
                              where x.IdPedidoCab == IdPedidoCab & x.IdPedidoDet == IdPedidoDet
                              select x;

                db.GdPedidosDet.RemoveRange(cSelect);
                db.SaveChanges();
            }
            CargarPedido();
        }

        public void GuardarUnidadContructiva()
        {
            try
            {
                {
                    using GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext();
                    if (EsAlta)
                    {
                        if (this.IdUC != 0)
                        {
                            var lst = (from a in db.GdUnidadesConstructivas
                                       where a.IdUc == this.IdUC
                                       select a).FirstOrDefault();

                            GdPedidosDet PedDet = new GdPedidosDet
                            {
                                IdPedidoCab = IdPedidoCab,
                                CodigoUc = lst.CodigoUc,
                                DescripcionUc = lst.DescripcionUc,
                                Cantidad = Cantidad,
                                Unidad = lst.Ud,
                                Precio = lst.PrecioUnidad
                            };
                            PedDet.Importe = PedDet.Cantidad * PedDet.Precio;
                            PedDet.PlazoEntrega = DateTime.UtcNow.Date;
                            PedDet.IdUc = lst.IdUc;
                            PedDet.IdResponsableFml = 11;
                            PedDet.IdEstadoTrabajo = 1;

                            db.GdPedidosDet.Add(PedDet);
                            db.SaveChanges();
                        }
                        else
                        {
                            //{
                            //    var query = (from a in db.GdEmpleados
                            //                 where a.IdEmpleado == IdEmpleado
                            //                 select a).FirstOrDefault();

                            //    query.IdEmpleado = IdEmpleado;
                            //    query.Empleado = Empleado;
                            //    query.IdCargo = IdCargo;
                            //    query.IdCliente = IdCliente;
                            //    query.IdEmpleadoSuperior = IdEmpleadoSuperior;
                            //    query.IdCliente = IdCliente;
                            //    query.Telefono = Telefono;
                            //    query.Email = Email;
                            //    query.Etiquetas = Etiquetas;

                            //    db.SaveChanges();

                            //    MessageBox.Show("Los cambios han sido modificados correctamente", "Modificar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //}
                        }
                        CargarPedido();
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
