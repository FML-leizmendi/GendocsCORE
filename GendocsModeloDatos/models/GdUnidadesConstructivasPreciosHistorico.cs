using System;
using System.Collections.Generic;

namespace GendocsForms.models
{
    public partial class GdUnidadesConstructivasPreciosHistorico
    {
        public int Id { get; set; }
        public int? IdUc { get; set; }
        public DateTime? Fecha { get; set; }
        public decimal? PrecioUc { get; set; }
        public string DescripcionUc { get; set; }
        public string Ud { get; set; }
    }
}
