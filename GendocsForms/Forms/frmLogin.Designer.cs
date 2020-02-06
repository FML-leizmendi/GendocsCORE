namespace GendocsForms
{
    partial class frmLogin
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
            this.pnlTituloLogin = new System.Windows.Forms.Panel();
            this.pnlPieFormulario = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.chkRecordarUsuario = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRestablecerContraseña = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // pnlTituloLogin
            // 
            this.pnlTituloLogin.BackColor = System.Drawing.Color.DarkGray;
            this.pnlTituloLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTituloLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlTituloLogin.Name = "pnlTituloLogin";
            this.pnlTituloLogin.Size = new System.Drawing.Size(539, 36);
            this.pnlTituloLogin.TabIndex = 0;
            // 
            // pnlPieFormulario
            // 
            this.pnlPieFormulario.BackColor = System.Drawing.Color.DarkGray;
            this.pnlPieFormulario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPieFormulario.Location = new System.Drawing.Point(0, 361);
            this.pnlPieFormulario.Name = "pnlPieFormulario";
            this.pnlPieFormulario.Size = new System.Drawing.Size(539, 49);
            this.pnlPieFormulario.TabIndex = 1;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblUsuario.Location = new System.Drawing.Point(96, 75);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(66, 21);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblContraseña.ForeColor = System.Drawing.Color.Black;
            this.lblContraseña.Location = new System.Drawing.Point(95, 130);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(103, 21);
            this.lblContraseña.TabIndex = 3;
            this.lblContraseña.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(92, 97);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(354, 20);
            this.txtUsuario.TabIndex = 4;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(92, 152);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(354, 20);
            this.txtContraseña.TabIndex = 5;
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.White;
            this.btnIniciar.Location = new System.Drawing.Point(92, 225);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(354, 39);
            this.btnIniciar.TabIndex = 6;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // chkRecordarUsuario
            // 
            this.chkRecordarUsuario.AutoSize = true;
            this.chkRecordarUsuario.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRecordarUsuario.ForeColor = System.Drawing.Color.Black;
            this.chkRecordarUsuario.Location = new System.Drawing.Point(92, 181);
            this.chkRecordarUsuario.Name = "chkRecordarUsuario";
            this.chkRecordarUsuario.Size = new System.Drawing.Size(119, 20);
            this.chkRecordarUsuario.TabIndex = 7;
            this.chkRecordarUsuario.Text = "Recordar Usuario";
            this.chkRecordarUsuario.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(92, 302);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 1);
            this.panel1.TabIndex = 8;
            // 
            // lblRestablecerContraseña
            // 
            this.lblRestablecerContraseña.AutoSize = true;
            this.lblRestablecerContraseña.LinkColor = System.Drawing.Color.Black;
            this.lblRestablecerContraseña.Location = new System.Drawing.Point(206, 326);
            this.lblRestablecerContraseña.Name = "lblRestablecerContraseña";
            this.lblRestablecerContraseña.Size = new System.Drawing.Size(121, 13);
            this.lblRestablecerContraseña.TabIndex = 9;
            this.lblRestablecerContraseña.TabStop = true;
            this.lblRestablecerContraseña.Text = "Restablecer Contraseña";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(539, 410);
            this.Controls.Add(this.lblRestablecerContraseña);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chkRecordarUsuario);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.pnlPieFormulario);
            this.Controls.Add(this.pnlTituloLogin);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Iniciar Sesión";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTituloLogin;
        private System.Windows.Forms.Panel pnlPieFormulario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.CheckBox chkRecordarUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel lblRestablecerContraseña;
    }
}

