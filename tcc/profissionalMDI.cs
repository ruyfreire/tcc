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
    public partial class profissionalMDI : Form
    {
        private int childFormNumber = 0;
        public Profissional profissional;

        public profissionalMDI(Profissional profissional)
        {
            InitializeComponent();
            this.profissional = profissional;
        }

        /* Menu Inicial */
        private void menuInicio_Click(object sender, EventArgs e)
        {
            abreJanela(new InicioProfissional());
        }


        /* Menus Clientes */
        private void clientesCadastrar_Click(object sender, EventArgs e)
        {
            abreJanela(new cadastrocliente());
        }

        private void clientesConsultar_Click(object sender, EventArgs e)
        {
            abreJanela(new ConsultaCliente());
        }


        /* Menus Informações */
        private void informacoesAlimentos_Click(object sender, EventArgs e)
        {
            abreJanela(new Alimentos());
        }

        private void informacoesExercicios_Click(object sender, EventArgs e)
        {
            abreJanela(new Exercicios());
        }


        /* Menus Configuração */
        private void configDadosCadastrar_Click(object sender, EventArgs e)
        {
            abreJanela(new Dados_Cadastrais_Profissional());
        }


        /* Menus Sair */
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

    }
}
