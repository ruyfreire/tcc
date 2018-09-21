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
    public partial class Consulta_Dieta : Form
    {
        int id_usuario;
        IList<Dieta> dietas;

        public Consulta_Dieta()
        {
            InitializeComponent();
        }

        private void Consulta_Dieta_Load(object sender, EventArgs e)
        {
            carregaDietas();
        }

        private void carregaDietas()
        {
            id_usuario = ((usuarioMDI)MdiParent).usuario.id_usuario;

            /* Carrega as dietas vinculadas ao id do usuario */
            dietas = new DietaBLL().carregaDietasDeUsuario(id_usuario);
            if (dietas.Count == 0)
            {
                MessageBox.Show("Sem dietas para este usuário!");
            }
            else
            {
                foreach(Dieta dieta in dietas)
                {
                    cboDiaSemana.Items.Add(dieta.dia_semana);
                }
            }
        }

        private void cboDiaSemana_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregaGrid();
        }

        private void carregaGrid()
        {
            gridManha.Rows.Clear();
            gridAlmoco.Rows.Clear();
            gridTarde.Rows.Clear();
            gridJanta.Rows.Clear();
            gridCeia.Rows.Clear();

            foreach (Dieta dieta in dietas)
            {
                if (dieta.dia_semana.Equals(cboDiaSemana.Text))
                {
                    /* Carrega lista de alimentos, vinculados ao id de cada dieta do usuario */
                    IList<Alimento> alimetosDieta = new List<Alimento>();
                    alimetosDieta = new AlimentosBLL().carregaAlimentosDieta(dieta.id_dieta);

                    /* Verifica qual o tipo da refeição, e inclui os dados da dieta no grid correto */
                    switch (dieta.tipo_refeicao)
                    {
                        case "Café da Manhã":
                            foreach(Alimento alimento in alimetosDieta)
                            {
                                gridManha.Rows.Add(alimento.nome, alimento.porcao, alimento.calorias);
                            }
                            break;
                        case "Almoço":
                            foreach (Alimento alimento in alimetosDieta)
                            {
                                gridAlmoco.Rows.Add(alimento.nome, alimento.porcao, alimento.calorias);
                            }
                            break;
                        case "Café da Tarde":
                            foreach (Alimento alimento in alimetosDieta)
                            {
                                gridTarde.Rows.Add(alimento.nome, alimento.porcao, alimento.calorias);
                            }
                            break;
                        case "Janta":
                            foreach (Alimento alimento in alimetosDieta)
                            {
                                gridJanta.Rows.Add(alimento.nome, alimento.porcao, alimento.calorias);
                            }
                            break;
                        case "Ceia":
                            foreach (Alimento alimento in alimetosDieta)
                            {
                                gridCeia.Rows.Add(alimento.nome, alimento.porcao, alimento.calorias);
                            }
                            break;
                    }
                }
            }
        }

    }
}
