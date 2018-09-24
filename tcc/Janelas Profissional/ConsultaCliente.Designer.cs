namespace tcc
{
    partial class ConsultaCliente
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
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.gridclientes = new System.Windows.Forms.DataGridView();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objetivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnBuscarTodos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridclientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(224, 382);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(139, 20);
            this.btnRemover.TabIndex = 9;
            this.btnRemover.Text = "Remover Cliente";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(428, 46);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 20);
            this.btnbuscar.TabIndex = 8;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // gridclientes
            // 
            this.gridclientes.AllowUserToAddRows = false;
            this.gridclientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridclientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridclientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome,
            this.email,
            this.sexo,
            this.objetivo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridclientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridclientes.Location = new System.Drawing.Point(56, 131);
            this.gridclientes.MultiSelect = false;
            this.gridclientes.Name = "gridclientes";
            this.gridclientes.ReadOnly = true;
            this.gridclientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridclientes.Size = new System.Drawing.Size(516, 217);
            this.gridclientes.TabIndex = 7;
            // 
            // nome
            // 
            this.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.email.HeaderText = "E-mail";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // sexo
            // 
            this.sexo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sexo.HeaderText = "Sexo";
            this.sexo.Name = "sexo";
            this.sexo.ReadOnly = true;
            this.sexo.Width = 68;
            // 
            // objetivo
            // 
            this.objetivo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.objetivo.HeaderText = "Objetivo";
            this.objetivo.Name = "objetivo";
            this.objetivo.ReadOnly = true;
            this.objetivo.Width = 91;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome :";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(182, 46);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(240, 20);
            this.txtNome.TabIndex = 5;
            // 
            // btnBuscarTodos
            // 
            this.btnBuscarTodos.Location = new System.Drawing.Point(224, 86);
            this.btnBuscarTodos.Name = "btnBuscarTodos";
            this.btnBuscarTodos.Size = new System.Drawing.Size(123, 20);
            this.btnBuscarTodos.TabIndex = 8;
            this.btnBuscarTodos.Text = "Buscar Todos";
            this.btnBuscarTodos.UseVisualStyleBackColor = true;
            this.btnBuscarTodos.Click += new System.EventHandler(this.btnBuscarTodos_Click);
            // 
            // ConsultaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 456);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnBuscarTodos);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.gridclientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Name = "ConsultaCliente";
            this.Text = "Consulta Cliente";
            this.Load += new System.EventHandler(this.ConsultaCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridclientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.DataGridView gridclientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn objetivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnBuscarTodos;
    }
}