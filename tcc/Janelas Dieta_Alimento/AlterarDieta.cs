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
    public partial class AlterarDieta : Form
    {
        int id_usuario;
        IList<Dieta> dietas;

        public AlterarDieta()
        {
            InitializeComponent();
        }

        private void AlterarDieta_Load(object sender, EventArgs e)
        {
            carregaDietas();
        }

        private void carregaDietas()
        {
            cboSelecioneDieta.Items.Clear();

            id_usuario = ((usuarioMDI)MdiParent).usuario.id_usuario;

            dietas = new DietaBLL().carregaDietasDeUsuario(id_usuario);

            int i = 1;
            foreach (Dieta dieta in dietas)
            {
                cboSelecioneDieta.Items.Add(i + " - " + dieta.dia_semana + " - " + dieta.tipo_refeicao);
                i++;
            }
        }

        private void cboSelecioneDieta_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDiaDaSemana.SelectedItem = dietas[cboSelecioneDieta.SelectedIndex].dia_semana;
            txtTipoDeRefeicao.SelectedItem = dietas[cboSelecioneDieta.SelectedIndex].tipo_refeicao;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (cboSelecioneDieta.Text.Equals("") || txtDiaDaSemana.Text.Equals("") || txtTipoDeRefeicao.Text.Equals(""))
            {
                MessageBox.Show("Preencha todos os campos.");
            }
            else
            {
                Dieta dieta = new Dieta()
                {
                    id_dieta = dietas[cboSelecioneDieta.SelectedIndex].id_dieta,
                    dia_semana = txtDiaDaSemana.Text,
                    tipo_refeicao = txtTipoDeRefeicao.Text
                };

                int alterado = new DietaBLL().alteraDietasDeUsuario(dieta, id_usuario);
                switch(Convert.ToString( alterado))
                {
                    case "-2":
                        MessageBox.Show("Nada foi alterado.", "Alterar Dieta");
                        break;


                    case "-1":
                        MessageBox.Show("Usuário já possui uma dieta deste tipo, para este dia da semana.", "Alterar Dieta");
                        break;


                    case "1":
                        MessageBox.Show("Dieta alterada com sucesso.", "Alterar Dieta");
                        carregaDietas();
                        break;


                    default:
                        MessageBox.Show("Erro ao alterar dieta.", "Alterar Dieta");
                        break;
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
