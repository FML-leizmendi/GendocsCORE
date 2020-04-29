using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace GendocsForms
{

   static public class Utiles
    {

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
                var p = new Process();
                p.StartInfo = new ProcessStartInfo(ruta)
                {
                    UseShellExecute = true
                };
                p.Start();
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }
        }
    }
}
