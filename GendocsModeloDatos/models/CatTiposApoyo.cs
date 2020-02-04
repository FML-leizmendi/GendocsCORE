using System;
using System.Collections.Generic;

namespace GendocsForms.models
{
    public partial class CatTiposApoyo
    {
        public int IdTipoApoyo { get; set; }
        public string Serie { get; set; }
        public string TipoApoyo { get; set; }
        public decimal? Lado { get; set; }
        public decimal? Ord { get; set; }
        public int? Mid { get; set; }
    }
}
