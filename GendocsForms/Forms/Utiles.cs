using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace GendocsForms
{

    static public class Utiles
    {
        public static int IdEmpleadoFML = 0;
        public static String User = string.Empty;
        //función
        public static bool IsOpenForm(string frmName)
        {
            if (Application.OpenForms[frmName] != null)
            {
                return true;
            }
            return false;
        }

        // Funcion que abre cualquier tipo de archivo, pasándole la ruta en la que se encuentre
        public static void AbrirArchivo(String ruta)
        {
            try
            {
                var p = new Process
                {
                    StartInfo = new ProcessStartInfo(ruta)
                    {
                        UseShellExecute = true
                    }
                };
                p.Start();
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        // Función para validar que solo se puede introducir números en un textbox

        public static void SoloNumeros(KeyPressEventArgs pE)
        {
            try
            {
                if (char.IsDigit(pE.KeyChar))
                {
                    pE.Handled = false;
                }
                else if (char.IsControl(pE.KeyChar))
                {
                    pE.Handled = false;
                }
                else
                    pE.Handled = true;
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        public static DataTable ToDataTable<T>(this IList<T> data)
        {
            PropertyDescriptorCollection properties =
                TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;
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
                _ = ex.Message;
            }
            return NumColumna;
        }

        //public static void CargarPedidosPedientes()
        //{
        //    try
        //    {
        //        string sURL;
        //        sURL = "https://api.trello.com/1/lists/5ec6754a3faf851dcab6d83c/cards?key=d96312f0a6409f687a998a10cc602b24&token=9d897910fbfb76a19e38f474dc16321d73d3ccfbd2f833d6bb995cfdaaed9411";

        //        WebRequest wrGETURL;
        //        wrGETURL = WebRequest.Create(sURL);

        //        WebProxy myProxy = new WebProxy("myproxy", 80);
        //        myProxy.BypassProxyOnLocal = true;

        //        //wrGETURL.Proxy = myProxy;

        //        Stream objStream;
        //        objStream = wrGETURL.GetResponse().GetResponseStream();

        //        StreamReader objReader = new StreamReader(objStream);

        //        string sLine = "";
        //        int i = 0;

        //        while (sLine != null)
        //        {
        //            i++;
        //            sLine = objReader.ReadLine();
        //            if (sLine != null)
        //                Console.WriteLine("{0}:{1}", i, sLine);
        //        }
        //        Console.ReadLine();
        //    }
        //    catch (Exception ex)
        //    {
        //        _ = ex.Message;
        //    }
        //}
    }
}
