namespace tcc
{
    partial class Exercicios
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
            this.grupomuscular = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.Label();
            this.execucao = new System.Windows.Forms.Label();
            this.queimacalorica = new System.Windows.Forms.Label();
            this.txtgrupoalimentar = new System.Windows.Forms.TextBox();
            this.txtexercicio = new System.Windows.Forms.TextBox();
            this.txtexecucao = new System.Windows.Forms.TextBox();
            this.txtqueimacalorica = new System.Windows.Forms.TextBox();
            this.fechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // grupomuscular
            // 
            this.grupomuscular.AutoSize = true;
            this.grupomuscular.Location = new System.Drawing.Point(147, 56);
            this.grupomuscular.Name = "grupomuscular";
            this.grupomuscular.Size = new System.Drawing.Size(88, 13);
            this.grupomuscular.TabIndex = 0;
            this.grupomuscular.Text = "Grupo Muscular :";
            this.grupomuscular.Click += new System.EventHandler(this.label1_Click);
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Location = new System.Drawing.Point(174, 102);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(58, 13);
            this.nome.TabIndex = 1;
            this.nome.Text = "Exercício :";
            // 
            // execucao
            // 
            this.execucao.AutoSize = true;
            this.execucao.Location = new System.Drawing.Point(174, 146);
            this.execucao.Name = "execucao";
            this.execucao.Size = new System.Drawing.Size(61, 13);
            this.execucao.TabIndex = 2;
            this.execucao.Text = "Execução :";
            // 
            // queimacalorica
            // 
            this.queimacalorica.AutoSize = true;
            this.queimacalorica.Location = new System.Drawing.Point(145, 189);
            this.queimacalorica.Name = "queimacalorica";
            this.queimacalorica.Size = new System.Drawing.Size(90, 13);
            this.queimacalorica.TabIndex = 3;
            this.queimacalorica.Text = "Queima Calorica :";
            // 
            // txtgrupoalimentar
            // 
            this.txtgrupoalimentar.Location = new System.Drawing.Point(241, 53);
            this.txtgrupoalimentar.Name = "txtgrupoalimentar";
            this.txtgrupoalimentar.Size = new System.Drawing.Size(227, 20);
            this.txtgrupoalimentar.TabIndex = 4;
            // 
            // txtexercicio
            // 
            this.txtexercicio.Location = new System.Drawing.Point(241, 99);
            this.txtexercicio.Name = "txtexercicio";
            this.txtexercicio.Size = new System.Drawing.Size(227, 20);
            this.txtexercicio.TabIndex = 5;
            // 
            // txtexecucao
            // 
            this.txtexecucao.Location = new System.Drawing.Point(241, 143);
            this.txtexecucao.Name = "txtexecucao";
            this.txtexecucao.Size = new System.Drawing.Size(227, 20);
            this.txtexecucao.TabIndex = 6;
            // 
            // txtqueimacalorica
            // 
            this.txtqueimacalorica.Location = new System.Drawing.Point(241, 189);
            this.txtqueimacalorica.Name = "txtqueimacalorica";
            this.txtqueimacalorica.Size = new System.Drawing.Size(227, 20);
            this.txtqueimacalorica.TabIndex = 7;
            // 
            // fechar
            // 
            this.fechar.Location = new System.Drawing.Point(322, 256);
            this.fechar.Name = "fechar";
            this.fechar.Size = new System.Drawing.Size(75, 23);
            this.fechar.TabIndex = 8;
            this.fechar.Text = "Fechar";
            this.fechar.UseVisualStyleBackColor = true;
            // 
            // Exercicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 450);
            this.Controls.Add(this.fechar);
            this.Controls.Add(this.txtqueimacalorica);
            this.Controls.Add(this.txtexecucao);
            this.Controls.Add(this.txtexercicio);
            this.Controls.Add(this.txtgrupoalimentar);
            this.Controls.Add(this.queimacalorica);
            this.Controls.Add(this.execucao);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.grupomuscular);
            this.Name = "Exercicios";
            this.Text = "Exercicio: ";
            this.Load += new System.EventHandler(this.Exercicios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label grupomuscular;
        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.Label execucao;
        private System.Windows.Forms.Label queimacalorica;
        private System.Windows.Forms.TextBox txtgrupoalimentar;
        private System.Windows.Forms.TextBox txtexercicio;
        private System.Windows.Forms.TextBox txtexecucao;
        private System.Windows.Forms.TextBox txtqueimacalorica;
        private System.Windows.Forms.Button fechar;
    }
}