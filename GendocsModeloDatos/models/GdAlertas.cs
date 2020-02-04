using System;
using System.Collections.Generic;

namespace GendocsForms.models
{
    public partial class GdAlertas
    {
        public int IdAlerta { get; set; }
        public int? IdProyectoHito { get; set; }
        public string Alerta { get; set; }
        public DateTime? Fecha { get; set; }
        public string User { get; set; }
    }
}
