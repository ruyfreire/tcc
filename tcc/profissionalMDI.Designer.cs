namespace tcc
{
    partial class profissionalMDI
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.Clientes = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.Informacoes = new System.Windows.Forms.ToolStripMenuItem();
            this.informacoesAlimentos = new System.Windows.Forms.ToolStripMenuItem();
            this.informacoesExercicios = new System.Windows.Forms.ToolStripMenuItem();
            this.Configuracoes = new System.Windows.Forms.ToolStripMenuItem();
            this.configDadosCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuInicio = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuInicio,
            this.Clientes,
            this.Informacoes,
            this.Configuracoes});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(634, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // Clientes
            // 
            this.Clientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesCadastrar,
            this.clientesConsultar});
            this.Clientes.Name = "Clientes";
            this.Clientes.Size = new System.Drawing.Size(61, 20);
            this.Clientes.Text = "Clientes";
            // 
            // clientesCadastrar
            // 
            this.clientesCadastrar.Name = "clientesCadastrar";
            this.clientesCadastrar.Size = new System.Drawing.Size(125, 22);
            this.clientesCadastrar.Text = "Cadastrar";
            this.clientesCadastrar.Click += new System.EventHandler(this.clientesCadastrar_Click);
            // 
            // clientesConsultar
            // 
            this.clientesConsultar.Name = "clientesConsultar";
            this.clientesConsultar.Size = new System.Drawing.Size(125, 22);
            this.clientesConsultar.Text = "Consultar";
            this.clientesConsultar.Click += new System.EventHandler(this.clientesConsultar_Click);
            // 
            // Informacoes
            // 
            this.Informacoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informacoesAlimentos,
            this.informacoesExercicios});
            this.Informacoes.Name = "Informacoes";
            this.Informacoes.Size = new System.Drawing.Size(85, 20);
            this.Informacoes.Text = "Informações";
            // 
            // informacoesAlimentos
            // 
            this.informacoesAlimentos.Name = "informacoesAlimentos";
            this.informacoesAlimentos.Size = new System.Drawing.Size(128, 22);
            this.informacoesAlimentos.Text = "Alimentos";
            this.informacoesAlimentos.Click += new System.EventHandler(this.informacoesAlimentos_Click);
            // 
            // informacoesExercicios
            // 
            this.informacoesExercicios.Name = "informacoesExercicios";
            this.informacoesExercicios.Size = new System.Drawing.Size(128, 22);
            this.informacoesExercicios.Text = "Exercícios";
            this.informacoesExercicios.Click += new System.EventHandler(this.informacoesExercicios_Click);
            // 
            // Configuracoes
            // 
            this.Configuracoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configDadosCadastrar});
            this.Configuracoes.Name = "Configuracoes";
            this.Configuracoes.Size = new System.Drawing.Size(96, 20);
            this.Configuracoes.Text = "Configurações";
            // 
            // configDadosCadastrar
            // 
            this.configDadosCadastrar.Name = "configDadosCadastrar";
            this.configDadosCadastrar.Size = new System.Drawing.Size(159, 22);
            this.configDadosCadastrar.Text = "Dados Cadatrais";
            this.configDadosCadastrar.Click += new System.EventHandler(this.configDadosCadastrar_Click);
            // 
            // menuInicio
            // 
            this.menuInicio.Name = "menuInicio";
            this.menuInicio.Size = new System.Drawing.Size(48, 20);
            this.menuInicio.Text = "Início";
            this.menuInicio.Click += new System.EventHandler(this.menuInicio_Click);
            // 
            // profissionalMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "profissionalMDI";
            this.Text = "Sistema Personal / Nutricionista";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem Clientes;
        private System.Windows.Forms.ToolStripMenuItem clientesCadastrar;
        private System.Windows.Forms.ToolStripMenuItem clientesConsultar;
        private System.Windows.Forms.ToolStripMenuItem Informacoes;
        private System.Windows.Forms.ToolStripMenuItem informacoesAlimentos;
        private System.Windows.Forms.ToolStripMenuItem informacoesExercicios;
        private System.Windows.Forms.ToolStripMenuItem Configuracoes;
        private System.Windows.Forms.ToolStripMenuItem configDadosCadastrar;
        private System.Windows.Forms.ToolStripMenuItem menuInicio;
    }
}



