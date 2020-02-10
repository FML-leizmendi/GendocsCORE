using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace GendocsForms
{
    static class Gdf //Gendocs Functions.... Colección de funciones propias de Gendocs
    {
        public static string userLogged;

        static public bool Login()
        {
            userLogged = string.Empty;
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {

                //MessageBox.Show("USER:" + frm.user + Environment.NewLine +
                //                "Pass:" + "*********");
                using (GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext())
                {
                    List<GendocsModeloDatos.models.GdEmpleadosFml> lst = (from d in db.GdEmpleadosFml
                                                                          where d.User == frm.user && d.Pass == frm.pass
                                                                          select d
                                                                          ).ToList();
                    if (lst.Count > 0)
                    {
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
