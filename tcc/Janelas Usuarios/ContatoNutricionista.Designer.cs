namespace tcc
{
    partial class ContatoNutricionista
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
            this.Nome = new System.Windows.Forms.Label();
            this.Telefone = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Endereco = new System.Windows.Forms.Label();
            this.Fechar = new System.Windows.Forms.Button();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtendereco = new System.Windows.Forms.TextBox();
            this.txttelefone = new System.Windows.Forms.TextBox();
            this.CRN = new System.Windows.Forms.Label();
            this.txtcrn = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.Location = new System.Drawing.Point(99, 64);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(71, 13);
            this.Nome.TabIndex = 0;
            this.Nome.Text = "Nutricionista :";
            this.Nome.Click += new System.EventHandler(this.label1_Click);
            // 
            // Telefone
            // 
            this.Telefone.AutoSize = true;
            this.Telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefone.Location = new System.Drawing.Point(118, 228);
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(55, 13);
            this.Telefone.TabIndex = 1;
            this.Telefone.Text = "Telefone :";
            this.Telefone.Click += new System.EventHandler(this.Contato_Click);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(132, 142);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(41, 13);
            this.Email.TabIndex = 2;
            this.Email.Text = "E-mail :";
            this.Email.Click += new System.EventHandler(this.Email_Click);
            // 
            // Endereco
            // 
            this.Endereco.AutoSize = true;
            this.Endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Endereco.Location = new System.Drawing.Point(114, 183);
            this.Endereco.Name = "Endereco";
            this.Endereco.Size = new System.Drawing.Size(59, 13);
            this.Endereco.TabIndex = 3;
            this.Endereco.Text = "Endereço :";
            this.Endereco.Click += new System.EventHandler(this.Endereço_Click);
            // 
            // Fechar
            // 
            this.Fechar.Location = new System.Drawing.Point(322, 286);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(75, 23);
            this.Fechar.TabIndex = 4;
            this.Fechar.Text = "Fechar";
            this.Fechar.UseVisualStyleBackColor = true;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(177, 61);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(351, 20);
            this.txtnome.TabIndex = 5;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(177, 139);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(351, 20);
            this.txtemail.TabIndex = 6;
            // 
            // txtendereco
            // 
            this.txtendereco.Location = new System.Drawing.Point(177, 180);
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.Size = new System.Drawing.Size(351, 20);
            this.txtendereco.TabIndex = 7;
            // 
            // txttelefone
            // 
            this.txttelefone.Location = new System.Drawing.Point(177, 225);
            this.txttelefone.Name = "txttelefone";
            this.txttelefone.Size = new System.Drawing.Size(351, 20);
            this.txttelefone.TabIndex = 8;
            // 
            // CRN
            // 
            this.CRN.AutoSize = true;
            this.CRN.Location = new System.Drawing.Point(134, 102);
            this.CRN.Name = "CRN";
            this.CRN.Size = new System.Drawing.Size(36, 13);
            this.CRN.TabIndex = 9;
            this.CRN.Text = "CRN :";
            this.CRN.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtcrn
            // 
            this.txtcrn.Location = new System.Drawing.Point(177, 99);
            this.txtcrn.Name = "txtcrn";
            this.txtcrn.Size = new System.Drawing.Size(351, 20);
            this.txtcrn.TabIndex = 10;
            // 
            // ContatoNutricionista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 450);
            this.Controls.Add(this.txtcrn);
            this.Controls.Add(this.CRN);
            this.Controls.Add(this.txttelefone);
            this.Controls.Add(this.txtendereco);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.Fechar);
            this.Controls.Add(this.Endereco);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Telefone);
            this.Controls.Add(this.Nome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ContatoNutricionista";
            this.Text = "Contato do Nutricionista";
            this.Load += new System.EventHandler(this.ContatoNutricionista_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label Telefone;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Endereco;
        private System.Windows.Forms.Button Fechar;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtendereco;
        private System.Windows.Forms.TextBox txttelefone;
        private System.Windows.Forms.Label CRN;
        private System.Windows.Forms.TextBox txtcrn;
    }
}