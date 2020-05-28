using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GendocsController;
using System.Collections;

namespace GendocsForms
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
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
            //var i = GendocsController.G3.SetParam("Param Memo", false, text, 12) ;
            
            //Console.WriteLine();
            //Console.WriteLine("GetEnvironmentVariables: ");
            //foreach (DictionaryEntry de in Environment.GetEnvironmentVariables())
            //    Console.WriteLine("  {0} = {1}", de.Key, de.Value);
            //Console.ReadLine();
            //return;

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (Gdf.Login())
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
