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
    static public class FormUtiles
    {
        public static bool IsOpenForm(string frmName)
        {
            if (Application.OpenForms[frmName] != null)
            {
                return true;
            }
            return false;
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

    }
}
