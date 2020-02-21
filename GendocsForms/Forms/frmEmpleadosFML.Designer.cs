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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpleadosFML));
            this.pnlCabercera = new System.Windows.Forms.Panel();
            this.pnlLateral = new System.Windows.Forms.Panel();
            this.pnlBotonera = new System.Windows.Forms.Panel();
            this.flpBotonera = new System.Windows.Forms.FlowLayoutPanel();
            this.btnProyecto = new System.Windows.Forms.Button();
            this.btnEditarDocs = new System.Windows.Forms.Button();
            this.grbEmpleados = new System.Windows.Forms.GroupBox();
            this.txtIntroduzcaTexto = new System.Windows.Forms.TextBox();
            this.lblTexto = new System.Windows.Forms.Label();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.pnlBotonera.SuspendLayout();
            this.flpBotonera.SuspendLayout();
            this.grbEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCabercera
            // 
            this.pnlCabercera.BackColor = System.Drawing.Color.LightBlue;
            this.pnlCabercera.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabercera.Location = new System.Drawing.Point(0, 0);
            this.pnlCabercera.Name = "pnlCabercera";
            this.pnlCabercera.Size = new System.Drawing.Size(1264, 50);
            this.pnlCabercera.TabIndex = 0;
            // 
            // pnlLateral
            // 
            this.pnlLateral.BackColor = System.Drawing.Color.Gray;
            this.pnlLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLateral.Location = new System.Drawing.Point(0, 50);
            this.pnlLateral.Name = "pnlLateral";
            this.pnlLateral.Size = new System.Drawing.Size(221, 631);
            this.pnlLateral.TabIndex = 1;
            // 
            // pnlBotonera
            // 
            this.pnlBotonera.Controls.Add(this.flpBotonera);
            this.pnlBotonera.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotonera.Location = new System.Drawing.Point(221, 626);
            this.pnlBotonera.Name = "pnlBotonera";
            this.pnlBotonera.Size = new System.Drawing.Size(1043, 55);
            this.pnlBotonera.TabIndex = 2;
            // 
            // flpBotonera
            // 
            this.flpBotonera.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.flpBotonera.Controls.Add(this.btnProyecto);
            this.flpBotonera.Controls.Add(this.btnEditarDocs);
            this.flpBotonera.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpBotonera.Location = new System.Drawing.Point(3, 6);
            this.flpBotonera.Name = "flpBotonera";
            this.flpBotonera.Size = new System.Drawing.Size(1037, 46);
            this.flpBotonera.TabIndex = 1;
            // 
            // btnProyecto
            // 
            this.btnProyecto.BackColor = System.Drawing.Color.LightGray;
            this.btnProyecto.FlatAppearance.BorderSize = 0;
            this.btnProyecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProyecto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProyecto.Image = ((System.Drawing.Image)(resources.GetObject("btnProyecto.Image")));
            this.btnProyecto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProyecto.Location = new System.Drawing.Point(873, 3);
            this.btnProyecto.Name = "btnProyecto";
            this.btnProyecto.Size = new System.Drawing.Size(161, 39);
            this.btnProyecto.TabIndex = 1;
            this.btnProyecto.Text = "Proyecto";
            this.btnProyecto.UseVisualStyleBackColor = false;
            // 
            // btnEditarDocs
            // 
            this.btnEditarDocs.BackColor = System.Drawing.Color.LightGray;
            this.btnEditarDocs.FlatAppearance.BorderSize = 0;
            this.btnEditarDocs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarDocs.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarDocs.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarDocs.Image")));
            this.btnEditarDocs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarDocs.Location = new System.Drawing.Point(706, 3);
            this.btnEditarDocs.Name = "btnEditarDocs";
            this.btnEditarDocs.Size = new System.Drawing.Size(161, 39);
            this.btnEditarDocs.TabIndex = 0;
            this.btnEditarDocs.Text = "      Editar Docs.";
            this.btnEditarDocs.UseVisualStyleBackColor = false;
            // 
            // grbEmpleados
            // 
            this.grbEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbEmpleados.Controls.Add(this.txtIntroduzcaTexto);
            this.grbEmpleados.Controls.Add(this.lblTexto);
            this.grbEmpleados.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEmpleados.Location = new System.Drawing.Point(227, 56);
            this.grbEmpleados.Name = "grbEmpleados";
            this.grbEmpleados.Size = new System.Drawing.Size(1031, 85);
            this.grbEmpleados.TabIndex = 3;
            this.grbEmpleados.TabStop = false;
            this.grbEmpleados.Text = "Empleados";
            // 
            // txtIntroduzcaTexto
            // 
            this.txtIntroduzcaTexto.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtIntroduzcaTexto.Location = new System.Drawing.Point(38, 48);
            this.txtIntroduzcaTexto.Name = "txtIntroduzcaTexto";
            this.txtIntroduzcaTexto.Size = new System.Drawing.Size(287, 23);
            this.txtIntroduzcaTexto.TabIndex = 1;
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.Location = new System.Drawing.Point(41, 30);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(115, 16);
            this.lblTexto.TabIndex = 0;
            this.lblTexto.Text = "Introduzca un texto";
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToOrderColumns = true;
            this.dgvEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(227, 147);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpleados.Size = new System.Drawing.Size(1031, 473);
            this.dgvEmpleados.TabIndex = 4;
            // 
            // frmEmpleadosFML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.grbEmpleados);
            this.Controls.Add(this.pnlBotonera);
            this.Controls.Add(this.pnlLateral);
            this.Controls.Add(this.pnlCabercera);
            this.Name = "frmEmpleadosFML";
            this.Text = "frmEmpleadosFML";
            this.Load += new System.EventHandler(this.frmEmpleadosFML_Load);
            this.pnlBotonera.ResumeLayout(false);
            this.flpBotonera.ResumeLayout(false);
            this.grbEmpleados.ResumeLayout(false);
            this.grbEmpleados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCabercera;
        private System.Windows.Forms.Panel pnlLateral;
        private System.Windows.Forms.Panel pnlBotonera;
        private System.Windows.Forms.FlowLayoutPanel flpBotonera;
        private System.Windows.Forms.Button btnProyecto;
        private System.Windows.Forms.Button btnEditarDocs;
        private System.Windows.Forms.GroupBox grbEmpleados;
        private System.Windows.Forms.TextBox txtIntroduzcaTexto;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.DataGridView dgvEmpleados;
    }
}