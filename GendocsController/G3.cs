
using GendocsModeloDatos.models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.VisualBasic;
using GendocsForms;

namespace GendocsController
{
    
    public static class G3
    {
        public static string UserLogged { get; set; }
        public static int IdEmpleadoFML_Logged { get; set; }
        public static object GetParam(string paramName, bool isUserParam, out bool ok, bool isSystemUserParam = false, int tipoDato=10)
        {
            if (isUserParam) paramName = paramName + "_" + UserLogged;
            if (isSystemUserParam) paramName = paramName + "_" + Environment.GetEnvironmentVariable("USERNAME");
            try
            {
                using G3ParamContext db = new G3ParamContext();
                var pa = (from p in db.G3Params
                         where (p.NP == paramName)
                         select p).First() as G3Param;
                ok = true;
                return pa.TipoDato switch
                {
                    10 => pa.VP.ToString(),
                    1 => pa.VPbool,
                    4 => pa.VPlng,
                    5 => pa.VPcur,
                    8 => pa.VPfecha,
                    12 => pa.VPmemo,
                    _ => pa.VP.ToString(),
                };
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }
            ok = false;
            return tipoDato switch
            {
                10 => "",
                1 => false,
                4 => 0,
                5 => 0,
                8 => null,
                12 => null,
                _ => "",
            };
        }
        public static bool SetParam(string paramName, bool isUserParam, object valorParam, int ?tipoDato = 10)
        {
            if (isUserParam)
            {
                paramName = paramName + "_" + UserLogged;
            }
            try
            {
                
                using G3ParamContext db = new G3ParamContext();
                //object pa;
                var pa = (from p in db.G3Params
                          where (p.NP == paramName)
                          select p).FirstOrDefault();
                bool nuevo = false;
                if (pa == null)
                {
                    nuevo = true;
                    pa = new G3Param{NP = paramName};
                }
                pa.TipoDato = (int)tipoDato;
                switch (tipoDato)
                {
                    case 10: 
                        pa.VP = valorParam.ToString();
                        break;
                    case 1:
                        pa.VPbool = (bool)valorParam;
                        break;
                    case 4:
                        pa.VPlng = (int)valorParam;
                        break;
                    case 5:
                        pa.VPcur = valorParam==null ?  0 : Convert.ToDecimal(valorParam);
                        break;
                    case 8:
                        pa.VPfecha = (DateTime)valorParam;
                        break;
                    case 12:
                        pa.VPmemo = valorParam.ToString();
                        break;
                    default:
                        pa.VP = valorParam.ToString();
                        break;
                };
                pa.FModificado = DateTime.Now;
                if (nuevo)
                {
                    db.Add<G3Param>(pa);
                }
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }
            return false;
        }
        public static void Popo()
        {
            SetParam("PruebaParam", false, "Primer parámetro");
        }
        public static int DimeIdColumnaC(int IdEmplFML = 0, string NomnbreGrid = "")
        {
            int NumColumna = 0;
            try
            {
                using GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext();
                var query = (from a in db.GdColumnasC
                             where (a.IdEmpleadoFMl == IdEmplFML) & (a.ListName.Contains(NomnbreGrid))
                             select new { a.IdColumnaC }).ToList();

                NumColumna = Convert.ToInt32(query[0].IdColumnaC);
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }
            return NumColumna;
        }

    }

}


