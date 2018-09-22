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
    public partial class Busca_Nutricionista : Form
    {
        public Busca_Nutricionista()
        {
            InitializeComponent();
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            Regex testaCampo = new Regex(@"^[\w -]+$");

            if (txtnutricionista.Text.Length < 3 || !testaCampo.IsMatch(txtnutricionista.Text))
                MessageBox.Show("Digite um texto válido e no mínimo 3 letras", "Busca Nutricionista");
            else
            {
                //limpa linhas do grid
                gridNutricionista.Rows.Clear();

                //carrega nutricionistas da busca
                IList<Nutricionista> nutricionistas = new NutricionistaBLL().buscaNutricionistaNome(txtnutricionista.Text);
                if (nutricionistas.Count == 0) MessageBox.Show("Nenhum nutricionista encontrado!", "Busca Nutricionista");
                else
                {
                    foreach (Nutricionista nutricionista in nutricionistas)
                    {
                        gridNutricionista.Rows.Add(nutricionista.nome, nutricionista.crn, nutricionista.email, nutricionista.endereco);
                    }
                }
            }
        }

        private void btnpesquisartudo_Click(object sender, EventArgs e)
        {
            //limpa linhas do grid
            gridNutricionista.Rows.Clear();

            //carrega nutricionistas da busca
            IList<Nutricionista> nutricionistas = new NutricionistaBLL().buscaTodosNutricionista();
            if (nutricionistas.Count == 0) MessageBox.Show("Nenhum nutricionista encontrado!", "Busca Nutricionista");
            else
            {
                foreach (Nutricionista nutricionista in nutricionistas)
                {
                    gridNutricionista.Rows.Add(nutricionista.nome, nutricionista.crn, nutricionista.email, nutricionista.endereco);
                }
            }
        }
    }
}
