namespace tcc
{
    partial class Alimentos
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
            this.alimento = new System.Windows.Forms.Label();
            this.gruponutricional = new System.Windows.Forms.Label();
            this.calorias = new System.Windows.Forms.Label();
            this.porcao = new System.Windows.Forms.Label();
            this.txtalimento = new System.Windows.Forms.TextBox();
            this.txtgrupoalimentar = new System.Windows.Forms.TextBox();
            this.txtcalorias = new System.Windows.Forms.TextBox();
            this.txtporcao = new System.Windows.Forms.TextBox();
            this.fechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // alimento
            // 
            this.alimento.AutoSize = true;
            this.alimento.Location = new System.Drawing.Point(138, 58);
            this.alimento.Name = "alimento";
            this.alimento.Size = new System.Drawing.Size(53, 13);
            this.alimento.TabIndex = 0;
            this.alimento.Text = "Alimento :";
            this.alimento.Click += new System.EventHandler(this.alimento_Click);
            // 
            // gruponutricional
            // 
            this.gruponutricional.AutoSize = true;
            this.gruponutricional.Location = new System.Drawing.Point(103, 102);
            this.gruponutricional.Name = "gruponutricional";
            this.gruponutricional.Size = new System.Drawing.Size(88, 13);
            this.gruponutricional.TabIndex = 1;
            this.gruponutricional.Text = "Grupo Alimentar :";
            this.gruponutricional.Click += new System.EventHandler(this.gruponutricional_Click);
            // 
            // calorias
            // 
            this.calorias.AutoSize = true;
            this.calorias.Location = new System.Drawing.Point(141, 147);
            this.calorias.Name = "calorias";
            this.calorias.Size = new System.Drawing.Size(50, 13);
            this.calorias.TabIndex = 2;
            this.calorias.Text = "Calorias :";
            this.calorias.Click += new System.EventHandler(this.calorias_Click);
            // 
            // porcao
            // 
            this.porcao.AutoSize = true;
            this.porcao.Location = new System.Drawing.Point(144, 190);
            this.porcao.Name = "porcao";
            this.porcao.Size = new System.Drawing.Size(47, 13);
            this.porcao.TabIndex = 3;
            this.porcao.Text = "Porção :";
            // 
            // txtalimento
            // 
            this.txtalimento.Location = new System.Drawing.Point(197, 55);
            this.txtalimento.Name = "txtalimento";
            this.txtalimento.Size = new System.Drawing.Size(266, 20);
            this.txtalimento.TabIndex = 4;
            // 
            // txtgrupoalimentar
            // 
            this.txtgrupoalimentar.Location = new System.Drawing.Point(197, 95);
            this.txtgrupoalimentar.Name = "txtgrupoalimentar";
            this.txtgrupoalimentar.Size = new System.Drawing.Size(266, 20);
            this.txtgrupoalimentar.TabIndex = 5;
            this.txtgrupoalimentar.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtcalorias
            // 
            this.txtcalorias.Location = new System.Drawing.Point(197, 140);
            this.txtcalorias.Name = "txtcalorias";
            this.txtcalorias.Size = new System.Drawing.Size(266, 20);
            this.txtcalorias.TabIndex = 6;
            // 
            // txtporcao
            // 
            this.txtporcao.Location = new System.Drawing.Point(197, 187);
            this.txtporcao.Name = "txtporcao";
            this.txtporcao.Size = new System.Drawing.Size(266, 20);
            this.txtporcao.TabIndex = 7;
            // 
            // fechar
            // 
            this.fechar.Location = new System.Drawing.Point(299, 256);
            this.fechar.Name = "fechar";
            this.fechar.Size = new System.Drawing.Size(75, 23);
            this.fechar.TabIndex = 8;
            this.fechar.Text = "Fechar";
            this.fechar.UseVisualStyleBackColor = true;
            // 
            // Alimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 450);
            this.Controls.Add(this.fechar);
            this.Controls.Add(this.txtporcao);
            this.Controls.Add(this.txtcalorias);
            this.Controls.Add(this.txtgrupoalimentar);
            this.Controls.Add(this.txtalimento);
            this.Controls.Add(this.porcao);
            this.Controls.Add(this.calorias);
            this.Controls.Add(this.gruponutricional);
            this.Controls.Add(this.alimento);
            this.Name = "Alimentos";
            this.Text = "Alimentos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label alimento;
        private System.Windows.Forms.Label gruponutricional;
        private System.Windows.Forms.Label calorias;
        private System.Windows.Forms.Label porcao;
        private System.Windows.Forms.TextBox txtalimento;
        private System.Windows.Forms.TextBox txtgrupoalimentar;
        private System.Windows.Forms.TextBox txtcalorias;
        private System.Windows.Forms.TextBox txtporcao;
        private System.Windows.Forms.Button fechar;
    }
}