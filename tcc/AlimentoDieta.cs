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
    public partial class AlimentoDieta : Form
    {
        int id_usuario;
        IList<Dieta> dietasCarregadas = null;
        Dieta dietaSelecionada = null;
        IList<Alimento> alimentosDieta = null;
        IList<Alimento> alimentosBusca = null;
        Alimento alimentoSlecionado = null;

        public AlimentoDieta()
        {
            InitializeComponent();
        }

        private void AlimentoDieta_Load(object sender, EventArgs e)
        {
            carregaDietas();
        }

        private void carregaDietas()
        {
            cboDieta.Items.Clear();

            id_usuario = ((usuarioMDI)MdiParent).usuario.id_usuario;

            dietasCarregadas = new DietaBLL().carregaDietasDeUsuario(id_usuario);

            int i = 1;
            foreach (Dieta dieta in dietasCarregadas)
            {
                cboDieta.Items.Add(i + " - " + dieta.dia_semana + " - " + dieta.tipo_refeicao);
                i++;
            }
        }

        private void carregaAlimentosDieta()
        {
            if (cboDieta.Text.Equals(""))
            {
                MessageBox.Show("Escolha uma dieta.");
            }
            else
            {
                dietaSelecionada = dietasCarregadas[cboDieta.SelectedIndex];

                /* Carrega lista de alimentos, vinculados ao id de cada dieta do usuario */
                alimentosDieta = new AlimentosBLL().carregaAlimentosDieta(dietaSelecionada.id_dieta);
            }

        }

        private void limpaGrid()
        {
            //limpa linhas do grid
            gridAlimento.Rows.Clear();
        }

        private Boolean checarSelecionado(String tipo)
        {
            if (cboDieta.Text.Equals(""))
            {
                MessageBox.Show("Escolha uma dieta.");
                return false;
            }
            else
            {
                foreach (DataGridViewRow linha in gridAlimento.Rows)
                {
                    if (linha.Selected == true)
                    {
                        alimentoSlecionado = alimentosBusca[linha.Index];
                        if(tipo.Equals("remover")) return true;

                        foreach (Alimento pegaAlimento in alimentosDieta)
                        {
                            if (alimentoSlecionado.id_alimento == pegaAlimento.id_alimento)
                            {
                                MessageBox.Show("Alimento já esta na dieta!");
                                return false;
                            }
                        }
                        return true;
                    }
                }
                MessageBox.Show("Selecione um alimento!");
                return false;
            }

        }

        private void cboDieta_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregaAlimentosDieta();
        }

        private void btnTodosAlimentosDieta_Click(object sender, EventArgs e)
        {
            limpaGrid();
            //carrega alimentos da busca
            carregaAlimentosDieta();
            alimentosBusca = alimentosDieta;

            if(alimentosDieta != null)
            {
                if (alimentosDieta.Count == 0) MessageBox.Show("Nenhum alimento encontrado!", "Busca Alimentos");
                else
                {
                    foreach (Alimento alimento in alimentosDieta)
                    {
                        gridAlimento.Rows.Add(alimento.nome, alimento.grupo_nutricional, alimento.calorias, alimento.porcao);
                    }
                    gridAlimento.Rows[0].Selected = false;
                }
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Regex testaCampo = new Regex(@"^[\w -]+$");

            if (txtAlimento.Text.Length < 3 || !testaCampo.IsMatch(txtAlimento.Text))
                MessageBox.Show("Digite um texto válido e no mínimo 3 letras", "Busca Alimentos");
            else
            {
                limpaGrid();

                //carrega alimentos da busca
                alimentosBusca = new AlimentosBLL().buscaAlimentoNome(txtAlimento.Text);
                if (alimentosBusca.Count == 0) MessageBox.Show("Nenhum alimento encontrado!", "Busca Alimentos");
                else
                {
                    foreach (Alimento alimento in alimentosBusca)
                    {
                        gridAlimento.Rows.Add(alimento.nome, alimento.grupo_nutricional, alimento.calorias, alimento.porcao);
                    }
                    gridAlimento.Rows[0].Selected = false;
                }
            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            limpaGrid();

            //carrega alimentos da busca
            alimentosBusca = new AlimentosBLL().buscaTodosAlimentos();
            if (alimentosBusca.Count == 0) MessageBox.Show("Nenhum alimento encontrado!", "Busca Alimentos");
            else
            {
                foreach (Alimento alimento in alimentosBusca)
                {
                    gridAlimento.Rows.Add(alimento.nome, alimento.grupo_nutricional, alimento.calorias, alimento.porcao);
                }
                gridAlimento.Rows[0].Selected = false;
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (checarSelecionado("adicionar") && alimentosDieta != null)
            {
                //valida campo gramas
                if (new Validacoes().validaCampos("porcao_alimento", txtGramas.Text))
                {
                    if (alimentoSlecionado != null)
                    {
                        var resp = MessageBox.Show("Deseja adicionar o alimento com " + txtGramas.Text + " gramas de consumo?\n\n",
                            "Adicionar Alimento", MessageBoxButtons.YesNo);

                        if (resp.ToString().Equals("Yes"))
                        {
                            Decimal gramas = Convert.ToDecimal(txtGramas.Text);
                            int adicionado = new AlimentosBLL().incluiAlimentoDieta(dietaSelecionada.id_dieta, alimentoSlecionado.id_alimento, gramas);
                            if (adicionado == 1)
                            {
                                MessageBox.Show("Alimento adicionado com sucesso", "Adicionar alimento");
                                limpaGrid();
                                reiniciaTudo();
                                carregaDietas();
                            }
                            else MessageBox.Show("Erro ao adicionar alimento", "Adicionar alimento");
                        }
                        else MessageBox.Show("Operação cancelada", "Adicionar alimento");
                    }
                }
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (checarSelecionado("remover") && alimentosDieta != null)
            {
                if (alimentoSlecionado != null)
                {
                    var resp = MessageBox.Show("Deseja remover o alimento da dieta?\n\n",
                        "Remover Alimento", MessageBoxButtons.YesNo);

                    if (resp.ToString().Equals("Yes"))
                    {
                        int removido = new AlimentosBLL().excluiAlimentoDieta(dietaSelecionada.id_dieta, alimentoSlecionado.id_alimento);
                        if (removido == 1)
                        {
                            MessageBox.Show("Alimento removido com sucesso", "Remover alimento");
                            limpaGrid();
                            reiniciaTudo();
                            carregaDietas();
                        }
                        else MessageBox.Show("Erro ao remover alimento", "Remover alimento");
                    }
                    else MessageBox.Show("Operação cancelada", "Remover alimento");
                }
            }
        }
        

        private void reiniciaTudo()
        {
            dietasCarregadas = null;
            dietaSelecionada = null;
            alimentosDieta = null;
            alimentosBusca = null;
            alimentoSlecionado = null;

            limpaGrid();
        }
    }
}
