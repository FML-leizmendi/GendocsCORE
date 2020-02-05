using System;
using System.Collections.Generic;

namespace GendocsModeloDatos.models
{
    public partial class GdProyectoApoyos
    {
        public int IdApoyo { get; set; }
        public int IdProyecto { get; set; }
        public int? IdLinea { get; set; }
        public string NumApoyo { get; set; }
        public bool? NuevoSn { get; set; }
        public bool? DesmontarSn { get; set; }
        public string SisRefCoord { get; set; }
        public decimal? CoordX { get; set; }
        public decimal? CoordY { get; set; }
        public decimal? CoordZ { get; set; }
        public float? VanoAnterior { get; set; }
        public float? VanoPosterior { get; set; }
        public float? CableTierra { get; set; }
        public float? Angulo { get; set; }
        public bool? AmarreSn { get; set; }
        public bool? AnclajeSn { get; set; }
        public string CodTipoApoyo { get; set; }
        public decimal? Altura { get; set; }
        public string Material { get; set; }
        public string Caracteristicas { get; set; }
        public int? Orden { get; set; }
    }
}
