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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedidoEdit));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtCoefPrecio = new System.Windows.Forms.TextBox();
            this.lblImporteTotal = new System.Windows.Forms.Label();
            this.txtImporteTotal = new System.Windows.Forms.TextBox();
            this.lblCoefFacturacion = new System.Windows.Forms.Label();
            this.txtCoefFacturacion = new System.Windows.Forms.TextBox();
            this.lblCoefPrecio = new System.Windows.Forms.Label();
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
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregarRecurso = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBajar = new System.Windows.Forms.Button();
            this.btnSubir = new System.Windows.Forms.Button();
            this.cmsMenuColumnas = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmConfigurarGrid = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblTitulo2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTituloFormulario = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidosEdit)).BeginInit();
            this.cmsMenuColumnas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2438, 114);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.btnSalir);
            this.panel2.Controls.Add(this.lblTitulo2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lblTituloFormulario);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 114);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 984);
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
            this.panel3.Location = new System.Drawing.Point(350, 980);
            this.panel3.Margin = new System.Windows.Forms.Padding(6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2088, 118);
            this.panel3.TabIndex = 2;
            // 
            // txtCoefPrecio
            // 
            this.txtCoefPrecio.Enabled = false;
            this.txtCoefPrecio.Location = new System.Drawing.Point(1206, 7);
            this.txtCoefPrecio.Margin = new System.Windows.Forms.Padding(6);
            this.txtCoefPrecio.Name = "txtCoefPrecio";
            this.txtCoefPrecio.Size = new System.Drawing.Size(66, 29);
            this.txtCoefPrecio.TabIndex = 26;
            // 
            // lblImporteTotal
            // 
            this.lblImporteTotal.AutoSize = true;
            this.lblImporteTotal.Location = new System.Drawing.Point(1591, 7);
            this.lblImporteTotal.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblImporteTotal.Name = "lblImporteTotal";
            this.lblImporteTotal.Size = new System.Drawing.Size(126, 25);
            this.lblImporteTotal.TabIndex = 13;
            this.lblImporteTotal.Text = "Importe Total";
            // 
            // txtImporteTotal
            // 
            this.txtImporteTotal.Location = new System.Drawing.Point(1725, 6);
            this.txtImporteTotal.Margin = new System.Windows.Forms.Padding(6);
            this.txtImporteTotal.Name = "txtImporteTotal";
            this.txtImporteTotal.Size = new System.Drawing.Size(338, 29);
            this.txtImporteTotal.TabIndex = 14;
            // 
            // lblCoefFacturacion
            // 
            this.lblCoefFacturacion.AutoSize = true;
            this.lblCoefFacturacion.Location = new System.Drawing.Point(1285, 11);
            this.lblCoefFacturacion.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCoefFacturacion.Name = "lblCoefFacturacion";
            this.lblCoefFacturacion.Size = new System.Drawing.Size(217, 25);
            this.lblCoefFacturacion.TabIndex = 23;
            this.lblCoefFacturacion.Text = "Coeficiente Facturación";
            // 
            // txtCoefFacturacion
            // 
            this.txtCoefFacturacion.Enabled = false;
            this.txtCoefFacturacion.Location = new System.Drawing.Point(1514, 9);
            this.txtCoefFacturacion.Margin = new System.Windows.Forms.Padding(6);
            this.txtCoefFacturacion.Name = "txtCoefFacturacion";
            this.txtCoefFacturacion.Size = new System.Drawing.Size(66, 29);
            this.txtCoefFacturacion.TabIndex = 24;
            // 
            // lblCoefPrecio
            // 
            this.lblCoefPrecio.AutoSize = true;
            this.lblCoefPrecio.Location = new System.Drawing.Point(1025, 9);
            this.lblCoefPrecio.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCoefPrecio.Name = "lblCoefPrecio";
            this.lblCoefPrecio.Size = new System.Drawing.Size(170, 25);
            this.lblCoefPrecio.TabIndex = 25;
            this.lblCoefPrecio.Text = "Coeficiente Precio";
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
            this.groupBox1.Location = new System.Drawing.Point(362, 126);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(2064, 249);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // txtProvincia
            // 
            this.txtProvincia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProvincia.BackColor = System.Drawing.Color.Gainsboro;
            this.txtProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProvincia.Location = new System.Drawing.Point(1742, 207);
            this.txtProvincia.Margin = new System.Windows.Forms.Padding(6);
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.Size = new System.Drawing.Size(290, 29);
            this.txtProvincia.TabIndex = 38;
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvincia.Location = new System.Drawing.Point(1742, 175);
            this.lblProvincia.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(101, 25);
            this.lblProvincia.TabIndex = 37;
            this.lblProvincia.Text = "Provincia";
            // 
            // txtPoblacion
            // 
            this.txtPoblacion.BackColor = System.Drawing.Color.Gainsboro;
            this.txtPoblacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPoblacion.Location = new System.Drawing.Point(1351, 207);
            this.txtPoblacion.Margin = new System.Windows.Forms.Padding(6);
            this.txtPoblacion.Name = "txtPoblacion";
            this.txtPoblacion.Size = new System.Drawing.Size(367, 29);
            this.txtPoblacion.TabIndex = 36;
            // 
            // lblPoblacion
            // 
            this.lblPoblacion.AutoSize = true;
            this.lblPoblacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoblacion.Location = new System.Drawing.Point(1348, 175);
            this.lblPoblacion.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPoblacion.Name = "lblPoblacion";
            this.lblPoblacion.Size = new System.Drawing.Size(107, 25);
            this.lblPoblacion.TabIndex = 35;
            this.lblPoblacion.Text = "Población";
            // 
            // txtArchivoPDF
            // 
            this.txtArchivoPDF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArchivoPDF.BackColor = System.Drawing.Color.Gainsboro;
            this.txtArchivoPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArchivoPDF.Location = new System.Drawing.Point(1353, 135);
            this.txtArchivoPDF.Margin = new System.Windows.Forms.Padding(6);
            this.txtArchivoPDF.Name = "txtArchivoPDF";
            this.txtArchivoPDF.Size = new System.Drawing.Size(676, 29);
            this.txtArchivoPDF.TabIndex = 34;
            // 
            // lblArchivoPDF
            // 
            this.lblArchivoPDF.AutoSize = true;
            this.lblArchivoPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArchivoPDF.Location = new System.Drawing.Point(1348, 103);
            this.lblArchivoPDF.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblArchivoPDF.Name = "lblArchivoPDF";
            this.lblArchivoPDF.Size = new System.Drawing.Size(133, 25);
            this.lblArchivoPDF.TabIndex = 33;
            this.lblArchivoPDF.Text = "Archivo PDF";
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.Gainsboro;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(677, 207);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(6);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(664, 29);
            this.txtDireccion.TabIndex = 32;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(669, 175);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(102, 25);
            this.lblDireccion.TabIndex = 31;
            this.lblDireccion.Text = "Direccion";
            // 
            // txtActuacion
            // 
            this.txtActuacion.BackColor = System.Drawing.Color.Gainsboro;
            this.txtActuacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActuacion.Location = new System.Drawing.Point(953, 135);
            this.txtActuacion.Margin = new System.Windows.Forms.Padding(6);
            this.txtActuacion.Name = "txtActuacion";
            this.txtActuacion.Size = new System.Drawing.Size(387, 29);
            this.txtActuacion.TabIndex = 30;
            // 
            // cmbProyectoFML
            // 
            this.cmbProyectoFML.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProyectoFML.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProyectoFML.FormattingEnabled = true;
            this.cmbProyectoFML.Location = new System.Drawing.Point(953, 54);
            this.cmbProyectoFML.Margin = new System.Windows.Forms.Padding(6);
            this.cmbProyectoFML.Name = "cmbProyectoFML";
            this.cmbProyectoFML.Size = new System.Drawing.Size(692, 32);
            this.cmbProyectoFML.TabIndex = 29;
            // 
            // lblProyectoFML
            // 
            this.lblProyectoFML.AutoSize = true;
            this.lblProyectoFML.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProyectoFML.Location = new System.Drawing.Point(955, 26);
            this.lblProyectoFML.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblProyectoFML.Name = "lblProyectoFML";
            this.lblProyectoFML.Size = new System.Drawing.Size(146, 25);
            this.lblProyectoFML.TabIndex = 28;
            this.lblProyectoFML.Text = "Proyecto FML";
            // 
            // cmbClientes
            // 
            this.cmbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(37, 54);
            this.cmbClientes.Margin = new System.Windows.Forms.Padding(6);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(215, 32);
            this.cmbClientes.TabIndex = 27;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblCliente.Location = new System.Drawing.Point(39, 26);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(80, 25);
            this.lblCliente.TabIndex = 26;
            this.lblCliente.Text = "Cliente";
            // 
            // lblActuacion
            // 
            this.lblActuacion.AutoSize = true;
            this.lblActuacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActuacion.Location = new System.Drawing.Point(950, 103);
            this.lblActuacion.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblActuacion.Name = "lblActuacion";
            this.lblActuacion.Size = new System.Drawing.Size(108, 25);
            this.lblActuacion.TabIndex = 25;
            this.lblActuacion.Text = "Actuación";
            // 
            // txtNumObra
            // 
            this.txtNumObra.BackColor = System.Drawing.Color.Gainsboro;
            this.txtNumObra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumObra.Location = new System.Drawing.Point(37, 135);
            this.txtNumObra.Margin = new System.Windows.Forms.Padding(6);
            this.txtNumObra.Name = "txtNumObra";
            this.txtNumObra.Size = new System.Drawing.Size(215, 29);
            this.txtNumObra.TabIndex = 23;
            // 
            // lblNumObra
            // 
            this.lblNumObra.AutoSize = true;
            this.lblNumObra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumObra.Location = new System.Drawing.Point(29, 103);
            this.lblNumObra.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNumObra.Name = "lblNumObra";
            this.lblNumObra.Size = new System.Drawing.Size(116, 25);
            this.lblNumObra.TabIndex = 22;
            this.lblNumObra.Text = "Num. Obra";
            // 
            // txtGestor
            // 
            this.txtGestor.BackColor = System.Drawing.Color.Gainsboro;
            this.txtGestor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGestor.Location = new System.Drawing.Point(158, 207);
            this.txtGestor.Margin = new System.Windows.Forms.Padding(6);
            this.txtGestor.Name = "txtGestor";
            this.txtGestor.Size = new System.Drawing.Size(506, 29);
            this.txtGestor.TabIndex = 19;
            // 
            // lblGestor
            // 
            this.lblGestor.AutoSize = true;
            this.lblGestor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestor.Location = new System.Drawing.Point(150, 175);
            this.lblGestor.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblGestor.Name = "lblGestor";
            this.lblGestor.Size = new System.Drawing.Size(76, 25);
            this.lblGestor.TabIndex = 18;
            this.lblGestor.Text = "Gestor";
            // 
            // txtIdGestor
            // 
            this.txtIdGestor.BackColor = System.Drawing.Color.Gainsboro;
            this.txtIdGestor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdGestor.Location = new System.Drawing.Point(37, 207);
            this.txtIdGestor.Margin = new System.Windows.Forms.Padding(6);
            this.txtIdGestor.Name = "txtIdGestor";
            this.txtIdGestor.Size = new System.Drawing.Size(110, 29);
            this.txtIdGestor.TabIndex = 17;
            // 
            // lblIdGestor
            // 
            this.lblIdGestor.AutoSize = true;
            this.lblIdGestor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdGestor.Location = new System.Drawing.Point(31, 175);
            this.lblIdGestor.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblIdGestor.Name = "lblIdGestor";
            this.lblIdGestor.Size = new System.Drawing.Size(100, 25);
            this.lblIdGestor.TabIndex = 16;
            this.lblIdGestor.Text = "Id Gestor";
            // 
            // txtNumRef
            // 
            this.txtNumRef.BackColor = System.Drawing.Color.Gainsboro;
            this.txtNumRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumRef.Location = new System.Drawing.Point(429, 57);
            this.txtNumRef.Margin = new System.Windows.Forms.Padding(6);
            this.txtNumRef.Name = "txtNumRef";
            this.txtNumRef.Size = new System.Drawing.Size(235, 29);
            this.txtNumRef.TabIndex = 13;
            // 
            // lblNumRef
            // 
            this.lblNumRef.AutoSize = true;
            this.lblNumRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumRef.Location = new System.Drawing.Point(425, 26);
            this.lblNumRef.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNumRef.Name = "lblNumRef";
            this.lblNumRef.Size = new System.Drawing.Size(100, 25);
            this.lblNumRef.TabIndex = 12;
            this.lblNumRef.Text = "Num Ref.";
            // 
            // txtDescripcionUC
            // 
            this.txtDescripcionUC.BackColor = System.Drawing.Color.Gainsboro;
            this.txtDescripcionUC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionUC.Location = new System.Drawing.Point(264, 135);
            this.txtDescripcionUC.Margin = new System.Windows.Forms.Padding(6);
            this.txtDescripcionUC.Name = "txtDescripcionUC";
            this.txtDescripcionUC.Size = new System.Drawing.Size(677, 29);
            this.txtDescripcionUC.TabIndex = 11;
            // 
            // lblDescripcionUC
            // 
            this.lblDescripcionUC.AutoSize = true;
            this.lblDescripcionUC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionUC.Location = new System.Drawing.Point(259, 103);
            this.lblDescripcionUC.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDescripcionUC.Name = "lblDescripcionUC";
            this.lblDescripcionUC.Size = new System.Drawing.Size(232, 25);
            this.lblDescripcionUC.TabIndex = 10;
            this.lblDescripcionUC.Text = "Descripción de la Obra";
            // 
            // txtFechaEntrega
            // 
            this.txtFechaEntrega.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFechaEntrega.BackColor = System.Drawing.Color.Gainsboro;
            this.txtFechaEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaEntrega.Location = new System.Drawing.Point(1887, 54);
            this.txtFechaEntrega.Margin = new System.Windows.Forms.Padding(6);
            this.txtFechaEntrega.Name = "txtFechaEntrega";
            this.txtFechaEntrega.Size = new System.Drawing.Size(143, 29);
            this.txtFechaEntrega.TabIndex = 7;
            // 
            // lblFechaEntrega
            // 
            this.lblFechaEntrega.AutoSize = true;
            this.lblFechaEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaEntrega.Location = new System.Drawing.Point(1881, 22);
            this.lblFechaEntrega.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFechaEntrega.Name = "lblFechaEntrega";
            this.lblFechaEntrega.Size = new System.Drawing.Size(153, 25);
            this.lblFechaEntrega.TabIndex = 6;
            this.lblFechaEntrega.Text = "Fecha Entrega";
            // 
            // txtFechaPedido
            // 
            this.txtFechaPedido.BackColor = System.Drawing.Color.Gainsboro;
            this.txtFechaPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaPedido.Location = new System.Drawing.Point(1656, 54);
            this.txtFechaPedido.Margin = new System.Windows.Forms.Padding(6);
            this.txtFechaPedido.Name = "txtFechaPedido";
            this.txtFechaPedido.Size = new System.Drawing.Size(215, 29);
            this.txtFechaPedido.TabIndex = 5;
            // 
            // lblFechaPedido
            // 
            this.lblFechaPedido.AutoSize = true;
            this.lblFechaPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaPedido.Location = new System.Drawing.Point(1650, 22);
            this.lblFechaPedido.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFechaPedido.Name = "lblFechaPedido";
            this.lblFechaPedido.Size = new System.Drawing.Size(145, 25);
            this.lblFechaPedido.TabIndex = 4;
            this.lblFechaPedido.Text = "Fecha Pedido";
            // 
            // txtNumContrato
            // 
            this.txtNumContrato.BackColor = System.Drawing.Color.Gainsboro;
            this.txtNumContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumContrato.Location = new System.Drawing.Point(677, 57);
            this.txtNumContrato.Margin = new System.Windows.Forms.Padding(6);
            this.txtNumContrato.Name = "txtNumContrato";
            this.txtNumContrato.Size = new System.Drawing.Size(264, 29);
            this.txtNumContrato.TabIndex = 3;
            // 
            // lblNumContrato
            // 
            this.lblNumContrato.AutoSize = true;
            this.lblNumContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumContrato.Location = new System.Drawing.Point(671, 26);
            this.lblNumContrato.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNumContrato.Name = "lblNumContrato";
            this.lblNumContrato.Size = new System.Drawing.Size(151, 25);
            this.lblNumContrato.TabIndex = 2;
            this.lblNumContrato.Text = "Num. Contrato";
            // 
            // txtPedidoCab
            // 
            this.txtPedidoCab.BackColor = System.Drawing.Color.Gainsboro;
            this.txtPedidoCab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPedidoCab.Location = new System.Drawing.Point(264, 57);
            this.txtPedidoCab.Margin = new System.Windows.Forms.Padding(6);
            this.txtPedidoCab.Name = "txtPedidoCab";
            this.txtPedidoCab.Size = new System.Drawing.Size(138, 29);
            this.txtPedidoCab.TabIndex = 1;
            // 
            // lblIdPedidoCab
            // 
            this.lblIdPedidoCab.AutoSize = true;
            this.lblIdPedidoCab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPedidoCab.Location = new System.Drawing.Point(264, 30);
            this.lblIdPedidoCab.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblIdPedidoCab.Name = "lblIdPedidoCab";
            this.lblIdPedidoCab.Size = new System.Drawing.Size(155, 25);
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
            this.dgvPedidosEdit.Location = new System.Drawing.Point(362, 388);
            this.dgvPedidosEdit.Margin = new System.Windows.Forms.Padding(6);
            this.dgvPedidosEdit.MultiSelect = false;
            this.dgvPedidosEdit.Name = "dgvPedidosEdit";
            this.dgvPedidosEdit.RowHeadersWidth = 82;
            this.dgvPedidosEdit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidosEdit.Size = new System.Drawing.Size(1976, 580);
            this.dgvPedidosEdit.TabIndex = 4;
            this.dgvPedidosEdit.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPedidosEdit_ColumnHeaderMouseClick);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEditar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(2341, 388);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(6);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(84, 46);
            this.btnEditar.TabIndex = 28;
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnAgregarRecurso
            // 
            this.btnAgregarRecurso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarRecurso.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAgregarRecurso.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAgregarRecurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarRecurso.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarRecurso.ForeColor = System.Drawing.Color.White;
            this.btnAgregarRecurso.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarRecurso.Image")));
            this.btnAgregarRecurso.Location = new System.Drawing.Point(2341, 436);
            this.btnAgregarRecurso.Margin = new System.Windows.Forms.Padding(6);
            this.btnAgregarRecurso.Name = "btnAgregarRecurso";
            this.btnAgregarRecurso.Size = new System.Drawing.Size(84, 46);
            this.btnAgregarRecurso.TabIndex = 27;
            this.btnAgregarRecurso.UseVisualStyleBackColor = false;
            this.btnAgregarRecurso.Click += new System.EventHandler(this.btnAgregarRecurso_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEliminar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(2341, 484);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(6);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(84, 46);
            this.btnEliminar.TabIndex = 29;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBajar
            // 
            this.btnBajar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBajar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBajar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnBajar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBajar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBajar.ForeColor = System.Drawing.Color.White;
            this.btnBajar.Image = ((System.Drawing.Image)(resources.GetObject("btnBajar.Image")));
            this.btnBajar.Location = new System.Drawing.Point(2341, 925);
            this.btnBajar.Margin = new System.Windows.Forms.Padding(6);
            this.btnBajar.Name = "btnBajar";
            this.btnBajar.Size = new System.Drawing.Size(84, 46);
            this.btnBajar.TabIndex = 30;
            this.btnBajar.UseVisualStyleBackColor = false;
            // 
            // btnSubir
            // 
            this.btnSubir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubir.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSubir.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSubir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubir.ForeColor = System.Drawing.Color.White;
            this.btnSubir.Image = ((System.Drawing.Image)(resources.GetObject("btnSubir.Image")));
            this.btnSubir.Location = new System.Drawing.Point(2341, 877);
            this.btnSubir.Margin = new System.Windows.Forms.Padding(6);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Size = new System.Drawing.Size(84, 46);
            this.btnSubir.TabIndex = 31;
            this.btnSubir.UseVisualStyleBackColor = false;
            this.btnSubir.Click += new System.EventHandler(this.btnSubir_Click);
            // 
            // cmsMenuColumnas
            // 
            this.cmsMenuColumnas.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.cmsMenuColumnas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmConfigurarGrid});
            this.cmsMenuColumnas.Name = "cmsMenuColumnas";
            this.cmsMenuColumnas.Size = new System.Drawing.Size(241, 40);
            // 
            // tsmConfigurarGrid
            // 
            this.tsmConfigurarGrid.Image = ((System.Drawing.Image)(resources.GetObject("tsmConfigurarGrid.Image")));
            this.tsmConfigurarGrid.Name = "tsmConfigurarGrid";
            this.tsmConfigurarGrid.Size = new System.Drawing.Size(240, 36);
            this.tsmConfigurarGrid.Text = "Congifurar Grid";
            this.tsmConfigurarGrid.Click += new System.EventHandler(this.tsmConfigurarGrid_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.IndianRed;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(28, 568);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(6);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(295, 72);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Tag = "AT";
            this.btnSalir.Text = "&SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.AutoSize = true;
            this.lblTitulo2.Font = new System.Drawing.Font("Perpetua Titling MT", 15.85714F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitulo2.Location = new System.Drawing.Point(94, 473);
            this.lblTitulo2.Name = "lblTitulo2";
            this.lblTitulo2.Size = new System.Drawing.Size(160, 44);
            this.lblTitulo2.TabIndex = 6;
            this.lblTitulo2.Text = "PEDIDO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(123, 344);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblTituloFormulario
            // 
            this.lblTituloFormulario.AutoSize = true;
            this.lblTituloFormulario.Font = new System.Drawing.Font("Perpetua Titling MT", 15.85714F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloFormulario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTituloFormulario.Location = new System.Drawing.Point(94, 429);
            this.lblTituloFormulario.Name = "lblTituloFormulario";
            this.lblTituloFormulario.Size = new System.Drawing.Size(175, 44);
            this.lblTituloFormulario.TabIndex = 5;
            this.lblTituloFormulario.Text = "DETALLE";
            // 
            // FrmPedidoEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(2438, 1098);
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
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmPedidoEdit";
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.FrmPedidoEdit_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidosEdit)).EndInit();
            this.cmsMenuColumnas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.ContextMenuStrip cmsMenuColumnas;
        private System.Windows.Forms.ToolStripMenuItem tsmConfigurarGrid;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblTitulo2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTituloFormulario;
    }
}