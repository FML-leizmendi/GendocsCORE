namespace GendocsForms
{
    partial class FrmPedidosEntrantes
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedidosEntrantes));
            this.pnlTituloLogin = new System.Windows.Forms.Panel();
            this.pnlPieFormulario = new System.Windows.Forms.Panel();
            this.btnProcesarPedido = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lstvDisponibles = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cIdEtiqueta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IdEmpleadoFML = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pbTrello = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrello)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTituloLogin
            // 
            this.pnlTituloLogin.BackColor = System.Drawing.Color.DarkGray;
            this.pnlTituloLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTituloLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlTituloLogin.Name = "pnlTituloLogin";
            this.pnlTituloLogin.Size = new System.Drawing.Size(503, 36);
            this.pnlTituloLogin.TabIndex = 0;
            // 
            // pnlPieFormulario
            // 
            this.pnlPieFormulario.BackColor = System.Drawing.Color.DarkGray;
            this.pnlPieFormulario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPieFormulario.Location = new System.Drawing.Point(0, 274);
            this.pnlPieFormulario.Name = "pnlPieFormulario";
            this.pnlPieFormulario.Size = new System.Drawing.Size(503, 66);
            this.pnlPieFormulario.TabIndex = 10;
            // 
            // btnProcesarPedido
            // 
            this.btnProcesarPedido.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnProcesarPedido.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnProcesarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcesarPedido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesarPedido.ForeColor = System.Drawing.Color.White;
            this.btnProcesarPedido.Location = new System.Drawing.Point(236, 229);
            this.btnProcesarPedido.Name = "btnProcesarPedido";
            this.btnProcesarPedido.Size = new System.Drawing.Size(255, 39);
            this.btnProcesarPedido.TabIndex = 6;
            this.btnProcesarPedido.Text = "&Procesar Pedido";
            this.btnProcesarPedido.UseVisualStyleBackColor = false;
            this.btnProcesarPedido.Click += new System.EventHandler(this.BtnProcesarPedido_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Gray;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(12, 229);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(163, 39);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // lstvDisponibles
            // 
            this.lstvDisponibles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.cIdEtiqueta,
            this.IdEmpleadoFML});
            this.lstvDisponibles.FullRowSelect = true;
            this.lstvDisponibles.HideSelection = false;
            this.lstvDisponibles.Location = new System.Drawing.Point(12, 42);
            this.lstvDisponibles.Name = "lstvDisponibles";
            this.lstvDisponibles.Size = new System.Drawing.Size(479, 181);
            this.lstvDisponibles.TabIndex = 13;
            this.lstvDisponibles.UseCompatibleStateImageBehavior = false;
            this.lstvDisponibles.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 0;
            // 
            // cIdEtiqueta
            // 
            this.cIdEtiqueta.DisplayIndex = 2;
            this.cIdEtiqueta.Text = "PEDIDOS DISPONIBLES";
            this.cIdEtiqueta.Width = 478;
            // 
            // IdEmpleadoFML
            // 
            this.IdEmpleadoFML.DisplayIndex = 1;
            this.IdEmpleadoFML.Text = "IdEmpleadoFML";
            this.IdEmpleadoFML.Width = 0;
            // 
            // pbTrello
            // 
            this.pbTrello.Image = ((System.Drawing.Image)(resources.GetObject("pbTrello.Image")));
            this.pbTrello.Location = new System.Drawing.Point(181, 229);
            this.pbTrello.Name = "pbTrello";
            this.pbTrello.Size = new System.Drawing.Size(49, 39);
            this.pbTrello.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTrello.TabIndex = 14;
            this.pbTrello.TabStop = false;
            this.pbTrello.Click += new System.EventHandler(this.PbTrello_Click);
            // 
            // FrmPedidosEntrantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(503, 340);
            this.Controls.Add(this.pbTrello);
            this.Controls.Add(this.lstvDisponibles);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnProcesarPedido);
            this.Controls.Add(this.pnlPieFormulario);
            this.Controls.Add(this.pnlTituloLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmPedidosEntrantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedidos Entrantes";
            this.Load += new System.EventHandler(this.FrmPedidosEntrantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbTrello)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTituloLogin;
        private System.Windows.Forms.Panel pnlPieFormulario;
        private System.Windows.Forms.Button btnProcesarPedido;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ListView lstvDisponibles;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader cIdEtiqueta;
        private System.Windows.Forms.ColumnHeader IdEmpleadoFML;
        private System.Windows.Forms.PictureBox pbTrello;
    }
}

