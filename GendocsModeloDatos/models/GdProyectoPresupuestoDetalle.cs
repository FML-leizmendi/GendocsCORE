using System;
using System.Collections.Generic;

namespace GendocsForms.models
{
    public partial class GdProyectoPresupuestoDetalle
    {
        public int IdPtoDet { get; set; }
        public int? IdPresupuesto { get; set; }
        public int? IdProPtoActuacion { get; set; }
        public int? IdProPtoLocalidad { get; set; }
        public int? IdProAdetGenesis { get; set; }
        public int? IdRecurso { get; set; }
        public string CodRecurso { get; set; }
        public string RecursoContratacion { get; set; }
        public string Unidad { get; set; }
        public decimal? Cantidad { get; set; }
        public decimal? PrecioUnitario { get; set; }
        public decimal? Importe { get; set; }
        public float? Orden { get; set; }
    }
}
