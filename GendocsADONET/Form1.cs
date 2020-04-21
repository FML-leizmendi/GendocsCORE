using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GendocsADONET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConexionBD conexion = new ConexionBD();
            conexion.AbrirBD();

            string cadena = "SELECT * FROM GD_ProyectoEstados";

            try
            {
                //*********** OPCION 1 ********
                SqlCommand command = new SqlCommand(cadena, conexion.conectarBD);
                SqlDataReader rd = command.ExecuteReader();
                while (rd.Read())
                {
                    MessageBox.Show(rd.GetValue(0).ToString() + "" + rd.GetValue(1).ToString());
                }

                //********** OPCION 2 ****** 
            }
            catch (Exception Ex)
            {
                string mensaje = Ex.Message;
            }
        }
    }
}
