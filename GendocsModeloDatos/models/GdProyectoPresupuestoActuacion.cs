using System;
using System.Collections.Generic;

namespace GendocsModeloDatos.models
{
    public partial class GdProyectoPresupuestoActuacion
    {
        public int IdProPtoActuacion { get; set; }
        public int? IdPresupuesto { get; set; }
        public string CodActuacion { get; set; }
        public string Actuacion { get; set; }
        public float? Orden { get; set; }
    }
}
