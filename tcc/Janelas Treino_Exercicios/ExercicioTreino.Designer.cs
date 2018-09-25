namespace tcc
{
    partial class ExercicioTreino
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
            this.cboTreino = new System.Windows.Forms.ComboBox();
            this.gridExercicio = new System.Windows.Forms.DataGridView();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupo_muscular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_exercicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtExercicio = new System.Windows.Forms.TextBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnTodosExerciciosTreino = new System.Windows.Forms.Button();
            this.btnTodos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridExercicio)).BeginInit();
            this.SuspendLayout();
            // 
            // cboTreino
            // 
            this.cboTreino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTreino.FormattingEnabled = true;
            this.cboTreino.Location = new System.Drawing.Point(116, 48);
            this.cboTreino.Name = "cboTreino";
            this.cboTreino.Size = new System.Drawing.Size(306, 21);
            this.cboTreino.TabIndex = 32;
            this.cboTreino.SelectedIndexChanged += new System.EventHandler(this.cboTreino_SelectedIndexChanged);
            // 
            // gridExercicio
            // 
            this.gridExercicio.AllowUserToAddRows = false;
            this.gridExercicio.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridExercicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridExercicio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome,
            this.grupo_muscular,
            this.tipo_exercicio});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridExercicio.DefaultCellStyle = dataGridViewCellStyle1;
            this.gridExercicio.Location = new System.Drawing.Point(90, 151);
            this.gridExercicio.MultiSelect = false;
            this.gridExercicio.Name = "gridExercicio";
            this.gridExercicio.ReadOnly = true;
            this.gridExercicio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridExercicio.Size = new System.Drawing.Size(484, 209);
            this.gridExercicio.TabIndex = 31;
            // 
            // nome
            // 
            this.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // grupo_muscular
            // 
            this.grupo_muscular.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.grupo_muscular.HeaderText = "Grupo Muscular";
            this.grupo_muscular.Name = "grupo_muscular";
            this.grupo_muscular.ReadOnly = true;
            this.grupo_muscular.Width = 98;
            // 
            // tipo_exercicio
            // 
            this.tipo_exercicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tipo_exercicio.HeaderText = "Tipo de Exercício";
            this.tipo_exercicio.Name = "tipo_exercicio";
            this.tipo_exercicio.ReadOnly = true;
            this.tipo_exercicio.Width = 106;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(393, 100);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 30;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Escolha o treino :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Exercício :";
            // 
            // txtExercicio
            // 
            this.txtExercicio.Location = new System.Drawing.Point(116, 102);
            this.txtExercicio.Name = "txtExercicio";
            this.txtExercicio.Size = new System.Drawing.Size(271, 20);
            this.txtExercicio.TabIndex = 27;
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(350, 379);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 24;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(223, 379);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 26;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnTodosExerciciosTreino
            // 
            this.btnTodosExerciciosTreino.Location = new System.Drawing.Point(428, 46);
            this.btnTodosExerciciosTreino.Name = "btnTodosExerciciosTreino";
            this.btnTodosExerciciosTreino.Size = new System.Drawing.Size(146, 23);
            this.btnTodosExerciciosTreino.TabIndex = 33;
            this.btnTodosExerciciosTreino.Text = "Exercicios do Treino";
            this.btnTodosExerciciosTreino.UseVisualStyleBackColor = true;
            this.btnTodosExerciciosTreino.Click += new System.EventHandler(this.btnTodosExerciciosTreino_Click);
            // 
            // btnTodos
            // 
            this.btnTodos.Location = new System.Drawing.Point(474, 100);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(100, 23);
            this.btnTodos.TabIndex = 34;
            this.btnTodos.Text = "Todos exercícios";
            this.btnTodos.UseVisualStyleBackColor = true;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // ExercicioTreino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(629, 452);
            this.Controls.Add(this.btnTodosExerciciosTreino);
            this.Controls.Add(this.btnTodos);
            this.Controls.Add(this.cboTreino);
            this.Controls.Add(this.gridExercicio);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtExercicio);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAdicionar);
            this.Name = "ExercicioTreino";
            this.Text = "Exercicio em Treino";
            this.Load += new System.EventHandler(this.ExercicioTreino_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridExercicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboTreino;
        private System.Windows.Forms.DataGridView gridExercicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupo_muscular;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_exercicio;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtExercicio;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnTodosExerciciosTreino;
        private System.Windows.Forms.Button btnTodos;
    }
}