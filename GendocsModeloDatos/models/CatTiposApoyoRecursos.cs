using System;
using System.Collections.Generic;

namespace GendocsModeloDatos.models
{
    public partial class CatTiposApoyoRecursos
    {
        public int Id { get; set; }
        public int? IdTipoApoyo { get; set; }
        public int? IdRecurso { get; set; }
    }
}
