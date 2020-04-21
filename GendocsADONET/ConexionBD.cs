using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GendocsADONET
{
    public class ConexionBD
    {
        String cadena = "Data Source=PC-ALEXMOTA;Initial Catalog=GenDocs;Integrated Security=True;";
        

        public SqlConnection conectarBD = new SqlConnection();

        public ConexionBD()
        {
            conectarBD.ConnectionString = cadena;
        }

        public void AbrirBD()
        {
            try
            {
                conectarBD.Open();
                Console.WriteLine("Conexion abierta");
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
                Console.WriteLine("Error al conectar la base de datos" + ex.Message);
            }
        }

        public void CerarBD()
        {
            try
            {
                conectarBD.Close();
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }
        }
    }
}
