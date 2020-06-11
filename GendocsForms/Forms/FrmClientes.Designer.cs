namespace GendocsForms.Forms
{
    partial class FrmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientes));
            this.grbClientes = new System.Windows.Forms.GroupBox();
            this.txtNuevoCliente = new System.Windows.Forms.TextBox();
            this.pcEliminarCliente = new System.Windows.Forms.PictureBox();
            this.pbAgregarCliente = new System.Windows.Forms.PictureBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.pbCarpeta = new System.Windows.Forms.PictureBox();
            this.txtProyecto = new System.Windows.Forms.TextBox();
            this.lblProyecto = new System.Windows.Forms.Label();
            this.CarpetaBaseProyectos = new System.Windows.Forms.TextBox();
            this.lblCarpeta = new System.Windows.Forms.Label();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.grbDetalleCliente = new System.Windows.Forms.GroupBox();
            this.pbEditarUsuario = new System.Windows.Forms.PictureBox();
            this.PbAgregarUsuario = new System.Windows.Forms.PictureBox();
            this.PbEliminarUsuario = new System.Windows.Forms.PictureBox();
            this.PbExpandirContraer = new System.Windows.Forms.PictureBox();
            this.tvClientes = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grbClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcEliminarCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgregarCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarpeta)).BeginInit();
            this.grbDetalleCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditarUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbAgregarUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbEliminarUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbExpandirContraer)).BeginInit();
            this.SuspendLayout();
            // 
            // grbClientes
            // 
            this.grbClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbClientes.BackColor = System.Drawing.SystemColors.Control;
            this.grbClientes.Controls.Add(this.txtNuevoCliente);
            this.grbClientes.Controls.Add(this.pcEliminarCliente);
            this.grbClientes.Controls.Add(this.pbAgregarCliente);
            this.grbClientes.Controls.Add(this.txtNombreCliente);
            this.grbClientes.Controls.Add(this.pbCarpeta);
            this.grbClientes.Controls.Add(this.txtProyecto);
            this.grbClientes.Controls.Add(this.lblProyecto);
            this.grbClientes.Controls.Add(this.CarpetaBaseProyectos);
            this.grbClientes.Controls.Add(this.lblCarpeta);
            this.grbClientes.Controls.Add(this.cmbClientes);
            this.grbClientes.Controls.Add(this.lblCliente);
            this.grbClientes.Location = new System.Drawing.Point(181, 60);
            this.grbClientes.Name = "grbClientes";
            this.grbClientes.Size = new System.Drawing.Size(873, 111);
            this.grbClientes.TabIndex = 2;
            this.grbClientes.TabStop = false;
            this.grbClientes.Tag = "";
            this.grbClientes.Text = "Clientes";
            // 
            // txtNuevoCliente
            // 
            this.txtNuevoCliente.Location = new System.Drawing.Point(25, 40);
            this.txtNuevoCliente.Name = "txtNuevoCliente";
            this.txtNuevoCliente.Size = new System.Drawing.Size(180, 20);
            this.txtNuevoCliente.TabIndex = 1;
            this.txtNuevoCliente.Tag = "";
            this.txtNuevoCliente.Visible = false;
            this.txtNuevoCliente.Leave += new System.EventHandler(this.TxtNuevoCliente_Leave);
            // 
            // pcEliminarCliente
            // 
            this.pcEliminarCliente.BackColor = System.Drawing.Color.LightBlue;
            this.pcEliminarCliente.Image = ((System.Drawing.Image)(resources.GetObject("pcEliminarCliente.Image")));
            this.pcEliminarCliente.Location = new System.Drawing.Point(572, 34);
            this.pcEliminarCliente.Name = "pcEliminarCliente";
            this.pcEliminarCliente.Size = new System.Drawing.Size(34, 25);
            this.pcEliminarCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcEliminarCliente.TabIndex = 14;
            this.pcEliminarCliente.TabStop = false;
            this.toolTip1.SetToolTip(this.pcEliminarCliente, "Eliminar un cliente");
            this.pcEliminarCliente.Click += new System.EventHandler(this.PbEliminarCliente_Click);
            // 
            // pbAgregarCliente
            // 
            this.pbAgregarCliente.BackColor = System.Drawing.Color.LightBlue;
            this.pbAgregarCliente.Image = ((System.Drawing.Image)(resources.GetObject("pbAgregarCliente.Image")));
            this.pbAgregarCliente.Location = new System.Drawing.Point(534, 34);
            this.pbAgregarCliente.Name = "pbAgregarCliente";
            this.pbAgregarCliente.Size = new System.Drawing.Size(34, 25);
            this.pbAgregarCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAgregarCliente.TabIndex = 13;
            this.pbAgregarCliente.TabStop = false;
            this.toolTip1.SetToolTip(this.pbAgregarCliente, "Añadir un nuevo cliente");
            this.pbAgregarCliente.Click += new System.EventHandler(this.PbAgregarCliente_Click);
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(211, 38);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(321, 20);
            this.txtNombreCliente.TabIndex = 3;
            this.txtNombreCliente.Tag = "paramUS010";
            this.txtNombreCliente.Leave += new System.EventHandler(this.TxtNombreCliente_Leave);
            // 
            // pbCarpeta
            // 
            this.pbCarpeta.BackColor = System.Drawing.Color.LightBlue;
            this.pbCarpeta.Image = ((System.Drawing.Image)(resources.GetObject("pbCarpeta.Image")));
            this.pbCarpeta.Location = new System.Drawing.Point(823, 81);
            this.pbCarpeta.Name = "pbCarpeta";
            this.pbCarpeta.Size = new System.Drawing.Size(34, 25);
            this.pbCarpeta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbCarpeta.TabIndex = 11;
            this.pbCarpeta.TabStop = false;
            this.pbCarpeta.Click += new System.EventHandler(this.PbCarpeta_Click);
            // 
            // txtProyecto
            // 
            this.txtProyecto.Location = new System.Drawing.Point(211, 85);
            this.txtProyecto.Name = "txtProyecto";
            this.txtProyecto.Size = new System.Drawing.Size(612, 20);
            this.txtProyecto.TabIndex = 7;
            this.txtProyecto.Tag = "paramUS010";
            // 
            // lblProyecto
            // 
            this.lblProyecto.AutoSize = true;
            this.lblProyecto.Location = new System.Drawing.Point(208, 70);
            this.lblProyecto.Name = "lblProyecto";
            this.lblProyecto.Size = new System.Drawing.Size(49, 13);
            this.lblProyecto.TabIndex = 6;
            this.lblProyecto.Text = "Proyecto";
            // 
            // CarpetaBaseProyectos
            // 
            this.CarpetaBaseProyectos.Location = new System.Drawing.Point(25, 85);
            this.CarpetaBaseProyectos.Name = "CarpetaBaseProyectos";
            this.CarpetaBaseProyectos.Size = new System.Drawing.Size(180, 20);
            this.CarpetaBaseProyectos.TabIndex = 5;
            this.CarpetaBaseProyectos.Tag = "paramUS010";
            // 
            // lblCarpeta
            // 
            this.lblCarpeta.AutoSize = true;
            this.lblCarpeta.Location = new System.Drawing.Point(22, 70);
            this.lblCarpeta.Name = "lblCarpeta";
            this.lblCarpeta.Size = new System.Drawing.Size(44, 13);
            this.lblCarpeta.TabIndex = 4;
            this.lblCarpeta.Text = "Carpeta";
            // 
            // cmbClientes
            // 
            this.cmbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClientes.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(25, 37);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(180, 25);
            this.cmbClientes.TabIndex = 2;
            this.cmbClientes.SelectedIndexChanged += new System.EventHandler(this.CmbClientes_SelectedIndexChanged);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(22, 18);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(46, 16);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente";
            // 
            // grbDetalleCliente
            // 
            this.grbDetalleCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbDetalleCliente.Controls.Add(this.pbEditarUsuario);
            this.grbDetalleCliente.Controls.Add(this.PbAgregarUsuario);
            this.grbDetalleCliente.Controls.Add(this.PbEliminarUsuario);
            this.grbDetalleCliente.Controls.Add(this.PbExpandirContraer);
            this.grbDetalleCliente.Controls.Add(this.tvClientes);
            this.grbDetalleCliente.Location = new System.Drawing.Point(181, 177);
            this.grbDetalleCliente.Name = "grbDetalleCliente";
            this.grbDetalleCliente.Size = new System.Drawing.Size(873, 409);
            this.grbDetalleCliente.TabIndex = 3;
            this.grbDetalleCliente.TabStop = false;
            // 
            // pbEditarUsuario
            // 
            this.pbEditarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbEditarUsuario.BackColor = System.Drawing.Color.LightBlue;
            this.pbEditarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("pbEditarUsuario.Image")));
            this.pbEditarUsuario.Location = new System.Drawing.Point(829, 81);
            this.pbEditarUsuario.Name = "pbEditarUsuario";
            this.pbEditarUsuario.Size = new System.Drawing.Size(34, 25);
            this.pbEditarUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbEditarUsuario.TabIndex = 15;
            this.pbEditarUsuario.TabStop = false;
            this.toolTip1.SetToolTip(this.pbEditarUsuario, "Expandir / Contraer Arbol ");
            this.pbEditarUsuario.Click += new System.EventHandler(this.PbEditarUsuario_Click);
            // 
            // PbAgregarUsuario
            // 
            this.PbAgregarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PbAgregarUsuario.BackColor = System.Drawing.Color.LightBlue;
            this.PbAgregarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("PbAgregarUsuario.Image")));
            this.PbAgregarUsuario.Location = new System.Drawing.Point(829, 19);
            this.PbAgregarUsuario.Name = "PbAgregarUsuario";
            this.PbAgregarUsuario.Size = new System.Drawing.Size(34, 25);
            this.PbAgregarUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PbAgregarUsuario.TabIndex = 14;
            this.PbAgregarUsuario.TabStop = false;
            this.toolTip1.SetToolTip(this.PbAgregarUsuario, "Expandir / Contraer Arbol ");
            this.PbAgregarUsuario.Click += new System.EventHandler(this.PbAgregarUsuario_Click);
            // 
            // PbEliminarUsuario
            // 
            this.PbEliminarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PbEliminarUsuario.BackColor = System.Drawing.Color.LightBlue;
            this.PbEliminarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("PbEliminarUsuario.Image")));
            this.PbEliminarUsuario.Location = new System.Drawing.Point(829, 50);
            this.PbEliminarUsuario.Name = "PbEliminarUsuario";
            this.PbEliminarUsuario.Size = new System.Drawing.Size(34, 25);
            this.PbEliminarUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PbEliminarUsuario.TabIndex = 13;
            this.PbEliminarUsuario.TabStop = false;
            this.toolTip1.SetToolTip(this.PbEliminarUsuario, "Expandir / Contraer Arbol ");
            this.PbEliminarUsuario.Click += new System.EventHandler(this.PbEliminarUsuario_Click);
            // 
            // PbExpandirContraer
            // 
            this.PbExpandirContraer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PbExpandirContraer.BackColor = System.Drawing.Color.LightBlue;
            this.PbExpandirContraer.Image = ((System.Drawing.Image)(resources.GetObject("PbExpandirContraer.Image")));
            this.PbExpandirContraer.Location = new System.Drawing.Point(829, 378);
            this.PbExpandirContraer.Name = "PbExpandirContraer";
            this.PbExpandirContraer.Size = new System.Drawing.Size(34, 25);
            this.PbExpandirContraer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PbExpandirContraer.TabIndex = 12;
            this.PbExpandirContraer.TabStop = false;
            this.toolTip1.SetToolTip(this.PbExpandirContraer, "Expandir / Contraer Arbol ");
            this.PbExpandirContraer.Click += new System.EventHandler(this.PbExpandirContraer_Click);
            // 
            // tvClientes
            // 
            this.tvClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvClientes.Location = new System.Drawing.Point(15, 19);
            this.tvClientes.Name = "tvClientes";
            this.tvClientes.Size = new System.Drawing.Size(808, 384);
            this.tvClientes.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1066, 54);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(175, 597);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(175, 592);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(891, 59);
            this.panel3.TabIndex = 4;
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1066, 651);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grbDetalleCliente);
            this.Controls.Add(this.grbClientes);
            this.Name = "FrmClientes";
            this.Text = "Clientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmClientes_FormClosing);
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            this.grbClientes.ResumeLayout(false);
            this.grbClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcEliminarCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgregarCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarpeta)).EndInit();
            this.grbDetalleCliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbEditarUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbAgregarUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbEliminarUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbExpandirContraer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbClientes;
        private System.Windows.Forms.GroupBox grbDetalleCliente;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtProyecto;
        private System.Windows.Forms.Label lblProyecto;
        private System.Windows.Forms.TextBox CarpetaBaseProyectos;
        private System.Windows.Forms.Label lblCarpeta;
        private System.Windows.Forms.PictureBox pbCarpeta;
        private System.Windows.Forms.TreeView tvClientes;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox PbExpandirContraer;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox PbAgregarUsuario;
        private System.Windows.Forms.PictureBox PbEliminarUsuario;
        private System.Windows.Forms.PictureBox pbEditarUsuario;
        private System.Windows.Forms.PictureBox pcEliminarCliente;
        private System.Windows.Forms.PictureBox pbAgregarCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtNuevoCliente;
    }
}