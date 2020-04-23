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
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            this.cmbEstadoProyecto = new System.Windows.Forms.ComboBox();
            this.lblEstadoProyecto = new System.Windows.Forms.Label();
            this.txtIntroduzcaTexto = new System.Windows.Forms.TextBox();
            this.lblTexto = new System.Windows.Forms.Label();
            this.dgvProyectos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlLateral.SuspendLayout();
            this.grbProyectos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProyectos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.pnlLateral.Location = new System.Drawing.Point(0, 0);
            this.pnlLateral.Name = "pnlLateral";
            this.pnlLateral.Size = new System.Drawing.Size(195, 725);
            this.pnlLateral.TabIndex = 0;
            // 
            // btnTodos
            // 
            this.btnTodos.BackColor = System.Drawing.Color.Yellow;
            this.btnTodos.FlatAppearance.BorderSize = 0;
            this.btnTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodos.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodos.Location = new System.Drawing.Point(16, 271);
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
            this.btnOtros.Location = new System.Drawing.Point(16, 521);
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
            this.btnCartografia.Location = new System.Drawing.Point(16, 470);
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
            this.btnBajaTension.Location = new System.Drawing.Point(16, 421);
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
            this.btnMediaTension.Location = new System.Drawing.Point(16, 370);
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
            this.btnAT.Location = new System.Drawing.Point(16, 319);
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
            this.pnlCabercera.Location = new System.Drawing.Point(0, 0);
            this.pnlCabercera.Name = "pnlCabercera";
            this.pnlCabercera.Size = new System.Drawing.Size(1244, 62);
            this.pnlCabercera.TabIndex = 0;
            // 
            // grbProyectos
            // 
            this.grbProyectos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbProyectos.Controls.Add(this.pictureBox1);
            this.grbProyectos.Controls.Add(this.btnLimpiarFiltros);
            this.grbProyectos.Controls.Add(this.cmbEstadoProyecto);
            this.grbProyectos.Controls.Add(this.lblEstadoProyecto);
            this.grbProyectos.Controls.Add(this.txtIntroduzcaTexto);
            this.grbProyectos.Controls.Add(this.lblTexto);
            this.grbProyectos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbProyectos.Location = new System.Drawing.Point(201, 63);
            this.grbProyectos.Name = "grbProyectos";
            this.grbProyectos.Size = new System.Drawing.Size(1034, 68);
            this.grbProyectos.TabIndex = 2;
            this.grbProyectos.TabStop = false;
            this.grbProyectos.Text = "Proyectos";
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.BackColor = System.Drawing.Color.LightBlue;
            this.btnLimpiarFiltros.FlatAppearance.BorderSize = 0;
            this.btnLimpiarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarFiltros.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarFiltros.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiarFiltros.Image")));
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(497, 38);
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
            this.cmbEstadoProyecto.Location = new System.Drawing.Point(330, 36);
            this.cmbEstadoProyecto.Name = "cmbEstadoProyecto";
            this.cmbEstadoProyecto.Size = new System.Drawing.Size(163, 25);
            this.cmbEstadoProyecto.TabIndex = 2;
            this.cmbEstadoProyecto.SelectedIndexChanged += new System.EventHandler(this.cmbEstadoProyecto_SelectedIndexChanged);
            // 
            // lblEstadoProyecto
            // 
            this.lblEstadoProyecto.AutoSize = true;
            this.lblEstadoProyecto.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoProyecto.Location = new System.Drawing.Point(328, 20);
            this.lblEstadoProyecto.Name = "lblEstadoProyecto";
            this.lblEstadoProyecto.Size = new System.Drawing.Size(116, 16);
            this.lblEstadoProyecto.TabIndex = 2;
            this.lblEstadoProyecto.Text = "Estado del Proyecto";
            // 
            // txtIntroduzcaTexto
            // 
            this.txtIntroduzcaTexto.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtIntroduzcaTexto.Location = new System.Drawing.Point(38, 36);
            this.txtIntroduzcaTexto.Name = "txtIntroduzcaTexto";
            this.txtIntroduzcaTexto.Size = new System.Drawing.Size(287, 23);
            this.txtIntroduzcaTexto.TabIndex = 1;
            this.txtIntroduzcaTexto.TextChanged += new System.EventHandler(this.txtIntroduzcaTexto_TextChanged);
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.Location = new System.Drawing.Point(36, 20);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(115, 16);
            this.lblTexto.TabIndex = 0;
            this.lblTexto.Text = "Introduzca un texto";
            // 
            // dgvProyectos
            // 
            this.dgvProyectos.AllowUserToOrderColumns = true;
            this.dgvProyectos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProyectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProyectos.Location = new System.Drawing.Point(201, 137);
            this.dgvProyectos.Name = "dgvProyectos";
            this.dgvProyectos.RowHeadersWidth = 82;
            this.dgvProyectos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProyectos.Size = new System.Drawing.Size(1034, 529);
            this.dgvProyectos.TabIndex = 3;
            this.dgvProyectos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProyectos_CellContentDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(201, 671);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1035, 53);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(988, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 37);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmListaProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1244, 725);
            this.Controls.Add(this.panel1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLimpiarFiltros;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}