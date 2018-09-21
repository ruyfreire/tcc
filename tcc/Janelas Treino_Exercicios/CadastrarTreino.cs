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
    public partial class CadastrarTreino : Form
    {
        public CadastrarTreino()
        {
            InitializeComponent();
        }

        private void CadastrarTreino_Load(object sender, EventArgs e)
        {
            txtDiaDaSemana.SelectedIndex = 0;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtDiaDaSemana.Text.Equals("")) return;

            Validacoes valida = new Validacoes();
            if( valida.validaCampos("serie", txtSerie.Text) && valida.validaCampos("duracao", txtDuracao.Text))
            {
                Treino treino = new Treino()
                {
                    diaSemana = txtDiaDaSemana.Text,
                    serie = Convert.ToInt32(txtSerie.Text),
                    duracao = Convert.ToInt32(txtDuracao.Text)
                };

                /* Pegar o perfil do usuario que esta no MDI principal, e armazenar o id dele */
                int id_usuario = ((usuarioMDI)MdiParent).usuario.id_usuario;
                int cadastrado = new TreinoBLL().incluirTreinoUsuario(id_usuario, treino);
                switch (Convert.ToString(cadastrado))
                {
                    case "-1":
                        MessageBox.Show("Usuário já possui um treino para este dia da semana.", "Novo Treino");
                        break;
                    case "1":
                        MessageBox.Show("Treino cadastrado com sucesso.", "Novo Treino");
                        txtSerie.Clear(); txtDuracao.Clear();
                        break;
                    default:
                        MessageBox.Show("Erro ao cadastrar treino.", "Novo Treino");
                        break;
                }
            }
        }
    }
}
