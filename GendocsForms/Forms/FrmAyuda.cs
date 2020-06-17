using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace GendocsForms
{
    public partial class FrmAyuda : Form
    {
        public String strSQL;
        public string CodBusqueda;
        public int TotalColumnas;
        public string AnchoColumnas;
        public int[] ElementosSeleccionados;

        public FrmAyuda()
        {
            InitializeComponent();
        }

        private void FrmAyuda_Load(object sender, EventArgs e)
        {
            try
            {
                //strSQL = DameSql(CodBusqueda);
                //BuscaAyuda();
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        //public void LlenarLista()
        //{

        //    try
        //    {
        //        if (strSQL != string.Empty)
        //        {
        //            SqlDataAdapter data = new SqlDataAdapter(strSQL, new SqlConnection(Environment.GetEnvironmentVariable("G3_CONNECTION", EnvironmentVariableTarget.User)));
        //            DataTable dt = new DataTable();
        //            data.Fill(dt);

        //            string[] arrayAnchoColumnas = DameArrayAnchoColumnas(AnchoColumnas);
        //            for (int i = 0; i < dt.Columns.Count; i++)
        //            { 
        //                this.lstvAyuda.Columns.Add(dt.Columns[i].ToString(), Convert.ToInt32(arrayAnchoColumnas[i]));
        //            }

        //            for (int i = 0; i < dt.Rows.Count; i++)
        //            {
        //                DataRow dr = dt.Rows[i];
        //                ListViewItem listitem = new ListViewItem(dr["IdEstadoTrabajo"].ToString());
        //                listitem.SubItems.Add(dr["EstadoTrabajo"].ToString());
        //                lstvAyuda.Items.Add(listitem);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        _ = ex.Message;
        //    }
        //}

        private String[] DameArrayAnchoColumnas(String AnchoColumnas)
        {
            string[] arrayAnchoColumnas;
            arrayAnchoColumnas = Strings.Split(AnchoColumnas, ",");
            return arrayAnchoColumnas;
        }


        public void LlenarLista(String CodBusqueda = "")
        {
            try
            {
                using GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext();
                var lst = (from d in db.GdBusqueda
                           where d.CodBusqueda.Equals(CodBusqueda)
                           select d).FirstOrDefault();

                if (lst != null)
                {
                    this.Text = lst.Titulo;
                    this.Height = Convert.ToInt32(lst.AltoFrm);
                    this.Width = Convert.ToInt32(lst.AnchoFrm);
                    this.lblAyuda.Text = lst.TextoOtra;
                    this.TotalColumnas = Convert.ToInt32(lst.NumColumnas);
                    this.AnchoColumnas = lst.AnchoColumnas;
                }

                if (lst.StrSQL != string.Empty)
                {
                    SqlDataAdapter data = new SqlDataAdapter(lst.StrSQL, new SqlConnection(Environment.GetEnvironmentVariable("G3_CONNECTION", EnvironmentVariableTarget.User)));
                    DataTable dt = new DataTable();
                    data.Fill(dt);

                    string[] arrayAnchoColumnas = DameArrayAnchoColumnas(AnchoColumnas);
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        this.lstvAyuda.Columns.Add(dt.Columns[i].ToString(), Convert.ToInt32(arrayAnchoColumnas[i]));
                    }

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DataRow dr = dt.Rows[i];
                        ListViewItem listitem = new ListViewItem(dr["IdEstadoTrabajo"].ToString()); // TODO
                        listitem.SubItems.Add(dr["EstadoTrabajo"].ToString());
                        lstvAyuda.Items.Add(listitem);
                    }
                }
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (lstvAyuda.SelectedItems.Count > 0)
            {
                Array.Resize( ref ElementosSeleccionados, lstvAyuda.SelectedItems.Count);
                int i = 0;
                foreach (ListViewItem itemRow in lstvAyuda.SelectedItems)
                {
                    ElementosSeleccionados[i] = Convert.ToInt32( itemRow.Text);
                    i++;
                    //ElementosSeleccionados.Add(itemRow.  SubItems[1].Text);
                }
            }
            else
                MessageBox.Show("Debe seleccionar al menos una etiqueta para añadir a la lista de Asignadas", "Seleccione una opción", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Visible = false;
        }

    }
}
