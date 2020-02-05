using System;
using System.Collections.Generic;

namespace GendocsModeloDatos.models
{
    public partial class GdPedidosDet
    {
        public int IdPedidoDet { get; set; }
        public int? IdPedidoCab { get; set; }
        public string CodigoUc { get; set; }
        public string DescripcionUc { get; set; }
        public decimal? Cantidad { get; set; }
        public string Unidad { get; set; }
        public decimal? Precio { get; set; }
        public decimal? Importe { get; set; }
        public DateTime? PlazoEntrega { get; set; }
        public int? IdUc { get; set; }
        public int? IdResponsableFml { get; set; }
        public int? IdEstadoTrabajo { get; set; }

        public virtual GdPedidosCab IdPedidoCabNavigation { get; set; }
    }
}
