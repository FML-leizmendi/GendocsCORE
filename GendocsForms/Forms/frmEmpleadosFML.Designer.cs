namespace GendocsForms.Forms
{
    partial class frmEmpleadosFML
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
            this.grbEmpleados = new System.Windows.Forms.GroupBox();
            this.txtIntroduzcaTexto = new System.Windows.Forms.TextBox();
            this.lblTexto = new System.Windows.Forms.Label();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.btnEditarEmpleado = new System.Windows.Forms.Button();
            this.btnConsultarEmpleado = new System.Windows.Forms.Button();
            this.pnlLateral = new System.Windows.Forms.Panel();
            this.grbEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.pnlLateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCabercera
            // 
            this.pnlCabercera.BackColor = System.Drawing.Color.LightBlue;
            this.pnlCabercera.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabercera.Location = new System.Drawing.Point(0, 0);
            this.pnlCabercera.Name = "pnlCabercera";
            this.pnlCabercera.Size = new System.Drawing.Size(1224, 50);
            this.pnlCabercera.TabIndex = 0;
            // 
            // grbEmpleados
            // 
            this.grbEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbEmpleados.Controls.Add(this.txtIntroduzcaTexto);
            this.grbEmpleados.Controls.Add(this.lblTexto);
            this.grbEmpleados.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEmpleados.Location = new System.Drawing.Point(191, 56);
            this.grbEmpleados.Name = "grbEmpleados";
            this.grbEmpleados.Size = new System.Drawing.Size(1025, 75);
            this.grbEmpleados.TabIndex = 2;
            this.grbEmpleados.TabStop = false;
            this.grbEmpleados.Text = "Empleados";
            // 
            // txtIntroduzcaTexto
            // 
            this.txtIntroduzcaTexto.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtIntroduzcaTexto.Location = new System.Drawing.Point(35, 37);
            this.txtIntroduzcaTexto.Name = "txtIntroduzcaTexto";
            this.txtIntroduzcaTexto.Size = new System.Drawing.Size(287, 23);
            this.txtIntroduzcaTexto.TabIndex = 1;
            this.txtIntroduzcaTexto.TextChanged += new System.EventHandler(this.txtIntroduzcaTexto_TextChanged);
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.Location = new System.Drawing.Point(38, 19);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(115, 16);
            this.lblTexto.TabIndex = 0;
            this.lblTexto.Text = "Introduzca un texto";
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AllowUserToDeleteRows = false;
            this.dgvEmpleados.AllowUserToOrderColumns = true;
            this.dgvEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(191, 137);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpleados.Size = new System.Drawing.Size(1025, 562);
            this.dgvEmpleados.TabIndex = 3;
            this.dgvEmpleados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellDoubleClick);
            this.dgvEmpleados.CurrentCellChanged += new System.EventHandler(this.dgvEmpleados_CurrentCellChanged);
            // 
            // btnEditarEmpleado
            // 
            this.btnEditarEmpleado.BackColor = System.Drawing.Color.LightBlue;
            this.btnEditarEmpleado.FlatAppearance.BorderSize = 0;
            this.btnEditarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarEmpleado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarEmpleado.ForeColor = System.Drawing.Color.Black;
            this.btnEditarEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarEmpleado.Location = new System.Drawing.Point(12, 323);
            this.btnEditarEmpleado.Name = "btnEditarEmpleado";
            this.btnEditarEmpleado.Size = new System.Drawing.Size(161, 39);
            this.btnEditarEmpleado.TabIndex = 0;
            this.btnEditarEmpleado.Text = "EDITAR";
            this.btnEditarEmpleado.UseVisualStyleBackColor = false;
            this.btnEditarEmpleado.Click += new System.EventHandler(this.btnEditarEmpleado_Click);
            // 
            // btnConsultarEmpleado
            // 
            this.btnConsultarEmpleado.BackColor = System.Drawing.Color.LightBlue;
            this.btnConsultarEmpleado.FlatAppearance.BorderSize = 0;
            this.btnConsultarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarEmpleado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarEmpleado.ForeColor = System.Drawing.Color.Black;
            this.btnConsultarEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarEmpleado.Location = new System.Drawing.Point(12, 372);
            this.btnConsultarEmpleado.Name = "btnConsultarEmpleado";
            this.btnConsultarEmpleado.Size = new System.Drawing.Size(161, 39);
            this.btnConsultarEmpleado.TabIndex = 1;
            this.btnConsultarEmpleado.Text = "CONSULTAR";
            this.btnConsultarEmpleado.UseVisualStyleBackColor = false;
            // 
            // pnlLateral
            // 
            this.pnlLateral.BackColor = System.Drawing.Color.Gray;
            this.pnlLateral.Controls.Add(this.btnConsultarEmpleado);
            this.pnlLateral.Controls.Add(this.btnEditarEmpleado);
            this.pnlLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLateral.Location = new System.Drawing.Point(0, 50);
            this.pnlLateral.Name = "pnlLateral";
            this.pnlLateral.Size = new System.Drawing.Size(185, 661);
            this.pnlLateral.TabIndex = 1;
            // 
            // frmEmpleadosFML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1224, 711);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.grbEmpleados);
            this.Controls.Add(this.pnlLateral);
            this.Controls.Add(this.pnlCabercera);
            this.MaximumSize = new System.Drawing.Size(1240, 750);
            this.MinimumSize = new System.Drawing.Size(1240, 750);
            this.Name = "frmEmpleadosFML";
            this.Text = "Empleados FML";
            this.Load += new System.EventHandler(this.frmEmpleadosFML_Load);
            this.grbEmpleados.ResumeLayout(false);
            this.grbEmpleados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.pnlLateral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCabercera;
        private System.Windows.Forms.GroupBox grbEmpleados;
        private System.Windows.Forms.TextBox txtIntroduzcaTexto;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.Button btnEditarEmpleado;
        private System.Windows.Forms.Button btnConsultarEmpleado;
        private System.Windows.Forms.Panel pnlLateral;
    }
}