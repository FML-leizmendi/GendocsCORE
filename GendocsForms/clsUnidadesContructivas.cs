using GendocsModeloDatos.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GendocsForms
{
    public partial  class clsUnidadesContructivas
    {
        public int IdUc { get; set; }
        public int? IdCliente { get; set; }
        public string CodigoUc { get; set; }
        public string CodigoUc2 { get; set; }
        public string DescripcionUc { get; set; }
        public string Ud { get; set; }
        public decimal? PrecioUnidad { get; set; }
        public int? IdTipoTrabajo { get; set; }
        public int? PlazoEntregaDias { get; set; }

        public List<int> lstId = new List<int>();

        public List<GdUnidadesConstructivas> lstUnds = new List<GdUnidadesConstructivas>();

        public bool esNuevo = false;

        public bool EsAlta = false;

        public int Cantidad { get; set; }

        public void CargarFrmUnidadesContructivas()
        {
            FrmUnidadesConstructivas frm = new FrmUnidadesConstructivas(this);
            //frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();
        }
    }
}
