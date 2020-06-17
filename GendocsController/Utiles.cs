using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;

namespace GendocsForms
{

    static public class Utiles
    {
        //public static int IdEmpleadoFML = 0;
        //public static String User = string.Empty;

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

        //public static void ConectarDB()
        //{
        //    try
        //    {
        //        string g3_connection = Environment.GetEnvironmentVariable("G3_CONNECTION", EnvironmentVariableTarget.User);
        //        using SqlConnection sql = new SqlConnection(g3_connection);
        //        sql.Open();
        //    }
        //    catch (Exception ex)
        //    {
        //        _ = ex.Message;
        //    }

        //}

        

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
        //        string mensaje = ex.Message;
        //    }
        //}
    }
}
