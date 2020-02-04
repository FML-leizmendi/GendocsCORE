using System;
using System.Collections.Generic;

namespace GendocsForms.models
{
    public partial class GdProyectosHitos
    {
        public int IdProyectoHito { get; set; }
        public int IdProyecto { get; set; }
        public int IdHito { get; set; }
        public string Hito { get; set; }
        public bool? HechoSn { get; set; }
        public string SubhitosHechos { get; set; }
        public DateTime? Fhecho { get; set; }
        public DateTime? Fplazo { get; set; }
        public DateTime? Fcaducidad { get; set; }
        public bool? AcabadoSn { get; set; }
        public string Notas { get; set; }
        public bool? IncluirEnNotasGenerales { get; set; }
        public DateTime? Falarma { get; set; }
        public decimal? Ord { get; set; }
        public int? IdProyectoHitoPadre { get; set; }
        public bool? ReplanteoSn { get; set; }
        public bool? ReplanteoOk { get; set; }
        public string TrelloCard { get; set; }
    }
}
