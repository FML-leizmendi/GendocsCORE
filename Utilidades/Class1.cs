using System.Data;
using System.Data.SqlClient;

namespace Utilidades
{
    public class Utilidades
    {
        public static DataSet Ejecutar(string cmd)
        {
            SqlConnection con = new SqlConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\GenDoc_sys.accdb");
            con.Open();

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd, con);
            da.fill(ds);

            con.Close();

            return ds;
        }
    }
}
