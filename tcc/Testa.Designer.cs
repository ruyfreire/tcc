namespace tcc
{
    partial class Testa
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
            this.gridTabela = new System.Windows.Forms.DataGridView();
            this.btnCarregaTodos = new System.Windows.Forms.Button();
            this.btnCarregaEspecifico = new System.Windows.Forms.Button();
            this.btnCarregaLista = new System.Windows.Forms.Button();
            this.gridManha = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.gridAlmoco = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.gridTarde = new System.Windows.Forms.DataGridView();
            this.gridJanta = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridTabela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridManha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAlmoco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTarde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridJanta)).BeginInit();
            this.SuspendLayout();
            // 
            // gridTabela
            // 
            this.gridTabela.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTabela.Location = new System.Drawing.Point(12, 2);
            this.gridTabela.Name = "gridTabela";
            this.gridTabela.Size = new System.Drawing.Size(506, 16);
            this.gridTabela.TabIndex = 0;
            // 
            // btnCarregaTodos
            // 
            this.btnCarregaTodos.Location = new System.Drawing.Point(11, 28);
            this.btnCarregaTodos.Name = "btnCarregaTodos";
            this.btnCarregaTodos.Size = new System.Drawing.Size(104, 23);
            this.btnCarregaTodos.TabIndex = 1;
            this.btnCarregaTodos.Text = "user 1";
            this.btnCarregaTodos.UseVisualStyleBackColor = true;
            this.btnCarregaTodos.Click += new System.EventHandler(this.btnCarregaTodos_Click);
            // 
            // btnCarregaEspecifico
            // 
            this.btnCarregaEspecifico.Location = new System.Drawing.Point(212, 28);
            this.btnCarregaEspecifico.Name = "btnCarregaEspecifico";
            this.btnCarregaEspecifico.Size = new System.Drawing.Size(104, 23);
            this.btnCarregaEspecifico.TabIndex = 1;
            this.btnCarregaEspecifico.Text = "user 2";
            this.btnCarregaEspecifico.UseVisualStyleBackColor = true;
            this.btnCarregaEspecifico.Click += new System.EventHandler(this.btnCarregaEspecifico_Click);
            // 
            // btnCarregaLista
            // 
            this.btnCarregaLista.Location = new System.Drawing.Point(413, 28);
            this.btnCarregaLista.Name = "btnCarregaLista";
            this.btnCarregaLista.Size = new System.Drawing.Size(104, 23);
            this.btnCarregaLista.TabIndex = 1;
            this.btnCarregaLista.Text = "user 3";
            this.btnCarregaLista.UseVisualStyleBackColor = true;
            this.btnCarregaLista.Click += new System.EventHandler(this.btnCarregaLista_Click);
            // 
            // gridManha
            // 
            this.gridManha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridManha.Location = new System.Drawing.Point(12, 77);
            this.gridManha.Name = "gridManha";
            this.gridManha.Size = new System.Drawing.Size(506, 110);
            this.gridManha.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Café da Manhã";
            // 
            // gridAlmoco
            // 
            this.gridAlmoco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAlmoco.Location = new System.Drawing.Point(12, 205);
            this.gridAlmoco.Name = "gridAlmoco";
            this.gridAlmoco.Size = new System.Drawing.Size(506, 90);
            this.gridAlmoco.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Almoço";
            // 
            // gridTarde
            // 
            this.gridTarde.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTarde.Location = new System.Drawing.Point(12, 324);
            this.gridTarde.Name = "gridTarde";
            this.gridTarde.Size = new System.Drawing.Size(506, 101);
            this.gridTarde.TabIndex = 2;
            // 
            // gridJanta
            // 
            this.gridJanta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridJanta.Location = new System.Drawing.Point(12, 444);
            this.gridJanta.Name = "gridJanta";
            this.gridJanta.Size = new System.Drawing.Size(506, 100);
            this.gridJanta.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Café da Tarde";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 428);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Janta";
            // 
            // Testa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 548);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridJanta);
            this.Controls.Add(this.gridAlmoco);
            this.Controls.Add(this.gridTarde);
            this.Controls.Add(this.gridManha);
            this.Controls.Add(this.btnCarregaLista);
            this.Controls.Add(this.btnCarregaEspecifico);
            this.Controls.Add(this.btnCarregaTodos);
            this.Controls.Add(this.gridTabela);
            this.Name = "Testa";
            this.Text = "Testa";
            this.Load += new System.EventHandler(this.Testa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridTabela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridManha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAlmoco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTarde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridJanta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridTabela;
        private System.Windows.Forms.Button btnCarregaTodos;
        private System.Windows.Forms.Button btnCarregaEspecifico;
        private System.Windows.Forms.Button btnCarregaLista;
        private System.Windows.Forms.DataGridView gridManha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridAlmoco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridTarde;
        private System.Windows.Forms.DataGridView gridJanta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}