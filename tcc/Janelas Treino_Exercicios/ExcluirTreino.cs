using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tcc.BLL;
using tcc.DTO;

namespace tcc
{
    public partial class ExcluirTreino : Form
    {
        int id_usuario;
        IList<Treino> treinos;

        public ExcluirTreino()
        {
            InitializeComponent();
        }

        private void ExcluirTreino_Load(object sender, EventArgs e)
        {
            carregaTreinos();
        }

        private void carregaTreinos()
        {
            cboTreino.Items.Clear();

            id_usuario = ((usuarioMDI)MdiParent).usuario.id_usuario;

            treinos = new TreinoBLL().carregaTreinosDeUsuario(id_usuario);

            int i = 1;
            foreach (Treino treino in treinos)
            {
                cboTreino.Items.Add(treino.diaSemana + " - Serie: " + treino.serie + ", Duração: " + treino.duracao);
                i++;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (cboTreino.Text.Equals(""))
            {
                MessageBox.Show("Escolha um treino.");
            }
            else
            {
                Treino treino = treinos[cboTreino.SelectedIndex];

                /* Verifica se treino possui exercicios */
                IList<Exercicio> exercicios = new ExerciciosBLL().carregaExerciciosTreino(treino.id_treino);
                int qtd = exercicios.Count;

                if (qtd > 0)
                {
                    MessageBox.Show("Treino não vazio, possui lista de exercicios definida.", "Excluir Treino");
                }

                var confirma = MessageBox.Show("Deseja realmente excluir o treino?\n\n" +
                    "Dia da Semana: " + treino.diaSemana + "\n" +
                    "Serie: " + treino.serie + "\n" +
                    "Duração: " + treino.duracao + "\n",
                    "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (confirma.ToString().Equals("Yes"))
                {
                    int excluido = new TreinoBLL().excluiTreinoUnicoUsuario(id_usuario, treino.id_treino);
                    if (excluido > 0)
                    {
                        MessageBox.Show("Treino excluído com sucesso", "Excluir Treino");
                        carregaTreinos();
                    }
                }
                else MessageBox.Show("Operação cancelada.", "Excluir Treino");

            }
        }
    }
}
