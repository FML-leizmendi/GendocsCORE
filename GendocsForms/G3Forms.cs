using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using GendocsController;
using GendocsModeloDatos.models;
using System.Linq;
using System.Drawing;


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
                    if (ctl.GetType() == typeof(GroupBox) || ctl.GetType() == typeof(TabControl) || ctl.GetType() == typeof(TabPage))
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
                    if (ctl.GetType() == typeof(GroupBox) || ctl.GetType() == typeof(TabControl) || ctl.GetType() == typeof(TabPage))
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
public class InputBox
    ////////////// https://www.csharp-examples.net/inputbox-class/
    ////////////// InputBox with value validation - first define validation delegate, which
    ////////////// returns empty string for valid values and error message for invalid values
    //////////// InputBoxValidation validation = delegate (string val) {
    ////////////    if (val == "")
    ////////////        return "Value cannot be empty.";
    ////////////    if (!(new Regex(@"^[a-zA-Z0-9_\-\.]+@[a-zA-Z0-9_\-\.]+\.[a-zA-Z]{2,}$")).IsMatch(val))
    ////////////        return "Email address is not valid.";
    ////////////    return "";
    //////////// };

    ////////////    string value = "info@example.com";
    ////////////    if (InputBox.Show("Enter your email address", "Email address:", ref value, validation) == DialogResult.OK)
    ////////////    {
    ////////////    MessageBox.Show(value);
    ////////////    }
    {
        public static DialogResult Show(string title, string promptText, ref string value)
        {
            return Show(title, promptText, ref value, null);
        }

        public static DialogResult Show(string title, string promptText, ref string value,
                                        InputBoxValidation validation)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor |= AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;
            if (validation != null)
            {
                form.FormClosing += delegate (object sender, FormClosingEventArgs e) {
                    if (form.DialogResult == DialogResult.OK)
                    {
                        string errorText = validation(textBox.Text);
                        if (e.Cancel = (errorText != ""))
                        {
                            MessageBox.Show(form, errorText, "Validation Error",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBox.Focus();
                        }
                    }
                };
            }
            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }
    }
    public delegate string InputBoxValidation(string errorMessage);

}
