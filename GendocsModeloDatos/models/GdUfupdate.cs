using System;
using System.Collections.Generic;

namespace GendocsModeloDatos.models
{
    public partial class GdUfupdate
    {
        public int Id { get; set; }
        public string Uupdate { get; set; }
        public DateTime? Fupdate { get; set; }
        public int? IdProyecto { get; set; }
        public int? IdDoc { get; set; }
        public int? IdProyectoHito { get; set; }
        public string Accion { get; set; }
    }
}
