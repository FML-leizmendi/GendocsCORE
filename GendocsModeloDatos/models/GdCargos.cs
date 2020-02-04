using System;
using System.Collections.Generic;

namespace GendocsForms.models
{
    public partial class GdCargos
    {
        public int IdCargo { get; set; }
        public string Cargo { get; set; }
        public int? IdCargoSuperior { get; set; }
    }
}
