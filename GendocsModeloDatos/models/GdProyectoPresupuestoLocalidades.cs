using System;
using System.Collections.Generic;

namespace GendocsModeloDatos.models
{
    public partial class GdProyectoPresupuestoLocalidades
    {
        public int IdProPtoLocalidad { get; set; }
        public int? IdPresupuesto { get; set; }
        public string CodLocalidad { get; set; }
        public string Localidad { get; set; }
        public string Municipio { get; set; }
        public float? Orden { get; set; }
    }
}
