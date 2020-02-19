using System;
using System.Collections.Generic;
using System.Text;

namespace GendocsModeloDatos.models
{
    public partial class GdProyectos_Reducida
    {
        public GdProyectos_Reducida()
        {
           
        }

        public int IdProyecto { get; set; }
        public string CodigoProyecto { get; set; }
        public string Alias { get; set; }
        public string TipoProyecto { get; set; }
        public string TerminoMunicipal { get; set; }
        public string Gestor { get; set; }
        public string Responsable { get; set; }
        public int? IdProyectoEstado { get; set; }
    }
}
