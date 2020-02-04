using System;
using System.Collections.Generic;

namespace GendocsForms.models
{
    public partial class GdProyectoLineas
    {
        public int IdLinea { get; set; }
        public int? IdProyecto { get; set; }
        public string Subestación { get; set; }
        public string NumLinea { get; set; }
        public int? Orden { get; set; }
    }
}
