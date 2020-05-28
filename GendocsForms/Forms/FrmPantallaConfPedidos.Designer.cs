namespace GendocsForms
{
    partial class FrmConfigPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfigPedido));
            this.pnlCabecera = new System.Windows.Forms.Panel();
            this.pnlLateral = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblTitulo2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTituloFormulario = new System.Windows.Forms.Label();
            this.pnlBotonera = new System.Windows.Forms.Panel();
            this.lstvDisponibles1 = new System.Windows.Forms.ListView();
            this.Id = new System.Windows.Forms.ColumnHeader();
            this.cIdEtiqueta = new System.Windows.Forms.ColumnHeader();
            this.IdEmpleadoFML = new System.Windows.Forms.ColumnHeader();
            this.lstvAsignadas = new System.Windows.Forms.ListView();
            this.IdEtiqueta = new System.Windows.Forms.ColumnHeader();
            this.dEtiquetaFML = new System.Windows.Forms.ColumnHeader();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.pnlLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCabecera
            // 
            this.pnlCabecera.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCabecera.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnlCabecera.Location = new System.Drawing.Point(0, 0);
            this.pnlCabecera.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlCabecera.Name = "pnlCabecera";
            this.pnlCabecera.Size = new System.Drawing.Size(1371, 50);
            this.pnlCabecera.TabIndex = 0;
            // 
            // pnlLateral
            // 
            this.pnlLateral.BackColor = System.Drawing.Color.Gray;
            this.pnlLateral.Controls.Add(this.btnSalir);
            this.pnlLateral.Controls.Add(this.lblTitulo2);
            this.pnlLateral.Controls.Add(this.pictureBox1);
            this.pnlLateral.Controls.Add(this.lblTituloFormulario);
            this.pnlLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLateral.Location = new System.Drawing.Point(0, 0);
            this.pnlLateral.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlLateral.Name = "pnlLateral";
            this.pnlLateral.Size = new System.Drawing.Size(217, 663);
            this.pnlLateral.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(15, 380);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(188, 45);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Tag = "AT";
            this.btnSalir.Text = "&SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.AutoSize = true;
            this.lblTitulo2.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitulo2.Location = new System.Drawing.Point(43, 317);
            this.lblTitulo2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo2.Name = "lblTitulo2";
            this.lblTitulo2.Size = new System.Drawing.Size(107, 22);
            this.lblTitulo2.TabIndex = 10;
            this.lblTitulo2.Text = "PANTALLA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(72, 235);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // lblTituloFormulario
            // 
            this.lblTituloFormulario.AutoSize = true;
            this.lblTituloFormulario.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblTituloFormulario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTituloFormulario.Location = new System.Drawing.Point(5, 288);
            this.lblTituloFormulario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTituloFormulario.Name = "lblTituloFormulario";
            this.lblTituloFormulario.Size = new System.Drawing.Size(177, 22);
            this.lblTituloFormulario.TabIndex = 9;
            this.lblTituloFormulario.Text = "CONFIGURACIÓN";
            // 
            // pnlBotonera
            // 
            this.pnlBotonera.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlBotonera.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotonera.Location = new System.Drawing.Point(217, 588);
            this.pnlBotonera.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlBotonera.Name = "pnlBotonera";
            this.pnlBotonera.Size = new System.Drawing.Size(1154, 75);
            this.pnlBotonera.TabIndex = 2;
            // 
            // lstvDisponibles1
            // 
            this.lstvDisponibles1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.cIdEtiqueta,
            this.IdEmpleadoFML});
            this.lstvDisponibles1.FullRowSelect = true;
            this.lstvDisponibles1.HideSelection = false;
            this.lstvDisponibles1.Location = new System.Drawing.Point(236, 57);
            this.lstvDisponibles1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstvDisponibles1.Name = "lstvDisponibles1";
            this.lstvDisponibles1.Size = new System.Drawing.Size(451, 524);
            this.lstvDisponibles1.TabIndex = 9;
            this.lstvDisponibles1.UseCompatibleStateImageBehavior = false;
            this.lstvDisponibles1.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 0;
            // 
            // cIdEtiqueta
            // 
            this.cIdEtiqueta.DisplayIndex = 2;
            this.cIdEtiqueta.Text = "DISPONIBLES";
            this.cIdEtiqueta.Width = 362;
            // 
            // IdEmpleadoFML
            // 
            this.IdEmpleadoFML.DisplayIndex = 1;
            this.IdEmpleadoFML.Text = "IdEmpleadoFML";
            this.IdEmpleadoFML.Width = 0;
            // 
            // lstvAsignadas
            // 
            this.lstvAsignadas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdEtiqueta,
            this.dEtiquetaFML});
            this.lstvAsignadas.FullRowSelect = true;
            this.lstvAsignadas.HideSelection = false;
            this.lstvAsignadas.Location = new System.Drawing.Point(905, 57);
            this.lstvAsignadas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstvAsignadas.Name = "lstvAsignadas";
            this.lstvAsignadas.Size = new System.Drawing.Size(451, 524);
            this.lstvAsignadas.TabIndex = 6;
            this.lstvAsignadas.UseCompatibleStateImageBehavior = false;
            this.lstvAsignadas.View = System.Windows.Forms.View.Details;
            // 
            // IdEtiqueta
            // 
            this.IdEtiqueta.Text = "IdEtiqueta";
            this.IdEtiqueta.Width = 0;
            // 
            // dEtiquetaFML
            // 
            this.dEtiquetaFML.Text = "ASIGNADAS";
            this.dEtiquetaFML.Width = 362;
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnQuitar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnQuitar.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitar.Image")));
            this.btnQuitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuitar.Location = new System.Drawing.Point(694, 310);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(204, 40);
            this.btnQuitar.TabIndex = 7;
            this.btnQuitar.Text = "QUITAR";
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.BtnAnadir_Click);
            // 
            // btnAñadir
            // 
            this.btnAñadir.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAñadir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAñadir.Image = ((System.Drawing.Image)(resources.GetObject("btnAñadir.Image")));
            this.btnAñadir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAñadir.Location = new System.Drawing.Point(694, 263);
            this.btnAñadir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(204, 40);
            this.btnAñadir.TabIndex = 8;
            this.btnAñadir.Text = "AÑADIR";
            this.btnAñadir.UseVisualStyleBackColor = false;
            this.btnAñadir.Click += new System.EventHandler(this.BtnQuitar_Click);
            // 
            // FrmConfigPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1371, 663);
            this.Controls.Add(this.lstvDisponibles1);
            this.Controls.Add(this.lstvAsignadas);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.pnlBotonera);
            this.Controls.Add(this.pnlLateral);
            this.Controls.Add(this.pnlCabecera);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConfigPedido";
            this.Text = "Configuración Pantalla";
            this.Load += new System.EventHandler(this.FrmPantallaConfPedidos_Load);
            this.pnlLateral.ResumeLayout(false);
            this.pnlLateral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCabecera;
        private System.Windows.Forms.Panel pnlLateral;
        private System.Windows.Forms.Panel pnlBotonera;
        private System.Windows.Forms.ListView lstvDisponibles1;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader cIdEtiqueta;
        private System.Windows.Forms.ColumnHeader IdEmpleadoFML;
        private System.Windows.Forms.ListView lstvAsignadas;
        private System.Windows.Forms.ColumnHeader IdEtiqueta;
        private System.Windows.Forms.ColumnHeader dEtiquetaFML;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblTitulo2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTituloFormulario;
    }
}