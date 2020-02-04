using System;
using System.Collections.Generic;

namespace GendocsForms.models
{
    public partial class GdClientes
    {
        public int IdCliente { get; set; }
        public string Cliente { get; set; }
        public int? CódigoPersona { get; set; }
    }
}
