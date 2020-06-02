namespace GendocsForms.Forms
{
    partial class FrmParametros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmParametros));
            this.gbParametros = new System.Windows.Forms.GroupBox();
            this.tbParametros = new System.Windows.Forms.TabControl();
            this.tpCarpetas = new System.Windows.Forms.TabPage();
            this.lblCarpetaGen3 = new System.Windows.Forms.Label();
            this.lblCarpetaBaseProyectos = new System.Windows.Forms.Label();
            this.pbCarpetaGen3 = new System.Windows.Forms.PictureBox();
            this.CarpertaGen3 = new System.Windows.Forms.TextBox();
            this.pbCarpetaBaseProyecto = new System.Windows.Forms.PictureBox();
            this.CarpetaBaseProyectos = new System.Windows.Forms.TextBox();
            this.tpCamposProyecto = new System.Windows.Forms.TabPage();
            this.gbParametros.SuspendLayout();
            this.tbParametros.SuspendLayout();
            this.tpCarpetas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarpetaGen3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarpetaBaseProyecto)).BeginInit();
            this.SuspendLayout();
            // 
            // gbParametros
            // 
            this.gbParametros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbParametros.Controls.Add(this.tbParametros);
            this.gbParametros.Location = new System.Drawing.Point(10, 10);
            this.gbParametros.Name = "gbParametros";
            this.gbParametros.Size = new System.Drawing.Size(779, 403);
            this.gbParametros.TabIndex = 0;
            this.gbParametros.TabStop = false;
            // 
            // tbParametros
            // 
            this.tbParametros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbParametros.Controls.Add(this.tpCarpetas);
            this.tbParametros.Controls.Add(this.tpCamposProyecto);
            this.tbParametros.Location = new System.Drawing.Point(5, 19);
            this.tbParametros.Name = "tbParametros";
            this.tbParametros.SelectedIndex = 0;
            this.tbParametros.Size = new System.Drawing.Size(769, 379);
            this.tbParametros.TabIndex = 0;
            // 
            // tpCarpetas
            // 
            this.tpCarpetas.Controls.Add(this.lblCarpetaGen3);
            this.tpCarpetas.Controls.Add(this.lblCarpetaBaseProyectos);
            this.tpCarpetas.Controls.Add(this.pbCarpetaGen3);
            this.tpCarpetas.Controls.Add(this.CarpertaGen3);
            this.tpCarpetas.Controls.Add(this.pbCarpetaBaseProyecto);
            this.tpCarpetas.Controls.Add(this.CarpetaBaseProyectos);
            this.tpCarpetas.Location = new System.Drawing.Point(4, 22);
            this.tpCarpetas.Name = "tpCarpetas";
            this.tpCarpetas.Padding = new System.Windows.Forms.Padding(3);
            this.tpCarpetas.Size = new System.Drawing.Size(761, 353);
            this.tpCarpetas.TabIndex = 0;
            this.tpCarpetas.Text = "Ubicación-Carpetas";
            this.tpCarpetas.UseVisualStyleBackColor = true;
            // 
            // lblCarpetaGen3
            // 
            this.lblCarpetaGen3.AutoSize = true;
            this.lblCarpetaGen3.Location = new System.Drawing.Point(36, 104);
            this.lblCarpetaGen3.Name = "lblCarpetaGen3";
            this.lblCarpetaGen3.Size = new System.Drawing.Size(73, 13);
            this.lblCarpetaGen3.TabIndex = 15;
            this.lblCarpetaGen3.Text = "Carpeta Gen3";
            // 
            // lblCarpetaBaseProyectos
            // 
            this.lblCarpetaBaseProyectos.AutoSize = true;
            this.lblCarpetaBaseProyectos.Location = new System.Drawing.Point(36, 47);
            this.lblCarpetaBaseProyectos.Name = "lblCarpetaBaseProyectos";
            this.lblCarpetaBaseProyectos.Size = new System.Drawing.Size(121, 13);
            this.lblCarpetaBaseProyectos.TabIndex = 14;
            this.lblCarpetaBaseProyectos.Text = "Carpeta Base Proyectos";
            // 
            // pbCarpetaGen3
            // 
            this.pbCarpetaGen3.BackColor = System.Drawing.Color.LightBlue;
            this.pbCarpetaGen3.Image = ((System.Drawing.Image)(resources.GetObject("pbCarpetaGen3.Image")));
            this.pbCarpetaGen3.Location = new System.Drawing.Point(426, 118);
            this.pbCarpetaGen3.Name = "pbCarpetaGen3";
            this.pbCarpetaGen3.Size = new System.Drawing.Size(34, 25);
            this.pbCarpetaGen3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbCarpetaGen3.TabIndex = 11;
            this.pbCarpetaGen3.TabStop = false;
            this.pbCarpetaGen3.Click += new System.EventHandler(this.PbCarpetaGendocs_Click);
            // 
            // CarpertaGen3
            // 
            this.CarpertaGen3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CarpertaGen3.Location = new System.Drawing.Point(39, 120);
            this.CarpertaGen3.Name = "CarpertaGen3";
            this.CarpertaGen3.Size = new System.Drawing.Size(387, 23);
            this.CarpertaGen3.TabIndex = 10;
            this.CarpertaGen3.Tag = "paramUS010";
            // 
            // pbCarpetaBaseProyecto
            // 
            this.pbCarpetaBaseProyecto.BackColor = System.Drawing.Color.LightBlue;
            this.pbCarpetaBaseProyecto.Image = ((System.Drawing.Image)(resources.GetObject("pbCarpetaBaseProyecto.Image")));
            this.pbCarpetaBaseProyecto.Location = new System.Drawing.Point(426, 61);
            this.pbCarpetaBaseProyecto.Name = "pbCarpetaBaseProyecto";
            this.pbCarpetaBaseProyecto.Size = new System.Drawing.Size(34, 25);
            this.pbCarpetaBaseProyecto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbCarpetaBaseProyecto.TabIndex = 9;
            this.pbCarpetaBaseProyecto.TabStop = false;
            this.pbCarpetaBaseProyecto.Click += new System.EventHandler(this.PbCarpetaBaseProyecto_Click);
            // 
            // CarpetaBaseProyectos
            // 
            this.CarpetaBaseProyectos.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CarpetaBaseProyectos.Location = new System.Drawing.Point(39, 63);
            this.CarpetaBaseProyectos.Name = "CarpetaBaseProyectos";
            this.CarpetaBaseProyectos.Size = new System.Drawing.Size(387, 23);
            this.CarpetaBaseProyectos.TabIndex = 8;
            this.CarpetaBaseProyectos.Tag = "paramUS010";
            // 
            // tpCamposProyecto
            // 
            this.tpCamposProyecto.Location = new System.Drawing.Point(4, 22);
            this.tpCamposProyecto.Name = "tpCamposProyecto";
            this.tpCamposProyecto.Padding = new System.Windows.Forms.Padding(3);
            this.tpCamposProyecto.Size = new System.Drawing.Size(761, 353);
            this.tpCamposProyecto.TabIndex = 1;
            this.tpCamposProyecto.Text = "Campos Proyecto";
            this.tpCamposProyecto.UseVisualStyleBackColor = true;
            // 
            // FrmParametros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 424);
            this.Controls.Add(this.gbParametros);
            this.Name = "FrmParametros";
            this.Text = "Parámetros";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmParametros_FormClosing);
            this.Load += new System.EventHandler(this.FrmParametros_Load);
            this.gbParametros.ResumeLayout(false);
            this.tbParametros.ResumeLayout(false);
            this.tpCarpetas.ResumeLayout(false);
            this.tpCarpetas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarpetaGen3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarpetaBaseProyecto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbParametros;
        private System.Windows.Forms.TabControl tbParametros;
        private System.Windows.Forms.TabPage tpCarpetas;
        private System.Windows.Forms.TabPage tpCamposProyecto;
        private System.Windows.Forms.Label lblCarpetaGen3;
        private System.Windows.Forms.Label lblCarpetaBaseProyectos;
        private System.Windows.Forms.PictureBox pbCarpetaGen3;
        private System.Windows.Forms.TextBox CarpertaGen3;
        private System.Windows.Forms.PictureBox pbCarpetaBaseProyecto;
        private System.Windows.Forms.TextBox CarpetaBaseProyectos;
    }
}