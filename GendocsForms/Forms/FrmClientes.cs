using GendocsForms.Properties;
using GendocsModeloDatos.models;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GendocsForms.Forms
{
    public partial class FrmClientes : Form
    {
        public static int IdEmpleadoSuperior;
        public static int ExpandirContraer = 1;
        public static String NodoPadreSeleccionado;
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
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        protected override bool ProcessDialogKey(Keys keyData) // cerrar formulario con ESCAPE
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void PbCarpeta_Click(object sender, EventArgs e)
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

        private void CmbClientes_SelectedIndexChanged(object sender, EventArgs e)
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
                    if (idEmpleadoSuperior != null)
                    {
                        lst = (from a in db.GdEmpleados
                               where a.IdEmpleadoSuperior == Convert.ToInt32(idEmpleadoSuperior)
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

        private void PbExpandirContraer_Click(object sender, EventArgs e)
        {
            try
            {
                if (ExpandirContraer == 1)
                {
                    PbExpandirContraer.Image = Resources.icons8_flecha_contraer_24;
                    ExpandirContraer = 0;
                    tvClientes.ExpandAll();
                }
                else
                {

                    PbExpandirContraer.Image = Resources.icons8_flecha_ampliar_24;
                    ExpandirContraer = 1;
                    tvClientes.CollapseAll();
                }
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }

        }

        private void PbAgregarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Desea añadir un nuevo empleado?", "Empleados", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (NodoPadreSeleccionado != string.Empty)
                    {
                        using GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext();
                        var lst = (from a in db.GdEmpleados
                                   where a.Empleado.Equals(NodoPadreSeleccionado)
                                   select a).ToList();

                        if (lst.Count() > 0)
                        {
                            FrmInputBox frm = new FrmInputBox();
                            frm.ShowDialog();
                            string NombreEmpleado = frm.DatosIntroducidos;
                            frm.Close();
                            if (NombreEmpleado != null)
                            {
                                GdEmpleados Emp = new GdEmpleados
                                {
                                    Empleado = NombreEmpleado,
                                    IdCliente = (int)Interaction.IIf(cmbClientes.SelectedIndex == 0, 1, 2),
                                    IdEmpleadoSuperior = (int)Interaction.IIf(lst[0].IdEmpleado != null, lst[0].IdEmpleado, null)
                                };

                                db.GdEmpleados.Add(Emp);
                                db.SaveChanges();
                            }
                            else
                                MessageBox.Show("No ha introducido el nombre de un empleado", "Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                        MessageBox.Show("No ha seleccionado ningún empleado", "Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                tvClientes.Nodes.Clear();
                TvEmpleadosCargarNodo(null, null);
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        private void PbEliminarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Desea eliminar el empleado seleccionado?", "Empleados", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (NodoPadreSeleccionado != string.Empty)
                    {
                        using GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext();
                        var cSelect = from x in db.GdEmpleados
                                      where x.Empleado.Equals(NodoPadreSeleccionado)
                                      select x;

                        if (cSelect.Count() > 0)
                        {
                            db.GdEmpleados.RemoveRange(cSelect);
                            db.SaveChanges();
                        }
                    }
                    else
                        MessageBox.Show("No ha seleccionado empleado que desea eliminar", "Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                tvClientes.Nodes.Clear();
                TvEmpleadosCargarNodo(null, null);
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        private void PbEditarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (NodoPadreSeleccionado != string.Empty)
                {
                    ClsEmp cEmp = new ClsEmp();
                    using GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext();
                    var lst = (from d in db.GdEmpleados
                               where (d.Empleado.Contains(NodoPadreSeleccionado))
                               select d.IdEmpleado

                           ).ToList();

                    cEmp.LstId = lst;
                    cEmp.CargarFrmEmpleados2();
                }
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        private void TvClientes_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                NodoPadreSeleccionado = tvClientes.SelectedNode.Text.ToString();
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }
    }
}
