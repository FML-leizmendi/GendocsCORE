using System;

namespace GendocsController
{
    public class Class1
    {
        void VerDB()
        {
            using (GendocsModeloDatos.gen)
            Console.WriteLine("Buenos tardes");
        }
    }
}
