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
                FolderBrowserDialog CarpetaEntrada = new FolderBrowserDialog
                {
                    SelectedPath = CarpetaBaseProyectos.Text + "\\"
                };
                if (CarpetaEntrada.ShowDialog() == DialogResult.OK)
                {
                    txtProyecto.Text = CarpetaEntrada.SelectedPath.Substring(CarpetaBaseProyectos.Text.Length) + "\\";
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
                    txtNombreCliente.Text = cmbClientes.Text;
                    tvClientes.Nodes.Clear();
                    TvEmpleadosCargarNodo(null, null);
                }
                else
                {
                    txtNombreCliente.Text = cmbClientes.Text;
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
                    if (tvClientes.SelectedNode.Name != string.Empty)
                    {
                        using GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext();
                        var lst = (from a in db.GdEmpleados
                                   where a.IdEmpleado == Convert.ToInt32(tvClientes.SelectedNode.Name)
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
                                    IdCliente = (int)Interaction.IIf(cmbClientes.SelectedIndex == 0, 1, 2), // TODO 
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
                    if (tvClientes.SelectedNode.Name != string.Empty)
                    {
                        using GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext();


                        var cSelect = from x in db.GdEmpleados
                                      where x.IdEmpleado == Convert.ToInt32(tvClientes.SelectedNode.Name)
                                      select x;

                        db.GdEmpleados.RemoveRange(cSelect);
                        db.SaveChanges();
                    }
                    tvClientes.Nodes.Clear();
                    TvEmpleadosCargarNodo(null, null);
                }
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
                if (tvClientes.SelectedNode.Name != string.Empty)
                {
                    ClsEmp cEmp = new ClsEmp();
                    using GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext();
                    var lst = (from d in db.GdEmpleados
                               where (d.IdEmpleado == Convert.ToInt32(tvClientes.SelectedNode.Name))
                               select d.IdEmpleado

                           ).ToList();

                    cEmp.LstId = lst;
                    cEmp.CargarFrmEmpleados2();
                }
                tvClientes.Nodes.Clear();
                TvEmpleadosCargarNodo(null, null);
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        private void TxtNombreCliente_Leave(object sender, EventArgs e)
        {
            try
            {
                using GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext();

                var query = (from a in db.GdClientes
                             where a.Cliente.Equals(cmbClientes.Text)
                             select a).FirstOrDefault();

                query.Cliente = txtNombreCliente.Text;
                db.SaveChanges();
                CargarComboClientes();
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        private bool ValidarCamposNuevoCliente()
        {
            bool EsValido = true;
            string cadena = "Faltan los siguientes campos obligatorios:" + Environment.NewLine;
            try
            {
                if (txtNuevoCliente.Text == string.Empty)
                {
                    cadena += "Nombre nuevo cliente:" + Environment.NewLine;
                    txtNuevoCliente.Focus();
                    EsValido = false;
                }
                if (CarpetaBaseProyectos.Text == string.Empty)
                {
                    cadena += "Carpeta Base proyectos:" + Environment.NewLine;
                    CarpetaBaseProyectos.Focus();
                    EsValido = false;
                }
                if (txtProyecto.Text == string.Empty)
                {
                    cadena += "Carpeta proyectos:" + Environment.NewLine;
                    txtProyecto.Focus();
                    EsValido = false;
                }
                if (!EsValido)
                {
                    MessageBox.Show(cadena, "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
            return EsValido;
        }

        private void PbAgregarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Desea agregar un nuevo cliente?", "Clientes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    txtNuevoCliente.Visible = true;
                    txtNuevoCliente.Text = string.Empty;
                    txtNombreCliente.Text = string.Empty;
                    txtNuevoCliente.Focus();
                    cmbClientes.Visible = false;
                }
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        private void TxtNuevoCliente_Leave(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCamposNuevoCliente())
                {
                    using GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext();
                    {

                        var query = (from a in db.GdClientes
                                     where a.Cliente.Equals(txtNuevoCliente.Text)
                                     select a);
                        if (query.Count() == 0)
                        {
                            var cli = new GdClientes()
                            {
                                Cliente = txtNuevoCliente.Text
                            };

                            db.GdClientes.Add(cli);
                            db.SaveChanges();
                        }

                    }
                }
                txtNuevoCliente.Visible = false;
                CargarComboClientes();
                cmbClientes.Visible = true;
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }

        private void PbEliminarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Desea eliminar este cliente?", "Clientes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using GendocsModeloDatos.models.GenDocsContext db = new GendocsModeloDatos.models.GenDocsContext();
                    {
                        var cSelect = (from x in db.GdClientes
                                       where x.Cliente == cmbClientes.Text
                                       select x).FirstOrDefault();

                        if (cSelect.IdCliente != 0)
                        {
                            var lst = from x in db.GdProyectos
                                      where x.IdCliente == cSelect.IdCliente
                                      select x;

                            if (lst.Count() > 0)
                            {
                                MessageBox.Show("No se puede eliminar este cliente ya que tiene expendientes asociados", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                db.GdClientes.RemoveRange(cSelect);
                                db.SaveChanges();
                            }                               
                        }
                    }
                    txtNuevoCliente.Visible = false;
                    CargarComboClientes();
                    cmbClientes.Visible = true;
                }
            }
            catch (Exception ex)
            {
                _ = ex.Message;
            }
        }
    }
}
