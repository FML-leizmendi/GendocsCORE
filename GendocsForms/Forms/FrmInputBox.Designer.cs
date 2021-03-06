﻿namespace GendocsForms
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
            this.lblIntroduzcaDatos = new System.Windows.Forms.Label();
            this.txtCantidadRecursos = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIntroduzcaDatos
            // 
            this.lblIntroduzcaDatos.AutoSize = true;
            this.lblIntroduzcaDatos.Location = new System.Drawing.Point(21, 21);
            this.lblIntroduzcaDatos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIntroduzcaDatos.Name = "lblIntroduzcaDatos";
            this.lblIntroduzcaDatos.Size = new System.Drawing.Size(88, 13);
            this.lblIntroduzcaDatos.TabIndex = 2;
            this.lblIntroduzcaDatos.Text = "Introduzca Datos";
            // 
            // txtCantidadRecursos
            // 
            this.txtCantidadRecursos.Location = new System.Drawing.Point(23, 36);
            this.txtCantidadRecursos.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidadRecursos.Name = "txtCantidadRecursos";
            this.txtCantidadRecursos.Size = new System.Drawing.Size(361, 20);
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
            this.btnAceptar.Location = new System.Drawing.Point(154, 61);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(112, 29);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(272, 61);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 29);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // FrmInputBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(395, 110);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtCantidadRecursos);
            this.Controls.Add(this.lblIntroduzcaDatos);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmInputBox";
            this.Text = "Introduzca Datos";
            this.Load += new System.EventHandler(this.FrmCantidadRecursos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblIntroduzcaDatos;
        private System.Windows.Forms.TextBox txtCantidadRecursos;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}