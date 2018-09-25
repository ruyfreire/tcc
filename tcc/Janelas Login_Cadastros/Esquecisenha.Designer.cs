namespace tcc
{
    partial class Esquecisenha
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
            this.lbllogin = new System.Windows.Forms.Label();
            this.txtlogin = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblnascimento = new System.Windows.Forms.Label();
            this.btnrecuperar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.maskednascimento = new System.Windows.Forms.MaskedTextBox();
            this.lblnovasenha = new System.Windows.Forms.Label();
            this.lblrepetesenha = new System.Windows.Forms.Label();
            this.txtnovasenha = new System.Windows.Forms.TextBox();
            this.txtrepetesenha = new System.Windows.Forms.TextBox();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblperfil = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbllogin
            // 
            this.lbllogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbllogin.AutoSize = true;
            this.lbllogin.Location = new System.Drawing.Point(192, 89);
            this.lbllogin.Name = "lbllogin";
            this.lbllogin.Size = new System.Drawing.Size(36, 13);
            this.lbllogin.TabIndex = 0;
            this.lbllogin.Text = "Login:";
            // 
            // txtlogin
            // 
            this.txtlogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtlogin.Location = new System.Drawing.Point(234, 86);
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(197, 20);
            this.txtlogin.TabIndex = 2;
            // 
            // txtemail
            // 
            this.txtemail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtemail.Location = new System.Drawing.Point(234, 131);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(197, 20);
            this.txtemail.TabIndex = 4;
            // 
            // lblemail
            // 
            this.lblemail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(190, 134);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(38, 13);
            this.lblemail.TabIndex = 3;
            this.lblemail.Text = "E-mail:";
            // 
            // lblnascimento
            // 
            this.lblnascimento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblnascimento.AutoSize = true;
            this.lblnascimento.Location = new System.Drawing.Point(121, 223);
            this.lblnascimento.Name = "lblnascimento";
            this.lblnascimento.Size = new System.Drawing.Size(107, 13);
            this.lblnascimento.TabIndex = 5;
            this.lblnascimento.Text = "Data de Nascimento:";
            // 
            // btnrecuperar
            // 
            this.btnrecuperar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnrecuperar.Location = new System.Drawing.Point(284, 346);
            this.btnrecuperar.Name = "btnrecuperar";
            this.btnrecuperar.Size = new System.Drawing.Size(75, 23);
            this.btnrecuperar.TabIndex = 7;
            this.btnrecuperar.Text = "Recuperar";
            this.btnrecuperar.UseVisualStyleBackColor = true;
            this.btnrecuperar.Click += new System.EventHandler(this.btnrecuperar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btncancelar.Location = new System.Drawing.Point(184, 346);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 8;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // maskednascimento
            // 
            this.maskednascimento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.maskednascimento.Location = new System.Drawing.Point(234, 221);
            this.maskednascimento.Mask = "00/00/0000";
            this.maskednascimento.Name = "maskednascimento";
            this.maskednascimento.Size = new System.Drawing.Size(73, 20);
            this.maskednascimento.TabIndex = 21;
            this.maskednascimento.ValidatingType = typeof(System.DateTime);
            // 
            // lblnovasenha
            // 
            this.lblnovasenha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblnovasenha.AutoSize = true;
            this.lblnovasenha.Location = new System.Drawing.Point(158, 178);
            this.lblnovasenha.Name = "lblnovasenha";
            this.lblnovasenha.Size = new System.Drawing.Size(70, 13);
            this.lblnovasenha.TabIndex = 0;
            this.lblnovasenha.Text = "Nova Senha:";
            this.lblnovasenha.Visible = false;
            // 
            // lblrepetesenha
            // 
            this.lblrepetesenha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblrepetesenha.AutoSize = true;
            this.lblrepetesenha.Location = new System.Drawing.Point(150, 269);
            this.lblrepetesenha.Name = "lblrepetesenha";
            this.lblrepetesenha.Size = new System.Drawing.Size(78, 13);
            this.lblrepetesenha.TabIndex = 3;
            this.lblrepetesenha.Text = "Repetir Senha:";
            this.lblrepetesenha.Visible = false;
            // 
            // txtnovasenha
            // 
            this.txtnovasenha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtnovasenha.Location = new System.Drawing.Point(234, 175);
            this.txtnovasenha.Name = "txtnovasenha";
            this.txtnovasenha.Size = new System.Drawing.Size(197, 20);
            this.txtnovasenha.TabIndex = 2;
            this.txtnovasenha.UseSystemPasswordChar = true;
            this.txtnovasenha.Visible = false;
            // 
            // txtrepetesenha
            // 
            this.txtrepetesenha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtrepetesenha.Location = new System.Drawing.Point(234, 266);
            this.txtrepetesenha.Name = "txtrepetesenha";
            this.txtrepetesenha.Size = new System.Drawing.Size(197, 20);
            this.txtrepetesenha.TabIndex = 4;
            this.txtrepetesenha.UseSystemPasswordChar = true;
            this.txtrepetesenha.Visible = false;
            // 
            // btnsalvar
            // 
            this.btnsalvar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnsalvar.Location = new System.Drawing.Point(385, 346);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(75, 23);
            this.btnsalvar.TabIndex = 7;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Visible = false;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(209, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Recuperar Senha de:";
            // 
            // lblperfil
            // 
            this.lblperfil.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblperfil.AutoSize = true;
            this.lblperfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblperfil.ForeColor = System.Drawing.Color.Tomato;
            this.lblperfil.Location = new System.Drawing.Point(339, 28);
            this.lblperfil.Name = "lblperfil";
            this.lblperfil.Size = new System.Drawing.Size(59, 20);
            this.lblperfil.TabIndex = 23;
            this.lblperfil.Text = "[perfil]";
            // 
            // Esquecisenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(629, 452);
            this.Controls.Add(this.lblperfil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskednascimento);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.btnrecuperar);
            this.Controls.Add(this.lblnascimento);
            this.Controls.Add(this.txtrepetesenha);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.lblrepetesenha);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.txtnovasenha);
            this.Controls.Add(this.txtlogin);
            this.Controls.Add(this.lblnovasenha);
            this.Controls.Add(this.lbllogin);
            this.Name = "Esquecisenha";
            this.Text = "Esqueci a Senha";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Esquecisenha_FormClosed);
            this.Load += new System.EventHandler(this.Esquecisenha_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbllogin;
        private System.Windows.Forms.TextBox txtlogin;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblnascimento;
        private System.Windows.Forms.Button btnrecuperar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.MaskedTextBox maskednascimento;
        private System.Windows.Forms.Label lblnovasenha;
        private System.Windows.Forms.Label lblrepetesenha;
        private System.Windows.Forms.TextBox txtnovasenha;
        private System.Windows.Forms.TextBox txtrepetesenha;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblperfil;
    }
}