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
            this.btnConsultar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TipoExercicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeExercicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerieExercicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(277, 12);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(141, 21);
            this.btnConsultar.TabIndex = 72;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Domingo",
            "Segunda-feira",
            "Terça-feira",
            "Quarta-feira",
            "Quinta-feira",
            "Sexta-feira",
            "Sábado"});
            this.comboBox1.Location = new System.Drawing.Point(22, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(221, 21);
            this.comboBox1.TabIndex = 71;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoExercicio,
            this.NomeExercicio,
            this.SerieExercicio});
            this.dataGridView1.Location = new System.Drawing.Point(36, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(346, 107);
            this.dataGridView1.TabIndex = 68;
            // 
            // TipoExercicio
            // 
            this.TipoExercicio.HeaderText = "Grupo Muscular";
            this.TipoExercicio.Name = "TipoExercicio";
            // 
            // NomeExercicio
            // 
            this.NomeExercicio.HeaderText = "Nome";
            this.NomeExercicio.Name = "NomeExercicio";
            // 
            // SerieExercicio
            // 
            this.SerieExercicio.HeaderText = "Série";
            this.SerieExercicio.Name = "SerieExercicio";
            // 
            // Consulta_Treino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 509);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Consulta_Treino";
            this.Text = "Consultar Treino";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoExercicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeExercicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerieExercicio;
    }
}