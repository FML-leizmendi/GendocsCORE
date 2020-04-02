namespace GendocsForms
{
    partial class FrmRecursos
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
            this.grbRecursos = new System.Windows.Forms.GroupBox();
            this.dgvRecursos = new System.Windows.Forms.DataGridView();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.cmbArea = new System.Windows.Forms.ComboBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblActivo = new System.Windows.Forms.Label();
            this.grbRecursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecursos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCabercera
            // 
            this.pnlCabercera.BackColor = System.Drawing.Color.LightBlue;
            this.pnlCabercera.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabercera.Location = new System.Drawing.Point(0, 0);
            this.pnlCabercera.Name = "pnlCabercera";
            this.pnlCabercera.Size = new System.Drawing.Size(1224, 50);
            this.pnlCabercera.TabIndex = 2;
            // 
            // pnlLateral
            // 
            this.pnlLateral.BackColor = System.Drawing.Color.Gray;
            this.pnlLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLateral.Location = new System.Drawing.Point(0, 50);
            this.pnlLateral.Name = "pnlLateral";
            this.pnlLateral.Size = new System.Drawing.Size(185, 651);
            this.pnlLateral.TabIndex = 3;
            // 
            // grbRecursos
            // 
            this.grbRecursos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbRecursos.Controls.Add(this.comboBox2);
            this.grbRecursos.Controls.Add(this.lblActivo);
            this.grbRecursos.Controls.Add(this.cmbArea);
            this.grbRecursos.Controls.Add(this.lblArea);
            this.grbRecursos.Controls.Add(this.cmbClientes);
            this.grbRecursos.Controls.Add(this.lblCliente);
            this.grbRecursos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbRecursos.Location = new System.Drawing.Point(191, 56);
            this.grbRecursos.Name = "grbRecursos";
            this.grbRecursos.Size = new System.Drawing.Size(1025, 75);
            this.grbRecursos.TabIndex = 4;
            this.grbRecursos.TabStop = false;
            this.grbRecursos.Text = "Recursos";
            // 
            // dgvRecursos
            // 
            this.dgvRecursos.AllowUserToAddRows = false;
            this.dgvRecursos.AllowUserToDeleteRows = false;
            this.dgvRecursos.AllowUserToOrderColumns = true;
            this.dgvRecursos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRecursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecursos.Location = new System.Drawing.Point(191, 137);
            this.dgvRecursos.Name = "dgvRecursos";
            this.dgvRecursos.ReadOnly = true;
            this.dgvRecursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecursos.Size = new System.Drawing.Size(1025, 552);
            this.dgvRecursos.TabIndex = 5;
            // 
            // cmbClientes
            // 
            this.cmbClientes.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(42, 33);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(180, 25);
            this.cmbClientes.TabIndex = 6;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(39, 17);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(46, 16);
            this.lblCliente.TabIndex = 5;
            this.lblCliente.Text = "Cliente";
            // 
            // cmbArea
            // 
            this.cmbArea.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Location = new System.Drawing.Point(239, 33);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(331, 25);
            this.cmbArea.TabIndex = 8;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(236, 17);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(33, 16);
            this.lblArea.TabIndex = 7;
            this.lblArea.Text = "Área";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(579, 33);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(180, 25);
            this.comboBox2.TabIndex = 10;
            // 
            // lblActivo
            // 
            this.lblActivo.AutoSize = true;
            this.lblActivo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivo.Location = new System.Drawing.Point(576, 17);
            this.lblActivo.Name = "lblActivo";
            this.lblActivo.Size = new System.Drawing.Size(43, 16);
            this.lblActivo.TabIndex = 9;
            this.lblActivo.Text = "Activo";
            // 
            // FrmRecursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1224, 701);
            this.Controls.Add(this.dgvRecursos);
            this.Controls.Add(this.grbRecursos);
            this.Controls.Add(this.pnlLateral);
            this.Controls.Add(this.pnlCabercera);
            this.MaximumSize = new System.Drawing.Size(1240, 740);
            this.MinimumSize = new System.Drawing.Size(1240, 726);
            this.Name = "FrmRecursos";
            this.Text = "Recursos";
            this.Load += new System.EventHandler(this.FrmRecursos_Load);
            this.grbRecursos.ResumeLayout(false);
            this.grbRecursos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecursos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCabercera;
        private System.Windows.Forms.Panel pnlLateral;
        private System.Windows.Forms.GroupBox grbRecursos;
        private System.Windows.Forms.DataGridView dgvRecursos;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblActivo;
        private System.Windows.Forms.ComboBox cmbArea;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.Label lblCliente;
    }
}