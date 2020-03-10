using System;
using System.Collections.Generic;

namespace GendocsModeloDatos.models
{
    public partial class GdEmpleados
    {
        public int IdEmpleado { get; set; }
        public string Empleado { get; set; }
        public int? IdCliente { get; set; }
        public int? IdCargo { get; set; }
        public int? CodigoPersona { get; set; }
        public int? IdEmpleadoSuperior { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Etiquetas { get; set; }

        //public virtual GdCargos IdCargoNavigation { get; set; }
        //public virtual GdProyectoEstados IdProyectoEstadoNavigation { get; set; }
    }
}
