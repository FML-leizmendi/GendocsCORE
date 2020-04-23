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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRecursos));
            this.pnlCabercera = new System.Windows.Forms.Panel();
            this.pnlLateral = new System.Windows.Forms.Panel();
            this.flpBotoneraLateral = new System.Windows.Forms.FlowLayoutPanel();
            this.PnlLateralPrincipal = new System.Windows.Forms.Panel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnHabilitarProhibidos = new System.Windows.Forms.Button();
            this.btnEliminarEmpleado = new System.Windows.Forms.Button();
            this.btnProhibidos = new System.Windows.Forms.Button();
            this.pnlLateralSecundario = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            this.grbRecursos = new System.Windows.Forms.GroupBox();
            this.txtIntroduzcaTexto = new System.Windows.Forms.TextBox();
            this.lblTexto = new System.Windows.Forms.Label();
            this.cmbActivos = new System.Windows.Forms.ComboBox();
            this.lblActivo = new System.Windows.Forms.Label();
            this.cmbArea = new System.Windows.Forms.ComboBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.dgvRecursos = new System.Windows.Forms.DataGridView();
            this.pnlBotonera = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnlLateral.SuspendLayout();
            this.flpBotoneraLateral.SuspendLayout();
            this.PnlLateralPrincipal.SuspendLayout();
            this.pnlLateralSecundario.SuspendLayout();
            this.grbRecursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecursos)).BeginInit();
            this.pnlBotonera.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCabercera
            // 
            this.pnlCabercera.BackColor = System.Drawing.Color.LightBlue;
            this.pnlCabercera.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabercera.Location = new System.Drawing.Point(0, 0);
            this.pnlCabercera.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlCabercera.Name = "pnlCabercera";
            this.pnlCabercera.Size = new System.Drawing.Size(1230, 44);
            this.pnlCabercera.TabIndex = 0;
            // 
            // pnlLateral
            // 
            this.pnlLateral.BackColor = System.Drawing.Color.Gray;
            this.pnlLateral.Controls.Add(this.flpBotoneraLateral);
            this.pnlLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLateral.Location = new System.Drawing.Point(0, 44);
            this.pnlLateral.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlLateral.Name = "pnlLateral";
            this.pnlLateral.Size = new System.Drawing.Size(191, 736);
            this.pnlLateral.TabIndex = 1;
            // 
            // flpBotoneraLateral
            // 
            this.flpBotoneraLateral.Controls.Add(this.PnlLateralPrincipal);
            this.flpBotoneraLateral.Controls.Add(this.pnlLateralSecundario);
            this.flpBotoneraLateral.Location = new System.Drawing.Point(6, 197);
            this.flpBotoneraLateral.Margin = new System.Windows.Forms.Padding(2);
            this.flpBotoneraLateral.Name = "flpBotoneraLateral";
            this.flpBotoneraLateral.Size = new System.Drawing.Size(173, 339);
            this.flpBotoneraLateral.TabIndex = 9;
            // 
            // PnlLateralPrincipal
            // 
            this.PnlLateralPrincipal.Controls.Add(this.btnNuevo);
            this.PnlLateralPrincipal.Controls.Add(this.btnModificar);
            this.PnlLateralPrincipal.Controls.Add(this.btnHabilitarProhibidos);
            this.PnlLateralPrincipal.Controls.Add(this.btnEliminarEmpleado);
            this.PnlLateralPrincipal.Controls.Add(this.btnProhibidos);
            this.PnlLateralPrincipal.Location = new System.Drawing.Point(2, 2);
            this.PnlLateralPrincipal.Margin = new System.Windows.Forms.Padding(2);
            this.PnlLateralPrincipal.Name = "PnlLateralPrincipal";
            this.PnlLateralPrincipal.Size = new System.Drawing.Size(167, 230);
            this.PnlLateralPrincipal.TabIndex = 0;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.LightBlue;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(4, 3);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(161, 39);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.LightBlue;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(4, 49);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(161, 39);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnHabilitarProhibidos
            // 
            this.btnHabilitarProhibidos.BackColor = System.Drawing.Color.LightBlue;
            this.btnHabilitarProhibidos.FlatAppearance.BorderSize = 0;
            this.btnHabilitarProhibidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHabilitarProhibidos.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHabilitarProhibidos.Image = ((System.Drawing.Image)(resources.GetObject("btnHabilitarProhibidos.Image")));
            this.btnHabilitarProhibidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHabilitarProhibidos.Location = new System.Drawing.Point(4, 185);
            this.btnHabilitarProhibidos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnHabilitarProhibidos.Name = "btnHabilitarProhibidos";
            this.btnHabilitarProhibidos.Size = new System.Drawing.Size(161, 39);
            this.btnHabilitarProhibidos.TabIndex = 8;
            this.btnHabilitarProhibidos.Text = "      AÑADIR A PROHIBIDOS";
            this.btnHabilitarProhibidos.UseVisualStyleBackColor = false;
            this.btnHabilitarProhibidos.Click += new System.EventHandler(this.btnHabilitarProhibidos_Click);
            // 
            // btnEliminarEmpleado
            // 
            this.btnEliminarEmpleado.BackColor = System.Drawing.Color.LightBlue;
            this.btnEliminarEmpleado.FlatAppearance.BorderSize = 0;
            this.btnEliminarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarEmpleado.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarEmpleado.Image")));
            this.btnEliminarEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarEmpleado.Location = new System.Drawing.Point(4, 94);
            this.btnEliminarEmpleado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            this.btnEliminarEmpleado.Size = new System.Drawing.Size(161, 39);
            this.btnEliminarEmpleado.TabIndex = 5;
            this.btnEliminarEmpleado.Text = "ELIMINAR";
            this.btnEliminarEmpleado.UseVisualStyleBackColor = false;
            this.btnEliminarEmpleado.Click += new System.EventHandler(this.btnEliminarEmpleado_Click);
            // 
            // btnProhibidos
            // 
            this.btnProhibidos.BackColor = System.Drawing.Color.LightBlue;
            this.btnProhibidos.FlatAppearance.BorderSize = 0;
            this.btnProhibidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProhibidos.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProhibidos.Image = ((System.Drawing.Image)(resources.GetObject("btnProhibidos.Image")));
            this.btnProhibidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProhibidos.Location = new System.Drawing.Point(4, 140);
            this.btnProhibidos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnProhibidos.Name = "btnProhibidos";
            this.btnProhibidos.Size = new System.Drawing.Size(161, 39);
            this.btnProhibidos.TabIndex = 7;
            this.btnProhibidos.Text = "    MOSTRAR PROH.";
            this.btnProhibidos.UseVisualStyleBackColor = false;
            this.btnProhibidos.Click += new System.EventHandler(this.btnProhibidos_Click);
            // 
            // pnlLateralSecundario
            // 
            this.pnlLateralSecundario.Controls.Add(this.btnCancelar);
            this.pnlLateralSecundario.Controls.Add(this.btnAceptar);
            this.pnlLateralSecundario.Location = new System.Drawing.Point(2, 236);
            this.pnlLateralSecundario.Margin = new System.Windows.Forms.Padding(2);
            this.pnlLateralSecundario.Name = "pnlLateralSecundario";
            this.pnlLateralSecundario.Size = new System.Drawing.Size(167, 95);
            this.pnlLateralSecundario.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightBlue;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(4, 47);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(161, 39);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.LightBlue;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Location = new System.Drawing.Point(4, 2);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(161, 39);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.BackColor = System.Drawing.Color.LightBlue;
            this.btnLimpiarFiltros.FlatAppearance.BorderSize = 0;
            this.btnLimpiarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarFiltros.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarFiltros.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiarFiltros.Image")));
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(958, 42);
            this.btnLimpiarFiltros.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLimpiarFiltros.MaximumSize = new System.Drawing.Size(50, 19);
            this.btnLimpiarFiltros.MinimumSize = new System.Drawing.Size(50, 19);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(50, 19);
            this.btnLimpiarFiltros.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnLimpiarFiltros, "Eliminar Filtros");
            this.btnLimpiarFiltros.UseVisualStyleBackColor = false;
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.btnLimpiarFiltros_Click);
            // 
            // grbRecursos
            // 
            this.grbRecursos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbRecursos.Controls.Add(this.btnLimpiarFiltros);
            this.grbRecursos.Controls.Add(this.txtIntroduzcaTexto);
            this.grbRecursos.Controls.Add(this.lblTexto);
            this.grbRecursos.Controls.Add(this.cmbActivos);
            this.grbRecursos.Controls.Add(this.lblActivo);
            this.grbRecursos.Controls.Add(this.cmbArea);
            this.grbRecursos.Controls.Add(this.lblArea);
            this.grbRecursos.Controls.Add(this.cmbClientes);
            this.grbRecursos.Controls.Add(this.lblCliente);
            this.grbRecursos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbRecursos.Location = new System.Drawing.Point(198, 56);
            this.grbRecursos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbRecursos.Name = "grbRecursos";
            this.grbRecursos.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbRecursos.Size = new System.Drawing.Size(1028, 75);
            this.grbRecursos.TabIndex = 2;
            this.grbRecursos.TabStop = false;
            this.grbRecursos.Text = "Recursos";
            // 
            // txtIntroduzcaTexto
            // 
            this.txtIntroduzcaTexto.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtIntroduzcaTexto.Location = new System.Drawing.Point(6, 42);
            this.txtIntroduzcaTexto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtIntroduzcaTexto.Name = "txtIntroduzcaTexto";
            this.txtIntroduzcaTexto.Size = new System.Drawing.Size(256, 23);
            this.txtIntroduzcaTexto.TabIndex = 7;
            this.txtIntroduzcaTexto.TextChanged += new System.EventHandler(this.txtIntroduzcaTexto_TextChanged);
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.Location = new System.Drawing.Point(10, 24);
            this.lblTexto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(115, 16);
            this.lblTexto.TabIndex = 6;
            this.lblTexto.Text = "Introduzca un texto";
            // 
            // cmbActivos
            // 
            this.cmbActivos.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmbActivos.FormattingEnabled = true;
            this.cmbActivos.Location = new System.Drawing.Point(683, 42);
            this.cmbActivos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbActivos.Name = "cmbActivos";
            this.cmbActivos.Size = new System.Drawing.Size(274, 25);
            this.cmbActivos.TabIndex = 5;
            this.cmbActivos.SelectedIndexChanged += new System.EventHandler(this.cmbActivos_SelectedIndexChanged);
            // 
            // lblActivo
            // 
            this.lblActivo.AutoSize = true;
            this.lblActivo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivo.Location = new System.Drawing.Point(680, 27);
            this.lblActivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActivo.Name = "lblActivo";
            this.lblActivo.Size = new System.Drawing.Size(43, 16);
            this.lblActivo.TabIndex = 4;
            this.lblActivo.Text = "Activo";
            // 
            // cmbArea
            // 
            this.cmbArea.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Location = new System.Drawing.Point(434, 42);
            this.cmbArea.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(245, 25);
            this.cmbArea.TabIndex = 3;
            this.cmbArea.SelectedIndexChanged += new System.EventHandler(this.cmbArea_SelectedIndexChanged);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(432, 27);
            this.lblArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(33, 16);
            this.lblArea.TabIndex = 2;
            this.lblArea.Text = "Área";
            // 
            // cmbClientes
            // 
            this.cmbClientes.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(266, 42);
            this.cmbClientes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(165, 25);
            this.cmbClientes.TabIndex = 1;
            this.cmbClientes.SelectedIndexChanged += new System.EventHandler(this.cmbClientes_SelectedIndexChanged);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(268, 27);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(46, 16);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente";
            // 
            // dgvRecursos
            // 
            this.dgvRecursos.AllowUserToAddRows = false;
            this.dgvRecursos.AllowUserToDeleteRows = false;
            this.dgvRecursos.AllowUserToOrderColumns = true;
            this.dgvRecursos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRecursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecursos.Location = new System.Drawing.Point(198, 136);
            this.dgvRecursos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvRecursos.Name = "dgvRecursos";
            this.dgvRecursos.ReadOnly = true;
            this.dgvRecursos.RowHeadersWidth = 72;
            this.dgvRecursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecursos.Size = new System.Drawing.Size(1028, 586);
            this.dgvRecursos.TabIndex = 3;
            // 
            // pnlBotonera
            // 
            this.pnlBotonera.Controls.Add(this.flowLayoutPanel1);
            this.pnlBotonera.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotonera.Location = new System.Drawing.Point(191, 728);
            this.pnlBotonera.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlBotonera.Name = "pnlBotonera";
            this.pnlBotonera.Size = new System.Drawing.Size(1039, 52);
            this.pnlBotonera.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(8, 7);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1022, 42);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-ocultar-32.png");
            this.imageList1.Images.SetKeyName(1, "icons8-visible-32.png");
            // 
            // FrmRecursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1230, 780);
            this.Controls.Add(this.pnlBotonera);
            this.Controls.Add(this.dgvRecursos);
            this.Controls.Add(this.grbRecursos);
            this.Controls.Add(this.pnlLateral);
            this.Controls.Add(this.pnlCabercera);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmRecursos";
            this.Text = "Recursos";
            this.Load += new System.EventHandler(this.FrmRecursos_Load);
            this.pnlLateral.ResumeLayout(false);
            this.flpBotoneraLateral.ResumeLayout(false);
            this.PnlLateralPrincipal.ResumeLayout(false);
            this.pnlLateralSecundario.ResumeLayout(false);
            this.grbRecursos.ResumeLayout(false);
            this.grbRecursos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecursos)).EndInit();
            this.pnlBotonera.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCabercera;
        private System.Windows.Forms.Panel pnlLateral;
        private System.Windows.Forms.GroupBox grbRecursos;
        private System.Windows.Forms.DataGridView dgvRecursos;
        private System.Windows.Forms.ComboBox cmbActivos;
        private System.Windows.Forms.Label lblActivo;
        private System.Windows.Forms.ComboBox cmbArea;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Panel pnlBotonera;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEliminarEmpleado;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtIntroduzcaTexto;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Button btnLimpiarFiltros;
        private System.Windows.Forms.Button btnProhibidos;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnHabilitarProhibidos;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.FlowLayoutPanel flpBotoneraLateral;
        private System.Windows.Forms.Panel PnlLateralPrincipal;
        private System.Windows.Forms.Panel pnlLateralSecundario;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
    }
}