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
    public partial class AlterarTreino : Form
    {
        int id_usuario;
        IList<Treino> treinos;

        public AlterarTreino()
        {
            InitializeComponent();
        }

        private void AlterarTreino_Load(object sender, EventArgs e)
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

        private void cboTreino_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDiaDaSemana.SelectedItem = treinos[cboTreino.SelectedIndex].diaSemana;
            txtSerie.Text = Convert.ToString(treinos[cboTreino.SelectedIndex].serie);
            txtDuracao.Text = Convert.ToString(treinos[cboTreino.SelectedIndex].duracao);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (cboTreino.Text.Equals(""))
            {
                MessageBox.Show("Selecione um treino");
                return;
            }
            if (txtDiaDaSemana.Text.Equals("") )
            {
                MessageBox.Show("Selecione um dia da semana");
                return;
            }
            Validacoes valida = new Validacoes();
            if(valida.validaCampos("serie", txtSerie.Text) && valida.validaCampos("duracao", txtDuracao.Text))
            {
                Treino treino = new Treino()
                {
                    id_treino = treinos[cboTreino.SelectedIndex].id_treino,
                    diaSemana = txtDiaDaSemana.Text,
                    serie = Convert.ToInt32(txtSerie.Text),
                    duracao = Convert.ToInt32(txtDuracao.Text)
                };

                int alterado = new TreinoBLL().alteraTreinoDeUsuario(treino, id_usuario);
                switch (Convert.ToString(alterado))
                {
                    case "-2":
                        MessageBox.Show("Nada foi alterado.", "Alterar Treino");
                        break;


                    case "-1":
                        MessageBox.Show("Usuário já possui um treino para este dia da semana.", "Alterar Treino");
                        break;


                    case "1":
                        MessageBox.Show("Treino alterado com sucesso.", "Alterar Treino");
                        txtSerie.Clear(); txtDuracao.Clear();
                        carregaTreinos();
                        break;


                    default:
                        MessageBox.Show("Erro ao alterar treino.", "Alterar Treino");
                        break;
                }
            }
        }

    }
}
