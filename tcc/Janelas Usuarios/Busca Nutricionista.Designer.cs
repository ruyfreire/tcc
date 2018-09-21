namespace tcc
{
    partial class Busca_Nutricionista
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtnutricionista = new System.Windows.Forms.TextBox();
            this.pesquisar = new System.Windows.Forms.Button();
            this.exibirlistacompleta = new System.Windows.Forms.Button();
            this.listanutricionista = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.listanutricionista)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nutricionista :";
            // 
            // txtnutricionista
            // 
            this.txtnutricionista.Location = new System.Drawing.Point(219, 61);
            this.txtnutricionista.Name = "txtnutricionista";
            this.txtnutricionista.Size = new System.Drawing.Size(245, 20);
            this.txtnutricionista.TabIndex = 1;
            // 
            // pesquisar
            // 
            this.pesquisar.Location = new System.Drawing.Point(481, 59);
            this.pesquisar.Name = "pesquisar";
            this.pesquisar.Size = new System.Drawing.Size(75, 23);
            this.pesquisar.TabIndex = 2;
            this.pesquisar.Text = "Pesquisar";
            this.pesquisar.UseVisualStyleBackColor = true;
            // 
            // exibirlistacompleta
            // 
            this.exibirlistacompleta.Location = new System.Drawing.Point(277, 147);
            this.exibirlistacompleta.Name = "exibirlistacompleta";
            this.exibirlistacompleta.Size = new System.Drawing.Size(151, 23);
            this.exibirlistacompleta.TabIndex = 3;
            this.exibirlistacompleta.Text = "Exibir Lista Completa";
            this.exibirlistacompleta.UseVisualStyleBackColor = true;
            // 
            // listanutricionista
            // 
            this.listanutricionista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listanutricionista.Location = new System.Drawing.Point(110, 202);
            this.listanutricionista.Name = "listanutricionista";
            this.listanutricionista.Size = new System.Drawing.Size(496, 319);
            this.listanutricionista.TabIndex = 4;
            // 
            // Busca_Nutricionista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 543);
            this.Controls.Add(this.listanutricionista);
            this.Controls.Add(this.exibirlistacompleta);
            this.Controls.Add(this.pesquisar);
            this.Controls.Add(this.txtnutricionista);
            this.Controls.Add(this.label1);
            this.Name = "Busca_Nutricionista";
            this.Text = "Busca_Nutricionista";
            this.Load += new System.EventHandler(this.Busca_Nutricionista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listanutricionista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnutricionista;
        private System.Windows.Forms.Button pesquisar;
        private System.Windows.Forms.Button exibirlistacompleta;
        private System.Windows.Forms.DataGridView listanutricionista;
    }
}