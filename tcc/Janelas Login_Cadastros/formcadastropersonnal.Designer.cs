namespace tcc
{
    partial class CadastroPersonal
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
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcrea = new System.Windows.Forms.TextBox();
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
            this.label6 = new System.Windows.Forms.Label();
            this.labname = new System.Windows.Forms.Label();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtlogin = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtcpf_cnpj = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(70, 364);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 11;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // btnsalvar
            // 
            this.btnsalvar.Location = new System.Drawing.Point(314, 364);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(75, 23);
            this.btnsalvar.TabIndex = 9;
            this.btnsalvar.Text = "Criar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(192, 364);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 10;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 77;
            this.label5.Text = "CREA";
            // 
            // txtcrea
            // 
            this.txtcrea.Location = new System.Drawing.Point(140, 200);
            this.txtcrea.Name = "txtcrea";
            this.txtcrea.Size = new System.Drawing.Size(129, 20);
            this.txtcrea.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 75;
            this.label4.Text = "Sem pontos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 74;
            this.label2.Text = "CPF_CNPJ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 73;
            this.label1.Text = "Endereço";
            // 
            // txtendereco
            // 
            this.txtendereco.Location = new System.Drawing.Point(140, 309);
            this.txtendereco.Multiline = true;
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.Size = new System.Drawing.Size(249, 49);
            this.txtendereco.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 71;
            this.label3.Text = "6 a 8";
            // 
            // maskednascimento
            // 
            this.maskednascimento.Location = new System.Drawing.Point(140, 236);
            this.maskednascimento.Mask = "00/00/0000";
            this.maskednascimento.Name = "maskednascimento";
            this.maskednascimento.Size = new System.Drawing.Size(129, 20);
            this.maskednascimento.TabIndex = 6;
            this.maskednascimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskednascimento.ValidatingType = typeof(System.DateTime);
            // 
            // comboBoxsexo
            // 
            this.comboBoxsexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxsexo.FormattingEnabled = true;
            this.comboBoxsexo.Items.AddRange(new object[] {
            "F",
            "M"});
            this.comboBoxsexo.Location = new System.Drawing.Point(140, 272);
            this.comboBoxsexo.Name = "comboBoxsexo";
            this.comboBoxsexo.Size = new System.Drawing.Size(48, 21);
            this.comboBoxsexo.TabIndex = 7;
            // 
            // labsexo
            // 
            this.labsexo.AutoSize = true;
            this.labsexo.Location = new System.Drawing.Point(89, 275);
            this.labsexo.Name = "labsexo";
            this.labsexo.Size = new System.Drawing.Size(31, 13);
            this.labsexo.TabIndex = 70;
            this.labsexo.Text = "Sexo";
            // 
            // labnascimento
            // 
            this.labnascimento.AutoSize = true;
            this.labnascimento.Location = new System.Drawing.Point(19, 239);
            this.labnascimento.Name = "labnascimento";
            this.labnascimento.Size = new System.Drawing.Size(104, 13);
            this.labnascimento.TabIndex = 69;
            this.labnascimento.Text = "Data de Nascimento";
            // 
            // labsenha
            // 
            this.labsenha.AutoSize = true;
            this.labsenha.Location = new System.Drawing.Point(85, 131);
            this.labsenha.Name = "labsenha";
            this.labsenha.Size = new System.Drawing.Size(38, 13);
            this.labsenha.TabIndex = 68;
            this.labsenha.Text = "Senha";
            // 
            // labemail
            // 
            this.labemail.AutoSize = true;
            this.labemail.Location = new System.Drawing.Point(85, 95);
            this.labemail.Name = "labemail";
            this.labemail.Size = new System.Drawing.Size(35, 13);
            this.labemail.TabIndex = 67;
            this.labemail.Text = "E-mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 66;
            this.label6.Text = "Login";
            // 
            // labname
            // 
            this.labname.AutoSize = true;
            this.labname.Location = new System.Drawing.Point(85, 23);
            this.labname.Name = "labname";
            this.labname.Size = new System.Drawing.Size(35, 13);
            this.labname.TabIndex = 65;
            this.labname.Text = "Nome";
            // 
            // txtsenha
            // 
            this.txtsenha.Location = new System.Drawing.Point(140, 128);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.PasswordChar = '*';
            this.txtsenha.Size = new System.Drawing.Size(129, 20);
            this.txtsenha.TabIndex = 3;
            this.txtsenha.UseSystemPasswordChar = true;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(140, 92);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(249, 20);
            this.txtemail.TabIndex = 2;
            // 
            // txtlogin
            // 
            this.txtlogin.Location = new System.Drawing.Point(140, 56);
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(249, 20);
            this.txtlogin.TabIndex = 1;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(140, 20);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(249, 20);
            this.txtname.TabIndex = 0;
            // 
            // txtcpf_cnpj
            // 
            this.txtcpf_cnpj.Location = new System.Drawing.Point(140, 164);
            this.txtcpf_cnpj.Name = "txtcpf_cnpj";
            this.txtcpf_cnpj.Size = new System.Drawing.Size(127, 20);
            this.txtcpf_cnpj.TabIndex = 4;
            // 
            // CadastroPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 406);
            this.Controls.Add(this.txtcpf_cnpj);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtcrea);
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
            this.Name = "CadastroPersonal";
            this.Text = "Cadastro Personal   ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadastroPersonal_FormClosed);
            this.Load += new System.EventHandler(this.formcadastropersonnal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcrea;
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labname;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtlogin;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtcpf_cnpj;
    }
}