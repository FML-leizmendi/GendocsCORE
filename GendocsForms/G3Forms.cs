using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using GendocsController;
using GendocsModeloDatos.models;
using System.Linq;

namespace GendocsForms
{
    public static class G3Forms
    {
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
        public static void CargarParam(Control frm, string prefijo="")
        {
            try
            {
                foreach (Control ctl in frm.Controls)
                {
                    if (ctl.GetType()== typeof(GroupBox))
                    {
                        CargarParam (ctl , prefijo);
                    }
                    if (Strings.InStr(ctl.Tag?.ToString(), "param") > 0)
                    {
                        var param = prefijo + ctl.Name;
                        var esUser = Strings.InStr(ctl.Tag.ToString(), "paramUS") > 0;
                        var p = G3.GetParam(param, esUser, out bool ok);
                        if (ok == false && esUser == true)
                        {
                            p = G3.GetParam(param, false, out ok);
                        }
                        if (ok) 
                        { 
                            if(ctl.GetType()== typeof(ComboBox))
                            {
                                var cmb = (ComboBox)ctl;
                                cmb.SelectedValue = Convert.ToInt32(p);
                            }
                            else
                            {
                                ctl.Text = p.ToString();
                            }
                            
                        }
                    }
                }
            }
            catch
            {
                
            }
        }

        public static void GrabarParam(Control frm, string prefijo = "")
        {
            try
            {
                foreach(Control ctl in frm.Controls)
                {
                    if (ctl.GetType() == typeof(GroupBox))
                    {
                        GrabarParam(ctl, prefijo);
                    }
                    if (Strings.InStr(ctl.Tag?.ToString(), "param") > 0)
                    {
                        var param = prefijo + ctl.Name;
                        var esUser = Strings.InStr(ctl.Tag.ToString(), "paramUS") > 0;
                        var tipoDato = 10;
                        if (esUser)
                        {
                            try { tipoDato = Convert.ToInt32(Strings.Mid(ctl.Tag.ToString(), 8, 3)); }
                            catch { tipoDato = 10; }
                        }
                        else
                        {
                            try { tipoDato = Convert.ToInt32(Strings.Mid(ctl.Tag.ToString(), 6, 3)); }
                            catch { tipoDato = 10; }
                        }
                        bool ok;

                        if (ctl.GetType() == typeof(ComboBox))
                        {
                            ComboBox cmb = (ComboBox)ctl;
                            ok = G3.SetParam(param, esUser, cmb.SelectedValue, false,tipoDato);
                        }
                        else
                        {
                            ok = G3.SetParam(param, esUser, ctl.Text,false,  tipoDato);
                        }
                    }
                }
            }
            catch { }
        }
    }
}
