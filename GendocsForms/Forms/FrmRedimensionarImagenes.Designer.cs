namespace GendocsForms
{
    partial class FrmRedimensionarImagenes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRedimensionarImagenes));
            this.txtRutaDestino = new System.Windows.Forms.TextBox();
            this.txtRutaOrigen = new System.Windows.Forms.TextBox();
            this.pbProgreso = new System.Windows.Forms.ProgressBar();
            this.grbImagenes = new System.Windows.Forms.GroupBox();
            this.lblCarpetaDestino = new System.Windows.Forms.Label();
            this.lblCarpetaOrigen = new System.Windows.Forms.Label();
            this.btnCarpetaDestino = new System.Windows.Forms.Button();
            this.btnCarpetaOrigen = new System.Windows.Forms.Button();
            this.btnRedimensionar = new System.Windows.Forms.Button();
            this.grbImagenes.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRutaDestino
            // 
            this.txtRutaDestino.Location = new System.Drawing.Point(27, 81);
            this.txtRutaDestino.Name = "txtRutaDestino";
            this.txtRutaDestino.Size = new System.Drawing.Size(321, 20);
            this.txtRutaDestino.TabIndex = 0;
            // 
            // txtRutaOrigen
            // 
            this.txtRutaOrigen.Location = new System.Drawing.Point(27, 38);
            this.txtRutaOrigen.Name = "txtRutaOrigen";
            this.txtRutaOrigen.Size = new System.Drawing.Size(321, 20);
            this.txtRutaOrigen.TabIndex = 0;
            // 
            // pbProgreso
            // 
            this.pbProgreso.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pbProgreso.Location = new System.Drawing.Point(27, 122);
            this.pbProgreso.Name = "pbProgreso";
            this.pbProgreso.Size = new System.Drawing.Size(354, 13);
            this.pbProgreso.TabIndex = 1;
            // 
            // grbImagenes
            // 
            this.grbImagenes.Controls.Add(this.pbProgreso);
            this.grbImagenes.Controls.Add(this.lblCarpetaDestino);
            this.grbImagenes.Controls.Add(this.lblCarpetaOrigen);
            this.grbImagenes.Controls.Add(this.btnCarpetaDestino);
            this.grbImagenes.Controls.Add(this.btnCarpetaOrigen);
            this.grbImagenes.Controls.Add(this.txtRutaDestino);
            this.grbImagenes.Controls.Add(this.txtRutaOrigen);
            this.grbImagenes.Location = new System.Drawing.Point(10, 10);
            this.grbImagenes.Name = "grbImagenes";
            this.grbImagenes.Size = new System.Drawing.Size(407, 145);
            this.grbImagenes.TabIndex = 2;
            this.grbImagenes.TabStop = false;
            this.grbImagenes.Text = "Redimensionar Imágenes";
            // 
            // lblCarpetaDestino
            // 
            this.lblCarpetaDestino.AutoSize = true;
            this.lblCarpetaDestino.Location = new System.Drawing.Point(27, 66);
            this.lblCarpetaDestino.Name = "lblCarpetaDestino";
            this.lblCarpetaDestino.Size = new System.Drawing.Size(83, 13);
            this.lblCarpetaDestino.TabIndex = 3;
            this.lblCarpetaDestino.Text = "Carpeta Destino";
            // 
            // lblCarpetaOrigen
            // 
            this.lblCarpetaOrigen.AutoSize = true;
            this.lblCarpetaOrigen.Location = new System.Drawing.Point(27, 23);
            this.lblCarpetaOrigen.Name = "lblCarpetaOrigen";
            this.lblCarpetaOrigen.Size = new System.Drawing.Size(78, 13);
            this.lblCarpetaOrigen.TabIndex = 3;
            this.lblCarpetaOrigen.Text = "Carpeta Origen";
            // 
            // btnCarpetaDestino
            // 
            this.btnCarpetaDestino.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnCarpetaDestino.Image = ((System.Drawing.Image)(resources.GetObject("btnCarpetaDestino.Image")));
            this.btnCarpetaDestino.Location = new System.Drawing.Point(350, 81);
            this.btnCarpetaDestino.Name = "btnCarpetaDestino";
            this.btnCarpetaDestino.Size = new System.Drawing.Size(31, 21);
            this.btnCarpetaDestino.TabIndex = 1;
            this.btnCarpetaDestino.UseVisualStyleBackColor = false;
            this.btnCarpetaDestino.Click += new System.EventHandler(this.BtnCarpetaDestino_Click);
            // 
            // btnCarpetaOrigen
            // 
            this.btnCarpetaOrigen.BackColor = System.Drawing.Color.White;
            this.btnCarpetaOrigen.Image = ((System.Drawing.Image)(resources.GetObject("btnCarpetaOrigen.Image")));
            this.btnCarpetaOrigen.Location = new System.Drawing.Point(350, 38);
            this.btnCarpetaOrigen.Name = "btnCarpetaOrigen";
            this.btnCarpetaOrigen.Size = new System.Drawing.Size(31, 20);
            this.btnCarpetaOrigen.TabIndex = 1;
            this.btnCarpetaOrigen.UseVisualStyleBackColor = false;
            this.btnCarpetaOrigen.Click += new System.EventHandler(this.BtnCarpetaOrigen_Click);
            // 
            // btnRedimensionar
            // 
            this.btnRedimensionar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRedimensionar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnRedimensionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRedimensionar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnRedimensionar.ForeColor = System.Drawing.Color.White;
            this.btnRedimensionar.Location = new System.Drawing.Point(121, 161);
            this.btnRedimensionar.Name = "btnRedimensionar";
            this.btnRedimensionar.Size = new System.Drawing.Size(182, 31);
            this.btnRedimensionar.TabIndex = 7;
            this.btnRedimensionar.Text = "&Redimensionar";
            this.btnRedimensionar.UseVisualStyleBackColor = false;
            this.btnRedimensionar.Click += new System.EventHandler(this.BtnRedimensionar_Click);
            // 
            // FrmRedimensionarImagenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(425, 199);
            this.Controls.Add(this.btnRedimensionar);
            this.Controls.Add(this.grbImagenes);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRedimensionarImagenes";
            this.Text = "Redimensionar Imágenes";
            this.Load += new System.EventHandler(this.FrmRedimensionarImagenes_Load);
            this.grbImagenes.ResumeLayout(false);
            this.grbImagenes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtRutaDestino;
        private System.Windows.Forms.TextBox txtRutaOrigen;
        private System.Windows.Forms.ProgressBar pbProgreso;
        private System.Windows.Forms.GroupBox grbImagenes;
        private System.Windows.Forms.Label lblCarpetaDestino;
        private System.Windows.Forms.Label lblCarpetaOrigen;
        private System.Windows.Forms.Button btnCarpetaDestino;
        private System.Windows.Forms.Button btnCarpetaOrigen;
        private System.Windows.Forms.Button btnRedimensionar;
    }
}