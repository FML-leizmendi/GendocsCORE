namespace GendocsForms
{
    partial class FrmAyuda
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
            this.pnlBotonera = new System.Windows.Forms.Panel();
            this.lblAyuda = new System.Windows.Forms.Label();
            this.lsvAyuda = new System.Windows.Forms.ListView();
            this.pnlBotonera.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBotonera
            // 
            this.pnlBotonera.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.pnlBotonera.Controls.Add(this.lblAyuda);
            this.pnlBotonera.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotonera.Location = new System.Drawing.Point(0, 320);
            this.pnlBotonera.Name = "pnlBotonera";
            this.pnlBotonera.Size = new System.Drawing.Size(358, 41);
            this.pnlBotonera.TabIndex = 0;
            // 
            // lblAyuda
            // 
            this.lblAyuda.AutoSize = true;
            this.lblAyuda.Location = new System.Drawing.Point(22, 16);
            this.lblAyuda.Name = "lblAyuda";
            this.lblAyuda.Size = new System.Drawing.Size(66, 13);
            this.lblAyuda.TabIndex = 0;
            this.lblAyuda.Text = "Texto ayuda";
            // 
            // lsvAyuda
            // 
            this.lsvAyuda.HideSelection = false;
            this.lsvAyuda.Location = new System.Drawing.Point(12, 12);
            this.lsvAyuda.Name = "lsvAyuda";
            this.lsvAyuda.Size = new System.Drawing.Size(334, 302);
            this.lsvAyuda.TabIndex = 1;
            this.lsvAyuda.UseCompatibleStateImageBehavior = false;
            // 
            // FrmAyuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(358, 361);
            this.Controls.Add(this.lsvAyuda);
            this.Controls.Add(this.pnlBotonera);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAyuda";
            this.Text = "Ayuda";
            this.Load += new System.EventHandler(this.FrmAyuda_Load);
            this.pnlBotonera.ResumeLayout(false);
            this.pnlBotonera.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBotonera;
        private System.Windows.Forms.Label lblAyuda;
        private System.Windows.Forms.ListView lsvAyuda;
    }
}