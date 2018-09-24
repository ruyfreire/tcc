using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tcc.DTO;

namespace tcc
{
    public partial class usuarioMDI : Form
    {
        private int childFormNumber = 0;
        public Usuario usuario;

        public usuarioMDI(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Janela " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            ActiveMdiChild.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void fechaJanelas()
        {
            /* fecha janelas abertas no mdi */
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void abreJanela(Form janela)
        {
            /* fecha janelas abertas no mdi */
            fechaJanelas();

            /* Inclui janela no mdi, maximiza e exibe */
            janela.MdiParent = this;
            janela.WindowState = FormWindowState.Maximized;
            janela.Show();
        }


        /* Menu pagina inicial */
        private void menuInicio_Click(object sender, EventArgs e)
        {
            abreJanela(new InicioUsuario());
        }



        /* Menu cadastrar dieta */
        private void cadastrarDietaCadastrar_Click(object sender, EventArgs e)
        {
            abreJanela(new CadastrarDieta());
        }

        private void cadastrarDietaAlterar_Click(object sender, EventArgs e)
        {
            abreJanela(new AlterarDieta());
        }

        private void cadastrarDietaExcluir_Click(object sender, EventArgs e)
        {
            abreJanela(new ExcluirDieta());
        }

        private void cadastrarAlimentosDieta_Click(object sender, EventArgs e)
        {
            abreJanela(new AlimentoDieta());
        }



        /* Menu cadastrar treino */
        private void cadastrarTreinoCadastrar_Click(object sender, EventArgs e)
        {
            /* Cria janela a ser chamada */
            abreJanela(new CadastrarTreino());
        }

        private void cadastrarTreinoAlterar_Click(object sender, EventArgs e)
        {
            abreJanela(new AlterarTreino());
        }

        private void cadastrarTreinoExcluir_Click(object sender, EventArgs e)
        {
            abreJanela(new ExcluirTreino());
        }

        private void cadastrarExerciciosTreino_Click(object sender, EventArgs e)
        {
            abreJanela(new ExercicioTreino());
        }



        /* Menu consulta dieta, treino, profissional */
        private void consultarDieta_Click(object sender, EventArgs e)
        {
            abreJanela(new Consulta_Dieta());
        }

        private void consultarTreino_Click(object sender, EventArgs e)
        {
            abreJanela(new Consulta_Treino());
        }

        private void consultarProfissionalNutricionista_Click(object sender, EventArgs e)
        {
            abreJanela(new ContatoNutricionista());
        }

        private void consultarProfissionalPersonal_Click(object sender, EventArgs e)
        {
            abreJanela(new ContatoPersonal());
        }




        /* Menu informações Alimentos e Exercicios */
        private void informacaoAlimentos_Click(object sender, EventArgs e)
        {
            abreJanela(new Alimentos());
        }

        private void informacaoExercicios_Click(object sender, EventArgs e)
        {
            abreJanela(new Exercicios());
        }




        /* Menu Busca profissional */
        private void buscaNutricionista_Click(object sender, EventArgs e)
        {
            abreJanela(new Busca_Nutricionista());
        }

        private void buscaPersonal_Click(object sender, EventArgs e)
        {
            abreJanela(new Busca_Personal());
        }




        /* Menu Configurações */
        private void configDados_Click(object sender, EventArgs e)
        {
            abreJanela(new Dados_Cadastrais());
        }



        /* Menu Sair */
        private void menuSair_Click(object sender, EventArgs e)
        {
            var sair = MessageBox.Show("Deseja fazer logoff do sistema?", "Logoff", MessageBoxButtons.YesNo);
            if (sair.ToString().Equals("Yes"))
            {
                fechaJanelas();
                login telaLogin = new login();
                telaLogin.Show();
                Close();
            }

        }
    }
}
