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
    public partial class Consulta_Treino : Form
    {
        int id_usuario;
        IList<Treino> treinos;

        public Consulta_Treino()
        {
            InitializeComponent();
        }

        private void Consulta_Treino_Load(object sender, EventArgs e)
        {
            carregaTreinos();
        }

        private void carregaTreinos()
        {
            id_usuario = ((usuarioMDI)MdiParent).usuario.id_usuario;

            /* Carrega as treinos vinculados ao id do usuario */
            treinos = new TreinoBLL().carregaTreinosDeUsuario(id_usuario);
            if (treinos.Count == 0)
            {
                MessageBox.Show("Sem treinos para este usuário!");
            }
            else
            {
                foreach (Treino treino in treinos)
                {
                    cboDiaSemana.Items.Add(treino.diaSemana);
                }
            }
        }

        private void cboDiaSemana_SelectedIndexChanged(object sender, EventArgs e)
        {
            gridTreino.Rows.Clear();

            foreach (Treino treino in treinos)
            {
                if (treino.diaSemana.Equals(cboDiaSemana.Text))
                {
                    /* Carrega lista de exercicios, vinculados ao id de cada treino do usuario */
                    IList<Exercicio> exerciciosTreino = new List<Exercicio>();
                    exerciciosTreino = new ExerciciosBLL().carregaExerciciosTreino(treino.id_treino);

                    if(exerciciosTreino.Count == 0)
                    {
                        MessageBox.Show("Treino não possui nenhum exercicio vinculado.", "Treino");
                        return;
                    }

                    foreach (Exercicio exercicio in exerciciosTreino)
                    {
                        gridTreino.Rows.Add(exercicio.nome, exercicio.grupo_muscular, exercicio.tipo_exercicio);
                    }
                }
            }
        }

    }
}
