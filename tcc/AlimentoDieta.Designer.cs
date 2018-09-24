namespace tcc
{
    partial class AlimentoDieta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboDieta = new System.Windows.Forms.ComboBox();
            this.gridAlimento = new System.Windows.Forms.DataGridView();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupo_nutricional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calorias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAlimento = new System.Windows.Forms.TextBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.txtGramas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTodosAlimentosDieta = new System.Windows.Forms.Button();
            this.btnTodos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridAlimento)).BeginInit();
            this.SuspendLayout();
            // 
            // cboDieta
            // 
            this.cboDieta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDieta.FormattingEnabled = true;
            this.cboDieta.Location = new System.Drawing.Point(104, 41);
            this.cboDieta.Name = "cboDieta";
            this.cboDieta.Size = new System.Drawing.Size(321, 21);
            this.cboDieta.TabIndex = 23;
            this.cboDieta.SelectedIndexChanged += new System.EventHandler(this.cboDieta_SelectedIndexChanged);
            // 
            // gridAlimento
            // 
            this.gridAlimento.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridAlimento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAlimento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome,
            this.grupo_nutricional,
            this.calorias,
            this.porcao});
            this.gridAlimento.Location = new System.Drawing.Point(93, 132);
            this.gridAlimento.MultiSelect = false;
            this.gridAlimento.Name = "gridAlimento";
            this.gridAlimento.ReadOnly = true;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAlimento.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gridAlimento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridAlimento.Size = new System.Drawing.Size(484, 201);
            this.gridAlimento.TabIndex = 22;
            // 
            // nome
            // 
            this.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // grupo_nutricional
            // 
            this.grupo_nutricional.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.grupo_nutricional.HeaderText = "Grupo Nutricional";
            this.grupo_nutricional.Name = "grupo_nutricional";
            this.grupo_nutricional.ReadOnly = true;
            this.grupo_nutricional.Width = 105;
            // 
            // calorias
            // 
            this.calorias.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.calorias.HeaderText = "Calorias por porção";
            this.calorias.Name = "calorias";
            this.calorias.ReadOnly = true;
            this.calorias.Width = 83;
            // 
            // porcao
            // 
            this.porcao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.porcao.HeaderText = "Porção";
            this.porcao.Name = "porcao";
            this.porcao.ReadOnly = true;
            this.porcao.Width = 66;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(392, 80);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 21;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Escolha a dieta :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Alimento :";
            // 
            // txtAlimento
            // 
            this.txtAlimento.Location = new System.Drawing.Point(104, 82);
            this.txtAlimento.Name = "txtAlimento";
            this.txtAlimento.Size = new System.Drawing.Size(282, 20);
            this.txtAlimento.TabIndex = 18;
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(221, 377);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 15;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(362, 377);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 17;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // txtGramas
            // 
            this.txtGramas.Location = new System.Drawing.Point(397, 342);
            this.txtGramas.Name = "txtGramas";
            this.txtGramas.Size = new System.Drawing.Size(180, 20);
            this.txtGramas.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Quantidade em gramas :";
            // 
            // btnTodosAlimentosDieta
            // 
            this.btnTodosAlimentosDieta.Location = new System.Drawing.Point(431, 39);
            this.btnTodosAlimentosDieta.Name = "btnTodosAlimentosDieta";
            this.btnTodosAlimentosDieta.Size = new System.Drawing.Size(146, 23);
            this.btnTodosAlimentosDieta.TabIndex = 21;
            this.btnTodosAlimentosDieta.Text = "Alimentos da dieta";
            this.btnTodosAlimentosDieta.UseVisualStyleBackColor = true;
            this.btnTodosAlimentosDieta.Click += new System.EventHandler(this.btnTodosAlimentosDieta_Click);
            // 
            // btnTodos
            // 
            this.btnTodos.Location = new System.Drawing.Point(473, 80);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(104, 23);
            this.btnTodos.TabIndex = 21;
            this.btnTodos.Text = "Todos alimentos";
            this.btnTodos.UseVisualStyleBackColor = true;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // AlimentoDieta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 450);
            this.Controls.Add(this.cboDieta);
            this.Controls.Add(this.gridAlimento);
            this.Controls.Add(this.btnTodosAlimentosDieta);
            this.Controls.Add(this.btnTodos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGramas);
            this.Controls.Add(this.txtAlimento);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAdicionar);
            this.Name = "AlimentoDieta";
            this.Text = "Alimento em Dieta";
            this.Load += new System.EventHandler(this.AlimentoDieta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAlimento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboDieta;
        private System.Windows.Forms.DataGridView gridAlimento;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAlimento;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupo_nutricional;
        private System.Windows.Forms.DataGridViewTextBoxColumn calorias;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcao;
        private System.Windows.Forms.TextBox txtGramas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTodosAlimentosDieta;
        private System.Windows.Forms.Button btnTodos;
    }
}