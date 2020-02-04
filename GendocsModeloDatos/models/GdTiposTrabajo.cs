using System;
using System.Collections.Generic;

namespace GendocsForms.models
{
    public partial class GdTiposTrabajo
    {
        public int IdTipoTrabajo { get; set; }
        public string TipoTrabajo { get; set; }
        public decimal? Ord { get; set; }
        public int? PlazoEntregaDias { get; set; }
        public int? TipoTrabajoAlb { get; set; }
    }
}
