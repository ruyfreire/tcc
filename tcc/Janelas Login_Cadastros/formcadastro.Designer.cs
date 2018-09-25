namespace tcc
{
    partial class formcadastro
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
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.labname = new System.Windows.Forms.Label();
            this.labemail = new System.Windows.Forms.Label();
            this.labsenha = new System.Windows.Forms.Label();
            this.labnascimento = new System.Windows.Forms.Label();
            this.labsexo = new System.Windows.Forms.Label();
            this.labpeso = new System.Windows.Forms.Label();
            this.labaltura = new System.Windows.Forms.Label();
            this.labobjetivo = new System.Windows.Forms.Label();
            this.comboBoxsexo = new System.Windows.Forms.ComboBox();
            this.comboBoxobjetivo = new System.Windows.Forms.ComboBox();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.maskednascimento = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpeso = new System.Windows.Forms.TextBox();
            this.txtaltura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtlogin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtname
            // 
            this.txtname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtname.Location = new System.Drawing.Point(220, 46);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(249, 20);
            this.txtname.TabIndex = 0;
            // 
            // txtemail
            // 
            this.txtemail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtemail.Location = new System.Drawing.Point(220, 119);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(249, 20);
            this.txtemail.TabIndex = 2;
            // 
            // txtsenha
            // 
            this.txtsenha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtsenha.Location = new System.Drawing.Point(220, 156);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.PasswordChar = '*';
            this.txtsenha.Size = new System.Drawing.Size(129, 20);
            this.txtsenha.TabIndex = 3;
            this.txtsenha.UseSystemPasswordChar = true;
            // 
            // labname
            // 
            this.labname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labname.AutoSize = true;
            this.labname.Location = new System.Drawing.Point(171, 49);
            this.labname.Name = "labname";
            this.labname.Size = new System.Drawing.Size(41, 13);
            this.labname.TabIndex = 5;
            this.labname.Text = "Nome :";
            // 
            // labemail
            // 
            this.labemail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labemail.AutoSize = true;
            this.labemail.Location = new System.Drawing.Point(171, 122);
            this.labemail.Name = "labemail";
            this.labemail.Size = new System.Drawing.Size(41, 13);
            this.labemail.TabIndex = 6;
            this.labemail.Text = "E-mail :";
            // 
            // labsenha
            // 
            this.labsenha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labsenha.AutoSize = true;
            this.labsenha.Location = new System.Drawing.Point(171, 159);
            this.labsenha.Name = "labsenha";
            this.labsenha.Size = new System.Drawing.Size(44, 13);
            this.labsenha.TabIndex = 7;
            this.labsenha.Text = "Senha :";
            // 
            // labnascimento
            // 
            this.labnascimento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labnascimento.AutoSize = true;
            this.labnascimento.Location = new System.Drawing.Point(105, 195);
            this.labnascimento.Name = "labnascimento";
            this.labnascimento.Size = new System.Drawing.Size(110, 13);
            this.labnascimento.TabIndex = 8;
            this.labnascimento.Text = "Data de Nascimento :";
            // 
            // labsexo
            // 
            this.labsexo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labsexo.AutoSize = true;
            this.labsexo.Location = new System.Drawing.Point(175, 232);
            this.labsexo.Name = "labsexo";
            this.labsexo.Size = new System.Drawing.Size(37, 13);
            this.labsexo.TabIndex = 9;
            this.labsexo.Text = "Sexo :";
            // 
            // labpeso
            // 
            this.labpeso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labpeso.AutoSize = true;
            this.labpeso.Location = new System.Drawing.Point(175, 267);
            this.labpeso.Name = "labpeso";
            this.labpeso.Size = new System.Drawing.Size(37, 13);
            this.labpeso.TabIndex = 12;
            this.labpeso.Text = "Peso :";
            // 
            // labaltura
            // 
            this.labaltura.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labaltura.AutoSize = true;
            this.labaltura.Location = new System.Drawing.Point(175, 307);
            this.labaltura.Name = "labaltura";
            this.labaltura.Size = new System.Drawing.Size(40, 13);
            this.labaltura.TabIndex = 13;
            this.labaltura.Text = "Altura :";
            // 
            // labobjetivo
            // 
            this.labobjetivo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labobjetivo.AutoSize = true;
            this.labobjetivo.Location = new System.Drawing.Point(163, 340);
            this.labobjetivo.Name = "labobjetivo";
            this.labobjetivo.Size = new System.Drawing.Size(52, 13);
            this.labobjetivo.TabIndex = 15;
            this.labobjetivo.Text = "Objetivo :";
            // 
            // comboBoxsexo
            // 
            this.comboBoxsexo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxsexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxsexo.FormattingEnabled = true;
            this.comboBoxsexo.Items.AddRange(new object[] {
            "F",
            "M"});
            this.comboBoxsexo.Location = new System.Drawing.Point(220, 229);
            this.comboBoxsexo.Name = "comboBoxsexo";
            this.comboBoxsexo.Size = new System.Drawing.Size(129, 21);
            this.comboBoxsexo.TabIndex = 5;
            // 
            // comboBoxobjetivo
            // 
            this.comboBoxobjetivo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxobjetivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxobjetivo.FormattingEnabled = true;
            this.comboBoxobjetivo.Items.AddRange(new object[] {
            "Ganhar Peso",
            "Perder Peso"});
            this.comboBoxobjetivo.Location = new System.Drawing.Point(220, 337);
            this.comboBoxobjetivo.Name = "comboBoxobjetivo";
            this.comboBoxobjetivo.Size = new System.Drawing.Size(129, 21);
            this.comboBoxobjetivo.TabIndex = 8;
            // 
            // btnlimpar
            // 
            this.btnlimpar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnlimpar.Location = new System.Drawing.Point(248, 397);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 10;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnsalvar
            // 
            this.btnsalvar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnsalvar.Location = new System.Drawing.Point(364, 397);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(75, 23);
            this.btnsalvar.TabIndex = 9;
            this.btnsalvar.Text = "Criar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // maskednascimento
            // 
            this.maskednascimento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.maskednascimento.Location = new System.Drawing.Point(220, 192);
            this.maskednascimento.Mask = "00/00/0000";
            this.maskednascimento.Name = "maskednascimento";
            this.maskednascimento.Size = new System.Drawing.Size(129, 20);
            this.maskednascimento.TabIndex = 4;
            this.maskednascimento.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(355, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "6 a 8 Caracteres";
            // 
            // txtpeso
            // 
            this.txtpeso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtpeso.Location = new System.Drawing.Point(220, 264);
            this.txtpeso.Name = "txtpeso";
            this.txtpeso.Size = new System.Drawing.Size(129, 20);
            this.txtpeso.TabIndex = 6;
            // 
            // txtaltura
            // 
            this.txtaltura.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtaltura.Location = new System.Drawing.Point(220, 301);
            this.txtaltura.Name = "txtaltura";
            this.txtaltura.Size = new System.Drawing.Size(129, 20);
            this.txtaltura.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(355, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "( 00,00 )";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(355, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "( 0,00 )";
            // 
            // txtlogin
            // 
            this.txtlogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtlogin.Location = new System.Drawing.Point(220, 83);
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(249, 20);
            this.txtlogin.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Login :";
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btncancelar.Location = new System.Drawing.Point(132, 397);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 11;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // formcadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(629, 452);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maskednascimento);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.comboBoxobjetivo);
            this.Controls.Add(this.comboBoxsexo);
            this.Controls.Add(this.labobjetivo);
            this.Controls.Add(this.labaltura);
            this.Controls.Add(this.labpeso);
            this.Controls.Add(this.labsexo);
            this.Controls.Add(this.labnascimento);
            this.Controls.Add(this.labsenha);
            this.Controls.Add(this.labemail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labname);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.txtaltura);
            this.Controls.Add(this.txtpeso);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtlogin);
            this.Controls.Add(this.txtname);
            this.MaximizeBox = false;
            this.Name = "formcadastro";
            this.Text = "Cadastro Usuário";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formcadastro_FormClosed);
            this.Load += new System.EventHandler(this.formcadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.Label labname;
        private System.Windows.Forms.Label labemail;
        private System.Windows.Forms.Label labsenha;
        private System.Windows.Forms.Label labnascimento;
        private System.Windows.Forms.Label labsexo;
        private System.Windows.Forms.Label labpeso;
        private System.Windows.Forms.Label labaltura;
        private System.Windows.Forms.Label labobjetivo;
        private System.Windows.Forms.ComboBox comboBoxsexo;
        private System.Windows.Forms.ComboBox comboBoxobjetivo;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.MaskedTextBox maskednascimento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpeso;
        private System.Windows.Forms.TextBox txtaltura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtlogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btncancelar;
    }
}