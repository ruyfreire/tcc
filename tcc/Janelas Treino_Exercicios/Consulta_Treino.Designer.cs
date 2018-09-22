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
            this.cboDiaSemana = new System.Windows.Forms.ComboBox();
            this.gridTreino = new System.Windows.Forms.DataGridView();
            this.TipoExercicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerieExercicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeExercicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridTreino)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboDiaSemana
            // 
            this.cboDiaSemana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDiaSemana.FormattingEnabled = true;
            this.cboDiaSemana.Location = new System.Drawing.Point(210, 14);
            this.cboDiaSemana.Name = "cboDiaSemana";
            this.cboDiaSemana.Size = new System.Drawing.Size(231, 21);
            this.cboDiaSemana.TabIndex = 71;
            this.cboDiaSemana.SelectedIndexChanged += new System.EventHandler(this.cboDiaSemana_SelectedIndexChanged);
            // 
            // gridTreino
            // 
            this.gridTreino.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridTreino.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTreino.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoExercicio,
            this.SerieExercicio,
            this.NomeExercicio});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridTreino.DefaultCellStyle = dataGridViewCellStyle1;
            this.gridTreino.Location = new System.Drawing.Point(3, 89);
            this.gridTreino.Name = "gridTreino";
            this.gridTreino.ReadOnly = true;
            this.gridTreino.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridTreino.Size = new System.Drawing.Size(487, 107);
            this.gridTreino.TabIndex = 68;
            // 
            // TipoExercicio
            // 
            this.TipoExercicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TipoExercicio.HeaderText = "Nome do Exercicio";
            this.TipoExercicio.Name = "TipoExercicio";
            this.TipoExercicio.ReadOnly = true;
            // 
            // SerieExercicio
            // 
            this.SerieExercicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SerieExercicio.HeaderText = "Grupo Muscular";
            this.SerieExercicio.Name = "SerieExercicio";
            this.SerieExercicio.ReadOnly = true;
            this.SerieExercicio.Width = 98;
            // 
            // NomeExercicio
            // 
            this.NomeExercicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NomeExercicio.HeaderText = "Tipo";
            this.NomeExercicio.Name = "NomeExercicio";
            this.NomeExercicio.ReadOnly = true;
            this.NomeExercicio.Width = 53;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cboDiaSemana);
            this.panel1.Controls.Add(this.gridTreino);
            this.panel1.Location = new System.Drawing.Point(43, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 269);
            this.panel1.TabIndex = 73;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 72;
            this.label1.Text = "DIA DA SEMANA :";
            // 
            // Consulta_Treino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 509);
            this.Controls.Add(this.panel1);
            this.Name = "Consulta_Treino";
            this.Text = "Consultar Treino";
            this.Load += new System.EventHandler(this.Consulta_Treino_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridTreino)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cboDiaSemana;
        private System.Windows.Forms.DataGridView gridTreino;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoExercicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerieExercicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeExercicio;
    }
}