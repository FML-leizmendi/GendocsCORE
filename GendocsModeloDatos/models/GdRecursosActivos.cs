using System;
using System.Collections.Generic;

namespace GendocsForms.models
{
    public partial class GdRecursosActivos
    {
        public int IdRecursosActivo { get; set; }
        public int? IdRecursosArea { get; set; }
        public string Activo { get; set; }
        public float? Orden { get; set; }
    }
}
