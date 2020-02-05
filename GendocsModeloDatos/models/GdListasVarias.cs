using System;
using System.Collections.Generic;

namespace GendocsModeloDatos.models
{
    public partial class GdListasVarias
    {
        public int IdElemento { get; set; }
        public string Lista { get; set; }
        public string Elemento { get; set; }
        public decimal? Ord { get; set; }
    }
}
