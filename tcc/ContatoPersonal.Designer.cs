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
            this.telefone = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtcrea = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtendereco = new System.Windows.Forms.TextBox();
            this.txttelefone = new System.Windows.Forms.TextBox();
            this.fechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // personal
            // 
            this.personal.AutoSize = true;
            this.personal.Location = new System.Drawing.Point(170, 64);
            this.personal.Name = "personal";
            this.personal.Size = new System.Drawing.Size(54, 13);
            this.personal.TabIndex = 0;
            this.personal.Text = "Personal :";
            this.personal.Click += new System.EventHandler(this.label1_Click);
            // 
            // CREA
            // 
            this.CREA.AutoSize = true;
            this.CREA.Location = new System.Drawing.Point(182, 104);
            this.CREA.Name = "CREA";
            this.CREA.Size = new System.Drawing.Size(42, 13);
            this.CREA.TabIndex = 1;
            this.CREA.Text = "CREA :";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(183, 152);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(41, 13);
            this.email.TabIndex = 2;
            this.email.Text = "E-mail :";
            // 
            // endereco
            // 
            this.endereco.AutoSize = true;
            this.endereco.Location = new System.Drawing.Point(165, 196);
            this.endereco.Name = "endereco";
            this.endereco.Size = new System.Drawing.Size(59, 13);
            this.endereco.TabIndex = 3;
            this.endereco.Text = "Endereço :";
            this.endereco.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // telefone
            // 
            this.telefone.AutoSize = true;
            this.telefone.Location = new System.Drawing.Point(169, 244);
            this.telefone.Name = "telefone";
            this.telefone.Size = new System.Drawing.Size(55, 13);
            this.telefone.TabIndex = 4;
            this.telefone.Text = "Telefone :";
            this.telefone.Click += new System.EventHandler(this.telefone_Click);
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(231, 61);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(309, 20);
            this.txtnome.TabIndex = 5;
            this.txtnome.TextChanged += new System.EventHandler(this.txtnome_TextChanged);
            // 
            // txtcrea
            // 
            this.txtcrea.Location = new System.Drawing.Point(231, 101);
            this.txtcrea.Name = "txtcrea";
            this.txtcrea.Size = new System.Drawing.Size(309, 20);
            this.txtcrea.TabIndex = 6;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(231, 149);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(309, 20);
            this.txtemail.TabIndex = 7;
            // 
            // txtendereco
            // 
            this.txtendereco.Location = new System.Drawing.Point(231, 193);
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.Size = new System.Drawing.Size(309, 20);
            this.txtendereco.TabIndex = 8;
            // 
            // txttelefone
            // 
            this.txttelefone.Location = new System.Drawing.Point(230, 241);
            this.txttelefone.Name = "txttelefone";
            this.txttelefone.Size = new System.Drawing.Size(309, 20);
            this.txttelefone.TabIndex = 9;
            // 
            // fechar
            // 
            this.fechar.Location = new System.Drawing.Point(398, 310);
            this.fechar.Name = "fechar";
            this.fechar.Size = new System.Drawing.Size(75, 23);
            this.fechar.TabIndex = 10;
            this.fechar.Text = "Fechar";
            this.fechar.UseVisualStyleBackColor = true;
            // 
            // ContatoPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 450);
            this.Controls.Add(this.fechar);
            this.Controls.Add(this.txttelefone);
            this.Controls.Add(this.txtendereco);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtcrea);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.telefone);
            this.Controls.Add(this.endereco);
            this.Controls.Add(this.email);
            this.Controls.Add(this.CREA);
            this.Controls.Add(this.personal);
            this.Name = "ContatoPersonal";
            this.Text = "ContatoPersonal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label personal;
        private System.Windows.Forms.Label CREA;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label endereco;
        private System.Windows.Forms.Label telefone;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtcrea;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtendereco;
        private System.Windows.Forms.TextBox txttelefone;
        private System.Windows.Forms.Button fechar;
    }
}