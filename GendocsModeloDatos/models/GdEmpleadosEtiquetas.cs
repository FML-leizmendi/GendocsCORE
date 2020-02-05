using System;
using System.Collections.Generic;

namespace GendocsModeloDatos.models
{
    public partial class GdEmpleadosEtiquetas
    {
        public int Id { get; set; }
        public int? IdEmpleado { get; set; }
        public int? IdEtiqueta { get; set; }
    }
}
