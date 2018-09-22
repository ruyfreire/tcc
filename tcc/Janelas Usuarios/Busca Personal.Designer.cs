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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buscapersonal = new System.Windows.Forms.Label();
            this.gridPersonal = new System.Windows.Forms.DataGridView();
            this.btnpesquisartudo = new System.Windows.Forms.Button();
            this.btnpesquisar = new System.Windows.Forms.Button();
            this.txtpersonal = new System.Windows.Forms.TextBox();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridPersonal)).BeginInit();
            this.SuspendLayout();
            // 
            // buscapersonal
            // 
            this.buscapersonal.AutoSize = true;
            this.buscapersonal.Location = new System.Drawing.Point(65, 50);
            this.buscapersonal.Name = "buscapersonal";
            this.buscapersonal.Size = new System.Drawing.Size(54, 13);
            this.buscapersonal.TabIndex = 10;
            this.buscapersonal.Text = "Personal :";
            // 
            // gridPersonal
            // 
            this.gridPersonal.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPersonal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome,
            this.crea,
            this.email,
            this.endereco});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPersonal.DefaultCellStyle = dataGridViewCellStyle1;
            this.gridPersonal.Location = new System.Drawing.Point(68, 166);
            this.gridPersonal.Name = "gridPersonal";
            this.gridPersonal.Size = new System.Drawing.Size(496, 221);
            this.gridPersonal.TabIndex = 14;
            // 
            // btnpesquisartudo
            // 
            this.btnpesquisartudo.Location = new System.Drawing.Point(229, 101);
            this.btnpesquisartudo.Name = "btnpesquisartudo";
            this.btnpesquisartudo.Size = new System.Drawing.Size(151, 23);
            this.btnpesquisartudo.TabIndex = 13;
            this.btnpesquisartudo.Text = "Exibir Lista Completa";
            this.btnpesquisartudo.UseVisualStyleBackColor = true;
            this.btnpesquisartudo.Click += new System.EventHandler(this.btnpesquisartudo_Click);
            // 
            // btnpesquisar
            // 
            this.btnpesquisar.Location = new System.Drawing.Point(489, 45);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnpesquisar.TabIndex = 12;
            this.btnpesquisar.Text = "Pesquisar";
            this.btnpesquisar.UseVisualStyleBackColor = true;
            this.btnpesquisar.Click += new System.EventHandler(this.btnpesquisar_Click);
            // 
            // txtpersonal
            // 
            this.txtpersonal.Location = new System.Drawing.Point(125, 47);
            this.txtpersonal.Name = "txtpersonal";
            this.txtpersonal.Size = new System.Drawing.Size(358, 20);
            this.txtpersonal.TabIndex = 11;
            // 
            // nome
            // 
            this.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.Width = 60;
            // 
            // crea
            // 
            this.crea.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.crea.HeaderText = "CREA";
            this.crea.Name = "crea";
            this.crea.Width = 61;
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.email.HeaderText = "E-mail";
            this.email.Name = "email";
            this.email.Width = 60;
            // 
            // endereco
            // 
            this.endereco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.endereco.HeaderText = "Endereço";
            this.endereco.Name = "endereco";
            // 
            // Busca_Personal
            // 
            this.AcceptButton = this.btnpesquisar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 441);
            this.Controls.Add(this.gridPersonal);
            this.Controls.Add(this.btnpesquisartudo);
            this.Controls.Add(this.btnpesquisar);
            this.Controls.Add(this.txtpersonal);
            this.Controls.Add(this.buscapersonal);
            this.Name = "Busca_Personal";
            this.Text = "Busca Personal";
            ((System.ComponentModel.ISupportInitialize)(this.gridPersonal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label buscapersonal;
        private System.Windows.Forms.DataGridView gridPersonal;
        private System.Windows.Forms.Button btnpesquisartudo;
        private System.Windows.Forms.Button btnpesquisar;
        private System.Windows.Forms.TextBox txtpersonal;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn crea;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn endereco;
    }
}