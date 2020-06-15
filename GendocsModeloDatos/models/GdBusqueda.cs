using System;
using System.Collections.Generic;
using System.Text;

namespace GendocsModeloDatos.models
{
    public partial class GdBusqueda
    {
        public string CodBusqueda { get; set; }
        public string StrSQL { get; set; }
        public int? NumColumnas { get; set; }

        public String AnchoColumnas { get; set; }

        public string Titulo { get; set; }

        public String TextoOtra { get; set; }
        public int AnchoFrm { get; set; }

        public int AltoFrm { get; set; }
    }
}
