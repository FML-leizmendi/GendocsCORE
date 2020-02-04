using System;
using System.Collections.Generic;

namespace GendocsForms.models
{
    public partial class GdModeloEsqCampos
    {
        public int IdCampo { get; set; }
        public int? IdModeloDoc { get; set; }
        public int? IdEsquema { get; set; }
        public string Campo { get; set; }
        public int? TipoCampo { get; set; }
        public decimal? Orden { get; set; }
        public string Default { get; set; }
        public string Funcion { get; set; }
        public string FuncionAuto { get; set; }
        public string FuncionNext { get; set; }
        public string CodCampo { get; set; }
        public string Info { get; set; }
    }
}
