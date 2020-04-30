namespace GendocsForms
{
    partial class FrmListaProyectos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListaProyectos));
            this.pnlLateral = new System.Windows.Forms.Panel();
            this.btnTodos = new System.Windows.Forms.Button();
            this.btnOtros = new System.Windows.Forms.Button();
            this.btnCartografia = new System.Windows.Forms.Button();
            this.btnBajaTension = new System.Windows.Forms.Button();
            this.btnMediaTension = new System.Windows.Forms.Button();
            this.btnAT = new System.Windows.Forms.Button();
            this.pnlCabercera = new System.Windows.Forms.Panel();
            this.grbProyectos = new System.Windows.Forms.GroupBox();
            this.txtCodProyecto = new System.Windows.Forms.TextBox();
            this.lblCodProyecto = new System.Windows.Forms.Label();
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            this.cmbEstadoProyecto = new System.Windows.Forms.ComboBox();
            this.lblEstadoProyecto = new System.Windows.Forms.Label();
            this.txtIntroduzcaTexto = new System.Windows.Forms.TextBox();
            this.lblTexto = new System.Windows.Forms.Label();
            this.dgvProyectos = new System.Windows.Forms.DataGridView();
            this.pnlBotonera = new System.Windows.Forms.Panel();
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
            this.grbProyectos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProyectos)).BeginInit();
            this.pnlDatosUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLateral
            // 
            this.pnlLateral.BackColor = System.Drawing.Color.Gray;
            this.pnlLateral.Controls.Add(this.btnTodos);
            this.pnlLateral.Controls.Add(this.btnOtros);
            this.pnlLateral.Controls.Add(this.btnCartografia);
            this.pnlLateral.Controls.Add(this.btnBajaTension);
            this.pnlLateral.Controls.Add(this.btnMediaTension);
            this.pnlLateral.Controls.Add(this.btnAT);
            this.pnlLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLateral.Location = new System.Drawing.Point(0, 0);
            this.pnlLateral.Name = "pnlLateral";
            this.pnlLateral.Size = new System.Drawing.Size(205, 775);
            this.pnlLateral.TabIndex = 0;
            // 
            // btnTodos
            // 
            this.btnTodos.BackColor = System.Drawing.Color.Yellow;
            this.btnTodos.FlatAppearance.BorderSize = 0;
            this.btnTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodos.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodos.Location = new System.Drawing.Point(18, 312);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(161, 39);
            this.btnTodos.TabIndex = 0;
            this.btnTodos.Tag = "Td";
            this.btnTodos.Text = "TODOS";
            this.btnTodos.UseVisualStyleBackColor = false;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // btnOtros
            // 
            this.btnOtros.BackColor = System.Drawing.Color.LightBlue;
            this.btnOtros.FlatAppearance.BorderSize = 0;
            this.btnOtros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOtros.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtros.Location = new System.Drawing.Point(18, 562);
            this.btnOtros.Name = "btnOtros";
            this.btnOtros.Size = new System.Drawing.Size(161, 39);
            this.btnOtros.TabIndex = 5;
            this.btnOtros.Tag = "Ot";
            this.btnOtros.Text = "OTROS";
            this.btnOtros.UseVisualStyleBackColor = false;
            this.btnOtros.Click += new System.EventHandler(this.btnOtros_Click);
            // 
            // btnCartografia
            // 
            this.btnCartografia.BackColor = System.Drawing.Color.LightBlue;
            this.btnCartografia.FlatAppearance.BorderSize = 0;
            this.btnCartografia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCartografia.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCartografia.Image = ((System.Drawing.Image)(resources.GetObject("btnCartografia.Image")));
            this.btnCartografia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCartografia.Location = new System.Drawing.Point(18, 511);
            this.btnCartografia.Name = "btnCartografia";
            this.btnCartografia.Size = new System.Drawing.Size(161, 39);
            this.btnCartografia.TabIndex = 4;
            this.btnCartografia.Tag = "Ca";
            this.btnCartografia.Text = "CARTROGRAFÍA";
            this.btnCartografia.UseVisualStyleBackColor = false;
            this.btnCartografia.Click += new System.EventHandler(this.btnCartografia_Click);
            // 
            // btnBajaTension
            // 
            this.btnBajaTension.BackColor = System.Drawing.Color.LightBlue;
            this.btnBajaTension.FlatAppearance.BorderSize = 0;
            this.btnBajaTension.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBajaTension.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBajaTension.Image = ((System.Drawing.Image)(resources.GetObject("btnBajaTension.Image")));
            this.btnBajaTension.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBajaTension.Location = new System.Drawing.Point(18, 462);
            this.btnBajaTension.Name = "btnBajaTension";
            this.btnBajaTension.Size = new System.Drawing.Size(161, 39);
            this.btnBajaTension.TabIndex = 3;
            this.btnBajaTension.Tag = "BT";
            this.btnBajaTension.Text = "BAJA TENSIÓN";
            this.btnBajaTension.UseVisualStyleBackColor = false;
            this.btnBajaTension.Click += new System.EventHandler(this.btnBajaTension_Click);
            // 
            // btnMediaTension
            // 
            this.btnMediaTension.BackColor = System.Drawing.Color.LightBlue;
            this.btnMediaTension.FlatAppearance.BorderSize = 0;
            this.btnMediaTension.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMediaTension.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMediaTension.Image = ((System.Drawing.Image)(resources.GetObject("btnMediaTension.Image")));
            this.btnMediaTension.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMediaTension.Location = new System.Drawing.Point(18, 411);
            this.btnMediaTension.Name = "btnMediaTension";
            this.btnMediaTension.Size = new System.Drawing.Size(161, 39);
            this.btnMediaTension.TabIndex = 2;
            this.btnMediaTension.Tag = "MT";
            this.btnMediaTension.Text = "MEDIA TENSIÓN";
            this.btnMediaTension.UseVisualStyleBackColor = false;
            this.btnMediaTension.Click += new System.EventHandler(this.btnMediaTension_Click);
            // 
            // btnAT
            // 
            this.btnAT.BackColor = System.Drawing.Color.LightBlue;
            this.btnAT.FlatAppearance.BorderSize = 0;
            this.btnAT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAT.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAT.Image = ((System.Drawing.Image)(resources.GetObject("btnAT.Image")));
            this.btnAT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAT.Location = new System.Drawing.Point(18, 360);
            this.btnAT.Name = "btnAT";
            this.btnAT.Size = new System.Drawing.Size(161, 39);
            this.btnAT.TabIndex = 1;
            this.btnAT.Tag = "AT";
            this.btnAT.Text = "ALTA TENSIÓN";
            this.btnAT.UseVisualStyleBackColor = false;
            this.btnAT.Click += new System.EventHandler(this.btnAT_Click);
            // 
            // pnlCabercera
            // 
            this.pnlCabercera.BackColor = System.Drawing.Color.LightBlue;
            this.pnlCabercera.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabercera.Location = new System.Drawing.Point(205, 0);
            this.pnlCabercera.Name = "pnlCabercera";
            this.pnlCabercera.Size = new System.Drawing.Size(1173, 46);
            this.pnlCabercera.TabIndex = 0;
            // 
            // grbProyectos
            // 
            this.grbProyectos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbProyectos.Controls.Add(this.txtCodProyecto);
            this.grbProyectos.Controls.Add(this.lblCodProyecto);
            this.grbProyectos.Controls.Add(this.btnLimpiarFiltros);
            this.grbProyectos.Controls.Add(this.cmbEstadoProyecto);
            this.grbProyectos.Controls.Add(this.lblEstadoProyecto);
            this.grbProyectos.Controls.Add(this.txtIntroduzcaTexto);
            this.grbProyectos.Controls.Add(this.lblTexto);
            this.grbProyectos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbProyectos.Location = new System.Drawing.Point(209, 120);
            this.grbProyectos.Name = "grbProyectos";
            this.grbProyectos.Size = new System.Drawing.Size(1160, 68);
            this.grbProyectos.TabIndex = 2;
            this.grbProyectos.TabStop = false;
            this.grbProyectos.Text = "Proyectos";
            // 
            // txtCodProyecto
            // 
            this.txtCodProyecto.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCodProyecto.Location = new System.Drawing.Point(58, 43);
            this.txtCodProyecto.Name = "txtCodProyecto";
            this.txtCodProyecto.Size = new System.Drawing.Size(179, 23);
            this.txtCodProyecto.TabIndex = 5;
            // 
            // lblCodProyecto
            // 
            this.lblCodProyecto.AutoSize = true;
            this.lblCodProyecto.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodProyecto.Location = new System.Drawing.Point(56, 25);
            this.lblCodProyecto.Name = "lblCodProyecto";
            this.lblCodProyecto.Size = new System.Drawing.Size(99, 16);
            this.lblCodProyecto.TabIndex = 4;
            this.lblCodProyecto.Text = "Código Proyecto";
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.BackColor = System.Drawing.Color.LightBlue;
            this.btnLimpiarFiltros.FlatAppearance.BorderSize = 0;
            this.btnLimpiarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarFiltros.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarFiltros.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiarFiltros.Image")));
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(734, 42);
            this.btnLimpiarFiltros.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLimpiarFiltros.MaximumSize = new System.Drawing.Size(50, 19);
            this.btnLimpiarFiltros.MinimumSize = new System.Drawing.Size(50, 19);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(50, 19);
            this.btnLimpiarFiltros.TabIndex = 3;
            this.btnLimpiarFiltros.UseVisualStyleBackColor = false;
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.btnLimpiarFiltros_Click);
            // 
            // cmbEstadoProyecto
            // 
            this.cmbEstadoProyecto.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmbEstadoProyecto.FormattingEnabled = true;
            this.cmbEstadoProyecto.Location = new System.Drawing.Point(567, 43);
            this.cmbEstadoProyecto.Name = "cmbEstadoProyecto";
            this.cmbEstadoProyecto.Size = new System.Drawing.Size(163, 25);
            this.cmbEstadoProyecto.TabIndex = 2;
            this.cmbEstadoProyecto.SelectedIndexChanged += new System.EventHandler(this.cmbEstadoProyecto_SelectedIndexChanged);
            // 
            // lblEstadoProyecto
            // 
            this.lblEstadoProyecto.AutoSize = true;
            this.lblEstadoProyecto.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoProyecto.Location = new System.Drawing.Point(565, 27);
            this.lblEstadoProyecto.Name = "lblEstadoProyecto";
            this.lblEstadoProyecto.Size = new System.Drawing.Size(116, 16);
            this.lblEstadoProyecto.TabIndex = 2;
            this.lblEstadoProyecto.Text = "Estado del Proyecto";
            // 
            // txtIntroduzcaTexto
            // 
            this.txtIntroduzcaTexto.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtIntroduzcaTexto.Location = new System.Drawing.Point(241, 43);
            this.txtIntroduzcaTexto.Name = "txtIntroduzcaTexto";
            this.txtIntroduzcaTexto.Size = new System.Drawing.Size(323, 23);
            this.txtIntroduzcaTexto.TabIndex = 1;
            this.txtIntroduzcaTexto.TextChanged += new System.EventHandler(this.txtIntroduzcaTexto_TextChanged);
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.Location = new System.Drawing.Point(239, 27);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(115, 16);
            this.lblTexto.TabIndex = 0;
            this.lblTexto.Text = "Introduzca un texto";
            // 
            // dgvProyectos
            // 
            this.dgvProyectos.AllowUserToAddRows = false;
            this.dgvProyectos.AllowUserToDeleteRows = false;
            this.dgvProyectos.AllowUserToOrderColumns = true;
            this.dgvProyectos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProyectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProyectos.Location = new System.Drawing.Point(211, 196);
            this.dgvProyectos.Name = "dgvProyectos";
            this.dgvProyectos.RowHeadersWidth = 82;
            this.dgvProyectos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProyectos.Size = new System.Drawing.Size(1159, 567);
            this.dgvProyectos.TabIndex = 3;
            this.dgvProyectos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProyectos_CellContentDoubleClick);
            this.dgvProyectos.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProyectos_ColumnHeaderMouseClick);
            this.dgvProyectos.CurrentCellChanged += new System.EventHandler(this.dgvProyectos_CurrentCellChanged);
            // 
            // pnlBotonera
            // 
            this.pnlBotonera.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBotonera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBotonera.Location = new System.Drawing.Point(211, 797);
            this.pnlBotonera.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlBotonera.Name = "pnlBotonera";
            this.pnlBotonera.Size = new System.Drawing.Size(1159, 53);
            this.pnlBotonera.TabIndex = 4;
            // 
            // pnlDatosUsuario
            // 
            this.pnlDatosUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDatosUsuario.BackColor = System.Drawing.Color.CadetBlue;
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
            this.pnlDatosUsuario.Location = new System.Drawing.Point(209, 51);
            this.pnlDatosUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlDatosUsuario.Name = "pnlDatosUsuario";
            this.pnlDatosUsuario.Size = new System.Drawing.Size(1161, 68);
            this.pnlDatosUsuario.TabIndex = 4;
            // 
            // lblAccesos
            // 
            this.lblAccesos.AutoSize = true;
            this.lblAccesos.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccesos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAccesos.Location = new System.Drawing.Point(238, 16);
            this.lblAccesos.Name = "lblAccesos";
            this.lblAccesos.Size = new System.Drawing.Size(51, 16);
            this.lblAccesos.TabIndex = 14;
            this.lblAccesos.Text = "Accesos";
            // 
            // cmbAccesos
            // 
            this.cmbAccesos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccesos.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmbAccesos.FormattingEnabled = true;
            this.cmbAccesos.Location = new System.Drawing.Point(241, 31);
            this.cmbAccesos.Name = "cmbAccesos";
            this.cmbAccesos.Size = new System.Drawing.Size(154, 25);
            this.cmbAccesos.TabIndex = 13;
            this.cmbAccesos.SelectedIndexChanged += new System.EventHandler(this.cmbAccesos_SelectedIndexChanged);
            // 
            // lblMetaframe
            // 
            this.lblMetaframe.AutoSize = true;
            this.lblMetaframe.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetaframe.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMetaframe.Location = new System.Drawing.Point(738, 10);
            this.lblMetaframe.Name = "lblMetaframe";
            this.lblMetaframe.Size = new System.Drawing.Size(122, 16);
            this.lblMetaframe.TabIndex = 12;
            this.lblMetaframe.Text = "Acceso a Metaframe";
            // 
            // lnklMetaframe
            // 
            this.lnklMetaframe.AutoSize = true;
            this.lnklMetaframe.Location = new System.Drawing.Point(737, 33);
            this.lnklMetaframe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnklMetaframe.Name = "lnklMetaframe";
            this.lnklMetaframe.Size = new System.Drawing.Size(292, 13);
            this.lnklMetaframe.TabIndex = 11;
            this.lnklMetaframe.TabStop = true;
            this.lnklMetaframe.Text = "https://www5.iberdrola.com/logon/LogonPoint/tmindex.html";
            this.lnklMetaframe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklMetaframe_LinkClicked);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtContraseña.Location = new System.Drawing.Point(567, 31);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(163, 23);
            this.txtContraseña.TabIndex = 8;
            this.txtContraseña.Click += new System.EventHandler(this.txtContraseña_Click);
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblContraseña.Location = new System.Drawing.Point(563, 11);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(72, 16);
            this.lblContraseña.TabIndex = 7;
            this.lblContraseña.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtUsuario.Location = new System.Drawing.Point(400, 31);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(163, 23);
            this.txtUsuario.TabIndex = 6;
            this.txtUsuario.Click += new System.EventHandler(this.txtUsuario_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUsuario.Location = new System.Drawing.Point(397, 14);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(47, 16);
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.Text = "Usuario";
            // 
            // cmbUsuarios
            // 
            this.cmbUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuarios.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmbUsuarios.FormattingEnabled = true;
            this.cmbUsuarios.Location = new System.Drawing.Point(57, 31);
            this.cmbUsuarios.Name = "cmbUsuarios";
            this.cmbUsuarios.Size = new System.Drawing.Size(179, 25);
            this.cmbUsuarios.TabIndex = 3;
            this.cmbUsuarios.SelectedIndexChanged += new System.EventHandler(this.cmbUsuarios_SelectedIndexChanged);
            // 
            // lblUsuarios
            // 
            this.lblUsuarios.AutoSize = true;
            this.lblUsuarios.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUsuarios.Location = new System.Drawing.Point(52, 16);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(51, 16);
            this.lblUsuarios.TabIndex = 4;
            this.lblUsuarios.Text = "Usuarios";
            // 
            // FrmListaProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1378, 775);
            this.Controls.Add(this.pnlBotonera);
            this.Controls.Add(this.pnlDatosUsuario);
            this.Controls.Add(this.dgvProyectos);
            this.Controls.Add(this.grbProyectos);
            this.Controls.Add(this.pnlCabercera);
            this.Controls.Add(this.pnlLateral);
            this.Name = "FrmListaProyectos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Proyectos";
            this.Load += new System.EventHandler(this.FrmListaProyectos_Load);
            this.pnlLateral.ResumeLayout(false);
            this.grbProyectos.ResumeLayout(false);
            this.grbProyectos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProyectos)).EndInit();
            this.pnlDatosUsuario.ResumeLayout(false);
            this.pnlDatosUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLateral;
        private System.Windows.Forms.Panel pnlCabercera;
        private System.Windows.Forms.Button btnOtros;
        private System.Windows.Forms.Button btnCartografia;
        private System.Windows.Forms.Button btnBajaTension;
        private System.Windows.Forms.Button btnMediaTension;
        private System.Windows.Forms.Button btnAT;
        private System.Windows.Forms.GroupBox grbProyectos;
        private System.Windows.Forms.ComboBox cmbEstadoProyecto;
        private System.Windows.Forms.Label lblEstadoProyecto;
        private System.Windows.Forms.TextBox txtIntroduzcaTexto;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.DataGridView dgvProyectos;
        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.Panel pnlBotonera;
        private System.Windows.Forms.Button btnLimpiarFiltros;
        private System.Windows.Forms.Panel pnlDatosUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ComboBox cmbUsuarios;
        private System.Windows.Forms.Label lblUsuarios;
        private System.Windows.Forms.Label lblMetaframe;
        private System.Windows.Forms.LinkLabel lnklMetaframe;
        private System.Windows.Forms.TextBox txtCodProyecto;
        private System.Windows.Forms.Label lblCodProyecto;
        private System.Windows.Forms.Label lblAccesos;
        private System.Windows.Forms.ComboBox cmbAccesos;
    }
}