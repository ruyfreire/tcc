namespace tcc
{
    partial class AlterarDieta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterarDieta));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiaDaSemana = new System.Windows.Forms.ComboBox();
            this.txtTipoDeRefeicao = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.cboSelecioneDieta = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "A L T E R A R    D I E T A";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(68, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dia da Semana:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(56, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo de Refeição :";
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
            this.txtDiaDaSemana.Location = new System.Drawing.Point(156, 280);
            this.txtDiaDaSemana.Name = "txtDiaDaSemana";
            this.txtDiaDaSemana.Size = new System.Drawing.Size(320, 21);
            this.txtDiaDaSemana.TabIndex = 6;
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
            this.txtTipoDeRefeicao.Location = new System.Drawing.Point(156, 320);
            this.txtTipoDeRefeicao.Name = "txtTipoDeRefeicao";
            this.txtTipoDeRefeicao.Size = new System.Drawing.Size(320, 21);
            this.txtTipoDeRefeicao.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(248, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnAlterar.Location = new System.Drawing.Point(260, 380);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(100, 23);
            this.btnAlterar.TabIndex = 12;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // cboSelecioneDieta
            // 
            this.cboSelecioneDieta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboSelecioneDieta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelecioneDieta.FormattingEnabled = true;
            this.cboSelecioneDieta.Location = new System.Drawing.Point(156, 185);
            this.cboSelecioneDieta.Name = "cboSelecioneDieta";
            this.cboSelecioneDieta.Size = new System.Drawing.Size(319, 21);
            this.cboSelecioneDieta.TabIndex = 13;
            this.cboSelecioneDieta.SelectedIndexChanged += new System.EventHandler(this.cboSelecioneDieta_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(57, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Selecione a Dieta:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(244, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "ALTERE OS DADOS";
            // 
            // AlterarDieta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(629, 452);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboSelecioneDieta);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtTipoDeRefeicao);
            this.Controls.Add(this.txtDiaDaSemana);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "AlterarDieta";
            this.Text = "Alterar Dieta";
            this.Load += new System.EventHandler(this.AlterarDieta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txtDiaDaSemana;
        private System.Windows.Forms.ComboBox txtTipoDeRefeicao;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.ComboBox cboSelecioneDieta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
    }
}