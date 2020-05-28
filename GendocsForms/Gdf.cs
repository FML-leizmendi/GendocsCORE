using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using GendocsModeloDatos.models;
using GendocsController;

namespace GendocsForms
{
    //Gendocs Functions.... Colección de funciones propias de Gendocs
    public static class Gdf
    {
        //public static string UserLogged { get; set; }
        //public static int IdEmpleadoFML_Logged { get; set; }

        static public bool Login()
        {
            G3.UserLogged = string.Empty;
            G3.IdEmpleadoFML_Logged = 0;
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {

                //MessageBox.Show("USER:" + frm.user + Environment.NewLine +
                //                "Pass:" + "*********");
                using (var db = new GenDocsContext())
                {
                    List<GdEmpleadosFml> lst = (from d in db.GdEmpleadosFml
                                                where d.User == frm.User && d.Pass == frm.Pass
                                                select d
                                                ).ToList();
                    if (lst.Count > 0)
                    {
                        G3.UserLogged = lst[0].User;
                        G3.IdEmpleadoFML_Logged = lst[0].IdEmpleadoFml;
                        
                        frm.Dispose();
                        return true;
                    }
                }
                frm.Dispose();
                return false;
            }
            else
                frm.Dispose();
                return false;
        }

    }

}
