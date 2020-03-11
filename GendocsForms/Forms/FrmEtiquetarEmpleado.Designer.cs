namespace GendocsForms
{
    partial class FrmEtiquetarEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEtiquetarEmpleado));
            this.pnlCabecera = new System.Windows.Forms.Panel();
            this.pnlLateral = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pnlBotonera = new System.Windows.Forms.Panel();
            this.lstvDisponibles = new System.Windows.Forms.ListView();
            this.IdEtiqueta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dEtiquetaFML = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstvAsignadas = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cIdEtiqueta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IdEmpleadoFML = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAnadir = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.pnlLateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCabecera
            // 
            this.pnlCabecera.BackColor = System.Drawing.Color.LightBlue;
            this.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabecera.Location = new System.Drawing.Point(0, 0);
            this.pnlCabecera.Name = "pnlCabecera";
            this.pnlCabecera.Size = new System.Drawing.Size(964, 49);
            this.pnlCabecera.TabIndex = 1;
            // 
            // pnlLateral
            // 
            this.pnlLateral.BackColor = System.Drawing.Color.Gray;
            this.pnlLateral.Controls.Add(this.btnSalir);
            this.pnlLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLateral.Location = new System.Drawing.Point(0, 49);
            this.pnlLateral.MaximumSize = new System.Drawing.Size(180, 336);
            this.pnlLateral.MinimumSize = new System.Drawing.Size(180, 336);
            this.pnlLateral.Name = "pnlLateral";
            this.pnlLateral.Size = new System.Drawing.Size(180, 336);
            this.pnlLateral.TabIndex = 2;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(12, 135);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(146, 39);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pnlBotonera
            // 
            this.pnlBotonera.BackColor = System.Drawing.Color.LightBlue;
            this.pnlBotonera.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotonera.Location = new System.Drawing.Point(180, 312);
            this.pnlBotonera.Name = "pnlBotonera";
            this.pnlBotonera.Size = new System.Drawing.Size(784, 39);
            this.pnlBotonera.TabIndex = 7;
            // 
            // lstvDisponibles
            // 
            this.lstvDisponibles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdEtiqueta,
            this.dEtiquetaFML});
            this.lstvDisponibles.FullRowSelect = true;
            this.lstvDisponibles.HideSelection = false;
            this.lstvDisponibles.Location = new System.Drawing.Point(196, 66);
            this.lstvDisponibles.Name = "lstvDisponibles";
            this.lstvDisponibles.Size = new System.Drawing.Size(314, 225);
            this.lstvDisponibles.TabIndex = 8;
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
            // lstvAsignadas
            // 
            this.lstvAsignadas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.cIdEtiqueta,
            this.IdEmpleadoFML});
            this.lstvAsignadas.FullRowSelect = true;
            this.lstvAsignadas.HideSelection = false;
            this.lstvAsignadas.Location = new System.Drawing.Point(622, 66);
            this.lstvAsignadas.Name = "lstvAsignadas";
            this.lstvAsignadas.Size = new System.Drawing.Size(314, 225);
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
            // btnAnadir
            // 
            this.btnAnadir.Image = ((System.Drawing.Image)(resources.GetObject("btnAnadir.Image")));
            this.btnAnadir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnadir.Location = new System.Drawing.Point(516, 146);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(100, 35);
            this.btnAnadir.TabIndex = 10;
            this.btnAnadir.Text = "Añadir";
            this.btnAnadir.UseVisualStyleBackColor = true;
            // 
            // btnQuitar
            // 
            this.btnQuitar.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitar.Image")));
            this.btnQuitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuitar.Location = new System.Drawing.Point(516, 188);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(100, 35);
            this.btnQuitar.TabIndex = 11;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            // 
            // FrmEtiquetarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(964, 351);
            this.Controls.Add(this.btnAnadir);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.lstvAsignadas);
            this.Controls.Add(this.lstvDisponibles);
            this.Controls.Add(this.pnlBotonera);
            this.Controls.Add(this.pnlLateral);
            this.Controls.Add(this.pnlCabecera);
            this.MaximumSize = new System.Drawing.Size(980, 390);
            this.MinimumSize = new System.Drawing.Size(980, 390);
            this.Name = "FrmEtiquetarEmpleado";
            this.Text = "Etiquetar Empleado";
            this.pnlLateral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCabecera;
        private System.Windows.Forms.Panel pnlLateral;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel pnlBotonera;
        private System.Windows.Forms.ListView lstvDisponibles;
        private System.Windows.Forms.ColumnHeader IdEtiqueta;
        private System.Windows.Forms.ColumnHeader dEtiquetaFML;
        private System.Windows.Forms.ListView lstvAsignadas;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader cIdEtiqueta;
        private System.Windows.Forms.ColumnHeader IdEmpleadoFML;
        private System.Windows.Forms.Button btnAnadir;
        private System.Windows.Forms.Button btnQuitar;
    }
}