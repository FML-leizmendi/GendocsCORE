using System;
using System.Collections.Generic;

namespace GendocsForms.models
{
    public partial class GdUnidadesConstructivas
    {
        public int IdUc { get; set; }
        public int? IdCliente { get; set; }
        public string CodigoUc { get; set; }
        public string CodigoUc2 { get; set; }
        public string DescripcionUc { get; set; }
        public string Ud { get; set; }
        public decimal? PrecioUnidad { get; set; }
        public int? IdTipoTrabajo { get; set; }
        public int? PlazoEntregaDias { get; set; }
    }
}
