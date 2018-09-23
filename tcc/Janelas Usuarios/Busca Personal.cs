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
    public partial class Busca_Personal : Form
    {
        public Busca_Personal()
        {
            InitializeComponent();
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            Regex testaCampo = new Regex(@"^[\w -]+$");

            if (txtpersonal.Text.Length < 3 || !testaCampo.IsMatch(txtpersonal.Text))
                MessageBox.Show("Digite um texto válido e no mínimo 3 letras", "Busca Personal");
            else
            {
                //limpa linhas do grid
                gridPersonal.Rows.Clear();

                //carrega nutricionistas da busca
                IList<Personal> personals = new PersonalBLL().buscaPersonalNome(txtpersonal.Text);
                if (personals.Count == 0) MessageBox.Show("Nenhum personal encontrado!", "Busca Personal");
                else
                {
                    foreach (Personal personal in personals)
                    {
                        gridPersonal.Rows.Add(personal.nome, personal.crea, personal.email, personal.endereco);
                    }
                }
            }
        }

        private void btnpesquisartudo_Click(object sender, EventArgs e)
        {
            //limpa linhas do grid
            gridPersonal.Rows.Clear();

            //carrega nutricionistas da busca
            IList<Personal> personals = new PersonalBLL().buscaTodosPersonal();
            if (personals.Count == 0) MessageBox.Show("Nenhum personal encontrado!", "Busca Personal");
            else
            {
                foreach (Personal personal in personals)
                {
                    gridPersonal.Rows.Add(personal.nome, personal.crea, personal.email, personal.endereco);
                }
            }
        }
    }
}
