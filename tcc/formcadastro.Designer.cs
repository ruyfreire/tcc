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
            this.SuspendLayout();
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(147, 44);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(249, 20);
            this.txtname.TabIndex = 0;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(147, 80);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(249, 20);
            this.txtemail.TabIndex = 1;
            // 
            // txtsenha
            // 
            this.txtsenha.Location = new System.Drawing.Point(147, 118);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.PasswordChar = '*';
            this.txtsenha.Size = new System.Drawing.Size(129, 20);
            this.txtsenha.TabIndex = 2;
            // 
            // labname
            // 
            this.labname.AutoSize = true;
            this.labname.Location = new System.Drawing.Point(39, 44);
            this.labname.Name = "labname";
            this.labname.Size = new System.Drawing.Size(35, 13);
            this.labname.TabIndex = 5;
            this.labname.Text = "Nome";
            // 
            // labemail
            // 
            this.labemail.AutoSize = true;
            this.labemail.Location = new System.Drawing.Point(39, 80);
            this.labemail.Name = "labemail";
            this.labemail.Size = new System.Drawing.Size(35, 13);
            this.labemail.TabIndex = 6;
            this.labemail.Text = "E-mail";
            // 
            // labsenha
            // 
            this.labsenha.AutoSize = true;
            this.labsenha.Location = new System.Drawing.Point(39, 118);
            this.labsenha.Name = "labsenha";
            this.labsenha.Size = new System.Drawing.Size(38, 13);
            this.labsenha.TabIndex = 7;
            this.labsenha.Text = "Senha";
            // 
            // labnascimento
            // 
            this.labnascimento.AutoSize = true;
            this.labnascimento.Location = new System.Drawing.Point(39, 156);
            this.labnascimento.Name = "labnascimento";
            this.labnascimento.Size = new System.Drawing.Size(104, 13);
            this.labnascimento.TabIndex = 8;
            this.labnascimento.Text = "Data de Nascimento";
            // 
            // labsexo
            // 
            this.labsexo.AutoSize = true;
            this.labsexo.Location = new System.Drawing.Point(39, 192);
            this.labsexo.Name = "labsexo";
            this.labsexo.Size = new System.Drawing.Size(31, 13);
            this.labsexo.TabIndex = 9;
            this.labsexo.Text = "Sexo";
            // 
            // labpeso
            // 
            this.labpeso.AutoSize = true;
            this.labpeso.Location = new System.Drawing.Point(39, 226);
            this.labpeso.Name = "labpeso";
            this.labpeso.Size = new System.Drawing.Size(31, 13);
            this.labpeso.TabIndex = 12;
            this.labpeso.Text = "Peso";
            // 
            // labaltura
            // 
            this.labaltura.AutoSize = true;
            this.labaltura.Location = new System.Drawing.Point(39, 269);
            this.labaltura.Name = "labaltura";
            this.labaltura.Size = new System.Drawing.Size(34, 13);
            this.labaltura.TabIndex = 13;
            this.labaltura.Text = "Altura";
            // 
            // labobjetivo
            // 
            this.labobjetivo.AutoSize = true;
            this.labobjetivo.Location = new System.Drawing.Point(39, 308);
            this.labobjetivo.Name = "labobjetivo";
            this.labobjetivo.Size = new System.Drawing.Size(46, 13);
            this.labobjetivo.TabIndex = 15;
            this.labobjetivo.Text = "Objetivo";
            // 
            // comboBoxsexo
            // 
            this.comboBoxsexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxsexo.FormattingEnabled = true;
            this.comboBoxsexo.Items.AddRange(new object[] {
            "F",
            "M"});
            this.comboBoxsexo.Location = new System.Drawing.Point(147, 189);
            this.comboBoxsexo.Name = "comboBoxsexo";
            this.comboBoxsexo.Size = new System.Drawing.Size(48, 21);
            this.comboBoxsexo.TabIndex = 4;
            // 
            // comboBoxobjetivo
            // 
            this.comboBoxobjetivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxobjetivo.FormattingEnabled = true;
            this.comboBoxobjetivo.Items.AddRange(new object[] {
            "Ganhar Peso",
            "Perder Peso"});
            this.comboBoxobjetivo.Location = new System.Drawing.Point(147, 300);
            this.comboBoxobjetivo.Name = "comboBoxobjetivo";
            this.comboBoxobjetivo.Size = new System.Drawing.Size(116, 21);
            this.comboBoxobjetivo.TabIndex = 7;
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(147, 351);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 9;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnsalvar
            // 
            this.btnsalvar.Location = new System.Drawing.Point(321, 351);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(75, 23);
            this.btnsalvar.TabIndex = 8;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // maskednascimento
            // 
            this.maskednascimento.Location = new System.Drawing.Point(147, 148);
            this.maskednascimento.Mask = "00/00/0000";
            this.maskednascimento.Name = "maskednascimento";
            this.maskednascimento.Size = new System.Drawing.Size(65, 20);
            this.maskednascimento.TabIndex = 3;
            this.maskednascimento.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "6 a 8 Caracteres";
            // 
            // txtpeso
            // 
            this.txtpeso.Location = new System.Drawing.Point(147, 223);
            this.txtpeso.Name = "txtpeso";
            this.txtpeso.Size = new System.Drawing.Size(116, 20);
            this.txtpeso.TabIndex = 5;
            // 
            // txtaltura
            // 
            this.txtaltura.Location = new System.Drawing.Point(147, 262);
            this.txtaltura.Name = "txtaltura";
            this.txtaltura.Size = new System.Drawing.Size(116, 20);
            this.txtaltura.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "( 00,00 )";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "( 0,00 )";
            // 
            // formcadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 405);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maskednascimento);
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
            this.Controls.Add(this.labname);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.txtaltura);
            this.Controls.Add(this.txtpeso);
            this.Controls.Add(this.txtemail);
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
    }
}