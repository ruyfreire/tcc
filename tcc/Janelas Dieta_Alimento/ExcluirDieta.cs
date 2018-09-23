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
    public partial class ExcluirDieta : Form
    {
        int id_usuario;
        IList<Dieta> dietas;

        public ExcluirDieta()
        {
            InitializeComponent();
        }

        private void ExcluirDieta_Load(object sender, EventArgs e)
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (cboSelecioneDieta.Text.Equals(""))
            {
                MessageBox.Show("Escolha uma dieta.");
            }
            else
            {
                Dieta dieta = dietas[cboSelecioneDieta.SelectedIndex];

                /* Verifica de dieta possui alimentos */
                IList<Alimento> alimentos = new AlimentosBLL().carregaAlimentosDieta(dieta.id_dieta);
                int qtd = alimentos.Count;

                if(qtd > 0)
                {
                    MessageBox.Show("Dieta não vazia, possui lista de alimentos definida.", "Excluir Dieta");
                }

                var confirma = MessageBox.Show("Deseja realmente excluir a dieta?\n\n" +
                    "Dia da Semana: " + dieta.dia_semana + "\n" +
                    "Tipo de Refeição: " + dieta.tipo_refeicao + "\n",
                    "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (confirma.ToString().Equals("Yes"))
                {
                    int excluido = new DietaBLL().excluiDietaUnicaUsuario(id_usuario, dieta.id_dieta);
                    if(excluido > 0)
                    {
                        MessageBox.Show("Dieta excluída com sucesso", "Excluir Dieta");
                        carregaDietas();
                    }
                }
                else MessageBox.Show("Operação cancelada.", "Excluir Dieta");

            }
        }

    }
}
