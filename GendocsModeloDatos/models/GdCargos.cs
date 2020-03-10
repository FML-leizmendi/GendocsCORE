using System;
using System.Collections.Generic;

namespace GendocsModeloDatos.models
{
    public partial class GdCargos
    {
        public int IdCargo { get; set; }
        public string Cargo { get; set; }
        public int? IdCargoSuperior { get; set; }

        //public virtual ICollection<GdEmpleados> GdEmpleados { get; set; }
    }
}
