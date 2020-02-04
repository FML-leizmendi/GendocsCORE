using System;
using System.Collections.Generic;

namespace GendocsForms.models
{
    public partial class GdCamposProyecto
    {
        public int IdCampoPro { get; set; }
        public string CampoPro { get; set; }
        public int? TipoCampo { get; set; }
        public decimal? Orden { get; set; }
        public string Default { get; set; }
        public string Funcion { get; set; }
        public string FuncionAuto { get; set; }
        public string FuncionNext { get; set; }
        public string CodCampo { get; set; }
    }
}
