using System;
using System.Collections.Generic;

namespace GendocsForms.models
{
    public partial class CatTiposApoyoRecursos
    {
        public int Id { get; set; }
        public int? IdTipoApoyo { get; set; }
        public int? IdRecurso { get; set; }
    }
}
