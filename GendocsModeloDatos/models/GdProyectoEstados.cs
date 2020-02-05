using System;
using System.Collections.Generic;

namespace GendocsModeloDatos.models
{
    public partial class GdProyectoEstados
    {
        public GdProyectoEstados()
        {
            GdProyectos = new HashSet<GdProyectos>();
        }

        public int IdProyectoEstado { get; set; }
        public string ProyectoEstado { get; set; }

        public virtual ICollection<GdProyectos> GdProyectos { get; set; }
    }
}
