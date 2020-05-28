using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using GendocsController;

namespace GendocsForms
{
    public static class G3Forms
    {
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
                        Boolean ok;
                        var p = G3.GetParam(param, esUser, out ok);
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
                            ok = G3.SetParam(param, esUser, cmb.SelectedValue, tipoDato);
                        }
                        else
                        {
                            ok = G3.SetParam(param, esUser, ctl.Text, tipoDato);
                        }
                    }
                }
            }
            catch { }
        }
    }
}
