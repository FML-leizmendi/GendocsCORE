using System;
using System.Collections.Generic;

namespace GendocsModeloDatos.models
{
    public partial class GdPedidosCab
    {
        public GdPedidosCab()
        {
            GdPedidosDet = new HashSet<GdPedidosDet>();
        }

        public int IdPedidoCab { get; set; }
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

        public virtual GdProyectos IdProyectoNavigation { get; set; }
        public virtual ICollection<GdPedidosDet> GdPedidosDet { get; set; }
    }
}
