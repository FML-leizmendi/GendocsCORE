using System;
using System.Collections.Generic;
using System.Text;

namespace GendocsModeloDatos.models
{
    public partial class GD_EmpleadosFML_Accesos
    {
        public int IdAcceso { get; set; }

        public int IdEmpleadoFML { get; set; }

        public string Acceso { get; set; }

        public string Usuario { get; set; }

        public string Password { get; set; }
    }
}
