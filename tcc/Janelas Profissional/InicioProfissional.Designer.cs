namespace tcc
{
    partial class InicioProfissional
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
            this.txtnome = new System.Windows.Forms.TextBox();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblcrn_crea = new System.Windows.Forms.Label();
            this.txtcrn_crea = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(150, 168);
            this.txtnome.Name = "txtnome";
            this.txtnome.ReadOnly = true;
            this.txtnome.Size = new System.Drawing.Size(363, 20);
            this.txtnome.TabIndex = 1;
            this.txtnome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(159, 93);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(195, 24);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "TELA INICIAL DE ...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome :";
            // 
            // lblcrn_crea
            // 
            this.lblcrn_crea.AutoSize = true;
            this.lblcrn_crea.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcrn_crea.Location = new System.Drawing.Point(79, 252);
            this.lblcrn_crea.Name = "lblcrn_crea";
            this.lblcrn_crea.Size = new System.Drawing.Size(65, 13);
            this.lblcrn_crea.TabIndex = 7;
            this.lblcrn_crea.Text = "crn_crea :";
            // 
            // txtcrn_crea
            // 
            this.txtcrn_crea.Location = new System.Drawing.Point(150, 249);
            this.txtcrn_crea.Name = "txtcrn_crea";
            this.txtcrn_crea.ReadOnly = true;
            this.txtcrn_crea.Size = new System.Drawing.Size(363, 20);
            this.txtcrn_crea.TabIndex = 1;
            this.txtcrn_crea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // InicioProfissional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.txtcrn_crea);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.lblcrn_crea);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.label1);
            this.Name = "InicioProfissional";
            this.Text = "Inicio Profissional";
            this.Load += new System.EventHandler(this.InicioProfissional_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblcrn_crea;
        private System.Windows.Forms.TextBox txtcrn_crea;
    }
}