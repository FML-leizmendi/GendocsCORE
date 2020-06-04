using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GendocsForms.Forms
{
    public partial class FrmClientes : Form
    {
        public static int IdEmpleadoSuperior;
        public FrmClientes()
        {
            InitializeComponent();
        }

        #region "Eventos Privados"
        private void FrmClientes_Load(object sender, EventArgs e)
        {
            try
            {
                G3Forms.CargarParam(this, "");
                CargarComboClientes();
                //TvEmpleadosCargarNodo(null, null);
                
            }
            catch(Exception ex)
            {
                _ = ex.Message;
            }
        }


        private void pbCarpeta_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog CarpetaEntrada = new FolderBrowserDialog();
                if (CarpetaEntrada.ShowDialog() == DialogResult.OK)
                {
                    txtProyecto.Text = CarpetaEntrada.SelectedPath;
                }
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        private void FrmClientes_FormClosing(object sender, FormClosingEventArgs e)

        {
            try
            {
                G3Forms.GrabarParam(this, "");
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }


        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbClientes.SelectedIndex == 0)
                {
                    tvClientes.Nodes.Clear();
                    TvEmpleadosCargarNodo(null, null);
                    
                }
                else
                {
                    tvClientes.Nodes.Clear();
                }
            }
            catch
            {

            }
        }
        private void btnAñadir_Click(object sender, EventArgs e)
        {
            try
            {
                if (tvClientes.SelectedNode.Nodes.Count > 0)
                {

                }
                else
                {
                    MessageBox.Show("Seleccione el Usuario al que quiera agregar un nuevo elemento", "Jerarquía de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }
        #endregion

        #region "Métodos Privados"
        private void CargarComboClientes()
        {
            try
            {
                GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext();
                List<GendocsModeloDatos.models.GdClientes> lstClientes;
                lstClientes = db.GdClientes.Select(e => new GendocsModeloDatos.models.GdClientes()
                {
                    IdCliente = e.IdCliente,
                    Cliente = e.Cliente
                }
                ).ToList();

                cmbClientes.DisplayMember = "Cliente";
                cmbClientes.ValueMember = "IdCliente";
                cmbClientes.DataSource = lstClientes;
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        private void TvEmpleadosCargarNodo(Object idEmpleadoSuperior, Object treeNode)
        {
            try
            {
                var db = new GendocsModeloDatos.models.GenDocsContext();
                {
                    List<GendocsModeloDatos.models.GdEmpleados> lst;
                    if(idEmpleadoSuperior !=null )
                    {
                        lst = (from a in db.GdEmpleados
                               where a.IdEmpleadoSuperior ==  Convert.ToInt32( idEmpleadoSuperior)
                               select a).ToList();
                    }
                    else
                    {
                        lst = (from a in db.GdEmpleados
                               where a.IdEmpleadoSuperior == null
                               select a).ToList();
                    }
                    int i = 0;
                    foreach (var e in lst)
                    {
                        if (treeNode == null)
                        {
                            tvClientes.Nodes.Add(e.IdEmpleado.ToString(), e.Empleado);
                            TvEmpleadosCargarNodo(e.IdEmpleado, tvClientes.Nodes[i]);       
                        }
                        else
                        {
                            TreeNode tn = treeNode as TreeNode;
                            tn.Nodes.Add(e.IdEmpleado.ToString(), e.Empleado);
                            TvEmpleadosCargarNodo(e.IdEmpleado.ToString(), (TreeNode)tn.Nodes[i]);
                        }

                        i++;
                    }
                    if (treeNode == null)
                    {
                        tvClientes.ExpandAll();
                    }
                }
                
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }
        #endregion

        #region "Control de Eventos"

        #endregion

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception)
            { 

            }
        }

        private void PbExpandirContraer_Click(object sender, EventArgs e)
        {
            int i = 1;
            try
            {
                if (i == 1)
                {
                    string imagePath = Path.Combine(Application.StartupPath, @"Imágenes\Movimientos\Rey.jpg");
                    PbExpandirContraer.Image = Image.FromFile(imagePath);
                    i = 0;
                }
                else
                {
                    i = 1;
                }
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }

        }
    }
}
