using System;
using System.Collections.Generic;

namespace GendocsModeloDatos.models
{
    public partial class GdProyectoApoyosDetGenesis
    {
        public int Id { get; set; }
        public int? IdApoyo { get; set; }
        public int? IdGcdet { get; set; }
        public string Campo { get; set; }
        public string Valor { get; set; }
        public int? Cuenta { get; set; }
    }
}
