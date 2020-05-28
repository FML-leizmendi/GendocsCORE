namespace GendocsForms.Forms
{
    partial class FrmContactos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlCabercera = new System.Windows.Forms.Panel();
            this.pnlLateral = new System.Windows.Forms.Panel();
            this.btnConsultarEmpleado = new System.Windows.Forms.Button();
            this.btnEditarEmpleado = new System.Windows.Forms.Button();
            this.grbEmpleados = new System.Windows.Forms.GroupBox();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtIntroduzcaTexto = new System.Windows.Forms.TextBox();
            this.lblTexto = new System.Windows.Forms.Label();
            this.dgvContactos = new System.Windows.Forms.DataGridView();
            this.pnlLateral.SuspendLayout();
            this.grbEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCabercera
            // 
            this.pnlCabercera.BackColor = System.Drawing.Color.LightBlue;
            this.pnlCabercera.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabercera.Location = new System.Drawing.Point(0, 0);
            this.pnlCabercera.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlCabercera.Name = "pnlCabercera";
            this.pnlCabercera.Size = new System.Drawing.Size(1428, 58);
            this.pnlCabercera.TabIndex = 1;
            // 
            // pnlLateral
            // 
            this.pnlLateral.BackColor = System.Drawing.Color.Gray;
            this.pnlLateral.Controls.Add(this.btnConsultarEmpleado);
            this.pnlLateral.Controls.Add(this.btnEditarEmpleado);
            this.pnlLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLateral.Location = new System.Drawing.Point(0, 58);
            this.pnlLateral.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlLateral.Name = "pnlLateral";
            this.pnlLateral.Size = new System.Drawing.Size(216, 751);
            this.pnlLateral.TabIndex = 2;
            // 
            // btnConsultarEmpleado
            // 
            this.btnConsultarEmpleado.BackColor = System.Drawing.Color.LightBlue;
            this.btnConsultarEmpleado.FlatAppearance.BorderSize = 0;
            this.btnConsultarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarEmpleado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConsultarEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarEmpleado.Location = new System.Drawing.Point(14, 415);
            this.btnConsultarEmpleado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConsultarEmpleado.Name = "btnConsultarEmpleado";
            this.btnConsultarEmpleado.Size = new System.Drawing.Size(188, 45);
            this.btnConsultarEmpleado.TabIndex = 1;
            this.btnConsultarEmpleado.Text = "Consultar Empleado";
            this.btnConsultarEmpleado.UseVisualStyleBackColor = false;
            // 
            // btnEditarEmpleado
            // 
            this.btnEditarEmpleado.BackColor = System.Drawing.Color.LightBlue;
            this.btnEditarEmpleado.FlatAppearance.BorderSize = 0;
            this.btnEditarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarEmpleado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditarEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarEmpleado.Location = new System.Drawing.Point(14, 351);
            this.btnEditarEmpleado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEditarEmpleado.Name = "btnEditarEmpleado";
            this.btnEditarEmpleado.Size = new System.Drawing.Size(188, 45);
            this.btnEditarEmpleado.TabIndex = 0;
            this.btnEditarEmpleado.Text = "      Editar Empleado";
            this.btnEditarEmpleado.UseVisualStyleBackColor = false;
            this.btnEditarEmpleado.Click += new System.EventHandler(this.btnEditarEmpleado_Click);
            // 
            // grbEmpleados
            // 
            this.grbEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbEmpleados.Controls.Add(this.cmbClientes);
            this.grbEmpleados.Controls.Add(this.lblCliente);
            this.grbEmpleados.Controls.Add(this.txtIntroduzcaTexto);
            this.grbEmpleados.Controls.Add(this.lblTexto);
            this.grbEmpleados.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grbEmpleados.Location = new System.Drawing.Point(223, 65);
            this.grbEmpleados.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbEmpleados.Name = "grbEmpleados";
            this.grbEmpleados.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbEmpleados.Size = new System.Drawing.Size(1196, 87);
            this.grbEmpleados.TabIndex = 3;
            this.grbEmpleados.TabStop = false;
            this.grbEmpleados.Text = "Empleados";
            // 
            // cmbClientes
            // 
            this.cmbClientes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(351, 45);
            this.cmbClientes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(209, 25);
            this.cmbClientes.TabIndex = 4;
            this.cmbClientes.Tag = "param004";
            this.cmbClientes.SelectedIndexChanged += new System.EventHandler(this.cmbClientes_SelectedIndexChanged);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCliente.Location = new System.Drawing.Point(348, 27);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(45, 16);
            this.lblCliente.TabIndex = 2;
            this.lblCliente.Text = "Cliente";
            // 
            // txtIntroduzcaTexto
            // 
            this.txtIntroduzcaTexto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIntroduzcaTexto.Location = new System.Drawing.Point(38, 47);
            this.txtIntroduzcaTexto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtIntroduzcaTexto.Name = "txtIntroduzcaTexto";
            this.txtIntroduzcaTexto.Size = new System.Drawing.Size(298, 23);
            this.txtIntroduzcaTexto.TabIndex = 1;
            this.txtIntroduzcaTexto.Tag = "paramUS010";
            this.txtIntroduzcaTexto.TextChanged += new System.EventHandler(this.txtIntroduzcaTexto_TextChanged);
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTexto.Location = new System.Drawing.Point(42, 27);
            this.lblTexto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(114, 16);
            this.lblTexto.TabIndex = 0;
            this.lblTexto.Text = "Introduzca un texto";
            // 
            // dgvContactos
            // 
            this.dgvContactos.AllowUserToAddRows = false;
            this.dgvContactos.AllowUserToDeleteRows = false;
            this.dgvContactos.AllowUserToOrderColumns = true;
            this.dgvContactos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactos.Location = new System.Drawing.Point(223, 158);
            this.dgvContactos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvContactos.Name = "dgvContactos";
            this.dgvContactos.ReadOnly = true;
            this.dgvContactos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContactos.Size = new System.Drawing.Size(1196, 637);
            this.dgvContactos.TabIndex = 4;
            this.dgvContactos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContactos_CellContentDoubleClick);
            this.dgvContactos.CurrentCellChanged += new System.EventHandler(this.dgvContactos_CurrentCellChanged);
            // 
            // FrmContactos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1428, 809);
            this.Controls.Add(this.dgvContactos);
            this.Controls.Add(this.grbEmpleados);
            this.Controls.Add(this.pnlLateral);
            this.Controls.Add(this.pnlCabercera);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmContactos";
            this.Text = "Contactos";
            this.Load += new System.EventHandler(this.FrmContactos_Load);
            this.Leave += new System.EventHandler(this.FrmContactos_Leave);
            this.pnlLateral.ResumeLayout(false);
            this.grbEmpleados.ResumeLayout(false);
            this.grbEmpleados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCabercera;
        private System.Windows.Forms.Panel pnlLateral;
        private System.Windows.Forms.Button btnConsultarEmpleado;
        private System.Windows.Forms.Button btnEditarEmpleado;
        private System.Windows.Forms.GroupBox grbEmpleados;
        private System.Windows.Forms.TextBox txtIntroduzcaTexto;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.DataGridView dgvContactos;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cmbClientes;
    }
}