namespace tcc
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.esqueciSenha = new System.Windows.Forms.LinkLabel();
            this.criarUsuario = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.criarPersonal = new System.Windows.Forms.LinkLabel();
            this.criarnutricionista = new System.Windows.Forms.LinkLabel();
            this.comboperfil = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(231, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(223, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Senha :";
            // 
            // txtLogin
            // 
            this.txtLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(275, 73);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(4);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(241, 26);
            this.txtLogin.TabIndex = 2;
            // 
            // txtSenha
            // 
            this.txtSenha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(275, 127);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(241, 26);
            this.txtSenha.TabIndex = 3;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // btnSair
            // 
            this.btnSair.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnSair.Location = new System.Drawing.Point(155, 241);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(112, 28);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOk.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnOk.Location = new System.Drawing.Point(343, 241);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(112, 28);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // esqueciSenha
            // 
            this.esqueciSenha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.esqueciSenha.AutoSize = true;
            this.esqueciSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.esqueciSenha.Location = new System.Drawing.Point(428, 170);
            this.esqueciSenha.Name = "esqueciSenha";
            this.esqueciSenha.Size = new System.Drawing.Size(88, 13);
            this.esqueciSenha.TabIndex = 4;
            this.esqueciSenha.TabStop = true;
            this.esqueciSenha.Text = "Esqueci a Senha";
            this.esqueciSenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.esqueciSenha_LinkClicked);
            // 
            // criarUsuario
            // 
            this.criarUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.criarUsuario.AutoSize = true;
            this.criarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.criarUsuario.Location = new System.Drawing.Point(55, 356);
            this.criarUsuario.Name = "criarUsuario";
            this.criarUsuario.Size = new System.Drawing.Size(92, 13);
            this.criarUsuario.TabIndex = 7;
            this.criarUsuario.TabStop = true;
            this.criarUsuario.Text = "Criar novo usuário";
            this.criarUsuario.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.criarUsuario_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // criarPersonal
            // 
            this.criarPersonal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.criarPersonal.AutoSize = true;
            this.criarPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.criarPersonal.Location = new System.Drawing.Point(222, 356);
            this.criarPersonal.Name = "criarPersonal";
            this.criarPersonal.Size = new System.Drawing.Size(93, 13);
            this.criarPersonal.TabIndex = 8;
            this.criarPersonal.TabStop = true;
            this.criarPersonal.Text = "Cadastro Personal";
            this.criarPersonal.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.criarPersonal_LinkClicked);
            // 
            // criarnutricionista
            // 
            this.criarnutricionista.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.criarnutricionista.AutoSize = true;
            this.criarnutricionista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.criarnutricionista.Location = new System.Drawing.Point(395, 356);
            this.criarnutricionista.Name = "criarnutricionista";
            this.criarnutricionista.Size = new System.Drawing.Size(110, 13);
            this.criarnutricionista.TabIndex = 9;
            this.criarnutricionista.TabStop = true;
            this.criarnutricionista.Text = "Cadastro Nutricionista";
            this.criarnutricionista.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.criarnutricionista_LinkClicked);
            // 
            // comboperfil
            // 
            this.comboperfil.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboperfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboperfil.FormattingEnabled = true;
            this.comboperfil.Items.AddRange(new object[] {
            "Usuário",
            "Personal",
            "Nutricionista"});
            this.comboperfil.Location = new System.Drawing.Point(279, 27);
            this.comboperfil.Name = "comboperfil";
            this.comboperfil.Size = new System.Drawing.Size(127, 24);
            this.comboperfil.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(236, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Perfil :";
            // 
            // login
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(625, 448);
            this.Controls.Add(this.comboperfil);
            this.Controls.Add(this.criarnutricionista);
            this.Controls.Add(this.criarPersonal);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.criarUsuario);
            this.Controls.Add(this.esqueciSenha);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.LinkLabel esqueciSenha;
        private System.Windows.Forms.LinkLabel criarUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel criarPersonal;
        private System.Windows.Forms.LinkLabel criarnutricionista;
        private System.Windows.Forms.ComboBox comboperfil;
        private System.Windows.Forms.Label label3;
    }
}