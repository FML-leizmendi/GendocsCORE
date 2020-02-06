using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmLogin frm = new frmLogin();

            frm.ShowDialog();
        }
    }
}
