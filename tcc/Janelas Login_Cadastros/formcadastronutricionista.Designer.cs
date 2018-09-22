namespace tcc
{
    partial class CadastroNutricionista
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
            this.btnsalvar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtendereco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.maskednascimento = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxsexo = new System.Windows.Forms.ComboBox();
            this.labsexo = new System.Windows.Forms.Label();
            this.labnascimento = new System.Windows.Forms.Label();
            this.labsenha = new System.Windows.Forms.Label();
            this.labemail = new System.Windows.Forms.Label();
            this.labname = new System.Windows.Forms.Label();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtlogin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.cboCPF_CNPJ = new System.Windows.Forms.ComboBox();
            this.txtcpf_cnpj = new System.Windows.Forms.MaskedTextBox();
            this.txtcrn = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnsalvar
            // 
            this.btnsalvar.Location = new System.Drawing.Point(307, 371);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(75, 23);
            this.btnsalvar.TabIndex = 9;
            this.btnsalvar.Text = "Criar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.Btnsalvar_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(185, 371);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 10;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "CRN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "Sem pontos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "CPF_CNPJ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Endereço";
            // 
            // txtendereco
            // 
            this.txtendereco.Location = new System.Drawing.Point(133, 316);
            this.txtendereco.Multiline = true;
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.Size = new System.Drawing.Size(249, 49);
            this.txtendereco.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "6 a 8";
            // 
            // maskednascimento
            // 
            this.maskednascimento.Location = new System.Drawing.Point(133, 243);
            this.maskednascimento.Mask = "00/00/0000";
            this.maskednascimento.Name = "maskednascimento";
            this.maskednascimento.Size = new System.Drawing.Size(127, 20);
            this.maskednascimento.TabIndex = 6;
            this.maskednascimento.ValidatingType = typeof(System.DateTime);
            // 
            // comboBoxsexo
            // 
            this.comboBoxsexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxsexo.FormattingEnabled = true;
            this.comboBoxsexo.Items.AddRange(new object[] {
            "F",
            "M"});
            this.comboBoxsexo.Location = new System.Drawing.Point(133, 279);
            this.comboBoxsexo.Name = "comboBoxsexo";
            this.comboBoxsexo.Size = new System.Drawing.Size(127, 21);
            this.comboBoxsexo.TabIndex = 7;
            // 
            // labsexo
            // 
            this.labsexo.AutoSize = true;
            this.labsexo.Location = new System.Drawing.Point(82, 282);
            this.labsexo.Name = "labsexo";
            this.labsexo.Size = new System.Drawing.Size(31, 13);
            this.labsexo.TabIndex = 46;
            this.labsexo.Text = "Sexo";
            // 
            // labnascimento
            // 
            this.labnascimento.AutoSize = true;
            this.labnascimento.Location = new System.Drawing.Point(12, 246);
            this.labnascimento.Name = "labnascimento";
            this.labnascimento.Size = new System.Drawing.Size(104, 13);
            this.labnascimento.TabIndex = 45;
            this.labnascimento.Text = "Data de Nascimento";
            // 
            // labsenha
            // 
            this.labsenha.AutoSize = true;
            this.labsenha.Location = new System.Drawing.Point(78, 138);
            this.labsenha.Name = "labsenha";
            this.labsenha.Size = new System.Drawing.Size(38, 13);
            this.labsenha.TabIndex = 44;
            this.labsenha.Text = "Senha";
            // 
            // labemail
            // 
            this.labemail.AutoSize = true;
            this.labemail.Location = new System.Drawing.Point(78, 102);
            this.labemail.Name = "labemail";
            this.labemail.Size = new System.Drawing.Size(35, 13);
            this.labemail.TabIndex = 43;
            this.labemail.Text = "E-mail";
            // 
            // labname
            // 
            this.labname.AutoSize = true;
            this.labname.Location = new System.Drawing.Point(78, 30);
            this.labname.Name = "labname";
            this.labname.Size = new System.Drawing.Size(35, 13);
            this.labname.TabIndex = 42;
            this.labname.Text = "Nome";
            // 
            // txtsenha
            // 
            this.txtsenha.Location = new System.Drawing.Point(133, 135);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.PasswordChar = '*';
            this.txtsenha.Size = new System.Drawing.Size(129, 20);
            this.txtsenha.TabIndex = 3;
            this.txtsenha.UseSystemPasswordChar = true;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(133, 99);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(249, 20);
            this.txtemail.TabIndex = 2;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(133, 27);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(249, 20);
            this.txtname.TabIndex = 0;
            // 
            // txtlogin
            // 
            this.txtlogin.Location = new System.Drawing.Point(133, 63);
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(249, 20);
            this.txtlogin.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Login";
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(63, 371);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 11;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // cboCPF_CNPJ
            // 
            this.cboCPF_CNPJ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCPF_CNPJ.FormattingEnabled = true;
            this.cboCPF_CNPJ.Items.AddRange(new object[] {
            "CNPJ",
            "CPF"});
            this.cboCPF_CNPJ.Location = new System.Drawing.Point(133, 171);
            this.cboCPF_CNPJ.Name = "cboCPF_CNPJ";
            this.cboCPF_CNPJ.Size = new System.Drawing.Size(63, 21);
            this.cboCPF_CNPJ.TabIndex = 55;
            this.cboCPF_CNPJ.SelectedIndexChanged += new System.EventHandler(this.cboCPF_CNPJ_SelectedIndexChanged);
            // 
            // txtcpf_cnpj
            // 
            this.txtcpf_cnpj.Location = new System.Drawing.Point(202, 172);
            this.txtcpf_cnpj.Name = "txtcpf_cnpj";
            this.txtcpf_cnpj.Size = new System.Drawing.Size(149, 20);
            this.txtcpf_cnpj.TabIndex = 56;
            this.txtcpf_cnpj.Enter += new System.EventHandler(this.txtcpf_cnpj_Enter);
            // 
            // txtcrn
            // 
            this.txtcrn.Location = new System.Drawing.Point(133, 207);
            this.txtcrn.Name = "txtcrn";
            this.txtcrn.Size = new System.Drawing.Size(127, 20);
            this.txtcrn.TabIndex = 57;
            // 
            // CadastroNutricionista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 419);
            this.Controls.Add(this.txtcrn);
            this.Controls.Add(this.txtcpf_cnpj);
            this.Controls.Add(this.cboCPF_CNPJ);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtendereco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maskednascimento);
            this.Controls.Add(this.comboBoxsexo);
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
            this.Name = "CadastroNutricionista";
            this.Text = "Cadastro Nutricionista";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Formcadastronutricionista_Formclosed);
            this.Load += new System.EventHandler(this.formcadastronutricionista_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtendereco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskednascimento;
        private System.Windows.Forms.ComboBox comboBoxsexo;
        private System.Windows.Forms.Label labsexo;
        private System.Windows.Forms.Label labnascimento;
        private System.Windows.Forms.Label labsenha;
        private System.Windows.Forms.Label labemail;
        private System.Windows.Forms.Label labname;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtlogin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.ComboBox cboCPF_CNPJ;
        private System.Windows.Forms.MaskedTextBox txtcpf_cnpj;
        private System.Windows.Forms.TextBox txtcrn;
    }
}