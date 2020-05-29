namespace GendocsForms
{
    partial class FrmMantenimientoEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMantenimientoEmpleados));
            this.pnlCabecera = new System.Windows.Forms.Panel();
            this.grbEmpleadoFML = new System.Windows.Forms.GroupBox();
            this.lblJefe = new System.Windows.Forms.Label();
            this.cmbJefes = new System.Windows.Forms.ComboBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.btnEtiquetas = new System.Windows.Forms.Button();
            this.txtIdEmpleado = new System.Windows.Forms.TextBox();
            this.txtEtiquetas = new System.Windows.Forms.TextBox();
            this.lblEtiquetas = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pnlBotonera = new System.Windows.Forms.Panel();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.flpBotonera = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grbEmpleadoFML.SuspendLayout();
            this.pnlBotonera.SuspendLayout();
            this.flpBotonera.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCabecera
            // 
            this.pnlCabecera.BackColor = System.Drawing.Color.LightBlue;
            this.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabecera.Location = new System.Drawing.Point(0, 0);
            this.pnlCabecera.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlCabecera.Name = "pnlCabecera";
            this.pnlCabecera.Size = new System.Drawing.Size(1161, 46);
            this.pnlCabecera.TabIndex = 0;
            // 
            // grbEmpleadoFML
            // 
            this.grbEmpleadoFML.Controls.Add(this.lblJefe);
            this.grbEmpleadoFML.Controls.Add(this.cmbJefes);
            this.grbEmpleadoFML.Controls.Add(this.lblCargo);
            this.grbEmpleadoFML.Controls.Add(this.lblCliente);
            this.grbEmpleadoFML.Controls.Add(this.cmbClientes);
            this.grbEmpleadoFML.Controls.Add(this.cmbCargo);
            this.grbEmpleadoFML.Controls.Add(this.btnEtiquetas);
            this.grbEmpleadoFML.Controls.Add(this.txtIdEmpleado);
            this.grbEmpleadoFML.Controls.Add(this.txtEtiquetas);
            this.grbEmpleadoFML.Controls.Add(this.lblEtiquetas);
            this.grbEmpleadoFML.Controls.Add(this.txtEmail);
            this.grbEmpleadoFML.Controls.Add(this.lblEmail);
            this.grbEmpleadoFML.Controls.Add(this.txtTelefono);
            this.grbEmpleadoFML.Controls.Add(this.lblTelefono);
            this.grbEmpleadoFML.Controls.Add(this.txtNombre);
            this.grbEmpleadoFML.Controls.Add(this.lblNombre);
            this.grbEmpleadoFML.Location = new System.Drawing.Point(5, 50);
            this.grbEmpleadoFML.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbEmpleadoFML.Name = "grbEmpleadoFML";
            this.grbEmpleadoFML.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbEmpleadoFML.Size = new System.Drawing.Size(1148, 223);
            this.grbEmpleadoFML.TabIndex = 1;
            this.grbEmpleadoFML.TabStop = false;
            this.grbEmpleadoFML.Text = "Empleado Seleccionado";
            // 
            // lblJefe
            // 
            this.lblJefe.AutoSize = true;
            this.lblJefe.Location = new System.Drawing.Point(645, 93);
            this.lblJefe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJefe.Name = "lblJefe";
            this.lblJefe.Size = new System.Drawing.Size(29, 15);
            this.lblJefe.TabIndex = 14;
            this.lblJefe.Text = "JEFE";
            // 
            // cmbJefes
            // 
            this.cmbJefes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbJefes.FormattingEnabled = true;
            this.cmbJefes.Location = new System.Drawing.Point(649, 112);
            this.cmbJefes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbJefes.Name = "cmbJefes";
            this.cmbJefes.Size = new System.Drawing.Size(330, 25);
            this.cmbJefes.TabIndex = 15;
            this.cmbJefes.SelectedIndexChanged += new System.EventHandler(this.CmbJefes_SelectedIndexChanged);
            this.cmbJefes.Leave += new System.EventHandler(this.CmbJefes_Leave);
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(335, 92);
            this.lblCargo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(47, 15);
            this.lblCargo.TabIndex = 7;
            this.lblCargo.Text = "CARGO";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(100, 92);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(51, 15);
            this.lblCliente.TabIndex = 5;
            this.lblCliente.Text = "CLIENTE";
            // 
            // cmbClientes
            // 
            this.cmbClientes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(97, 112);
            this.cmbClientes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(230, 25);
            this.cmbClientes.TabIndex = 6;
            this.cmbClientes.SelectedIndexChanged += new System.EventHandler(this.CmbClientes_SelectedIndexChanged);
            this.cmbClientes.Leave += new System.EventHandler(this.CmbClientes_Leave);
            // 
            // cmbCargo
            // 
            this.cmbCargo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.Location = new System.Drawing.Point(332, 112);
            this.cmbCargo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(308, 25);
            this.cmbCargo.TabIndex = 8;
            this.cmbCargo.SelectedIndexChanged += new System.EventHandler(this.CmbCargo_SelectedIndexChanged);
            this.cmbCargo.Leave += new System.EventHandler(this.CmbCargo_Leave);
            // 
            // btnEtiquetas
            // 
            this.btnEtiquetas.Image = ((System.Drawing.Image)(resources.GetObject("btnEtiquetas.Image")));
            this.btnEtiquetas.Location = new System.Drawing.Point(978, 171);
            this.btnEtiquetas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEtiquetas.Name = "btnEtiquetas";
            this.btnEtiquetas.Size = new System.Drawing.Size(43, 25);
            this.btnEtiquetas.TabIndex = 13;
            this.btnEtiquetas.UseVisualStyleBackColor = true;
            this.btnEtiquetas.Click += new System.EventHandler(this.BtnEtiquetas_Click);
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.Location = new System.Drawing.Point(54, 59);
            this.txtIdEmpleado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.Size = new System.Drawing.Size(33, 23);
            this.txtIdEmpleado.TabIndex = 0;
            this.txtIdEmpleado.Visible = false;
            // 
            // txtEtiquetas
            // 
            this.txtEtiquetas.Enabled = false;
            this.txtEtiquetas.Location = new System.Drawing.Point(469, 172);
            this.txtEtiquetas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEtiquetas.Name = "txtEtiquetas";
            this.txtEtiquetas.Size = new System.Drawing.Size(509, 23);
            this.txtEtiquetas.TabIndex = 12;
            this.txtEtiquetas.TextChanged += new System.EventHandler(this.TxtEtiquetas_TextChanged);
            this.txtEtiquetas.Leave += new System.EventHandler(this.TxtEtiquetas_Leave);
            // 
            // lblEtiquetas
            // 
            this.lblEtiquetas.AutoSize = true;
            this.lblEtiquetas.Location = new System.Drawing.Point(465, 152);
            this.lblEtiquetas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEtiquetas.Name = "lblEtiquetas";
            this.lblEtiquetas.Size = new System.Drawing.Size(64, 15);
            this.lblEtiquetas.TabIndex = 11;
            this.lblEtiquetas.Text = "ETIQUETAS";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(97, 172);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(364, 23);
            this.txtEmail.TabIndex = 10;
            this.txtEmail.TextChanged += new System.EventHandler(this.TxtEmail_TextChanged);
            this.txtEmail.Leave += new System.EventHandler(this.TxtEmail_Leave);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(93, 153);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 15);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "EMAIL";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(614, 59);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(364, 23);
            this.txtTelefono.TabIndex = 4;
            this.txtTelefono.TextChanged += new System.EventHandler(this.TxtTelefono_TextChanged);
            this.txtTelefono.Leave += new System.EventHandler(this.TxtTelefono_Leave);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(608, 39);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(64, 15);
            this.lblTelefono.TabIndex = 3;
            this.lblTelefono.Text = "TELÉFONO";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(97, 59);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(507, 23);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged);
            this.txtNombre.Leave += new System.EventHandler(this.TxtNombre_Leave);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(91, 39);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 15);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "NOMBRE";
            // 
            // pnlBotonera
            // 
            this.pnlBotonera.Controls.Add(this.btnUltimo);
            this.pnlBotonera.Controls.Add(this.btnSiguiente);
            this.pnlBotonera.Controls.Add(this.btnAnterior);
            this.pnlBotonera.Controls.Add(this.flpBotonera);
            this.pnlBotonera.Controls.Add(this.btnPrimero);
            this.pnlBotonera.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotonera.Location = new System.Drawing.Point(0, 291);
            this.pnlBotonera.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlBotonera.Name = "pnlBotonera";
            this.pnlBotonera.Size = new System.Drawing.Size(1161, 66);
            this.pnlBotonera.TabIndex = 2;
            // 
            // btnUltimo
            // 
            this.btnUltimo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUltimo.FlatAppearance.BorderSize = 0;
            this.btnUltimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUltimo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUltimo.ForeColor = System.Drawing.Color.White;
            this.btnUltimo.Image = ((System.Drawing.Image)(resources.GetObject("btnUltimo.Image")));
            this.btnUltimo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUltimo.Location = new System.Drawing.Point(154, 13);
            this.btnUltimo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(41, 40);
            this.btnUltimo.TabIndex = 3;
            this.btnUltimo.UseVisualStyleBackColor = false;
            this.btnUltimo.Click += new System.EventHandler(this.BtnUltimo_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSiguiente.FlatAppearance.BorderSize = 0;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSiguiente.ForeColor = System.Drawing.Color.White;
            this.btnSiguiente.Image = ((System.Drawing.Image)(resources.GetObject("btnSiguiente.Image")));
            this.btnSiguiente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSiguiente.Location = new System.Drawing.Point(110, 13);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(41, 40);
            this.btnSiguiente.TabIndex = 2;
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.BtnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAnterior.FlatAppearance.BorderSize = 0;
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnterior.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAnterior.ForeColor = System.Drawing.Color.White;
            this.btnAnterior.Image = ((System.Drawing.Image)(resources.GetObject("btnAnterior.Image")));
            this.btnAnterior.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnterior.Location = new System.Drawing.Point(58, 13);
            this.btnAnterior.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(41, 40);
            this.btnAnterior.TabIndex = 1;
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.BtnAnterior_Click);
            // 
            // flpBotonera
            // 
            this.flpBotonera.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.flpBotonera.Controls.Add(this.btnNuevo);
            this.flpBotonera.Controls.Add(this.btnGuardar);
            this.flpBotonera.Controls.Add(this.btnEliminar);
            this.flpBotonera.Controls.Add(this.btnSalir);
            this.flpBotonera.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpBotonera.Location = new System.Drawing.Point(370, 5);
            this.flpBotonera.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.flpBotonera.Name = "flpBotonera";
            this.flpBotonera.Size = new System.Drawing.Size(788, 58);
            this.flpBotonera.TabIndex = 4;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(596, 3);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(188, 45);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(400, 3);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(188, 45);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Visible = false;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Crimson;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(204, 3);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(188, 45);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(8, 3);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(188, 45);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // btnPrimero
            // 
            this.btnPrimero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPrimero.FlatAppearance.BorderSize = 0;
            this.btnPrimero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimero.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPrimero.ForeColor = System.Drawing.Color.White;
            this.btnPrimero.Image = ((System.Drawing.Image)(resources.GetObject("btnPrimero.Image")));
            this.btnPrimero.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrimero.Location = new System.Drawing.Point(14, 13);
            this.btnPrimero.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(41, 40);
            this.btnPrimero.TabIndex = 0;
            this.btnPrimero.UseVisualStyleBackColor = false;
            this.btnPrimero.Click += new System.EventHandler(this.BtnPrimero_Click);
            // 
            // FrmMantenimientoEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1161, 357);
            this.Controls.Add(this.pnlBotonera);
            this.Controls.Add(this.grbEmpleadoFML);
            this.Controls.Add(this.pnlCabecera);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(1177, 396);
            this.MinimumSize = new System.Drawing.Size(921, 396);
            this.Name = "FrmMantenimientoEmpleados";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.FrmMantenimientoEmpleados_Load);
            this.grbEmpleadoFML.ResumeLayout(false);
            this.grbEmpleadoFML.PerformLayout();
            this.pnlBotonera.ResumeLayout(false);
            this.flpBotonera.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCabecera;
        private System.Windows.Forms.GroupBox grbEmpleadoFML;
        private System.Windows.Forms.Button btnEtiquetas;
        private System.Windows.Forms.TextBox txtIdEmpleado;
        private System.Windows.Forms.TextBox txtEtiquetas;
        private System.Windows.Forms.Label lblEtiquetas;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Panel pnlBotonera;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.FlowLayoutPanel flpBotonera;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox cmbCargo;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.Label lblJefe;
        private System.Windows.Forms.ComboBox cmbJefes;
    }
}