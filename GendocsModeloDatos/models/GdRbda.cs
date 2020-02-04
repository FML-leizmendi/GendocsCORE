using System;
using System.Collections.Generic;

namespace GendocsForms.models
{
    public partial class GdRbda
    {
        public int Id { get; set; }
        public int? IdProyecto { get; set; }
        public int? NumFinca { get; set; }
        public string FincaFinca { get; set; }
        public string FincaMunicipio { get; set; }
        public string FincaPoligono { get; set; }
        public string FincaParcela { get; set; }
        public string FincaNaturalezaCultivo { get; set; }
        public string TitularPropietario { get; set; }
        public string TitularNif { get; set; }
        public string TitularDireccion { get; set; }
        public string TitularCp { get; set; }
        public string TitularLocalidad { get; set; }
        public string TitularProvincia { get; set; }
        public string AfeccionActuacion { get; set; }
        public string AfeccionNumeroApoyo { get; set; }
        public string AfeccionOcupacionApoyoM2 { get; set; }
        public string AfeccionLongitudTendidoM { get; set; }
        public string AfeccionServidumbreVueloM2 { get; set; }
        public string Observaciones { get; set; }
        public decimal? TalaArboladoM2 { get; set; }
    }
}
