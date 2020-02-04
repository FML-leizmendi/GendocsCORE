using System;
using System.Collections.Generic;

namespace GendocsForms.models
{
    public partial class GdModeloEsq
    {
        public int IdEsquema { get; set; }
        public int? IdModeloDoc { get; set; }
        public int? IdEsquemaSuper { get; set; }
        public decimal? Orden { get; set; }
        public string TituloEsquema { get; set; }
        public bool? Expanded { get; set; }
        public bool? NumerarHijos { get; set; }
        public string ModeloWord { get; set; }
        public string IdParents { get; set; }
        public string Orders { get; set; }
    }
}
