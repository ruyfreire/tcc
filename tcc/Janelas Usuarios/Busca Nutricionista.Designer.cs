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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnutricionista = new System.Windows.Forms.TextBox();
            this.btnpesquisar = new System.Windows.Forms.Button();
            this.btnpesquisartudo = new System.Windows.Forms.Button();
            this.gridNutricionista = new System.Windows.Forms.DataGridView();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMeuNutricionista = new System.Windows.Forms.Button();
            this.btnContratar = new System.Windows.Forms.Button();
            this.btnDispensar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridNutricionista)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nutricionista :";
            // 
            // txtnutricionista
            // 
            this.txtnutricionista.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtnutricionista.Location = new System.Drawing.Point(142, 47);
            this.txtnutricionista.Name = "txtnutricionista";
            this.txtnutricionista.Size = new System.Drawing.Size(341, 20);
            this.txtnutricionista.TabIndex = 1;
            // 
            // btnpesquisar
            // 
            this.btnpesquisar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnpesquisar.Location = new System.Drawing.Point(489, 45);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnpesquisar.TabIndex = 2;
            this.btnpesquisar.Text = "Pesquisar";
            this.btnpesquisar.UseVisualStyleBackColor = true;
            this.btnpesquisar.Click += new System.EventHandler(this.btnpesquisar_Click);
            // 
            // btnpesquisartudo
            // 
            this.btnpesquisartudo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnpesquisartudo.Location = new System.Drawing.Point(244, 104);
            this.btnpesquisartudo.Name = "btnpesquisartudo";
            this.btnpesquisartudo.Size = new System.Drawing.Size(151, 23);
            this.btnpesquisartudo.TabIndex = 3;
            this.btnpesquisartudo.Text = "Exibir Lista Completa";
            this.btnpesquisartudo.UseVisualStyleBackColor = true;
            this.btnpesquisartudo.Click += new System.EventHandler(this.btnpesquisartudo_Click);
            // 
            // gridNutricionista
            // 
            this.gridNutricionista.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gridNutricionista.AllowUserToAddRows = false;
            this.gridNutricionista.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridNutricionista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridNutricionista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome,
            this.crn,
            this.email,
            this.endereco});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridNutricionista.DefaultCellStyle = dataGridViewCellStyle1;
            this.gridNutricionista.Location = new System.Drawing.Point(68, 144);
            this.gridNutricionista.MultiSelect = false;
            this.gridNutricionista.Name = "gridNutricionista";
            this.gridNutricionista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridNutricionista.Size = new System.Drawing.Size(496, 221);
            this.gridNutricionista.TabIndex = 4;
            // 
            // nome
            // 
            this.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.Width = 60;
            // 
            // crn
            // 
            this.crn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.crn.HeaderText = "CRN";
            this.crn.Name = "crn";
            this.crn.Width = 55;
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
            // btnMeuNutricionista
            // 
            this.btnMeuNutricionista.Location = new System.Drawing.Point(359, 96);
            this.btnMeuNutricionista.Name = "btnMeuNutricionista";
            this.btnMeuNutricionista.Size = new System.Drawing.Size(102, 23);
            this.btnMeuNutricionista.TabIndex = 16;
            this.btnMeuNutricionista.Text = "Meu Nutricionista";
            this.btnMeuNutricionista.UseVisualStyleBackColor = true;
            this.btnMeuNutricionista.Click += new System.EventHandler(this.btnMeuNutricionista_Click);
            // 
            // btnContratar
            // 
            this.btnContratar.Location = new System.Drawing.Point(332, 386);
            this.btnContratar.Name = "btnContratar";
            this.btnContratar.Size = new System.Drawing.Size(151, 23);
            this.btnContratar.TabIndex = 17;
            this.btnContratar.Text = "Contratar Nutricionista";
            this.btnContratar.UseVisualStyleBackColor = true;
            this.btnContratar.Click += new System.EventHandler(this.btnContratar_Click);
            // 
            // btnDispensar
            // 
            this.btnDispensar.Location = new System.Drawing.Point(148, 386);
            this.btnDispensar.Name = "btnDispensar";
            this.btnDispensar.Size = new System.Drawing.Size(151, 23);
            this.btnDispensar.TabIndex = 18;
            this.btnDispensar.Text = "Dispensar Nutricionista";
            this.btnDispensar.UseVisualStyleBackColor = true;
            this.btnDispensar.Click += new System.EventHandler(this.btnDispensar_Click);
            // 
            // Busca_Nutricionista
            // 
            this.AcceptButton = this.btnpesquisar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 441);
            this.Controls.Add(this.btnContratar);
            this.Controls.Add(this.btnDispensar);
            this.Controls.Add(this.btnMeuNutricionista);
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(629, 452);
            this.Controls.Add(this.gridNutricionista);
            this.Controls.Add(this.btnpesquisartudo);
            this.Controls.Add(this.btnpesquisar);
            this.Controls.Add(this.txtnutricionista);
            this.Controls.Add(this.label1);
            this.Name = "Busca_Nutricionista";
            this.Text = "Busca Nutricionista";
            this.Load += new System.EventHandler(this.Busca_Nutricionista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridNutricionista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnutricionista;
        private System.Windows.Forms.Button btnpesquisar;
        private System.Windows.Forms.Button btnpesquisartudo;
        private System.Windows.Forms.DataGridView gridNutricionista;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn crn;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn endereco;
        private System.Windows.Forms.Button btnMeuNutricionista;
        private System.Windows.Forms.Button btnContratar;
        private System.Windows.Forms.Button btnDispensar;
    }
}