namespace GendocsForms
{
    partial class FrmPantallaConfPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPantallaConfPedidos));
            this.pnlCabecera = new System.Windows.Forms.Panel();
            this.pnlLateral = new System.Windows.Forms.Panel();
            this.pnlBotonera = new System.Windows.Forms.Panel();
            this.lstvAsignadas = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cIdEtiqueta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IdEmpleadoFML = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstvDisponibles = new System.Windows.Forms.ListView();
            this.IdEtiqueta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dEtiquetaFML = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAnadir = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlCabecera
            // 
            this.pnlCabecera.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabecera.Location = new System.Drawing.Point(0, 0);
            this.pnlCabecera.Name = "pnlCabecera";
            this.pnlCabecera.Size = new System.Drawing.Size(1137, 70);
            this.pnlCabecera.TabIndex = 0;
            // 
            // pnlLateral
            // 
            this.pnlLateral.BackColor = System.Drawing.Color.Gray;
            this.pnlLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLateral.Location = new System.Drawing.Point(0, 70);
            this.pnlLateral.Name = "pnlLateral";
            this.pnlLateral.Size = new System.Drawing.Size(154, 514);
            this.pnlLateral.TabIndex = 1;
            // 
            // pnlBotonera
            // 
            this.pnlBotonera.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlBotonera.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotonera.Location = new System.Drawing.Point(154, 519);
            this.pnlBotonera.Name = "pnlBotonera";
            this.pnlBotonera.Size = new System.Drawing.Size(983, 65);
            this.pnlBotonera.TabIndex = 2;
            // 
            // lstvAsignadas
            // 
            this.lstvAsignadas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.cIdEtiqueta,
            this.IdEmpleadoFML});
            this.lstvAsignadas.FullRowSelect = true;
            this.lstvAsignadas.HideSelection = false;
            this.lstvAsignadas.Location = new System.Drawing.Point(743, 76);
            this.lstvAsignadas.Name = "lstvAsignadas";
            this.lstvAsignadas.Size = new System.Drawing.Size(387, 437);
            this.lstvAsignadas.TabIndex = 9;
            this.lstvAsignadas.UseCompatibleStateImageBehavior = false;
            this.lstvAsignadas.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 0;
            // 
            // cIdEtiqueta
            // 
            this.cIdEtiqueta.DisplayIndex = 2;
            this.cIdEtiqueta.Text = "ASIGNADAS";
            this.cIdEtiqueta.Width = 362;
            // 
            // IdEmpleadoFML
            // 
            this.IdEmpleadoFML.DisplayIndex = 1;
            this.IdEmpleadoFML.Text = "IdEmpleadoFML";
            this.IdEmpleadoFML.Width = 0;
            // 
            // lstvDisponibles
            // 
            this.lstvDisponibles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdEtiqueta,
            this.dEtiquetaFML});
            this.lstvDisponibles.FullRowSelect = true;
            this.lstvDisponibles.HideSelection = false;
            this.lstvDisponibles.Location = new System.Drawing.Point(169, 76);
            this.lstvDisponibles.Name = "lstvDisponibles";
            this.lstvDisponibles.Size = new System.Drawing.Size(387, 437);
            this.lstvDisponibles.TabIndex = 6;
            this.lstvDisponibles.UseCompatibleStateImageBehavior = false;
            this.lstvDisponibles.View = System.Windows.Forms.View.Details;
            // 
            // IdEtiqueta
            // 
            this.IdEtiqueta.Text = "IdEtiqueta";
            this.IdEtiqueta.Width = 0;
            // 
            // dEtiquetaFML
            // 
            this.dEtiquetaFML.Text = "DISPONIBLES";
            this.dEtiquetaFML.Width = 362;
            // 
            // btnAnadir
            // 
            this.btnAnadir.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAnadir.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnAnadir.Image = ((System.Drawing.Image)(resources.GetObject("btnAnadir.Image")));
            this.btnAnadir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnadir.Location = new System.Drawing.Point(562, 260);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(175, 35);
            this.btnAnadir.TabIndex = 7;
            this.btnAnadir.Text = "Añadir";
            this.btnAnadir.UseVisualStyleBackColor = false;
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnQuitar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnQuitar.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitar.Image")));
            this.btnQuitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuitar.Location = new System.Drawing.Point(562, 302);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(175, 35);
            this.btnQuitar.TabIndex = 8;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = false;
            // 
            // FrmPantallaConfPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1137, 584);
            this.Controls.Add(this.lstvAsignadas);
            this.Controls.Add(this.lstvDisponibles);
            this.Controls.Add(this.btnAnadir);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.pnlBotonera);
            this.Controls.Add(this.pnlLateral);
            this.Controls.Add(this.pnlCabecera);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPantallaConfPedidos";
            this.Text = "Pantalla Config. Pedidos";
            this.Load += new System.EventHandler(this.FrmPantallaConfPedidos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCabecera;
        private System.Windows.Forms.Panel pnlLateral;
        private System.Windows.Forms.Panel pnlBotonera;
        private System.Windows.Forms.ListView lstvAsignadas;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader cIdEtiqueta;
        private System.Windows.Forms.ColumnHeader IdEmpleadoFML;
        private System.Windows.Forms.ListView lstvDisponibles;
        private System.Windows.Forms.ColumnHeader IdEtiqueta;
        private System.Windows.Forms.ColumnHeader dEtiquetaFML;
        private System.Windows.Forms.Button btnAnadir;
        private System.Windows.Forms.Button btnQuitar;
    }
}