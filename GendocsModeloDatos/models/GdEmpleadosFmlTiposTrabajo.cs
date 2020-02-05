using System;
using System.Collections.Generic;

namespace GendocsModeloDatos.models
{
    public partial class GdEmpleadosFmlTiposTrabajo
    {
        public int Id { get; set; }
        public int IdEmpleadoFml { get; set; }
        public int? IdTipoTrabajo { get; set; }
        public string Provincia { get; set; }
        public int? Prioridad { get; set; }
    }
}
