namespace tcc
{
    partial class ContatoPersonal
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
            this.personal = new System.Windows.Forms.Label();
            this.CREA = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.endereco = new System.Windows.Forms.Label();
            this.txtcrea = new System.Windows.Forms.TextBox();
            this.txtendereco = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.lblSemPersonal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // personal
            // 
            this.personal.AutoSize = true;
            this.personal.Location = new System.Drawing.Point(97, 161);
            this.personal.Name = "personal";
            this.personal.Size = new System.Drawing.Size(54, 13);
            this.personal.TabIndex = 0;
            this.personal.Text = "Personal :";
            // 
            // CREA
            // 
            this.CREA.AutoSize = true;
            this.CREA.Location = new System.Drawing.Point(109, 199);
            this.CREA.Name = "CREA";
            this.CREA.Size = new System.Drawing.Size(42, 13);
            this.CREA.TabIndex = 1;
            this.CREA.Text = "CREA :";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(110, 239);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(41, 13);
            this.email.TabIndex = 2;
            this.email.Text = "E-mail :";
            // 
            // endereco
            // 
            this.endereco.AutoSize = true;
            this.endereco.Location = new System.Drawing.Point(92, 280);
            this.endereco.Name = "endereco";
            this.endereco.Size = new System.Drawing.Size(59, 13);
            this.endereco.TabIndex = 3;
            this.endereco.Text = "Endereço :";
            // 
            // txtcrea
            // 
            this.txtcrea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcrea.Location = new System.Drawing.Point(176, 194);
            this.txtcrea.Name = "txtcrea";
            this.txtcrea.ReadOnly = true;
            this.txtcrea.Size = new System.Drawing.Size(351, 22);
            this.txtcrea.TabIndex = 14;
            // 
            // txtendereco
            // 
            this.txtendereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtendereco.Location = new System.Drawing.Point(176, 275);
            this.txtendereco.Multiline = true;
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.ReadOnly = true;
            this.txtendereco.Size = new System.Drawing.Size(351, 67);
            this.txtendereco.TabIndex = 13;
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(176, 234);
            this.txtemail.Name = "txtemail";
            this.txtemail.ReadOnly = true;
            this.txtemail.Size = new System.Drawing.Size(351, 22);
            this.txtemail.TabIndex = 12;
            // 
            // txtnome
            // 
            this.txtnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.Location = new System.Drawing.Point(176, 156);
            this.txtnome.Name = "txtnome";
            this.txtnome.ReadOnly = true;
            this.txtnome.Size = new System.Drawing.Size(351, 22);
            this.txtnome.TabIndex = 11;
            // 
            // lblSemPersonal
            // 
            this.lblSemPersonal.AutoSize = true;
            this.lblSemPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemPersonal.ForeColor = System.Drawing.Color.Red;
            this.lblSemPersonal.Location = new System.Drawing.Point(215, 82);
            this.lblSemPersonal.Name = "lblSemPersonal";
            this.lblSemPersonal.Size = new System.Drawing.Size(193, 16);
            this.lblSemPersonal.TabIndex = 15;
            this.lblSemPersonal.Text = "Você não possui personal!";
            this.lblSemPersonal.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "CONTATO DO PERSONAL";
            // 
            // ContatoPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 441);
            this.Controls.Add(this.lblSemPersonal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcrea);
            this.Controls.Add(this.txtendereco);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.endereco);
            this.Controls.Add(this.email);
            this.Controls.Add(this.CREA);
            this.Controls.Add(this.personal);
            this.Name = "ContatoPersonal";
            this.Text = "ContatoPersonal";
            this.Load += new System.EventHandler(this.ContatoPersonal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label personal;
        private System.Windows.Forms.Label CREA;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label endereco;
        private System.Windows.Forms.TextBox txtcrea;
        private System.Windows.Forms.TextBox txtendereco;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label lblSemPersonal;
        private System.Windows.Forms.Label label1;
    }
}