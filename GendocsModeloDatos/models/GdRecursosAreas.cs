using System;
using System.Collections.Generic;

namespace GendocsModeloDatos.models
{
    public partial class GdRecursosAreas
    {
        public int IdRecursosArea { get; set; }
        public string Area { get; set; }
        public float? Orden { get; set; }
        public int IdCliente { get; set; }
    }
}
