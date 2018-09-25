namespace tcc
{
    partial class Consulta_Treino
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
            this.gridTreino = new System.Windows.Forms.DataGridView();
            this.NomeExercicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerieExercicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoExercicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboDiaSemana = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridTreino)).BeginInit();
            this.SuspendLayout();
            // 
            // gridTreino
            // 
            this.gridTreino.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gridTreino.AllowUserToAddRows = false;
            this.gridTreino.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridTreino.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridTreino.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTreino.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoExercicio,
            this.SerieExercicio,
            this.NomeExercicio});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridTreino.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridTreino.Location = new System.Drawing.Point(58, 182);
            this.gridTreino.Name = "gridTreino";
            this.gridTreino.ReadOnly = true;
            this.gridTreino.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridTreino.Size = new System.Drawing.Size(487, 107);
            this.gridTreino.TabIndex = 68;
            // 
            // NomeExercicio
            // 
            this.NomeExercicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NomeExercicio.HeaderText = "Tipo";
            this.NomeExercicio.Name = "NomeExercicio";
            this.NomeExercicio.ReadOnly = true;
            this.NomeExercicio.Width = 57;
            // 
            // SerieExercicio
            // 
            this.SerieExercicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SerieExercicio.HeaderText = "Grupo Muscular";
            this.SerieExercicio.Name = "SerieExercicio";
            this.SerieExercicio.ReadOnly = true;
            this.SerieExercicio.Width = 111;
            // 
            // TipoExercicio
            // 
            this.TipoExercicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TipoExercicio.HeaderText = "Nome do Exercicio";
            this.TipoExercicio.Name = "TipoExercicio";
            this.TipoExercicio.ReadOnly = true;
            // 
            // cboDiaSemana
            // 
            this.cboDiaSemana.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboDiaSemana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDiaSemana.FormattingEnabled = true;
            this.cboDiaSemana.Location = new System.Drawing.Point(151, 117);
            this.cboDiaSemana.Name = "cboDiaSemana";
            this.cboDiaSemana.Size = new System.Drawing.Size(394, 21);
            this.cboDiaSemana.TabIndex = 71;
            this.cboDiaSemana.SelectedIndexChanged += new System.EventHandler(this.cboDiaSemana_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 72;
            this.label1.Text = "Dia da Semana :";
            // 
            // Consulta_Treino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(629, 452);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboDiaSemana);
            this.Controls.Add(this.gridTreino);
            this.Name = "Consulta_Treino";
            this.Text = "Consultar Treino";
            this.Load += new System.EventHandler(this.Consulta_Treino_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridTreino)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridTreino;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoExercicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerieExercicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeExercicio;
        private System.Windows.Forms.ComboBox cboDiaSemana;
        private System.Windows.Forms.Label label1;
    }
}