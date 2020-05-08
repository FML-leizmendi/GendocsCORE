using System;
using System.Collections.Generic;

namespace GendocsModeloDatos.models
{
    public partial class GdColumnasD
    {
        public int IdColumnaD { get; set; }
        public int? IdColumnaC { get; set; }
        public int? NumCol { get; set; }

        public String NameField { get; set; }

        public int? Ancho { get; set; }

        public String OrderBy { get; set; }
        public bool Visible { get; set; }
    }
}
