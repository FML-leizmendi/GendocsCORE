using System;
using System.Collections.Generic;

namespace GendocsModeloDatos.models
{
    public partial class GdRecursos
    {
        public int IdRecurso { get; set; }
        public int? IdRecursosActivo { get; set; }
        public string CodRecurso { get; set; }
        public string RecursoContratacion { get; set; }
        public string Unidad { get; set; }
        public decimal? CosteManodeObra { get; set; }
        public decimal? CosteMateriales { get; set; }
        public decimal? CosteTotal { get; set; }
        public bool? Prohibido { get; set; }
    }
}
