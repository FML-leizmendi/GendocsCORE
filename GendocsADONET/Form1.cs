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
        public string strSQL = string.Empty;
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
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    MessageBox.Show(dr.GetValue(0).ToString() + " " + dr.GetValue(1).ToString());
                }

                //********** OPCION 2 ****** 
            }
            catch (Exception Ex)
            {
                string mensaje = Ex.Message;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
        //    ConexionBDAccess conexionAccess = new ConexionBDAccess();
        //    conexionAccess.AbrirBD();
        }

        private void sysBusquedasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sysBusquedasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.genDoc_sysDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'genDoc_sysDataSet.sysBusquedas' Puede moverla o quitarla según sea necesario.
            this.sysBusquedasTableAdapter.Fill(this.genDoc_sysDataSet.sysBusquedas);

        }

        private void sysBusquedasDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (sysBusquedasDataGridView.SelectedRows != null)
                {
                    strSQL = sysBusquedasDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }
        }
    }
}
