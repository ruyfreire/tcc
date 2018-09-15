namespace tcc
{
    partial class Busca_Personal
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
            this.listanutricionista = new System.Windows.Forms.DataGridView();
            this.exibirlistacompleta = new System.Windows.Forms.Button();
            this.pesquisar = new System.Windows.Forms.Button();
            this.txtpersonal = new System.Windows.Forms.TextBox();
            this.buscapersonal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listanutricionista)).BeginInit();
            this.SuspendLayout();
            // 
            // listanutricionista
            // 
            this.listanutricionista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listanutricionista.Location = new System.Drawing.Point(144, 208);
            this.listanutricionista.Name = "listanutricionista";
            this.listanutricionista.Size = new System.Drawing.Size(496, 319);
            this.listanutricionista.TabIndex = 14;
            // 
            // exibirlistacompleta
            // 
            this.exibirlistacompleta.Location = new System.Drawing.Point(311, 153);
            this.exibirlistacompleta.Name = "exibirlistacompleta";
            this.exibirlistacompleta.Size = new System.Drawing.Size(151, 23);
            this.exibirlistacompleta.TabIndex = 13;
            this.exibirlistacompleta.Text = "Exibir Lista Completa";
            this.exibirlistacompleta.UseVisualStyleBackColor = true;
            // 
            // pesquisar
            // 
            this.pesquisar.Location = new System.Drawing.Point(515, 65);
            this.pesquisar.Name = "pesquisar";
            this.pesquisar.Size = new System.Drawing.Size(75, 23);
            this.pesquisar.TabIndex = 12;
            this.pesquisar.Text = "Pesquisar";
            this.pesquisar.UseVisualStyleBackColor = true;
            // 
            // txtpersonal
            // 
            this.txtpersonal.Location = new System.Drawing.Point(253, 67);
            this.txtpersonal.Name = "txtpersonal";
            this.txtpersonal.Size = new System.Drawing.Size(245, 20);
            this.txtpersonal.TabIndex = 11;
            // 
            // buscapersonal
            // 
            this.buscapersonal.AutoSize = true;
            this.buscapersonal.Location = new System.Drawing.Point(176, 70);
            this.buscapersonal.Name = "buscapersonal";
            this.buscapersonal.Size = new System.Drawing.Size(54, 13);
            this.buscapersonal.TabIndex = 10;
            this.buscapersonal.Text = "Personal :";
            // 
            // Busca_Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listanutricionista);
            this.Controls.Add(this.exibirlistacompleta);
            this.Controls.Add(this.pesquisar);
            this.Controls.Add(this.txtpersonal);
            this.Controls.Add(this.buscapersonal);
            this.Name = "Busca_Personal";
            this.Text = "Busca_Personal";
            ((System.ComponentModel.ISupportInitialize)(this.listanutricionista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listanutricionista;
        private System.Windows.Forms.Button exibirlistacompleta;
        private System.Windows.Forms.Button pesquisar;
        private System.Windows.Forms.TextBox txtpersonal;
        private System.Windows.Forms.Label buscapersonal;
    }
}