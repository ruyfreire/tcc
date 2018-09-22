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
    public partial class Exercicios : Form
    {
        public Exercicios()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Regex testaCampo = new Regex(@"^[\w -]+$");

            if (txtBusca.Text.Length < 3 || !testaCampo.IsMatch(txtBusca.Text))
                MessageBox.Show("Digite um texto válido e no mínimo 3 letras", "Busca Exercícios");
            else
            {
                //limpa linhas do grid
                gridExercicios.Rows.Clear();

                //carrega exercicios da busca
                IList<Exercicio> exercicios = new ExerciciosBLL().buscaExerciciosNome(txtBusca.Text);
                if (exercicios.Count == 0) MessageBox.Show("Nenhum exercício encontrado!", "Busca Exercícios");
                else
                {
                    foreach (Exercicio exercicio in exercicios)
                    {
                        gridExercicios.Rows.Add(exercicio.nome, exercicio.grupo_muscular, exercicio.tipo_exercicio);
                    }
                }
            }
        }

        private void btnBuscarTodos_Click(object sender, EventArgs e)
        {
            //limpa linhas do grid
            gridExercicios.Rows.Clear();

            //carrega exericios da busca
            IList<Exercicio> exercicios = new ExerciciosBLL().buscaTodosExercicios();
            if (exercicios.Count == 0) MessageBox.Show("Nenhum exercício encontrado!", "Busca Exercícios");
            else
            {
                foreach (Exercicio exercicio in exercicios)
                {
                    gridExercicios.Rows.Add(exercicio.nome, exercicio.grupo_muscular, exercicio.tipo_exercicio);
                }
            }
        }
    }
}
