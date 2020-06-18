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

            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

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
                    this.lstvAyuda.AutoResizeColumns(ColumnHeaderAutoResizeStyle.None);
                }

                if (lst.StrSQL != string.Empty)
                {
                    SqlDataAdapter data = new SqlDataAdapter(lst.StrSQL, new SqlConnection(Environment.GetEnvironmentVariable("G3_CONNECTION", EnvironmentVariableTarget.User)));
                    DataTable dt = new DataTable();
                    data.Fill(dt);

                    // Se añades las columnas 
                    dt.Columns.Cast<DataColumn>().ToList().ForEach(column => lstvAyuda.Columns.Add(column.Caption));
                    // Se añaden las filas
                    dt.AsEnumerable().ToList().ForEach(row =>
                    {
                        ListViewItem item = new ListViewItem(Convert.ToString(row[0]));
                        row.ItemArray.ToList().Skip(1).ToList().ForEach(value =>
                              item.SubItems.Add(Convert.ToString(value)));
                        lstvAyuda.Items.Add(item);
                    });

                    //Se le asigna un ancho a cada columna
                    string[] arrayAnchoColumnas = DameArrayAnchoColumnas(AnchoColumnas);
                    for (int i = 0; i < arrayAnchoColumnas.Length; i++)
                    {
                        lstvAyuda.Columns[i].Width = Convert.ToInt32(arrayAnchoColumnas[i]);
                    }
                    lstvAyuda.AutoResizeColumns(ColumnHeaderAutoResizeStyle.None);
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
                Array.Resize(ref ElementosSeleccionados, lstvAyuda.SelectedItems.Count);
                int i = 0;
                foreach (ListViewItem itemRow in lstvAyuda.SelectedItems)
                {
                    ElementosSeleccionados[i] = Convert.ToInt32((itemRow.Text));
                    i++;
                }
            }
            else
                MessageBox.Show("Debe seleccionar una opción", "Seleccione una opción", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Visible = false;
        }

    }
}
