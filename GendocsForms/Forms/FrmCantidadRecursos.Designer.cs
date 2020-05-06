namespace GendocsForms
{
    partial class FrmCantidadRecursos
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
            this.pnlCabecera = new System.Windows.Forms.Panel();
            this.pnlLateral = new System.Windows.Forms.Panel();
            this.pnlBotonera = new System.Windows.Forms.Panel();
            this.lblIntroduzcaCantidad = new System.Windows.Forms.Label();
            this.txtCantidadRecursos = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlCabecera
            // 
            this.pnlCabecera.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabecera.Location = new System.Drawing.Point(0, 0);
            this.pnlCabecera.Name = "pnlCabecera";
            this.pnlCabecera.Size = new System.Drawing.Size(724, 46);
            this.pnlCabecera.TabIndex = 0;
            // 
            // pnlLateral
            // 
            this.pnlLateral.BackColor = System.Drawing.Color.Gray;
            this.pnlLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLateral.Location = new System.Drawing.Point(0, 46);
            this.pnlLateral.Name = "pnlLateral";
            this.pnlLateral.Size = new System.Drawing.Size(64, 202);
            this.pnlLateral.TabIndex = 1;
            // 
            // pnlBotonera
            // 
            this.pnlBotonera.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlBotonera.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotonera.Location = new System.Drawing.Point(64, 207);
            this.pnlBotonera.Name = "pnlBotonera";
            this.pnlBotonera.Size = new System.Drawing.Size(660, 41);
            this.pnlBotonera.TabIndex = 1;
            // 
            // lblIntroduzcaCantidad
            // 
            this.lblIntroduzcaCantidad.AutoSize = true;
            this.lblIntroduzcaCantidad.Location = new System.Drawing.Point(115, 96);
            this.lblIntroduzcaCantidad.Name = "lblIntroduzcaCantidad";
            this.lblIntroduzcaCantidad.Size = new System.Drawing.Size(187, 25);
            this.lblIntroduzcaCantidad.TabIndex = 2;
            this.lblIntroduzcaCantidad.Text = "Introduzca Cantidad";
            // 
            // txtCantidadRecursos
            // 
            this.txtCantidadRecursos.Location = new System.Drawing.Point(120, 124);
            this.txtCantidadRecursos.Name = "txtCantidadRecursos";
            this.txtCantidadRecursos.Size = new System.Drawing.Size(182, 29);
            this.txtCantidadRecursos.TabIndex = 3;
            this.txtCantidadRecursos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadRecursos_KeyPress);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(376, 96);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(6);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(321, 72);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // FrmCantidadRecursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(724, 248);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtCantidadRecursos);
            this.Controls.Add(this.lblIntroduzcaCantidad);
            this.Controls.Add(this.pnlBotonera);
            this.Controls.Add(this.pnlLateral);
            this.Controls.Add(this.pnlCabecera);
            this.Name = "FrmCantidadRecursos";
            this.Text = "Cantidad Recursos";
            this.Load += new System.EventHandler(this.FrmCantidadRecursos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCabecera;
        private System.Windows.Forms.Panel pnlLateral;
        private System.Windows.Forms.Panel pnlBotonera;
        private System.Windows.Forms.Label lblIntroduzcaCantidad;
        private System.Windows.Forms.TextBox txtCantidadRecursos;
        private System.Windows.Forms.Button btnAceptar;
    }
}