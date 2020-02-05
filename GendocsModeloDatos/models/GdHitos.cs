using System;
using System.Collections.Generic;

namespace GendocsModeloDatos.models
{
    public partial class GdHitos
    {
        public int IdHito { get; set; }
        public string Hito { get; set; }
        public bool? BtSn { get; set; }
        public bool? MtSn { get; set; }
        public bool? AtSn { get; set; }
        public bool? IndicadorMecoSn { get; set; }
        public bool? FechaHechoSn { get; set; }
        public bool? FechaPlazoSn { get; set; }
        public bool? FechaCaducidadSn { get; set; }
        public string Funcion { get; set; }
        public string FuncionAuto { get; set; }
        public string FuncionNext { get; set; }
        public string Fase { get; set; }
        public bool? SigorSn { get; set; }
        public int? IdHitoPadre { get; set; }
        public bool? ReplanteoSn { get; set; }
        public decimal? Orden { get; set; }
        public decimal? OrdenS { get; set; }
    }
}
