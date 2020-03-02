﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Globalization;


namespace GendocsForms
{
    public partial class frmMantenimientoEmpleadosFML : Form
    {
        public clsEmpFml cEmp { get; set; }
        public int IdEmpleadoMantenimiento { get; set; }

        public frmMantenimientoEmpleadosFML(clsEmpFml cemp)
        {
            cEmp = cemp;
            InitializeComponent();
        }

        public frmMantenimientoEmpleadosFML()
        {
            InitializeComponent();

        }

        #region "Eventos Privados"
        private void frmMantenimientoEmpleadosFML_Load(object sender, EventArgs e)
        {
            CargarForm();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimpiarControles()
        {
            txtApellidos.Text = String.Empty;
            txtEmail.Text = string.Empty;
            txtEtiquetas.Text = string.Empty;
            // txtIdEmpleado.Text = string.Empty;
            txtNIF.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtTelefono.Text = string.Empty;
        }

        #endregion

        #region "Métodos Privados"

        public void CargarForm()
        {
            try
            {
                //txtIdEmpleado.Text = cEmp.IdEmpleado.ToString();
                txtNIF.Text = cEmp.Nif;
                txtNombre.Text = cEmp.Nombre;
                txtApellidos.Text = cEmp.Apellidos;
                txtTelefono.Text = cEmp.Telefono;
                txtEmail.Text = cEmp.Email;
                txtEtiquetas.Text = cEmp.Etiquetas;

            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
            }
        }

        bool validarControles()
        {
            foreach (Control item in this.Controls)
            {
                try
                {
                    if (item is TextBox)
                    {
                        //Codigo comprobacion  de textbox
                        if (item.Text == "")
                        {
                            MessageBox.Show("Hay campos vacios");
                            item.Focus();
                            return false;
                        }
                    }
                }
                catch { }
            }
            return true;
        }

        #endregion

        #region "Control de Eventos"
        private void btnPrimero_Click(object sender, EventArgs e)
        {
            cEmp.IrPrimero();
            CargarForm();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            cEmp.IrAnterior();
            CargarForm();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            cEmp.IrSiguiente();
            CargarForm();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            cEmp.IrUltimo();
            CargarForm();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            cEmp.EliminarUsuario();
            CargarForm();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            // txtIdEmpleado.Visible = true;
            cEmp.EsAlta = true;
            btnEliminar.Visible = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarControles())
            {
                //cEmp.IdEmpleado = Int32.Parse(txtIdEmpleado.Text);
                cEmp.Nif = txtNIF.Text;
                cEmp.Nombre = txtNombre.Text;
                cEmp.Apellidos = txtApellidos.Text;
                cEmp.Telefono = txtTelefono.Text;
                cEmp.Email = txtEmail.Text;
                cEmp.Etiquetas = txtEtiquetas.Text;
                cEmp.GuardarUsuario();
                cEmp.EsAlta = false;
                // txtIdEmpleado.Visible = false;
                btnEliminar.Visible = true;
            }

        }
        #endregion
    }
}