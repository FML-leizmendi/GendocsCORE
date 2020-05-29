using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GendocsController;
using System.Collections;
using Microsoft.VisualBasic;

namespace GendocsForms
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            /*
             * using(GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext())
            {
                List<GendocsModeloDatos.models.GdProyectos> lst = (from d in db.GdProyectos
                                                                   select d).ToList();
                foreach (GendocsModeloDatos.models.GdProyectos pro in lst)
                {
                    Console.WriteLine(pro.Alias);
                    MessageBox.Show(pro.Alias, pro.CodigoProyecto);

                }
            }
            */
            //string text = System.IO.File.ReadAllText(@"C:\Users\Lorenzo\Desktop\basProcedures.txt");
            bool ok;
            var i = GendocsController.G3.GetParam("xxxxx", false,out ok  ) ;
            
            //Console.WriteLine();
            //Console.WriteLine("GetEnvironmentVariables: ");
            //foreach (DictionaryEntry de in Environment.GetEnvironmentVariables())
            //    Console.WriteLine("  {0} = {1}", de.Key, de.Value);
            //Console.ReadLine();
            //return;

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var g3_connection = Environment.GetEnvironmentVariable("G3_CONNECTION", EnvironmentVariableTarget.User);
            if (g3_connection == null || g3_connection == "")
            {
                InputBoxValidation validation = delegate (string val)
                {
                    if (val == "")
                        return "Value cannot be empty.";
                    return "";
                };

                string value = "";
                if (InputBox.Show("Cadena de conexión a base de datos G3", "G3 database:", ref value, validation) == DialogResult.OK)
                {
                    MessageBox.Show(value);
                    Environment.SetEnvironmentVariable("G3_CONNECTION", value, EnvironmentVariableTarget.User);
                }
                g3_connection = Environment.GetEnvironmentVariable("G3_CONNECTION", EnvironmentVariableTarget.User);
            }
            if (G3Forms.Login())
            {
                //MessageBox.Show("OK!","Acceso correcto",MessageBoxButtons.OK,MessageBoxIcon.Information);
                FrmMDIGd frmMDI = new FrmMDIGd();
                frmMDI.WindowState = FormWindowState.Maximized;
                frmMDI.ShowDialog();
                //FrmListaProyectos frm = new FrmListaProyectos();
                //frm.ShowDialog();

                //frmEmpleadosFML frm = new frmEmpleadosFML();
                //frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("No access", "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
