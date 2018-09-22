namespace tcc
{
    partial class Dados_Cadastrais_Profissional
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
            this.txtcpf_cnpj = new System.Windows.Forms.MaskedTextBox();
            this.lblcrea_crn = new System.Windows.Forms.Label();
            this.txtcrea_crn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtendereco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.maskednascimento = new System.Windows.Forms.MaskedTextBox();
            this.cbosexo = new System.Windows.Forms.ComboBox();
            this.labsexo = new System.Windows.Forms.Label();
            this.labnascimento = new System.Windows.Forms.Label();
            this.labsenha = new System.Windows.Forms.Label();
            this.labemail = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labname = new System.Windows.Forms.Label();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtlogin = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtcpf_cnpj
            // 
            this.txtcpf_cnpj.Location = new System.Drawing.Point(200, 177);
            this.txtcpf_cnpj.Name = "txtcpf_cnpj";
            this.txtcpf_cnpj.ReadOnly = true;
            this.txtcpf_cnpj.Size = new System.Drawing.Size(249, 20);
            this.txtcpf_cnpj.TabIndex = 103;
            // 
            // lblcrea_crn
            // 
            this.lblcrea_crn.AutoSize = true;
            this.lblcrea_crn.Location = new System.Drawing.Point(128, 216);
            this.lblcrea_crn.Name = "lblcrea_crn";
            this.lblcrea_crn.Size = new System.Drawing.Size(55, 13);
            this.lblcrea_crn.TabIndex = 101;
            this.lblcrea_crn.Text = "[crea_crn]";
            // 
            // txtcrea_crn
            // 
            this.txtcrea_crn.Location = new System.Drawing.Point(200, 213);
            this.txtcrea_crn.Name = "txtcrea_crn";
            this.txtcrea_crn.ReadOnly = true;
            this.txtcrea_crn.Size = new System.Drawing.Size(249, 20);
            this.txtcrea_crn.TabIndex = 84;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(455, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 100;
            this.label4.Text = "Sem pontos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 99;
            this.label2.Text = "CPF_CNPJ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 98;
            this.label1.Text = "Endereço";
            // 
            // txtendereco
            // 
            this.txtendereco.Location = new System.Drawing.Point(200, 322);
            this.txtendereco.Multiline = true;
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.ReadOnly = true;
            this.txtendereco.Size = new System.Drawing.Size(249, 49);
            this.txtendereco.TabIndex = 87;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(455, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 97;
            this.label3.Text = "6 a 8";
            // 
            // maskednascimento
            // 
            this.maskednascimento.Location = new System.Drawing.Point(200, 249);
            this.maskednascimento.Mask = "00/00/0000";
            this.maskednascimento.Name = "maskednascimento";
            this.maskednascimento.ReadOnly = true;
            this.maskednascimento.Size = new System.Drawing.Size(249, 20);
            this.maskednascimento.TabIndex = 85;
            this.maskednascimento.ValidatingType = typeof(System.DateTime);
            // 
            // cbosexo
            // 
            this.cbosexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbosexo.FormattingEnabled = true;
            this.cbosexo.Items.AddRange(new object[] {
            "F",
            "M"});
            this.cbosexo.Location = new System.Drawing.Point(200, 285);
            this.cbosexo.Name = "cbosexo";
            this.cbosexo.Size = new System.Drawing.Size(249, 21);
            this.cbosexo.TabIndex = 86;
            // 
            // labsexo
            // 
            this.labsexo.AutoSize = true;
            this.labsexo.Location = new System.Drawing.Point(149, 288);
            this.labsexo.Name = "labsexo";
            this.labsexo.Size = new System.Drawing.Size(31, 13);
            this.labsexo.TabIndex = 96;
            this.labsexo.Text = "Sexo";
            // 
            // labnascimento
            // 
            this.labnascimento.AutoSize = true;
            this.labnascimento.Location = new System.Drawing.Point(79, 252);
            this.labnascimento.Name = "labnascimento";
            this.labnascimento.Size = new System.Drawing.Size(104, 13);
            this.labnascimento.TabIndex = 95;
            this.labnascimento.Text = "Data de Nascimento";
            // 
            // labsenha
            // 
            this.labsenha.AutoSize = true;
            this.labsenha.Location = new System.Drawing.Point(145, 144);
            this.labsenha.Name = "labsenha";
            this.labsenha.Size = new System.Drawing.Size(38, 13);
            this.labsenha.TabIndex = 94;
            this.labsenha.Text = "Senha";
            // 
            // labemail
            // 
            this.labemail.AutoSize = true;
            this.labemail.Location = new System.Drawing.Point(145, 108);
            this.labemail.Name = "labemail";
            this.labemail.Size = new System.Drawing.Size(35, 13);
            this.labemail.TabIndex = 93;
            this.labemail.Text = "E-mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(147, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 92;
            this.label6.Text = "Login";
            // 
            // labname
            // 
            this.labname.AutoSize = true;
            this.labname.Location = new System.Drawing.Point(145, 36);
            this.labname.Name = "labname";
            this.labname.Size = new System.Drawing.Size(35, 13);
            this.labname.TabIndex = 91;
            this.labname.Text = "Nome";
            // 
            // txtsenha
            // 
            this.txtsenha.Location = new System.Drawing.Point(200, 141);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.PasswordChar = '*';
            this.txtsenha.ReadOnly = true;
            this.txtsenha.Size = new System.Drawing.Size(249, 20);
            this.txtsenha.TabIndex = 83;
            this.txtsenha.UseSystemPasswordChar = true;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(200, 105);
            this.txtemail.Name = "txtemail";
            this.txtemail.ReadOnly = true;
            this.txtemail.Size = new System.Drawing.Size(249, 20);
            this.txtemail.TabIndex = 82;
            // 
            // txtlogin
            // 
            this.txtlogin.Location = new System.Drawing.Point(200, 69);
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.ReadOnly = true;
            this.txtlogin.Size = new System.Drawing.Size(249, 20);
            this.txtlogin.TabIndex = 81;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(200, 33);
            this.txtname.Name = "txtname";
            this.txtname.ReadOnly = true;
            this.txtname.Size = new System.Drawing.Size(249, 20);
            this.txtname.TabIndex = 80;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(503, 407);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 105;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Visible = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(254, 407);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 104;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // Dados_Cadastrais_Profissional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 456);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtcpf_cnpj);
            this.Controls.Add(this.lblcrea_crn);
            this.Controls.Add(this.txtcrea_crn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtendereco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maskednascimento);
            this.Controls.Add(this.cbosexo);
            this.Controls.Add(this.labsexo);
            this.Controls.Add(this.labnascimento);
            this.Controls.Add(this.labsenha);
            this.Controls.Add(this.labemail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labname);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtlogin);
            this.Controls.Add(this.txtname);
            this.Name = "Dados_Cadastrais_Profissional";
            this.Text = "Dados Cadastrais";
            this.Load += new System.EventHandler(this.Dados_Cadastrais_Profissional_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtcpf_cnpj;
        private System.Windows.Forms.Label lblcrea_crn;
        private System.Windows.Forms.TextBox txtcrea_crn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtendereco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskednascimento;
        private System.Windows.Forms.ComboBox cbosexo;
        private System.Windows.Forms.Label labsexo;
        private System.Windows.Forms.Label labnascimento;
        private System.Windows.Forms.Label labsenha;
        private System.Windows.Forms.Label labemail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labname;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtlogin;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnEditar;
    }
}