namespace GendocsForms
{
    partial class FrmPedidoEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedidoEdit));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtProvincia = new System.Windows.Forms.TextBox();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.txtPoblacion = new System.Windows.Forms.TextBox();
            this.lblPoblacion = new System.Windows.Forms.Label();
            this.txtArchivoPDF = new System.Windows.Forms.TextBox();
            this.lblArchivoPDF = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtActuacion = new System.Windows.Forms.TextBox();
            this.cmbProyectoFML = new System.Windows.Forms.ComboBox();
            this.lblProyectoFML = new System.Windows.Forms.Label();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblActuacion = new System.Windows.Forms.Label();
            this.txtNumObra = new System.Windows.Forms.TextBox();
            this.lblNumObra = new System.Windows.Forms.Label();
            this.txtGestor = new System.Windows.Forms.TextBox();
            this.lblGestor = new System.Windows.Forms.Label();
            this.txtIdGestor = new System.Windows.Forms.TextBox();
            this.lblIdGestor = new System.Windows.Forms.Label();
            this.txtNumRef = new System.Windows.Forms.TextBox();
            this.lblNumRef = new System.Windows.Forms.Label();
            this.txtDescripcionUC = new System.Windows.Forms.TextBox();
            this.lblDescripcionUC = new System.Windows.Forms.Label();
            this.txtFechaEntrega = new System.Windows.Forms.TextBox();
            this.lblFechaEntrega = new System.Windows.Forms.Label();
            this.txtFechaPedido = new System.Windows.Forms.TextBox();
            this.lblFechaPedido = new System.Windows.Forms.Label();
            this.txtNumContrato = new System.Windows.Forms.TextBox();
            this.lblNumContrato = new System.Windows.Forms.Label();
            this.txtPedidoCab = new System.Windows.Forms.TextBox();
            this.lblIdPedidoCab = new System.Windows.Forms.Label();
            this.dgvPedidosEdit = new System.Windows.Forms.DataGridView();
            this.txtImporteTotal = new System.Windows.Forms.TextBox();
            this.lblImporteTotal = new System.Windows.Forms.Label();
            this.txtCoefFacturacion = new System.Windows.Forms.TextBox();
            this.lblCoefFacturacion = new System.Windows.Forms.Label();
            this.txtCoefPrecio = new System.Windows.Forms.TextBox();
            this.lblCoefPrecio = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregarRecurso = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBajar = new System.Windows.Forms.Button();
            this.btnSubir = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidosEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1330, 62);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 533);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Controls.Add(this.txtCoefPrecio);
            this.panel3.Controls.Add(this.lblImporteTotal);
            this.panel3.Controls.Add(this.txtImporteTotal);
            this.panel3.Controls.Add(this.lblCoefFacturacion);
            this.panel3.Controls.Add(this.txtCoefFacturacion);
            this.panel3.Controls.Add(this.lblCoefPrecio);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(150, 531);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1180, 64);
            this.panel3.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtProvincia);
            this.groupBox1.Controls.Add(this.lblProvincia);
            this.groupBox1.Controls.Add(this.txtPoblacion);
            this.groupBox1.Controls.Add(this.lblPoblacion);
            this.groupBox1.Controls.Add(this.txtArchivoPDF);
            this.groupBox1.Controls.Add(this.lblArchivoPDF);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.lblDireccion);
            this.groupBox1.Controls.Add(this.txtActuacion);
            this.groupBox1.Controls.Add(this.cmbProyectoFML);
            this.groupBox1.Controls.Add(this.lblProyectoFML);
            this.groupBox1.Controls.Add(this.cmbClientes);
            this.groupBox1.Controls.Add(this.lblCliente);
            this.groupBox1.Controls.Add(this.lblActuacion);
            this.groupBox1.Controls.Add(this.txtNumObra);
            this.groupBox1.Controls.Add(this.lblNumObra);
            this.groupBox1.Controls.Add(this.txtGestor);
            this.groupBox1.Controls.Add(this.lblGestor);
            this.groupBox1.Controls.Add(this.txtIdGestor);
            this.groupBox1.Controls.Add(this.lblIdGestor);
            this.groupBox1.Controls.Add(this.txtNumRef);
            this.groupBox1.Controls.Add(this.lblNumRef);
            this.groupBox1.Controls.Add(this.txtDescripcionUC);
            this.groupBox1.Controls.Add(this.lblDescripcionUC);
            this.groupBox1.Controls.Add(this.txtFechaEntrega);
            this.groupBox1.Controls.Add(this.lblFechaEntrega);
            this.groupBox1.Controls.Add(this.txtFechaPedido);
            this.groupBox1.Controls.Add(this.lblFechaPedido);
            this.groupBox1.Controls.Add(this.txtNumContrato);
            this.groupBox1.Controls.Add(this.lblNumContrato);
            this.groupBox1.Controls.Add(this.txtPedidoCab);
            this.groupBox1.Controls.Add(this.lblIdPedidoCab);
            this.groupBox1.Location = new System.Drawing.Point(158, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1165, 135);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // txtProvincia
            // 
            this.txtProvincia.BackColor = System.Drawing.Color.Gainsboro;
            this.txtProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProvincia.Location = new System.Drawing.Point(950, 112);
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.Size = new System.Drawing.Size(199, 20);
            this.txtProvincia.TabIndex = 38;
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvincia.Location = new System.Drawing.Point(950, 95);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(60, 13);
            this.lblProvincia.TabIndex = 37;
            this.lblProvincia.Text = "Provincia";
            // 
            // txtPoblacion
            // 
            this.txtPoblacion.BackColor = System.Drawing.Color.Gainsboro;
            this.txtPoblacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPoblacion.Location = new System.Drawing.Point(737, 112);
            this.txtPoblacion.Name = "txtPoblacion";
            this.txtPoblacion.Size = new System.Drawing.Size(202, 20);
            this.txtPoblacion.TabIndex = 36;
            // 
            // lblPoblacion
            // 
            this.lblPoblacion.AutoSize = true;
            this.lblPoblacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoblacion.Location = new System.Drawing.Point(735, 95);
            this.lblPoblacion.Name = "lblPoblacion";
            this.lblPoblacion.Size = new System.Drawing.Size(63, 13);
            this.lblPoblacion.TabIndex = 35;
            this.lblPoblacion.Text = "Población";
            // 
            // txtArchivoPDF
            // 
            this.txtArchivoPDF.BackColor = System.Drawing.Color.Gainsboro;
            this.txtArchivoPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArchivoPDF.Location = new System.Drawing.Point(738, 73);
            this.txtArchivoPDF.Name = "txtArchivoPDF";
            this.txtArchivoPDF.Size = new System.Drawing.Size(410, 20);
            this.txtArchivoPDF.TabIndex = 34;
            // 
            // lblArchivoPDF
            // 
            this.lblArchivoPDF.AutoSize = true;
            this.lblArchivoPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArchivoPDF.Location = new System.Drawing.Point(735, 56);
            this.lblArchivoPDF.Name = "lblArchivoPDF";
            this.lblArchivoPDF.Size = new System.Drawing.Size(78, 13);
            this.lblArchivoPDF.TabIndex = 33;
            this.lblArchivoPDF.Text = "Archivo PDF";
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.Gainsboro;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(369, 112);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(364, 20);
            this.txtDireccion.TabIndex = 32;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(365, 95);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(61, 13);
            this.lblDireccion.TabIndex = 31;
            this.lblDireccion.Text = "Direccion";
            // 
            // txtActuacion
            // 
            this.txtActuacion.BackColor = System.Drawing.Color.Gainsboro;
            this.txtActuacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActuacion.Location = new System.Drawing.Point(520, 73);
            this.txtActuacion.Name = "txtActuacion";
            this.txtActuacion.Size = new System.Drawing.Size(213, 20);
            this.txtActuacion.TabIndex = 30;
            // 
            // cmbProyectoFML
            // 
            this.cmbProyectoFML.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProyectoFML.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProyectoFML.FormattingEnabled = true;
            this.cmbProyectoFML.Location = new System.Drawing.Point(520, 29);
            this.cmbProyectoFML.Name = "cmbProyectoFML";
            this.cmbProyectoFML.Size = new System.Drawing.Size(379, 21);
            this.cmbProyectoFML.TabIndex = 29;
            // 
            // lblProyectoFML
            // 
            this.lblProyectoFML.AutoSize = true;
            this.lblProyectoFML.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProyectoFML.Location = new System.Drawing.Point(521, 14);
            this.lblProyectoFML.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProyectoFML.Name = "lblProyectoFML";
            this.lblProyectoFML.Size = new System.Drawing.Size(85, 13);
            this.lblProyectoFML.TabIndex = 28;
            this.lblProyectoFML.Text = "Proyecto FML";
            // 
            // cmbClientes
            // 
            this.cmbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(20, 29);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(119, 21);
            this.cmbClientes.TabIndex = 27;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblCliente.Location = new System.Drawing.Point(21, 14);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(46, 13);
            this.lblCliente.TabIndex = 26;
            this.lblCliente.Text = "Cliente";
            // 
            // lblActuacion
            // 
            this.lblActuacion.AutoSize = true;
            this.lblActuacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActuacion.Location = new System.Drawing.Point(518, 56);
            this.lblActuacion.Name = "lblActuacion";
            this.lblActuacion.Size = new System.Drawing.Size(64, 13);
            this.lblActuacion.TabIndex = 25;
            this.lblActuacion.Text = "Actuación";
            // 
            // txtNumObra
            // 
            this.txtNumObra.BackColor = System.Drawing.Color.Gainsboro;
            this.txtNumObra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumObra.Location = new System.Drawing.Point(20, 73);
            this.txtNumObra.Name = "txtNumObra";
            this.txtNumObra.Size = new System.Drawing.Size(119, 20);
            this.txtNumObra.TabIndex = 23;
            // 
            // lblNumObra
            // 
            this.lblNumObra.AutoSize = true;
            this.lblNumObra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumObra.Location = new System.Drawing.Point(16, 56);
            this.lblNumObra.Name = "lblNumObra";
            this.lblNumObra.Size = new System.Drawing.Size(67, 13);
            this.lblNumObra.TabIndex = 22;
            this.lblNumObra.Text = "Num. Obra";
            // 
            // txtGestor
            // 
            this.txtGestor.BackColor = System.Drawing.Color.Gainsboro;
            this.txtGestor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGestor.Location = new System.Drawing.Point(86, 112);
            this.txtGestor.Name = "txtGestor";
            this.txtGestor.Size = new System.Drawing.Size(278, 20);
            this.txtGestor.TabIndex = 19;
            // 
            // lblGestor
            // 
            this.lblGestor.AutoSize = true;
            this.lblGestor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestor.Location = new System.Drawing.Point(82, 95);
            this.lblGestor.Name = "lblGestor";
            this.lblGestor.Size = new System.Drawing.Size(44, 13);
            this.lblGestor.TabIndex = 18;
            this.lblGestor.Text = "Gestor";
            // 
            // txtIdGestor
            // 
            this.txtIdGestor.BackColor = System.Drawing.Color.Gainsboro;
            this.txtIdGestor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdGestor.Location = new System.Drawing.Point(20, 112);
            this.txtIdGestor.Name = "txtIdGestor";
            this.txtIdGestor.Size = new System.Drawing.Size(62, 20);
            this.txtIdGestor.TabIndex = 17;
            // 
            // lblIdGestor
            // 
            this.lblIdGestor.AutoSize = true;
            this.lblIdGestor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdGestor.Location = new System.Drawing.Point(17, 95);
            this.lblIdGestor.Name = "lblIdGestor";
            this.lblIdGestor.Size = new System.Drawing.Size(59, 13);
            this.lblIdGestor.TabIndex = 16;
            this.lblIdGestor.Text = "Id Gestor";
            // 
            // txtNumRef
            // 
            this.txtNumRef.BackColor = System.Drawing.Color.Gainsboro;
            this.txtNumRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumRef.Location = new System.Drawing.Point(234, 31);
            this.txtNumRef.Name = "txtNumRef";
            this.txtNumRef.Size = new System.Drawing.Size(130, 20);
            this.txtNumRef.TabIndex = 13;
            // 
            // lblNumRef
            // 
            this.lblNumRef.AutoSize = true;
            this.lblNumRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumRef.Location = new System.Drawing.Point(232, 14);
            this.lblNumRef.Name = "lblNumRef";
            this.lblNumRef.Size = new System.Drawing.Size(60, 13);
            this.lblNumRef.TabIndex = 12;
            this.lblNumRef.Text = "Num Ref.";
            // 
            // txtDescripcionUC
            // 
            this.txtDescripcionUC.BackColor = System.Drawing.Color.Gainsboro;
            this.txtDescripcionUC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionUC.Location = new System.Drawing.Point(144, 73);
            this.txtDescripcionUC.Name = "txtDescripcionUC";
            this.txtDescripcionUC.Size = new System.Drawing.Size(371, 20);
            this.txtDescripcionUC.TabIndex = 11;
            // 
            // lblDescripcionUC
            // 
            this.lblDescripcionUC.AutoSize = true;
            this.lblDescripcionUC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionUC.Location = new System.Drawing.Point(141, 56);
            this.lblDescripcionUC.Name = "lblDescripcionUC";
            this.lblDescripcionUC.Size = new System.Drawing.Size(137, 13);
            this.lblDescripcionUC.TabIndex = 10;
            this.lblDescripcionUC.Text = "Descripción de la Obra";
            // 
            // txtFechaEntrega
            // 
            this.txtFechaEntrega.BackColor = System.Drawing.Color.Gainsboro;
            this.txtFechaEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaEntrega.Location = new System.Drawing.Point(1029, 29);
            this.txtFechaEntrega.Name = "txtFechaEntrega";
            this.txtFechaEntrega.Size = new System.Drawing.Size(119, 20);
            this.txtFechaEntrega.TabIndex = 7;
            // 
            // lblFechaEntrega
            // 
            this.lblFechaEntrega.AutoSize = true;
            this.lblFechaEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaEntrega.Location = new System.Drawing.Point(1026, 12);
            this.lblFechaEntrega.Name = "lblFechaEntrega";
            this.lblFechaEntrega.Size = new System.Drawing.Size(90, 13);
            this.lblFechaEntrega.TabIndex = 6;
            this.lblFechaEntrega.Text = "Fecha Entrega";
            // 
            // txtFechaPedido
            // 
            this.txtFechaPedido.BackColor = System.Drawing.Color.Gainsboro;
            this.txtFechaPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaPedido.Location = new System.Drawing.Point(903, 29);
            this.txtFechaPedido.Name = "txtFechaPedido";
            this.txtFechaPedido.Size = new System.Drawing.Size(119, 20);
            this.txtFechaPedido.TabIndex = 5;
            // 
            // lblFechaPedido
            // 
            this.lblFechaPedido.AutoSize = true;
            this.lblFechaPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaPedido.Location = new System.Drawing.Point(900, 12);
            this.lblFechaPedido.Name = "lblFechaPedido";
            this.lblFechaPedido.Size = new System.Drawing.Size(85, 13);
            this.lblFechaPedido.TabIndex = 4;
            this.lblFechaPedido.Text = "Fecha Pedido";
            // 
            // txtNumContrato
            // 
            this.txtNumContrato.BackColor = System.Drawing.Color.Gainsboro;
            this.txtNumContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumContrato.Location = new System.Drawing.Point(369, 31);
            this.txtNumContrato.Name = "txtNumContrato";
            this.txtNumContrato.Size = new System.Drawing.Size(146, 20);
            this.txtNumContrato.TabIndex = 3;
            // 
            // lblNumContrato
            // 
            this.lblNumContrato.AutoSize = true;
            this.lblNumContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumContrato.Location = new System.Drawing.Point(366, 14);
            this.lblNumContrato.Name = "lblNumContrato";
            this.lblNumContrato.Size = new System.Drawing.Size(88, 13);
            this.lblNumContrato.TabIndex = 2;
            this.lblNumContrato.Text = "Num. Contrato";
            // 
            // txtPedidoCab
            // 
            this.txtPedidoCab.BackColor = System.Drawing.Color.Gainsboro;
            this.txtPedidoCab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPedidoCab.Location = new System.Drawing.Point(144, 31);
            this.txtPedidoCab.Name = "txtPedidoCab";
            this.txtPedidoCab.Size = new System.Drawing.Size(77, 20);
            this.txtPedidoCab.TabIndex = 1;
            // 
            // lblIdPedidoCab
            // 
            this.lblIdPedidoCab.AutoSize = true;
            this.lblIdPedidoCab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPedidoCab.Location = new System.Drawing.Point(144, 16);
            this.lblIdPedidoCab.Name = "lblIdPedidoCab";
            this.lblIdPedidoCab.Size = new System.Drawing.Size(91, 13);
            this.lblIdPedidoCab.TabIndex = 0;
            this.lblIdPedidoCab.Text = "Id Pedido Cab.";
            // 
            // dgvPedidosEdit
            // 
            this.dgvPedidosEdit.AllowUserToAddRows = false;
            this.dgvPedidosEdit.AllowUserToDeleteRows = false;
            this.dgvPedidosEdit.AllowUserToOrderColumns = true;
            this.dgvPedidosEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPedidosEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidosEdit.Location = new System.Drawing.Point(158, 210);
            this.dgvPedidosEdit.Name = "dgvPedidosEdit";
            this.dgvPedidosEdit.RowHeadersWidth = 82;
            this.dgvPedidosEdit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidosEdit.Size = new System.Drawing.Size(1117, 319);
            this.dgvPedidosEdit.TabIndex = 4;
            // 
            // txtImporteTotal
            // 
            this.txtImporteTotal.Location = new System.Drawing.Point(941, 3);
            this.txtImporteTotal.Name = "txtImporteTotal";
            this.txtImporteTotal.Size = new System.Drawing.Size(186, 20);
            this.txtImporteTotal.TabIndex = 14;
            // 
            // lblImporteTotal
            // 
            this.lblImporteTotal.AutoSize = true;
            this.lblImporteTotal.Location = new System.Drawing.Point(868, 4);
            this.lblImporteTotal.Name = "lblImporteTotal";
            this.lblImporteTotal.Size = new System.Drawing.Size(69, 13);
            this.lblImporteTotal.TabIndex = 13;
            this.lblImporteTotal.Text = "Importe Total";
            // 
            // txtCoefFacturacion
            // 
            this.txtCoefFacturacion.Enabled = false;
            this.txtCoefFacturacion.Location = new System.Drawing.Point(826, 5);
            this.txtCoefFacturacion.Name = "txtCoefFacturacion";
            this.txtCoefFacturacion.Size = new System.Drawing.Size(38, 20);
            this.txtCoefFacturacion.TabIndex = 24;
            // 
            // lblCoefFacturacion
            // 
            this.lblCoefFacturacion.AutoSize = true;
            this.lblCoefFacturacion.Location = new System.Drawing.Point(701, 6);
            this.lblCoefFacturacion.Name = "lblCoefFacturacion";
            this.lblCoefFacturacion.Size = new System.Drawing.Size(119, 13);
            this.lblCoefFacturacion.TabIndex = 23;
            this.lblCoefFacturacion.Text = "Coeficiente Facturación";
            // 
            // txtCoefPrecio
            // 
            this.txtCoefPrecio.Enabled = false;
            this.txtCoefPrecio.Location = new System.Drawing.Point(658, 4);
            this.txtCoefPrecio.Name = "txtCoefPrecio";
            this.txtCoefPrecio.Size = new System.Drawing.Size(38, 20);
            this.txtCoefPrecio.TabIndex = 26;
            // 
            // lblCoefPrecio
            // 
            this.lblCoefPrecio.AutoSize = true;
            this.lblCoefPrecio.Location = new System.Drawing.Point(559, 5);
            this.lblCoefPrecio.Name = "lblCoefPrecio";
            this.lblCoefPrecio.Size = new System.Drawing.Size(93, 13);
            this.lblCoefPrecio.TabIndex = 25;
            this.lblCoefPrecio.Text = "Coeficiente Precio";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEditar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(1277, 210);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(46, 25);
            this.btnEditar.TabIndex = 28;
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnAgregarRecurso
            // 
            this.btnAgregarRecurso.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAgregarRecurso.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAgregarRecurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarRecurso.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarRecurso.ForeColor = System.Drawing.Color.White;
            this.btnAgregarRecurso.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarRecurso.Image")));
            this.btnAgregarRecurso.Location = new System.Drawing.Point(1277, 236);
            this.btnAgregarRecurso.Name = "btnAgregarRecurso";
            this.btnAgregarRecurso.Size = new System.Drawing.Size(46, 25);
            this.btnAgregarRecurso.TabIndex = 27;
            this.btnAgregarRecurso.UseVisualStyleBackColor = false;
            this.btnAgregarRecurso.Click += new System.EventHandler(this.btnAgregarRecurso_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEliminar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(1277, 262);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(46, 25);
            this.btnEliminar.TabIndex = 29;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBajar
            // 
            this.btnBajar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBajar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnBajar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBajar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBajar.ForeColor = System.Drawing.Color.White;
            this.btnBajar.Image = ((System.Drawing.Image)(resources.GetObject("btnBajar.Image")));
            this.btnBajar.Location = new System.Drawing.Point(1277, 501);
            this.btnBajar.Name = "btnBajar";
            this.btnBajar.Size = new System.Drawing.Size(46, 25);
            this.btnBajar.TabIndex = 30;
            this.btnBajar.UseVisualStyleBackColor = false;
            // 
            // btnSubir
            // 
            this.btnSubir.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSubir.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSubir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubir.ForeColor = System.Drawing.Color.White;
            this.btnSubir.Image = ((System.Drawing.Image)(resources.GetObject("btnSubir.Image")));
            this.btnSubir.Location = new System.Drawing.Point(1277, 475);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Size = new System.Drawing.Size(46, 25);
            this.btnSubir.TabIndex = 31;
            this.btnSubir.UseVisualStyleBackColor = false;
            this.btnSubir.Click += new System.EventHandler(this.btnSubir_Click);
            // 
            // FrmPedidoEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1330, 595);
            this.Controls.Add(this.btnSubir);
            this.Controls.Add(this.btnBajar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregarRecurso);
            this.Controls.Add(this.dgvPedidosEdit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmPedidoEdit";
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.FrmPedidoEdit_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidosEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtGestor;
        private System.Windows.Forms.Label lblGestor;
        private System.Windows.Forms.TextBox txtIdGestor;
        private System.Windows.Forms.Label lblIdGestor;
        private System.Windows.Forms.TextBox txtNumRef;
        private System.Windows.Forms.Label lblNumRef;
        private System.Windows.Forms.TextBox txtDescripcionUC;
        private System.Windows.Forms.Label lblDescripcionUC;
        private System.Windows.Forms.TextBox txtFechaEntrega;
        private System.Windows.Forms.Label lblFechaEntrega;
        private System.Windows.Forms.TextBox txtFechaPedido;
        private System.Windows.Forms.Label lblFechaPedido;
        private System.Windows.Forms.TextBox txtNumContrato;
        private System.Windows.Forms.Label lblNumContrato;
        private System.Windows.Forms.TextBox txtPedidoCab;
        private System.Windows.Forms.Label lblIdPedidoCab;
        private System.Windows.Forms.DataGridView dgvPedidosEdit;
        private System.Windows.Forms.TextBox txtImporteTotal;
        private System.Windows.Forms.Label lblImporteTotal;
        private System.Windows.Forms.TextBox txtNumObra;
        private System.Windows.Forms.Label lblNumObra;
        private System.Windows.Forms.Label lblActuacion;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.ComboBox cmbProyectoFML;
        private System.Windows.Forms.Label lblProyectoFML;
        private System.Windows.Forms.TextBox txtActuacion;
        private System.Windows.Forms.TextBox txtProvincia;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.TextBox txtPoblacion;
        private System.Windows.Forms.Label lblPoblacion;
        private System.Windows.Forms.TextBox txtArchivoPDF;
        private System.Windows.Forms.Label lblArchivoPDF;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtCoefFacturacion;
        private System.Windows.Forms.Label lblCoefFacturacion;
        private System.Windows.Forms.TextBox txtCoefPrecio;
        private System.Windows.Forms.Label lblCoefPrecio;
        private System.Windows.Forms.Button btnAgregarRecurso;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBajar;
        private System.Windows.Forms.Button btnSubir;
    }
}