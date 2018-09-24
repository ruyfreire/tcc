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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gridAlimentos = new System.Windows.Forms.DataGridView();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupo_nutricional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calorias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscarTodos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridAlimentos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBusca
            // 
            this.txtBusca.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBusca.Location = new System.Drawing.Point(156, 62);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(310, 20);
            this.txtBusca.TabIndex = 8;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscar.Location = new System.Drawing.Point(486, 60);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(52, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nome do alimento :";
            // 
            // gridAlimentos
            // 
            this.gridAlimentos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gridAlimentos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAlimentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridAlimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAlimentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome,
            this.grupo_nutricional,
            this.calorias,
            this.porcao});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAlimentos.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridAlimentos.Location = new System.Drawing.Point(55, 177);
            this.gridAlimentos.Name = "gridAlimentos";
            this.gridAlimentos.ReadOnly = true;
            this.gridAlimentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridAlimentos.Size = new System.Drawing.Size(506, 230);
            this.gridAlimentos.TabIndex = 11;
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
            this.grupo_nutricional.Width = 120;
            // 
            // calorias
            // 
            this.calorias.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.calorias.HeaderText = "Calorias";
            this.calorias.Name = "calorias";
            this.calorias.ReadOnly = true;
            this.calorias.Width = 77;
            // 
            // porcao
            // 
            this.porcao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.porcao.HeaderText = "Porção";
            this.porcao.Name = "porcao";
            this.porcao.ReadOnly = true;
            this.porcao.Width = 72;
            // 
            // btnBuscarTodos
            // 
            this.btnBuscarTodos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscarTodos.Location = new System.Drawing.Point(234, 118);
            this.btnBuscarTodos.Name = "btnBuscarTodos";
            this.btnBuscarTodos.Size = new System.Drawing.Size(152, 23);
            this.btnBuscarTodos.TabIndex = 12;
            this.btnBuscarTodos.Text = "Buscar lista completa";
            this.btnBuscarTodos.UseVisualStyleBackColor = true;
            this.btnBuscarTodos.Click += new System.EventHandler(this.btnBuscarTodos_Click);
            // 
            // Alimentos
            // 
            this.AcceptButton = this.btnBuscar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(629, 452);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.btnBuscarTodos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridAlimentos);
            this.Name = "Alimentos";
            this.Text = "Alimentos";
            ((System.ComponentModel.ISupportInitialize)(this.gridAlimentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridAlimentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupo_nutricional;
        private System.Windows.Forms.DataGridViewTextBoxColumn calorias;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcao;
        private System.Windows.Forms.Button btnBuscarTodos;
    }
}