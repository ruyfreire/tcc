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
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Informacoes = new System.Windows.Forms.ToolStripMenuItem();
            this.alimentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercíciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Configuracoes = new System.Windows.Forms.ToolStripMenuItem();
            this.dadosCadatraisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Clientes,
            this.Informacoes,
            this.Configuracoes});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // Clientes
            // 
            this.Clientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.consultarToolStripMenuItem});
            this.Clientes.Name = "Clientes";
            this.Clientes.Size = new System.Drawing.Size(61, 20);
            this.Clientes.Text = "Clientes";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // Informacoes
            // 
            this.Informacoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alimentosToolStripMenuItem,
            this.exercíciosToolStripMenuItem});
            this.Informacoes.Name = "Informacoes";
            this.Informacoes.Size = new System.Drawing.Size(85, 20);
            this.Informacoes.Text = "Informações";
            // 
            // alimentosToolStripMenuItem
            // 
            this.alimentosToolStripMenuItem.Name = "alimentosToolStripMenuItem";
            this.alimentosToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.alimentosToolStripMenuItem.Text = "Alimentos";
            // 
            // exercíciosToolStripMenuItem
            // 
            this.exercíciosToolStripMenuItem.Name = "exercíciosToolStripMenuItem";
            this.exercíciosToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.exercíciosToolStripMenuItem.Text = "Exercícios";
            // 
            // Configuracoes
            // 
            this.Configuracoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dadosCadatraisToolStripMenuItem});
            this.Configuracoes.Name = "Configuracoes";
            this.Configuracoes.Size = new System.Drawing.Size(96, 20);
            this.Configuracoes.Text = "Configurações";
            // 
            // dadosCadatraisToolStripMenuItem
            // 
            this.dadosCadatraisToolStripMenuItem.Name = "dadosCadatraisToolStripMenuItem";
            this.dadosCadatraisToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.dadosCadatraisToolStripMenuItem.Text = "Dados Cadatrais";
            // 
            // profissionalMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "profissionalMDI";
            this.Text = "profissionalMDI";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem Clientes;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Informacoes;
        private System.Windows.Forms.ToolStripMenuItem alimentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exercíciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Configuracoes;
        private System.Windows.Forms.ToolStripMenuItem dadosCadatraisToolStripMenuItem;
    }
}



