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
        IList<Nutricionista> nutricionistas = new List<Nutricionista>();
        Nutricionista nutricionista = null;
        Usuario usuario;
        Nutricionista nutricionistaUsuario = null;

        public Busca_Nutricionista()
        {
            InitializeComponent();
        }

        private void Busca_Nutricionista_Load(object sender, EventArgs e)
        {
            usuario = ((usuarioMDI)MdiParent).usuario;
            carregaNutricionista();
        }

        private void carregaNutricionista()
        {
            nutricionistaUsuario = new UsuarioBLL().carregaNutricionista(usuario.id_usuario);
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
                nutricionistas = new NutricionistaBLL().buscaNutricionistaNome(txtnutricionista.Text);
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
            nutricionistas = new NutricionistaBLL().buscaTodosNutricionista();
            if (nutricionistas.Count == 0) MessageBox.Show("Nenhum nutricionista encontrado!", "Busca Nutricionista");
            else
            {
                foreach (Nutricionista nutricionista in nutricionistas)
                {
                    gridNutricionista.Rows.Add(nutricionista.nome, nutricionista.crn, nutricionista.email, nutricionista.endereco);
                }
            }
        }

        private void btnMeuNutricionista_Click(object sender, EventArgs e)
        {
            gridNutricionista.Rows.Clear();

            if (nutricionistaUsuario.id_nutricionista != 0)
            {
                gridNutricionista.Rows.Add(nutricionistaUsuario.nome, nutricionistaUsuario.crn, nutricionistaUsuario.email, nutricionistaUsuario.endereco);
                nutricionistas.Clear();
                nutricionistas.Add(nutricionistaUsuario);
            }
            else MessageBox.Show("Você não possui nutricionista");
        }

        private Boolean verificaSelecionado()
        {
            foreach (DataGridViewRow linha in gridNutricionista.Rows)
            {
                if (linha.Selected == true)
                {
                    nutricionista = nutricionistas[linha.Index];
                    return true;
                }
            }
            return false;
        }

        private void btnContratar_Click(object sender, EventArgs e)
        {
            if (verificaSelecionado())
            {
                if (nutricionistaUsuario.id_nutricionista != 0)
                {
                    MessageBox.Show("Você já possui um nutricionista contratado");
                }
                else
                {
                    confirmaContrato();
                }
            }
            else MessageBox.Show("Selecione um Nutricionista!");
        }

        private void confirmaContrato()
        {
            if (nutricionista != null)
            {
                var resp = MessageBox.Show("Deseja contratar este Nutricionista?\n\n" +
                    "Nome: " + nutricionista.nome +
                    "\nCRN: " + nutricionista.crn +
                    "\nCPF/CNPJ: " + nutricionista.cpf_cnpj,
                    "Contratar Nutricionista", MessageBoxButtons.YesNo);


                if (resp.ToString().Equals("Yes"))
                {
                    int contratado = new UsuarioBLL().incluiNutricionista(usuario.id_usuario, nutricionista.id_nutricionista);
                    if (contratado > 0)
                    {
                        MessageBox.Show("Nutricionista contratado com sucesso", "Novo Nutricionista");
                        //limpa linhas do grid
                        gridNutricionista.Rows.Clear();
                        nutricionista = null; nutricionistaUsuario = null; nutricionistas.Clear();
                        carregaNutricionista();
                    }
                    else if (contratado == -1)
                    {
                        MessageBox.Show("Você já possui um nutricionista contratado", "Novo Nutricionista");
                        //limpa linhas do grid
                        gridNutricionista.Rows.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao contratar Nutricionista", "Novo Nutricionista");
                    }
                }
            }
        }

        private void btnDispensar_Click(object sender, EventArgs e)
        {
            if (nutricionistaUsuario.id_nutricionista == 0)
            {
                MessageBox.Show("Você não possui um nutricionista contratado");
            }
            else
            {
                confirmaDispensar();
            }
        }

        private void confirmaDispensar()
        {
            var resp = MessageBox.Show("Deseja dispensar o seu nutricionista?\n\n" +
                "Nome: " + nutricionistaUsuario.nome +
                "\nCRN: " + nutricionistaUsuario.crn +
                "\nCPF/CNPJ: " + nutricionistaUsuario.cpf_cnpj,
                "Contratar Nutricionista", MessageBoxButtons.YesNo);


            if (resp.ToString().Equals("Yes"))
            {
                int dispensado = new UsuarioBLL().removeNutricionista(usuario.id_usuario);
                if (dispensado > 0)
                {
                    MessageBox.Show("Nutricionista dispensado com sucesso", "Dispensar Nutricionista");
                    //limpa linhas do grid
                    gridNutricionista.Rows.Clear();
                    nutricionista = null; nutricionistaUsuario = null;  nutricionistas.Clear();
                    carregaNutricionista();
                }
                else if (dispensado == -1)
                {
                    MessageBox.Show("Você não possui um nutricionista contratado", "Dispensar Nutricionista");
                    //limpa linhas do grid
                    gridNutricionista.Rows.Clear();
                }
                else
                {
                    MessageBox.Show("Erro ao dispensar Nutricionista", "Dispensar Nutricionista");
                }
            }
        }
    }
}
