namespace tcc
{
    partial class CadastrarDieta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarDieta));
            this.btncadastrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtTipoDeRefeicao = new System.Windows.Forms.ComboBox();
            this.txtDiaDaSemana = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btncadastrar
            // 
            this.btncadastrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btncadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btncadastrar.Location = new System.Drawing.Point(268, 383);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(100, 23);
            this.btncadastrar.TabIndex = 25;
            this.btncadastrar.Text = "Cadastrar";
            this.btncadastrar.UseVisualStyleBackColor = true;
            this.btncadastrar.Click += new System.EventHandler(this.btncadastrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(253, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // txtTipoDeRefeicao
            // 
            this.txtTipoDeRefeicao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTipoDeRefeicao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtTipoDeRefeicao.FormattingEnabled = true;
            this.txtTipoDeRefeicao.Items.AddRange(new object[] {
            "Café da Manhã",
            "Almoço",
            "Café da Tarde",
            "Janta",
            "Ceia"});
            this.txtTipoDeRefeicao.Location = new System.Drawing.Point(182, 283);
            this.txtTipoDeRefeicao.Name = "txtTipoDeRefeicao";
            this.txtTipoDeRefeicao.Size = new System.Drawing.Size(320, 21);
            this.txtTipoDeRefeicao.TabIndex = 20;
            // 
            // txtDiaDaSemana
            // 
            this.txtDiaDaSemana.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDiaDaSemana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtDiaDaSemana.FormattingEnabled = true;
            this.txtDiaDaSemana.Items.AddRange(new object[] {
            "Domingo",
            "Segunda-feira",
            "Terça-feira",
            "Quarta-feira",
            "Quinta-feira",
            "Sexta-feira",
            "Sábado"});
            this.txtDiaDaSemana.Location = new System.Drawing.Point(182, 243);
            this.txtDiaDaSemana.Name = "txtDiaDaSemana";
            this.txtDiaDaSemana.Size = new System.Drawing.Size(320, 21);
            this.txtDiaDaSemana.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(81, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Tipo de Refeição:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(87, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Dia da Semana :";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "C A D A S T R A R    D I E T A";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // CadastrarDieta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(629, 452);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncadastrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDiaDaSemana);
            this.Controls.Add(this.txtTipoDeRefeicao);
            this.Name = "CadastrarDieta";
            this.Text = "Cadastrar Dieta";
            this.Load += new System.EventHandler(this.CadastrarDieta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox txtTipoDeRefeicao;
        private System.Windows.Forms.ComboBox txtDiaDaSemana;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}