using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using tcc.BLL;
using tcc.DTO;

namespace tcc
{
    public partial class ExercicioTreino : Form
    {
        int id_usuario;
        IList<Treino> treinosCarregados = null;
        Treino treinoSelecionado = null;
        IList<Exercicio> exerciciosTreino = null;
        IList<Exercicio> exerciciosBusca = null;
        Exercicio exercicioSelecionado = null;

        public ExercicioTreino()
        {
            InitializeComponent();
        }

        private void ExercicioTreino_Load(object sender, EventArgs e)
        {
            carregaTreinos();
        }

        private void carregaTreinos()
        {
            cboTreino.Items.Clear();

            id_usuario = ((usuarioMDI)MdiParent).usuario.id_usuario;

            treinosCarregados = new TreinoBLL().carregaTreinosDeUsuario(id_usuario);

            int i = 1;
            foreach (Treino treino in treinosCarregados)
            {
                cboTreino.Items.Add(treino.diaSemana + " - Serie: " + treino.serie + ", Duração: " + treino.duracao);
                i++;
            }
        }

        private void carregaExerciciosTreino()
        {
            if (cboTreino.Text.Equals(""))
            {
                MessageBox.Show("Escolha um treino.");
            }
            else
            {
                treinoSelecionado = treinosCarregados[cboTreino.SelectedIndex];

                /* Carrega lista de exercicios, vinculados ao id de cada treino do usuario */
                exerciciosTreino = new ExerciciosBLL().carregaExerciciosTreino(treinoSelecionado.id_treino);
            }

        }

        private void limpaGrid()
        {
            //limpa linhas do grid
            gridExercicio.Rows.Clear();
        }

        private Boolean checarSelecionado(String tipo)
        {
            if (cboTreino.Text.Equals(""))
            {
                MessageBox.Show("Escolha um treino.");
                return false;
            }
            else
            {
                foreach (DataGridViewRow linha in gridExercicio.Rows)
                {
                    if (linha.Selected == true)
                    {
                        exercicioSelecionado = exerciciosBusca[linha.Index];
                        if (tipo.Equals("remover")) return true;

                        foreach (Exercicio pegaExercicio in exerciciosTreino)
                        {
                            if (exercicioSelecionado.id_exercicio == pegaExercicio.id_exercicio)
                            {
                                MessageBox.Show("Exercicio já esta no treino!");
                                return false;
                            }
                        }
                        return true;
                    }
                }
                MessageBox.Show("Selecione um exercício!");
                return false;
            }

        }

        private void cboTreino_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregaExerciciosTreino();
        }

        private void btnTodosExerciciosTreino_Click(object sender, EventArgs e)
        {
            limpaGrid();
            //carrega exercicios da busca
            carregaExerciciosTreino();
            exerciciosBusca = exerciciosTreino;

            if (exerciciosTreino != null)
            {
                if (exerciciosTreino.Count == 0) MessageBox.Show("Nenhum exercício encontrado!", "Busca Exercicios");
                else
                {
                    foreach (Exercicio exercicio in exerciciosTreino)
                    {
                        gridExercicio.Rows.Add(exercicio.nome, exercicio.grupo_muscular, exercicio.tipo_exercicio);
                    }
                    gridExercicio.Rows[0].Selected = false;
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Regex testaCampo = new Regex(@"^[\w -]+$");

            if (txtExercicio.Text.Length < 3 || !testaCampo.IsMatch(txtExercicio.Text))
                MessageBox.Show("Digite um texto válido e no mínimo 3 letras", "Busca Exercicios");
            else
            {
                limpaGrid();

                //carrega exercicios da busca
                exerciciosBusca = new ExerciciosBLL().buscaExerciciosNome(txtExercicio.Text);
                if (exerciciosBusca.Count == 0) MessageBox.Show("Nenhum exercicio encontrado!", "Busca Exercicio");
                else
                {
                    foreach (Exercicio exercicio in exerciciosBusca)
                    {
                        gridExercicio.Rows.Add(exercicio.nome, exercicio.grupo_muscular, exercicio.tipo_exercicio);
                    }
                    gridExercicio.Rows[0].Selected = false;
                }
            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            limpaGrid();

            //carrega exercicios da busca
            exerciciosBusca = new ExerciciosBLL().buscaTodosExercicios();
            if (exerciciosBusca.Count == 0) MessageBox.Show("Nenhum exrcicio encontrado!", "Busca Exercicios");
            else
            {
                foreach (Exercicio exercicio in exerciciosBusca)
                {
                    gridExercicio.Rows.Add(exercicio.nome, exercicio.grupo_muscular, exercicio.tipo_exercicio);
                }
                gridExercicio.Rows[0].Selected = false;
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (checarSelecionado("adicionar") && exerciciosTreino != null)
            {
                if (exercicioSelecionado != null)
                {
                    var resp = MessageBox.Show("Deseja adicionar o exercicio ao treino?\n\n",
                        "Adicionar Exercicio", MessageBoxButtons.YesNo);

                    if (resp.ToString().Equals("Yes"))
                    {
                        int adicionado = new ExerciciosBLL().incluiExercicioTreino(treinoSelecionado.id_treino, exercicioSelecionado.id_exercicio);
                        if (adicionado == 1)
                        {
                            MessageBox.Show("Exercicio adicionado com sucesso", "Adicionar exercicio");
                            limpaGrid();
                            reiniciaTudo();
                            carregaTreinos();
                        }
                        else MessageBox.Show("Erro ao adicionar exercicio", "Adicionar exercicio");
                    }
                    else MessageBox.Show("Operação cancelada", "Adicionar exericio");
                }
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (checarSelecionado("remover") && exerciciosTreino != null)
            {
                if (exercicioSelecionado != null)
                {
                    var resp = MessageBox.Show("Deseja remover o exercicios do treino?\n\n",
                        "Remover exercicio", MessageBoxButtons.YesNo);

                    if (resp.ToString().Equals("Yes"))
                    {
                        int removido = new ExerciciosBLL().excluiExercicioTreino(treinoSelecionado.id_treino, exercicioSelecionado.id_exercicio);
                        if (removido == 1)
                        {
                            MessageBox.Show("Exercicio removido com sucesso", "Remover exercicio");
                            limpaGrid();
                            reiniciaTudo();
                            carregaTreinos();
                        }
                        else MessageBox.Show("Erro ao remover exercicio", "Remover exercicio");
                    }
                    else MessageBox.Show("Operação cancelada", "Remover exercicio");
                }
            }
        }

        private void reiniciaTudo()
        {
            treinosCarregados = null;
            treinoSelecionado = null;
            exerciciosTreino = null;
            exerciciosBusca = null;
            exercicioSelecionado = null;

            limpaGrid();
        }
    }
}
