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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRecursos));
            this.pnlCabercera = new System.Windows.Forms.Panel();
            this.pnlLateral = new System.Windows.Forms.Panel();
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEliminarEmpleado = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
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
            this.btnProhibidos = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pnlLateral.SuspendLayout();
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
            this.pnlCabercera.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlCabercera.Name = "pnlCabercera";
            this.pnlCabercera.Size = new System.Drawing.Size(2229, 92);
            this.pnlCabercera.TabIndex = 0;
            // 
            // pnlLateral
            // 
            this.pnlLateral.BackColor = System.Drawing.Color.Gray;
            this.pnlLateral.Controls.Add(this.textBox1);
            this.pnlLateral.Controls.Add(this.btnProhibidos);
            this.pnlLateral.Controls.Add(this.btnLimpiarFiltros);
            this.pnlLateral.Controls.Add(this.btnNuevo);
            this.pnlLateral.Controls.Add(this.btnEliminarEmpleado);
            this.pnlLateral.Controls.Add(this.btnModificar);
            this.pnlLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLateral.Location = new System.Drawing.Point(0, 92);
            this.pnlLateral.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlLateral.Name = "pnlLateral";
            this.pnlLateral.Size = new System.Drawing.Size(339, 1174);
            this.pnlLateral.TabIndex = 1;
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.BackColor = System.Drawing.Color.LightBlue;
            this.btnLimpiarFiltros.FlatAppearance.BorderSize = 0;
            this.btnLimpiarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarFiltros.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarFiltros.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiarFiltros.Image")));
            this.btnLimpiarFiltros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(26, 659);
            this.btnLimpiarFiltros.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(295, 72);
            this.btnLimpiarFiltros.TabIndex = 6;
            this.btnLimpiarFiltros.Text = "   LIMPIAR FILTROS";
            this.btnLimpiarFiltros.UseVisualStyleBackColor = false;
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.btnLimpiarFiltros_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.LightBlue;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(26, 410);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(295, 72);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = false;
            // 
            // btnEliminarEmpleado
            // 
            this.btnEliminarEmpleado.BackColor = System.Drawing.Color.LightBlue;
            this.btnEliminarEmpleado.FlatAppearance.BorderSize = 0;
            this.btnEliminarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarEmpleado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarEmpleado.Image")));
            this.btnEliminarEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarEmpleado.Location = new System.Drawing.Point(26, 576);
            this.btnEliminarEmpleado.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            this.btnEliminarEmpleado.Size = new System.Drawing.Size(295, 72);
            this.btnEliminarEmpleado.TabIndex = 5;
            this.btnEliminarEmpleado.Text = "ELIMINAR";
            this.btnEliminarEmpleado.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.LightBlue;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(26, 493);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(295, 72);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // grbRecursos
            // 
            this.grbRecursos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbRecursos.Controls.Add(this.txtIntroduzcaTexto);
            this.grbRecursos.Controls.Add(this.lblTexto);
            this.grbRecursos.Controls.Add(this.cmbActivos);
            this.grbRecursos.Controls.Add(this.lblActivo);
            this.grbRecursos.Controls.Add(this.cmbArea);
            this.grbRecursos.Controls.Add(this.lblArea);
            this.grbRecursos.Controls.Add(this.cmbClientes);
            this.grbRecursos.Controls.Add(this.lblCliente);
            this.grbRecursos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbRecursos.Location = new System.Drawing.Point(350, 103);
            this.grbRecursos.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grbRecursos.Name = "grbRecursos";
            this.grbRecursos.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grbRecursos.Size = new System.Drawing.Size(1879, 138);
            this.grbRecursos.TabIndex = 2;
            this.grbRecursos.TabStop = false;
            this.grbRecursos.Text = "Recursos";
            // 
            // txtIntroduzcaTexto
            // 
            this.txtIntroduzcaTexto.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtIntroduzcaTexto.Location = new System.Drawing.Point(51, 65);
            this.txtIntroduzcaTexto.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtIntroduzcaTexto.Name = "txtIntroduzcaTexto";
            this.txtIntroduzcaTexto.Size = new System.Drawing.Size(466, 35);
            this.txtIntroduzcaTexto.TabIndex = 7;
            this.txtIntroduzcaTexto.TextChanged += new System.EventHandler(this.txtIntroduzcaTexto_TextChanged);
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.Location = new System.Drawing.Point(57, 31);
            this.lblTexto.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(201, 23);
            this.lblTexto.TabIndex = 6;
            this.lblTexto.Text = "Introduzca un texto";
            // 
            // cmbActivos
            // 
            this.cmbActivos.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmbActivos.FormattingEnabled = true;
            this.cmbActivos.Location = new System.Drawing.Point(1327, 61);
            this.cmbActivos.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmbActivos.Name = "cmbActivos";
            this.cmbActivos.Size = new System.Drawing.Size(499, 35);
            this.cmbActivos.TabIndex = 5;
            this.cmbActivos.SelectedIndexChanged += new System.EventHandler(this.cmbActivos_SelectedIndexChanged);
            // 
            // lblActivo
            // 
            this.lblActivo.AutoSize = true;
            this.lblActivo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivo.Location = new System.Drawing.Point(1322, 31);
            this.lblActivo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblActivo.Name = "lblActivo";
            this.lblActivo.Size = new System.Drawing.Size(74, 23);
            this.lblActivo.TabIndex = 4;
            this.lblActivo.Text = "Activo";
            // 
            // cmbArea
            // 
            this.cmbArea.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Location = new System.Drawing.Point(860, 61);
            this.cmbArea.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(446, 35);
            this.cmbArea.TabIndex = 3;
            this.cmbArea.SelectedIndexChanged += new System.EventHandler(this.cmbArea_SelectedIndexChanged);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(854, 31);
            this.lblArea.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(58, 23);
            this.lblArea.TabIndex = 2;
            this.lblArea.Text = "Área";
            // 
            // cmbClientes
            // 
            this.cmbClientes.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(539, 61);
            this.cmbClientes.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(299, 35);
            this.cmbClientes.TabIndex = 1;
            this.cmbClientes.SelectedIndexChanged += new System.EventHandler(this.cmbClientes_SelectedIndexChanged);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(534, 31);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(79, 23);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente";
            // 
            // dgvRecursos
            // 
            this.dgvRecursos.AllowUserToAddRows = false;
            this.dgvRecursos.AllowUserToDeleteRows = false;
            this.dgvRecursos.AllowUserToOrderColumns = true;
            this.dgvRecursos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRecursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecursos.Location = new System.Drawing.Point(350, 253);
            this.dgvRecursos.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgvRecursos.Name = "dgvRecursos";
            this.dgvRecursos.ReadOnly = true;
            this.dgvRecursos.RowHeadersWidth = 72;
            this.dgvRecursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecursos.Size = new System.Drawing.Size(1879, 951);
            this.dgvRecursos.TabIndex = 3;
            // 
            // pnlBotonera
            // 
            this.pnlBotonera.Controls.Add(this.flowLayoutPanel1);
            this.pnlBotonera.Location = new System.Drawing.Point(350, 1215);
            this.pnlBotonera.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlBotonera.Name = "pnlBotonera";
            this.pnlBotonera.Size = new System.Drawing.Size(1879, 89);
            this.pnlBotonera.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1866, 78);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnProhibidos
            // 
            this.btnProhibidos.BackColor = System.Drawing.Color.LightBlue;
            this.btnProhibidos.FlatAppearance.BorderSize = 0;
            this.btnProhibidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProhibidos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProhibidos.Image = ((System.Drawing.Image)(resources.GetObject("btnProhibidos.Image")));
            this.btnProhibidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProhibidos.Location = new System.Drawing.Point(26, 743);
            this.btnProhibidos.Margin = new System.Windows.Forms.Padding(6);
            this.btnProhibidos.Name = "btnProhibidos";
            this.btnProhibidos.Size = new System.Drawing.Size(295, 72);
            this.btnProhibidos.TabIndex = 7;
            this.btnProhibidos.Text = "    MOSTRAR PROHIBIDOS";
            this.btnProhibidos.UseVisualStyleBackColor = false;
            this.btnProhibidos.Click += new System.EventHandler(this.btnProhibidos_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(35, 317);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 29);
            this.textBox1.TabIndex = 8;
            // 
            // FrmRecursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(2229, 1266);
            this.Controls.Add(this.pnlBotonera);
            this.Controls.Add(this.dgvRecursos);
            this.Controls.Add(this.grbRecursos);
            this.Controls.Add(this.pnlLateral);
            this.Controls.Add(this.pnlCabercera);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximumSize = new System.Drawing.Size(2253, 1330);
            this.MinimumSize = new System.Drawing.Size(2253, 1330);
            this.Name = "FrmRecursos";
            this.Text = "Recursos";
            this.Load += new System.EventHandler(this.FrmRecursos_Load);
            this.pnlLateral.ResumeLayout(false);
            this.pnlLateral.PerformLayout();
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
        private System.Windows.Forms.TextBox textBox1;
    }
}