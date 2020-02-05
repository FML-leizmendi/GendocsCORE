using System;
using System.Collections.Generic;

namespace GendocsModeloDatos.models
{
    public partial class GdDocCampos
    {
        public int IdDocCampo { get; set; }
        public int? IdProyecto { get; set; }
        public string Campo { get; set; }
        public int? IdCampoPro { get; set; }
        public int? IdDoc { get; set; }
        public int? IdCampo { get; set; }
        public bool? Valor1 { get; set; }
        public int? Valor4 { get; set; }
        public decimal? Valor5 { get; set; }
        public DateTime? Valor8 { get; set; }
        public string Valor10 { get; set; }
        public string Valor12 { get; set; }
        public string ValorExp { get; set; }
    }
}
