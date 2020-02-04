using System;
using System.Collections.Generic;

namespace GendocsForms.models
{
    public partial class GdProyectoPresupuestos
    {
        public int IdPresupuesto { get; set; }
        public int? IdProyecto { get; set; }
        public string Presupuesto { get; set; }
        public int? Orden { get; set; }
        public decimal? TotalImporte { get; set; }
    }
}
