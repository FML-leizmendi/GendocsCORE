using System;
using System.Collections.Generic;

namespace GendocsModeloDatos.models
{
    public partial class GdProyectoTipos
    {
        public GdProyectoTipos()
        {
            GdProyectos = new HashSet<GdProyectos>();
        }

        public string CodTipoProyecto { get; set; }
        public string TipoProyecto { get; set; }
        public int? Orden { get; set; }
        public string CarpetasModelo { get; set; }

        public virtual ICollection<GdProyectos> GdProyectos { get; set; }
    }
}
