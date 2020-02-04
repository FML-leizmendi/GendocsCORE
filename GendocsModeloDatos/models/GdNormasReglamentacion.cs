using System;
using System.Collections.Generic;

namespace GendocsForms.models
{
    public partial class GdNormasReglamentacion
    {
        public int IdNorma { get; set; }
        public string CodNorma { get; set; }
        public string Norma { get; set; }
        public decimal? Ord { get; set; }
        public bool? SiLineaAerea { get; set; }
        public bool? SiLineaSubterranea { get; set; }
        public bool? SiCentroTransformador { get; set; }
    }
}
