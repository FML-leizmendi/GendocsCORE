using System;
using System.Collections.Generic;

namespace GendocsForms.models
{
    public partial class CatApoyoCuerpos
    {
        public int Mid { get; set; }
        public int? NumMatSap { get; set; }
        public int? CodTipMatCuerpo { get; set; }
        public string TipMatCuerpo { get; set; }
        public int? CodSubtipMatCuerpo { get; set; }
        public string SubtipMatCuerpo { get; set; }
        public int? CodModCuerpo { get; set; }
        public string ModCuerpo { get; set; }
        public int? AltCuerpoMm { get; set; }
        public int? CanEsfuerMaxCuerpoDN { get; set; }
        public int? Ordinal { get; set; }
    }
}
