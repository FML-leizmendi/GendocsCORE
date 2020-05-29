namespace GendocsForms
{
    partial class FrmUnidadesConstructivas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUnidadesConstructivas));
            this.pnlCabecera = new System.Windows.Forms.Panel();
            this.pnlLateral = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.pnlBotonera = new System.Windows.Forms.Panel();
            this.grbUnidadesContructivas = new System.Windows.Forms.GroupBox();
            this.cmbTipoTrabajo = new System.Windows.Forms.ComboBox();
            this.lblTipoTrabajo = new System.Windows.Forms.Label();
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            this.txtIntroduzcaTexto = new System.Windows.Forms.TextBox();
            this.lblTexto = new System.Windows.Forms.Label();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.dgvUndsContructivas = new System.Windows.Forms.DataGridView();
            this.pnlLateral.SuspendLayout();
            this.grbUnidadesContructivas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUndsContructivas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCabecera
            // 
            this.pnlCabecera.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabecera.Location = new System.Drawing.Point(0, 0);
            this.pnlCabecera.Margin = new System.Windows.Forms.Padding(2);
            this.pnlCabecera.Name = "pnlCabecera";
            this.pnlCabecera.Size = new System.Drawing.Size(1173, 54);
            this.pnlCabecera.TabIndex = 0;
            // 
            // pnlLateral
            // 
            this.pnlLateral.BackColor = System.Drawing.Color.Gray;
            this.pnlLateral.Controls.Add(this.btnCancelar);
            this.pnlLateral.Controls.Add(this.btnAceptar);
            this.pnlLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLateral.Location = new System.Drawing.Point(0, 54);
            this.pnlLateral.Margin = new System.Windows.Forms.Padding(2);
            this.pnlLateral.Name = "pnlLateral";
            this.pnlLateral.Size = new System.Drawing.Size(191, 504);
            this.pnlLateral.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Gray;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(8, 238);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(175, 39);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(8, 193);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(175, 39);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // pnlBotonera
            // 
            this.pnlBotonera.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pnlBotonera.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBotonera.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotonera.Location = new System.Drawing.Point(191, 502);
            this.pnlBotonera.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBotonera.Name = "pnlBotonera";
            this.pnlBotonera.Size = new System.Drawing.Size(982, 56);
            this.pnlBotonera.TabIndex = 2;
            // 
            // grbUnidadesContructivas
            // 
            this.grbUnidadesContructivas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbUnidadesContructivas.Controls.Add(this.cmbTipoTrabajo);
            this.grbUnidadesContructivas.Controls.Add(this.lblTipoTrabajo);
            this.grbUnidadesContructivas.Controls.Add(this.btnLimpiarFiltros);
            this.grbUnidadesContructivas.Controls.Add(this.txtIntroduzcaTexto);
            this.grbUnidadesContructivas.Controls.Add(this.lblTexto);
            this.grbUnidadesContructivas.Controls.Add(this.cmbClientes);
            this.grbUnidadesContructivas.Controls.Add(this.lblCliente);
            this.grbUnidadesContructivas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.grbUnidadesContructivas.Location = new System.Drawing.Point(194, 57);
            this.grbUnidadesContructivas.Margin = new System.Windows.Forms.Padding(2);
            this.grbUnidadesContructivas.Name = "grbUnidadesContructivas";
            this.grbUnidadesContructivas.Padding = new System.Windows.Forms.Padding(2);
            this.grbUnidadesContructivas.Size = new System.Drawing.Size(973, 83);
            this.grbUnidadesContructivas.TabIndex = 3;
            this.grbUnidadesContructivas.TabStop = false;
            this.grbUnidadesContructivas.Text = "Unidades Contructivas";
            // 
            // cmbTipoTrabajo
            // 
            this.cmbTipoTrabajo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmbTipoTrabajo.FormattingEnabled = true;
            this.cmbTipoTrabajo.Location = new System.Drawing.Point(466, 48);
            this.cmbTipoTrabajo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbTipoTrabajo.Name = "cmbTipoTrabajo";
            this.cmbTipoTrabajo.Size = new System.Drawing.Size(165, 25);
            this.cmbTipoTrabajo.TabIndex = 14;
            this.cmbTipoTrabajo.SelectedIndexChanged += new System.EventHandler(this.CmbTipoTrabajo_SelectedIndexChanged);
            // 
            // lblTipoTrabajo
            // 
            this.lblTipoTrabajo.AutoSize = true;
            this.lblTipoTrabajo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoTrabajo.Location = new System.Drawing.Point(467, 33);
            this.lblTipoTrabajo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoTrabajo.Name = "lblTipoTrabajo";
            this.lblTipoTrabajo.Size = new System.Drawing.Size(92, 16);
            this.lblTipoTrabajo.TabIndex = 13;
            this.lblTipoTrabajo.Text = "Tipo de Trabajo";
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.BackColor = System.Drawing.Color.LightBlue;
            this.btnLimpiarFiltros.FlatAppearance.BorderSize = 0;
            this.btnLimpiarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarFiltros.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarFiltros.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiarFiltros.Image")));
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(638, 51);
            this.btnLimpiarFiltros.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLimpiarFiltros.MaximumSize = new System.Drawing.Size(50, 19);
            this.btnLimpiarFiltros.MinimumSize = new System.Drawing.Size(50, 19);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(50, 19);
            this.btnLimpiarFiltros.TabIndex = 12;
            this.btnLimpiarFiltros.UseVisualStyleBackColor = false;
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.BtnLimpiarFiltros_Click);
            // 
            // txtIntroduzcaTexto
            // 
            this.txtIntroduzcaTexto.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtIntroduzcaTexto.Location = new System.Drawing.Point(35, 48);
            this.txtIntroduzcaTexto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtIntroduzcaTexto.Name = "txtIntroduzcaTexto";
            this.txtIntroduzcaTexto.Size = new System.Drawing.Size(256, 23);
            this.txtIntroduzcaTexto.TabIndex = 11;
            this.txtIntroduzcaTexto.TextChanged += new System.EventHandler(this.TxtIntroduzcaTexto_TextChanged);
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.Location = new System.Drawing.Point(39, 29);
            this.lblTexto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(115, 16);
            this.lblTexto.TabIndex = 10;
            this.lblTexto.Text = "Introduzca un texto";
            // 
            // cmbClientes
            // 
            this.cmbClientes.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(295, 48);
            this.cmbClientes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(165, 25);
            this.cmbClientes.TabIndex = 9;
            this.cmbClientes.SelectedIndexChanged += new System.EventHandler(this.CmbClientes_SelectedIndexChanged);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(297, 33);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(46, 16);
            this.lblCliente.TabIndex = 8;
            this.lblCliente.Text = "Cliente";
            // 
            // dgvUndsContructivas
            // 
            this.dgvUndsContructivas.AllowUserToAddRows = false;
            this.dgvUndsContructivas.AllowUserToDeleteRows = false;
            this.dgvUndsContructivas.AllowUserToOrderColumns = true;
            this.dgvUndsContructivas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUndsContructivas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUndsContructivas.Location = new System.Drawing.Point(194, 146);
            this.dgvUndsContructivas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvUndsContructivas.MultiSelect = false;
            this.dgvUndsContructivas.Name = "dgvUndsContructivas";
            this.dgvUndsContructivas.ReadOnly = true;
            this.dgvUndsContructivas.RowHeadersWidth = 72;
            this.dgvUndsContructivas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUndsContructivas.Size = new System.Drawing.Size(973, 354);
            this.dgvUndsContructivas.TabIndex = 4;
            // 
            // FrmUnidadesConstructivas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1173, 558);
            this.Controls.Add(this.dgvUndsContructivas);
            this.Controls.Add(this.grbUnidadesContructivas);
            this.Controls.Add(this.pnlBotonera);
            this.Controls.Add(this.pnlLateral);
            this.Controls.Add(this.pnlCabecera);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1194, 611);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1053, 580);
            this.Name = "FrmUnidadesConstructivas";
            this.Text = "Unidades Constructivas";
            this.Load += new System.EventHandler(this.FrmUnidadesConstructivas_Load);
            this.pnlLateral.ResumeLayout(false);
            this.grbUnidadesContructivas.ResumeLayout(false);
            this.grbUnidadesContructivas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUndsContructivas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCabecera;
        private System.Windows.Forms.Panel pnlLateral;
        private System.Windows.Forms.Panel pnlBotonera;
        private System.Windows.Forms.GroupBox grbUnidadesContructivas;
        private System.Windows.Forms.TextBox txtIntroduzcaTexto;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.DataGridView dgvUndsContructivas;
        private System.Windows.Forms.Button btnLimpiarFiltros;
        private System.Windows.Forms.ComboBox cmbTipoTrabajo;
        private System.Windows.Forms.Label lblTipoTrabajo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}