using System;
using System.Collections.Generic;

namespace GendocsModeloDatos.models
{
    public partial class GdProyectos
    {
        public GdProyectos()
        {
            GdPedidosCab = new HashSet<GdPedidosCab>();
        }

        public int IdProyecto { get; set; }
        public string CodigoProyecto { get; set; }
        public string CarpetaBase { get; set; }
        public int? IdCliente { get; set; }
        public string Titulo { get; set; }
        public string TituloCorto { get; set; }
        public string Alias { get; set; }
        public string TipoProyecto { get; set; }
        public string Autor { get; set; }
        public string Colegiado { get; set; }
        public string TerminoMunicipal { get; set; }
        public string Provincia { get; set; }
        public bool? LineaAereaSn { get; set; }
        public bool? LineaSubterraneaSn { get; set; }
        public bool? CentroTransformadorSn { get; set; }
        public int? IdEmpleadoGestor { get; set; }
        public string Gestor { get; set; }
        public string EmailGestor { get; set; }
        public int? IdEmpleadoResponsable { get; set; }
        public string Responsable { get; set; }
        public string EmailResponsable { get; set; }
        public DateTime? Fmodificado { get; set; }
        public string Umodificado { get; set; }
        public DateTime? Fcreado { get; set; }
        public string Ucreado { get; set; }
        public string Notas { get; set; }
        public string Historico { get; set; }
        public string NotasG { get; set; }
        public int? IdProyectoEstado { get; set; }

        public virtual GdProyectoEstados IdProyectoEstadoNavigation { get; set; }
        public virtual GdProyectoTipos TipoProyectoNavigation { get; set; }
        public virtual ICollection<GdPedidosCab> GdPedidosCab { get; set; }
    }
}
