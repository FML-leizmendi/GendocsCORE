using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Globalization;
using GendocsModeloDatos.models;
using GendocsForms.Forms;


namespace GendocsForms
{
    public partial class clsProyectos
    {
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

        public List<int> lstId = new List<int>();

        public bool esNuevo = false;

        public bool EsAlta = false;

        public void CargarFrmExpedientes()
        {
            FrmExpedientes frm = new FrmExpedientes(this);
            IdProyecto = this.IdProyecto;
            CargarExpediente();
            frm.ShowDialog();
        }

        public void CargarExpediente()
        {
            using (GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext())
            {
                var lst = (from d in db.GdProyectos
                           where (d.IdProyecto == this.IdProyecto)
                           select d

                       ).ToList();

                if (lst.Count() != 0)
                {
                    foreach (var item in lst)
                    {
                        IdProyecto = item.IdProyecto;
                        CodigoProyecto = item.CodigoProyecto;
                        IdCliente = item.IdCliente;
                        CarpetaBase = item.CarpetaBase;
                        Titulo = item.Titulo;
                        TituloCorto = item.TituloCorto;
                        TipoProyecto = item.TipoProyecto;
                        TerminoMunicipal = item.TerminoMunicipal;
                        Provincia = item.Provincia;
                        Alias = item.Alias;
                        IdProyectoEstado = item.IdProyectoEstado;
                    }
                }
                else
                {
                    CodigoProyecto = String.Empty;
                    IdCliente = 0;
                    CarpetaBase = string.Empty;
                    Titulo = string.Empty;
                    TituloCorto = string.Empty;
                    TipoProyecto = string.Empty;
                    TerminoMunicipal = string.Empty;
                    Provincia = string.Empty;
                    IdProyectoEstado = 0;
                }

            }
        }

    }
}
