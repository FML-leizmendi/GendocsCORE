namespace GendocsForms
{
    partial class FrmPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedidos));
            this.pnlCabecera = new System.Windows.Forms.Panel();
            this.pnlLateral = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblTitulo2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTituloFormulario = new System.Windows.Forms.Label();
            this.pnlBotonera = new System.Windows.Forms.Panel();
            this.grbPedidos = new System.Windows.Forms.GroupBox();
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            this.txtIntroduzcaTexto = new System.Windows.Forms.TextBox();
            this.lblTexto = new System.Windows.Forms.Label();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.pnlDatosUsuario = new System.Windows.Forms.Panel();
            this.lblAccesos = new System.Windows.Forms.Label();
            this.cmbAccesos = new System.Windows.Forms.ComboBox();
            this.lblMetaframe = new System.Windows.Forms.Label();
            this.lnklMetaframe = new System.Windows.Forms.LinkLabel();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.cmbUsuarios = new System.Windows.Forms.ComboBox();
            this.lblUsuarios = new System.Windows.Forms.Label();
            this.pnlLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grbPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.pnlDatosUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCabecera
            // 
            this.pnlCabecera.BackColor = System.Drawing.Color.LightBlue;
            this.pnlCabecera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabecera.Location = new System.Drawing.Point(0, 0);
            this.pnlCabecera.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCabecera.Name = "pnlCabecera";
            this.pnlCabecera.Size = new System.Drawing.Size(2458, 100);
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
            this.pnlLateral.Location = new System.Drawing.Point(0, 100);
            this.pnlLateral.Margin = new System.Windows.Forms.Padding(4);
            this.pnlLateral.Name = "pnlLateral";
            this.pnlLateral.Size = new System.Drawing.Size(350, 1151);
            this.pnlLateral.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.LightBlue;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(26, 586);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(6);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(295, 72);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Tag = "AT";
            this.btnSalir.Text = "&SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.AutoSize = true;
            this.lblTitulo2.Font = new System.Drawing.Font("Perpetua Titling MT", 15.85714F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitulo2.Location = new System.Drawing.Point(63, 491);
            this.lblTitulo2.Name = "lblTitulo2";
            this.lblTitulo2.Size = new System.Drawing.Size(234, 44);
            this.lblTitulo2.TabIndex = 2;
            this.lblTitulo2.Text = "ENTRANTES";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(121, 362);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblTituloFormulario
            // 
            this.lblTituloFormulario.AutoSize = true;
            this.lblTituloFormulario.Font = new System.Drawing.Font("Perpetua Titling MT", 15.85714F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloFormulario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTituloFormulario.Location = new System.Drawing.Point(92, 447);
            this.lblTituloFormulario.Name = "lblTituloFormulario";
            this.lblTituloFormulario.Size = new System.Drawing.Size(177, 44);
            this.lblTituloFormulario.TabIndex = 1;
            this.lblTituloFormulario.Text = "PEDIDOS";
            // 
            // pnlBotonera
            // 
            this.pnlBotonera.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBotonera.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotonera.Location = new System.Drawing.Point(350, 1169);
            this.pnlBotonera.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBotonera.Name = "pnlBotonera";
            this.pnlBotonera.Size = new System.Drawing.Size(2108, 82);
            this.pnlBotonera.TabIndex = 4;
            // 
            // grbPedidos
            // 
            this.grbPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbPedidos.Controls.Add(this.btnLimpiarFiltros);
            this.grbPedidos.Controls.Add(this.txtIntroduzcaTexto);
            this.grbPedidos.Controls.Add(this.lblTexto);
            this.grbPedidos.Location = new System.Drawing.Point(358, 226);
            this.grbPedidos.Margin = new System.Windows.Forms.Padding(4);
            this.grbPedidos.Name = "grbPedidos";
            this.grbPedidos.Padding = new System.Windows.Forms.Padding(4);
            this.grbPedidos.Size = new System.Drawing.Size(2087, 135);
            this.grbPedidos.TabIndex = 2;
            this.grbPedidos.TabStop = false;
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.BackColor = System.Drawing.Color.LightBlue;
            this.btnLimpiarFiltros.FlatAppearance.BorderSize = 0;
            this.btnLimpiarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarFiltros.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarFiltros.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiarFiltros.Image")));
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(552, 64);
            this.btnLimpiarFiltros.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnLimpiarFiltros.MaximumSize = new System.Drawing.Size(92, 35);
            this.btnLimpiarFiltros.MinimumSize = new System.Drawing.Size(92, 35);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(92, 35);
            this.btnLimpiarFiltros.TabIndex = 2;
            this.btnLimpiarFiltros.UseVisualStyleBackColor = false;
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.btnLimpiarFiltros_Click);
            // 
            // txtIntroduzcaTexto
            // 
            this.txtIntroduzcaTexto.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtIntroduzcaTexto.Location = new System.Drawing.Point(75, 66);
            this.txtIntroduzcaTexto.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtIntroduzcaTexto.Name = "txtIntroduzcaTexto";
            this.txtIntroduzcaTexto.Size = new System.Drawing.Size(466, 35);
            this.txtIntroduzcaTexto.TabIndex = 1;
            this.txtIntroduzcaTexto.TextChanged += new System.EventHandler(this.txtIntroduzcaTexto_TextChanged);
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.Location = new System.Drawing.Point(83, 33);
            this.lblTexto.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(201, 23);
            this.lblTexto.TabIndex = 0;
            this.lblTexto.Text = "Introduzca un texto";
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.AllowUserToDeleteRows = false;
            this.dgvPedidos.AllowUserToOrderColumns = true;
            this.dgvPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Location = new System.Drawing.Point(358, 371);
            this.dgvPedidos.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.RowHeadersWidth = 72;
            this.dgvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidos.Size = new System.Drawing.Size(2087, 786);
            this.dgvPedidos.TabIndex = 3;
            this.dgvPedidos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedidos_CellContentDoubleClick);
            // 
            // pnlDatosUsuario
            // 
            this.pnlDatosUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDatosUsuario.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlDatosUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDatosUsuario.Controls.Add(this.lblAccesos);
            this.pnlDatosUsuario.Controls.Add(this.cmbAccesos);
            this.pnlDatosUsuario.Controls.Add(this.lblMetaframe);
            this.pnlDatosUsuario.Controls.Add(this.lnklMetaframe);
            this.pnlDatosUsuario.Controls.Add(this.txtContraseña);
            this.pnlDatosUsuario.Controls.Add(this.lblContraseña);
            this.pnlDatosUsuario.Controls.Add(this.txtUsuario);
            this.pnlDatosUsuario.Controls.Add(this.lblUsuario);
            this.pnlDatosUsuario.Controls.Add(this.cmbUsuarios);
            this.pnlDatosUsuario.Controls.Add(this.lblUsuarios);
            this.pnlDatosUsuario.Location = new System.Drawing.Point(358, 108);
            this.pnlDatosUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDatosUsuario.Name = "pnlDatosUsuario";
            this.pnlDatosUsuario.Size = new System.Drawing.Size(2087, 124);
            this.pnlDatosUsuario.TabIndex = 5;
            // 
            // lblAccesos
            // 
            this.lblAccesos.AutoSize = true;
            this.lblAccesos.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccesos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAccesos.Location = new System.Drawing.Point(405, 30);
            this.lblAccesos.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAccesos.Name = "lblAccesos";
            this.lblAccesos.Size = new System.Drawing.Size(93, 23);
            this.lblAccesos.TabIndex = 14;
            this.lblAccesos.Text = "Accesos";
            // 
            // cmbAccesos
            // 
            this.cmbAccesos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccesos.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmbAccesos.FormattingEnabled = true;
            this.cmbAccesos.Location = new System.Drawing.Point(411, 57);
            this.cmbAccesos.Margin = new System.Windows.Forms.Padding(6);
            this.cmbAccesos.Name = "cmbAccesos";
            this.cmbAccesos.Size = new System.Drawing.Size(279, 35);
            this.cmbAccesos.TabIndex = 13;
            this.cmbAccesos.SelectedIndexChanged += new System.EventHandler(this.cmbAccesos_SelectedIndexChanged);
            // 
            // lblMetaframe
            // 
            this.lblMetaframe.AutoSize = true;
            this.lblMetaframe.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetaframe.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMetaframe.Location = new System.Drawing.Point(1322, 18);
            this.lblMetaframe.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMetaframe.Name = "lblMetaframe";
            this.lblMetaframe.Size = new System.Drawing.Size(220, 23);
            this.lblMetaframe.TabIndex = 12;
            this.lblMetaframe.Text = "Acceso a Metaframe";
            // 
            // lnklMetaframe
            // 
            this.lnklMetaframe.AutoSize = true;
            this.lnklMetaframe.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lnklMetaframe.Location = new System.Drawing.Point(1320, 61);
            this.lnklMetaframe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnklMetaframe.Name = "lnklMetaframe";
            this.lnklMetaframe.Size = new System.Drawing.Size(521, 25);
            this.lnklMetaframe.TabIndex = 11;
            this.lnklMetaframe.TabStop = true;
            this.lnklMetaframe.Text = "https://www5.iberdrola.com/logon/LogonPoint/tmindex.html";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtContraseña.Location = new System.Drawing.Point(1009, 57);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(6);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(296, 35);
            this.txtContraseña.TabIndex = 8;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblContraseña.Location = new System.Drawing.Point(1001, 20);
            this.lblContraseña.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(125, 23);
            this.lblContraseña.TabIndex = 7;
            this.lblContraseña.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtUsuario.Location = new System.Drawing.Point(702, 57);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(6);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(296, 35);
            this.txtUsuario.TabIndex = 6;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUsuario.Location = new System.Drawing.Point(697, 26);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(79, 23);
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.Text = "Usuario";
            // 
            // cmbUsuarios
            // 
            this.cmbUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuarios.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmbUsuarios.FormattingEnabled = true;
            this.cmbUsuarios.Location = new System.Drawing.Point(74, 57);
            this.cmbUsuarios.Margin = new System.Windows.Forms.Padding(6);
            this.cmbUsuarios.Name = "cmbUsuarios";
            this.cmbUsuarios.Size = new System.Drawing.Size(325, 35);
            this.cmbUsuarios.TabIndex = 3;
            this.cmbUsuarios.SelectedIndexChanged += new System.EventHandler(this.cmbUsuarios_SelectedIndexChanged);
            // 
            // lblUsuarios
            // 
            this.lblUsuarios.AutoSize = true;
            this.lblUsuarios.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUsuarios.Location = new System.Drawing.Point(64, 30);
            this.lblUsuarios.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(87, 23);
            this.lblUsuarios.TabIndex = 4;
            this.lblUsuarios.Text = "Usuarios";
            // 
            // FrmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(2458, 1251);
            this.Controls.Add(this.pnlDatosUsuario);
            this.Controls.Add(this.dgvPedidos);
            this.Controls.Add(this.grbPedidos);
            this.Controls.Add(this.pnlBotonera);
            this.Controls.Add(this.pnlLateral);
            this.Controls.Add(this.pnlCabecera);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedidos Entrantes";
            this.Load += new System.EventHandler(this.FrmPedidos_Load);
            this.pnlLateral.ResumeLayout(false);
            this.pnlLateral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grbPedidos.ResumeLayout(false);
            this.grbPedidos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.pnlDatosUsuario.ResumeLayout(false);
            this.pnlDatosUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCabecera;
        private System.Windows.Forms.Panel pnlLateral;
        private System.Windows.Forms.Panel pnlBotonera;
        private System.Windows.Forms.GroupBox grbPedidos;
        private System.Windows.Forms.TextBox txtIntroduzcaTexto;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Button btnLimpiarFiltros;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.Label lblTituloFormulario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitulo2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel pnlDatosUsuario;
        private System.Windows.Forms.Label lblAccesos;
        private System.Windows.Forms.ComboBox cmbAccesos;
        private System.Windows.Forms.Label lblMetaframe;
        private System.Windows.Forms.LinkLabel lnklMetaframe;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ComboBox cmbUsuarios;
        private System.Windows.Forms.Label lblUsuarios;
    }
}