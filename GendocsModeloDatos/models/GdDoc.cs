using System;
using System.Collections.Generic;

namespace GendocsForms.models
{
    public partial class GdDoc
    {
        public int IdDoc { get; set; }
        public int? IdProyecto { get; set; }
        public int? IdModeloDoc { get; set; }
        public string NombreDoc { get; set; }
        public string DocumentoGenerado { get; set; }
        public string LastUpdateU { get; set; }
        public DateTime? LastUpdateF { get; set; }
    }
}
