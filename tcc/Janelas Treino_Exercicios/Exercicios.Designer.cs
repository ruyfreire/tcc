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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridExercicios = new System.Windows.Forms.DataGridView();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupo_muscular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_exercicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.btnBuscarTodos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridExercicios)).BeginInit();
            this.SuspendLayout();
            // 
            // gridExercicios
            // 
            this.gridExercicios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridExercicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridExercicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome,
            this.grupo_muscular,
            this.tipo_exercicio});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridExercicios.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridExercicios.Location = new System.Drawing.Point(72, 182);
            this.gridExercicios.Name = "gridExercicios";
            this.gridExercicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridExercicios.Size = new System.Drawing.Size(506, 230);
            this.gridExercicios.TabIndex = 15;
            // 
            // nome
            // 
            this.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            // 
            // grupo_muscular
            // 
            this.grupo_muscular.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.grupo_muscular.HeaderText = "Grupo Muscular";
            this.grupo_muscular.Name = "grupo_muscular";
            this.grupo_muscular.Width = 98;
            // 
            // tipo_exercicio
            // 
            this.tipo_exercicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tipo_exercicio.HeaderText = "Tipo de Exercício";
            this.tipo_exercicio.Name = "tipo_exercicio";
            this.tipo_exercicio.Width = 106;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nome do exercício :";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(503, 66);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(217, 68);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(266, 20);
            this.txtBusca.TabIndex = 12;
            // 
            // btnBuscarTodos
            // 
            this.btnBuscarTodos.Location = new System.Drawing.Point(233, 124);
            this.btnBuscarTodos.Name = "btnBuscarTodos";
            this.btnBuscarTodos.Size = new System.Drawing.Size(152, 23);
            this.btnBuscarTodos.TabIndex = 16;
            this.btnBuscarTodos.Text = "Buscar lista completa";
            this.btnBuscarTodos.UseVisualStyleBackColor = true;
            this.btnBuscarTodos.Click += new System.EventHandler(this.btnBuscarTodos_Click);
            // 
            // Exercicios
            // 
            this.AcceptButton = this.btnBuscar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 450);
            this.Controls.Add(this.btnBuscarTodos);
            this.Controls.Add(this.gridExercicios);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBusca);
            this.Name = "Exercicios";
            this.Text = "Exercicio: ";
            ((System.ComponentModel.ISupportInitialize)(this.gridExercicios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridExercicios;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupo_muscular;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_exercicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Button btnBuscarTodos;
    }
}