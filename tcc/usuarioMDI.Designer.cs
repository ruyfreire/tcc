namespace tcc
{
    partial class usuarioMDI
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
            this.menuInicio = new System.Windows.Forms.ToolStripMenuItem();
            this.Cadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.dietaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cadatrarDietaCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarDietaAlterar = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarDietaExcluir = new System.Windows.Forms.ToolStripMenuItem();
            this.treinoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarTreinoCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarTreinoAlterar = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarTreinoExcluir = new System.Windows.Forms.ToolStripMenuItem();
            this.Consultar = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarDieta = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarTreino = new System.Windows.Forms.ToolStripMenuItem();
            this.profissionalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarProfissionalNutricionista = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarProfissionalPersonal = new System.Windows.Forms.ToolStripMenuItem();
            this.Informacoes = new System.Windows.Forms.ToolStripMenuItem();
            this.informacaoAlimentos = new System.Windows.Forms.ToolStripMenuItem();
            this.informacaoExercicios = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarProfissionalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscaNutricionista = new System.Windows.Forms.ToolStripMenuItem();
            this.buscaPersonal = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configDados = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuInicio,
            this.Cadastrar,
            this.Consultar,
            this.Informacoes,
            this.buscarProfissionalToolStripMenuItem,
            this.configuraçõesToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(634, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // menuInicio
            // 
            this.menuInicio.Name = "menuInicio";
            this.menuInicio.Size = new System.Drawing.Size(48, 20);
            this.menuInicio.Text = "Início";
            this.menuInicio.Click += new System.EventHandler(this.menuInicio_Click);
            // 
            // Cadastrar
            // 
            this.Cadastrar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dietaToolStripMenuItem2,
            this.treinoToolStripMenuItem2});
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Size = new System.Drawing.Size(69, 20);
            this.Cadastrar.Text = "Cadastrar";
            // 
            // dietaToolStripMenuItem2
            // 
            this.dietaToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadatrarDietaCadastrar,
            this.cadastrarDietaAlterar,
            this.cadastrarDietaExcluir});
            this.dietaToolStripMenuItem2.Name = "dietaToolStripMenuItem2";
            this.dietaToolStripMenuItem2.Size = new System.Drawing.Size(107, 22);
            this.dietaToolStripMenuItem2.Text = "Dieta";
            // 
            // cadatrarDietaCadastrar
            // 
            this.cadatrarDietaCadastrar.Name = "cadatrarDietaCadastrar";
            this.cadatrarDietaCadastrar.Size = new System.Drawing.Size(124, 22);
            this.cadatrarDietaCadastrar.Text = "Cadastrar";
            this.cadatrarDietaCadastrar.Click += new System.EventHandler(this.cadastrarDietaCadastrar_Click);
            // 
            // cadastrarDietaAlterar
            // 
            this.cadastrarDietaAlterar.Name = "cadastrarDietaAlterar";
            this.cadastrarDietaAlterar.Size = new System.Drawing.Size(124, 22);
            this.cadastrarDietaAlterar.Text = "Alterar";
            this.cadastrarDietaAlterar.Click += new System.EventHandler(this.cadastrarDietaAlterar_Click);
            // 
            // cadastrarDietaExcluir
            // 
            this.cadastrarDietaExcluir.Name = "cadastrarDietaExcluir";
            this.cadastrarDietaExcluir.Size = new System.Drawing.Size(124, 22);
            this.cadastrarDietaExcluir.Text = "Excluir";
            this.cadastrarDietaExcluir.Click += new System.EventHandler(this.cadastrarDietaExcluir_Click);
            // 
            // treinoToolStripMenuItem2
            // 
            this.treinoToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarTreinoCadastrar,
            this.cadastrarTreinoAlterar,
            this.cadastrarTreinoExcluir});
            this.treinoToolStripMenuItem2.Name = "treinoToolStripMenuItem2";
            this.treinoToolStripMenuItem2.Size = new System.Drawing.Size(107, 22);
            this.treinoToolStripMenuItem2.Text = "Treino";
            // 
            // cadastrarTreinoCadastrar
            // 
            this.cadastrarTreinoCadastrar.Name = "cadastrarTreinoCadastrar";
            this.cadastrarTreinoCadastrar.Size = new System.Drawing.Size(124, 22);
            this.cadastrarTreinoCadastrar.Text = "Cadastrar";
            this.cadastrarTreinoCadastrar.Click += new System.EventHandler(this.cadastrarTreinoCadastrar_Click);
            // 
            // cadastrarTreinoAlterar
            // 
            this.cadastrarTreinoAlterar.Name = "cadastrarTreinoAlterar";
            this.cadastrarTreinoAlterar.Size = new System.Drawing.Size(124, 22);
            this.cadastrarTreinoAlterar.Text = "Alterar";
            this.cadastrarTreinoAlterar.Click += new System.EventHandler(this.cadastrarTreinoAlterar_Click);
            // 
            // cadastrarTreinoExcluir
            // 
            this.cadastrarTreinoExcluir.Name = "cadastrarTreinoExcluir";
            this.cadastrarTreinoExcluir.Size = new System.Drawing.Size(124, 22);
            this.cadastrarTreinoExcluir.Text = "Excluir";
            this.cadastrarTreinoExcluir.Click += new System.EventHandler(this.cadastrarTreinoExcluir_Click);
            // 
            // Consultar
            // 
            this.Consultar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarDieta,
            this.consultarTreino,
            this.profissionalToolStripMenuItem});
            this.Consultar.Name = "Consultar";
            this.Consultar.Size = new System.Drawing.Size(70, 20);
            this.Consultar.Text = "Consultar";
            // 
            // consultarDieta
            // 
            this.consultarDieta.Name = "consultarDieta";
            this.consultarDieta.Size = new System.Drawing.Size(180, 22);
            this.consultarDieta.Text = "Dieta";
            this.consultarDieta.Click += new System.EventHandler(this.consultarDieta_Click);
            // 
            // consultarTreino
            // 
            this.consultarTreino.Name = "consultarTreino";
            this.consultarTreino.Size = new System.Drawing.Size(180, 22);
            this.consultarTreino.Text = "Treino";
            this.consultarTreino.Click += new System.EventHandler(this.consultarTreino_Click);
            // 
            // profissionalToolStripMenuItem
            // 
            this.profissionalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarProfissionalNutricionista,
            this.consultarProfissionalPersonal});
            this.profissionalToolStripMenuItem.Name = "profissionalToolStripMenuItem";
            this.profissionalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.profissionalToolStripMenuItem.Text = "Profissional";
            // 
            // consultarProfissionalNutricionista
            // 
            this.consultarProfissionalNutricionista.Name = "consultarProfissionalNutricionista";
            this.consultarProfissionalNutricionista.Size = new System.Drawing.Size(229, 22);
            this.consultarProfissionalNutricionista.Text = "Contato Nutricionista";
            this.consultarProfissionalNutricionista.Click += new System.EventHandler(this.consultarProfissionalNutricionista_Click);
            // 
            // consultarProfissionalPersonal
            // 
            this.consultarProfissionalPersonal.Name = "consultarProfissionalPersonal";
            this.consultarProfissionalPersonal.Size = new System.Drawing.Size(229, 22);
            this.consultarProfissionalPersonal.Text = "Contato Personal / Academia";
            this.consultarProfissionalPersonal.Click += new System.EventHandler(this.consultarProfissionalPersonal_Click);
            // 
            // Informacoes
            // 
            this.Informacoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informacaoAlimentos,
            this.informacaoExercicios});
            this.Informacoes.Name = "Informacoes";
            this.Informacoes.Size = new System.Drawing.Size(85, 20);
            this.Informacoes.Text = "Informações";
            // 
            // informacaoAlimentos
            // 
            this.informacaoAlimentos.Name = "informacaoAlimentos";
            this.informacaoAlimentos.Size = new System.Drawing.Size(217, 22);
            this.informacaoAlimentos.Text = "Nutricionais dos Alimentos";
            this.informacaoAlimentos.Click += new System.EventHandler(this.informacaoAlimentos_Click);
            // 
            // informacaoExercicios
            // 
            this.informacaoExercicios.Name = "informacaoExercicios";
            this.informacaoExercicios.Size = new System.Drawing.Size(217, 22);
            this.informacaoExercicios.Text = "Exercícios";
            this.informacaoExercicios.Click += new System.EventHandler(this.informacaoExercicios_Click);
            // 
            // buscarProfissionalToolStripMenuItem
            // 
            this.buscarProfissionalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscaNutricionista,
            this.buscaPersonal});
            this.buscarProfissionalToolStripMenuItem.Name = "buscarProfissionalToolStripMenuItem";
            this.buscarProfissionalToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.buscarProfissionalToolStripMenuItem.Text = "Buscar Profissional";
            // 
            // buscaNutricionista
            // 
            this.buscaNutricionista.Name = "buscaNutricionista";
            this.buscaNutricionista.Size = new System.Drawing.Size(142, 22);
            this.buscaNutricionista.Text = "Nutricionista";
            this.buscaNutricionista.Click += new System.EventHandler(this.buscaNutricionista_Click);
            // 
            // buscaPersonal
            // 
            this.buscaPersonal.Name = "buscaPersonal";
            this.buscaPersonal.Size = new System.Drawing.Size(142, 22);
            this.buscaPersonal.Text = "Personal";
            this.buscaPersonal.Click += new System.EventHandler(this.buscaPersonal_Click);
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configDados});
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // configDados
            // 
            this.configDados.Name = "configDados";
            this.configDados.Size = new System.Drawing.Size(164, 22);
            this.configDados.Text = "Dados Cadastrais";
            this.configDados.Click += new System.EventHandler(this.configDados_Click);
            // 
            // usuarioMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 453);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "usuarioMDI";
            this.Text = "usuarioMDI";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem Consultar;
        private System.Windows.Forms.ToolStripMenuItem consultarDieta;
        private System.Windows.Forms.ToolStripMenuItem consultarTreino;
        private System.Windows.Forms.ToolStripMenuItem profissionalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarProfissionalNutricionista;
        private System.Windows.Forms.ToolStripMenuItem consultarProfissionalPersonal;
        private System.Windows.Forms.ToolStripMenuItem Informacoes;
        private System.Windows.Forms.ToolStripMenuItem informacaoAlimentos;
        private System.Windows.Forms.ToolStripMenuItem informacaoExercicios;
        private System.Windows.Forms.ToolStripMenuItem Cadastrar;
        private System.Windows.Forms.ToolStripMenuItem dietaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem treinoToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem menuInicio;
        private System.Windows.Forms.ToolStripMenuItem cadatrarDietaCadastrar;
        private System.Windows.Forms.ToolStripMenuItem cadastrarDietaAlterar;
        private System.Windows.Forms.ToolStripMenuItem cadastrarDietaExcluir;
        private System.Windows.Forms.ToolStripMenuItem cadastrarTreinoCadastrar;
        private System.Windows.Forms.ToolStripMenuItem cadastrarTreinoAlterar;
        private System.Windows.Forms.ToolStripMenuItem cadastrarTreinoExcluir;
        private System.Windows.Forms.ToolStripMenuItem buscarProfissionalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscaNutricionista;
        private System.Windows.Forms.ToolStripMenuItem buscaPersonal;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configDados;
    }
}



