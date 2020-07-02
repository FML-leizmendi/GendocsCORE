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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.chkRecordarUsuario = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRestablecerContraseña = new System.Windows.Forms.LinkLabel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlTituloLogin
            // 
            this.pnlTituloLogin.BackColor = System.Drawing.Color.DarkGray;
            this.pnlTituloLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTituloLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlTituloLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlTituloLogin.Name = "pnlTituloLogin";
            this.pnlTituloLogin.Size = new System.Drawing.Size(629, 42);
            this.pnlTituloLogin.TabIndex = 0;
            // 
            // pnlPieFormulario
            // 
            this.pnlPieFormulario.BackColor = System.Drawing.Color.DarkGray;
            this.pnlPieFormulario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPieFormulario.Location = new System.Drawing.Point(0, 375);
            this.pnlPieFormulario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlPieFormulario.Name = "pnlPieFormulario";
            this.pnlPieFormulario.Size = new System.Drawing.Size(629, 76);
            this.pnlPieFormulario.TabIndex = 10;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblUsuario.Location = new System.Drawing.Point(112, 57);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(66, 21);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblContraseña.ForeColor = System.Drawing.Color.Black;
            this.lblContraseña.Location = new System.Drawing.Point(111, 120);
            this.lblContraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(103, 21);
            this.lblContraseña.TabIndex = 3;
            this.lblContraseña.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(107, 82);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(412, 23);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.TextChanged += new System.EventHandler(this.TxtUsuario_TextChanged);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(107, 145);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(412, 23);
            this.txtContraseña.TabIndex = 4;
            this.txtContraseña.TextChanged += new System.EventHandler(this.TxtContraseña_TextChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(107, 230);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(204, 45);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // chkRecordarUsuario
            // 
            this.chkRecordarUsuario.AutoSize = true;
            this.chkRecordarUsuario.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkRecordarUsuario.ForeColor = System.Drawing.Color.Black;
            this.chkRecordarUsuario.Location = new System.Drawing.Point(107, 179);
            this.chkRecordarUsuario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkRecordarUsuario.Name = "chkRecordarUsuario";
            this.chkRecordarUsuario.Size = new System.Drawing.Size(118, 20);
            this.chkRecordarUsuario.TabIndex = 5;
            this.chkRecordarUsuario.Text = "Recordar Usuario";
            this.chkRecordarUsuario.UseVisualStyleBackColor = true;
            this.chkRecordarUsuario.CheckedChanged += new System.EventHandler(this.ChkRecordarUsuario_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(107, 318);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 1);
            this.panel1.TabIndex = 8;
            // 
            // lblRestablecerContraseña
            // 
            this.lblRestablecerContraseña.AutoSize = true;
            this.lblRestablecerContraseña.LinkColor = System.Drawing.Color.Black;
            this.lblRestablecerContraseña.Location = new System.Drawing.Point(240, 346);
            this.lblRestablecerContraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRestablecerContraseña.Name = "lblRestablecerContraseña";
            this.lblRestablecerContraseña.Size = new System.Drawing.Size(130, 15);
            this.lblRestablecerContraseña.TabIndex = 9;
            this.lblRestablecerContraseña.TabStop = true;
            this.lblRestablecerContraseña.Text = "Restablecer Contraseña";
            this.lblRestablecerContraseña.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Gray;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(316, 230);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(204, 45);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(629, 451);
            this.Controls.Add(this.lblRestablecerContraseña);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chkRecordarUsuario);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.pnlPieFormulario);
            this.Controls.Add(this.pnlTituloLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmLogin";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLogin_FormClosing);
            this.Load += new System.EventHandler(this.FrmLogin_Load);
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
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.CheckBox chkRecordarUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel lblRestablecerContraseña;
        private System.Windows.Forms.Button btnCancelar;
    }
}

