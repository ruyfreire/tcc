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
    public partial class Alimentos : Form
    {
        public Alimentos()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Regex testaCampo = new Regex(@"^[\w -]+$");

            if (txtBusca.Text.Length < 3 || !testaCampo.IsMatch(txtBusca.Text))
                MessageBox.Show("Digite um texto válido e no mínimo 3 letras", "Busca Alimentos");
            else
            {
                //limpa linhas do grid
                gridAlimentos.Rows.Clear();

                //carrega alimentos da busca
                IList<Alimento> alimentos = new AlimentosBLL().buscaAlimentoNome(txtBusca.Text);
                if (alimentos.Count == 0) MessageBox.Show("Nenhum alimento encontrado!", "Busca Alimentos");
                else
                {
                    foreach(Alimento alimento in alimentos)
                    {
                        gridAlimentos.Rows.Add(alimento.nome, alimento.grupo_nutricional, alimento.calorias, alimento.porcao);
                    }
                }
            }
        }

        private void btnBuscarTodos_Click(object sender, EventArgs e)
        {
            //limpa linhas do grid
            gridAlimentos.Rows.Clear();

            //carrega alimentos da busca
            IList<Alimento> alimentos = new AlimentosBLL().buscaTodosAlimentos();
            if (alimentos.Count == 0) MessageBox.Show("Nenhum alimento encontrado!", "Busca Alimentos");
            else
            {
                foreach (Alimento alimento in alimentos)
                {
                    gridAlimentos.Rows.Add(alimento.nome, alimento.grupo_nutricional, alimento.calorias, alimento.porcao);
                }
            }
        }
    }
}
