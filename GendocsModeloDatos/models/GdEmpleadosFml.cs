using System;
using System.Collections.Generic;

namespace GendocsModeloDatos.models
{
    public partial class GdEmpleadosFml
    {
        public int IdEmpleadoFml { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Nif { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public string User { get; set; }
        public int? Estado { get; set; }
        public string Etiquetas { get; set; }
        public string TrelloIdMember { get; set; }
        public int? CodigoPersona { get; set; }
    }
}
