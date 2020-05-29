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
            this.txtNomeclatura = new System.Windows.Forms.TextBox();
            this.pbProgreso = new System.Windows.Forms.ProgressBar();
            this.grbImagenes = new System.Windows.Forms.GroupBox();
            this.lblAlto = new System.Windows.Forms.Label();
            this.lblAncho = new System.Windows.Forms.Label();
            this.lblNomeclatura = new System.Windows.Forms.Label();
            this.lblCarpetaDestino = new System.Windows.Forms.Label();
            this.lblCarpetaOrigen = new System.Windows.Forms.Label();
            this.numAlto = new System.Windows.Forms.NumericUpDown();
            this.numAncho = new System.Windows.Forms.NumericUpDown();
            this.btnCarpetaDestino = new System.Windows.Forms.Button();
            this.btnCarpetaOrigen = new System.Windows.Forms.Button();
            this.btnRedimensionar = new System.Windows.Forms.Button();
            this.grbImagenes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAlto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAncho)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRutaDestino
            // 
            this.txtRutaDestino.Location = new System.Drawing.Point(31, 94);
            this.txtRutaDestino.Name = "txtRutaDestino";
            this.txtRutaDestino.Size = new System.Drawing.Size(374, 23);
            this.txtRutaDestino.TabIndex = 0;
            // 
            // txtRutaOrigen
            // 
            this.txtRutaOrigen.Location = new System.Drawing.Point(31, 44);
            this.txtRutaOrigen.Name = "txtRutaOrigen";
            this.txtRutaOrigen.Size = new System.Drawing.Size(374, 23);
            this.txtRutaOrigen.TabIndex = 0;
            // 
            // txtNomeclatura
            // 
            this.txtNomeclatura.Location = new System.Drawing.Point(31, 140);
            this.txtNomeclatura.Name = "txtNomeclatura";
            this.txtNomeclatura.Size = new System.Drawing.Size(100, 23);
            this.txtNomeclatura.TabIndex = 0;
            this.txtNomeclatura.Text = "_thumb";
            // 
            // pbProgreso
            // 
            this.pbProgreso.Location = new System.Drawing.Point(31, 175);
            this.pbProgreso.Name = "pbProgreso";
            this.pbProgreso.Size = new System.Drawing.Size(413, 23);
            this.pbProgreso.TabIndex = 1;
            // 
            // grbImagenes
            // 
            this.grbImagenes.Controls.Add(this.lblAlto);
            this.grbImagenes.Controls.Add(this.pbProgreso);
            this.grbImagenes.Controls.Add(this.lblAncho);
            this.grbImagenes.Controls.Add(this.lblNomeclatura);
            this.grbImagenes.Controls.Add(this.lblCarpetaDestino);
            this.grbImagenes.Controls.Add(this.lblCarpetaOrigen);
            this.grbImagenes.Controls.Add(this.numAlto);
            this.grbImagenes.Controls.Add(this.numAncho);
            this.grbImagenes.Controls.Add(this.btnCarpetaDestino);
            this.grbImagenes.Controls.Add(this.btnCarpetaOrigen);
            this.grbImagenes.Controls.Add(this.txtRutaDestino);
            this.grbImagenes.Controls.Add(this.txtNomeclatura);
            this.grbImagenes.Controls.Add(this.txtRutaOrigen);
            this.grbImagenes.Location = new System.Drawing.Point(12, 12);
            this.grbImagenes.Name = "grbImagenes";
            this.grbImagenes.Size = new System.Drawing.Size(475, 210);
            this.grbImagenes.TabIndex = 2;
            this.grbImagenes.TabStop = false;
            this.grbImagenes.Text = "Redimensionar Imágenes";
            // 
            // lblAlto
            // 
            this.lblAlto.AutoSize = true;
            this.lblAlto.Location = new System.Drawing.Point(220, 125);
            this.lblAlto.Name = "lblAlto";
            this.lblAlto.Size = new System.Drawing.Size(29, 15);
            this.lblAlto.TabIndex = 3;
            this.lblAlto.Text = "Alto";
            // 
            // lblAncho
            // 
            this.lblAncho.AutoSize = true;
            this.lblAncho.Location = new System.Drawing.Point(137, 126);
            this.lblAncho.Name = "lblAncho";
            this.lblAncho.Size = new System.Drawing.Size(42, 15);
            this.lblAncho.TabIndex = 3;
            this.lblAncho.Text = "Ancho";
            // 
            // lblNomeclatura
            // 
            this.lblNomeclatura.AutoSize = true;
            this.lblNomeclatura.Location = new System.Drawing.Point(31, 123);
            this.lblNomeclatura.Name = "lblNomeclatura";
            this.lblNomeclatura.Size = new System.Drawing.Size(76, 15);
            this.lblNomeclatura.TabIndex = 3;
            this.lblNomeclatura.Text = "Nomeclatura";
            // 
            // lblCarpetaDestino
            // 
            this.lblCarpetaDestino.AutoSize = true;
            this.lblCarpetaDestino.Location = new System.Drawing.Point(31, 76);
            this.lblCarpetaDestino.Name = "lblCarpetaDestino";
            this.lblCarpetaDestino.Size = new System.Drawing.Size(91, 15);
            this.lblCarpetaDestino.TabIndex = 3;
            this.lblCarpetaDestino.Text = "Carpeta Destino";
            // 
            // lblCarpetaOrigen
            // 
            this.lblCarpetaOrigen.AutoSize = true;
            this.lblCarpetaOrigen.Location = new System.Drawing.Point(31, 27);
            this.lblCarpetaOrigen.Name = "lblCarpetaOrigen";
            this.lblCarpetaOrigen.Size = new System.Drawing.Size(87, 15);
            this.lblCarpetaOrigen.TabIndex = 3;
            this.lblCarpetaOrigen.Text = "Carpeta Origen";
            // 
            // numAlto
            // 
            this.numAlto.Location = new System.Drawing.Point(220, 140);
            this.numAlto.Name = "numAlto";
            this.numAlto.Size = new System.Drawing.Size(77, 23);
            this.numAlto.TabIndex = 2;
            this.numAlto.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numAncho
            // 
            this.numAncho.Location = new System.Drawing.Point(137, 141);
            this.numAncho.Name = "numAncho";
            this.numAncho.Size = new System.Drawing.Size(77, 23);
            this.numAncho.TabIndex = 2;
            this.numAncho.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // btnCarpetaDestino
            // 
            this.btnCarpetaDestino.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnCarpetaDestino.Image = ((System.Drawing.Image)(resources.GetObject("btnCarpetaDestino.Image")));
            this.btnCarpetaDestino.Location = new System.Drawing.Point(408, 93);
            this.btnCarpetaDestino.Name = "btnCarpetaDestino";
            this.btnCarpetaDestino.Size = new System.Drawing.Size(36, 24);
            this.btnCarpetaDestino.TabIndex = 1;
            this.btnCarpetaDestino.UseVisualStyleBackColor = false;
            this.btnCarpetaDestino.Click += new System.EventHandler(this.BtnCarpetaDestino_Click);
            // 
            // btnCarpetaOrigen
            // 
            this.btnCarpetaOrigen.BackColor = System.Drawing.Color.White;
            this.btnCarpetaOrigen.Image = ((System.Drawing.Image)(resources.GetObject("btnCarpetaOrigen.Image")));
            this.btnCarpetaOrigen.Location = new System.Drawing.Point(408, 44);
            this.btnCarpetaOrigen.Name = "btnCarpetaOrigen";
            this.btnCarpetaOrigen.Size = new System.Drawing.Size(36, 23);
            this.btnCarpetaOrigen.TabIndex = 1;
            this.btnCarpetaOrigen.UseVisualStyleBackColor = false;
            this.btnCarpetaOrigen.Click += new System.EventHandler(this.BtnCarpetaOrigen_Click);
            // 
            // btnRedimensionar
            // 
            this.btnRedimensionar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRedimensionar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnRedimensionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRedimensionar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRedimensionar.ForeColor = System.Drawing.Color.White;
            this.btnRedimensionar.Location = new System.Drawing.Point(142, 228);
            this.btnRedimensionar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRedimensionar.Name = "btnRedimensionar";
            this.btnRedimensionar.Size = new System.Drawing.Size(212, 36);
            this.btnRedimensionar.TabIndex = 7;
            this.btnRedimensionar.Text = "&Redimensionar";
            this.btnRedimensionar.UseVisualStyleBackColor = false;
            this.btnRedimensionar.Click += new System.EventHandler(this.BtnRedimensionar_Click);
            // 
            // FrmRedimensionarImagenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(496, 270);
            this.Controls.Add(this.btnRedimensionar);
            this.Controls.Add(this.grbImagenes);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRedimensionarImagenes";
            this.Text = "Redimensionar Imágenes";
            this.grbImagenes.ResumeLayout(false);
            this.grbImagenes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAlto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAncho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtRutaDestino;
        private System.Windows.Forms.TextBox txtRutaOrigen;
        private System.Windows.Forms.TextBox txtNomeclatura;
        private System.Windows.Forms.ProgressBar pbProgreso;
        private System.Windows.Forms.GroupBox grbImagenes;
        private System.Windows.Forms.Label lblAlto;
        private System.Windows.Forms.Label lblAncho;
        private System.Windows.Forms.Label lblNomeclatura;
        private System.Windows.Forms.Label lblCarpetaDestino;
        private System.Windows.Forms.Label lblCarpetaOrigen;
        private System.Windows.Forms.NumericUpDown numAlto;
        private System.Windows.Forms.NumericUpDown numAncho;
        private System.Windows.Forms.Button btnCarpetaDestino;
        private System.Windows.Forms.Button btnCarpetaOrigen;
        private System.Windows.Forms.Button btnRedimensionar;
    }
}