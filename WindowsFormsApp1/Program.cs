using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
#pragma warning disable CS0246 // El nombre del tipo o del espacio de nombres 'Form1' no se encontró (¿falta una directiva using o una referencia de ensamblado?)
            Application.Run(new Form1());
#pragma warning restore CS0246 // El nombre del tipo o del espacio de nombres 'Form1' no se encontró (¿falta una directiva using o una referencia de ensamblado?)
        }
    }
}
