namespace GendocsForms
{
    partial class FrmInputBox
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
            this.lblIntroduzcaCantidad = new System.Windows.Forms.Label();
            this.txtCantidadRecursos = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIntroduzcaCantidad
            // 
            this.lblIntroduzcaCantidad.AutoSize = true;
            this.lblIntroduzcaCantidad.Location = new System.Drawing.Point(63, 52);
            this.lblIntroduzcaCantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIntroduzcaCantidad.Name = "lblIntroduzcaCantidad";
            this.lblIntroduzcaCantidad.Size = new System.Drawing.Size(102, 13);
            this.lblIntroduzcaCantidad.TabIndex = 2;
            this.lblIntroduzcaCantidad.Text = "Introduzca Cantidad";
            // 
            // txtCantidadRecursos
            // 
            this.txtCantidadRecursos.Location = new System.Drawing.Point(65, 67);
            this.txtCantidadRecursos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCantidadRecursos.Name = "txtCantidadRecursos";
            this.txtCantidadRecursos.Size = new System.Drawing.Size(101, 20);
            this.txtCantidadRecursos.TabIndex = 3;
            this.txtCantidadRecursos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCantidadRecursos_KeyPress);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(205, 52);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(175, 39);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // FrmCantidadRecursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(395, 166);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtCantidadRecursos);
            this.Controls.Add(this.lblIntroduzcaCantidad);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmCantidadRecursos";
            this.Text = "Cantidad Recursos";
            this.Load += new System.EventHandler(this.FrmCantidadRecursos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblIntroduzcaCantidad;
        private System.Windows.Forms.TextBox txtCantidadRecursos;
        private System.Windows.Forms.Button btnAceptar;
    }
}