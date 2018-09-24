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
        IList<Personal> personals = new List<Personal>();
        Personal personal = null;
        Usuario usuario;
        Personal personalUsuario = null;

        public Busca_Personal()
        {
            InitializeComponent();
        }

        private void Busca_Personal_Load(object sender, EventArgs e)
        {
            usuario = ((usuarioMDI)MdiParent).usuario;
            carregaPersonal();
        }

        private void carregaPersonal()
        {
            personalUsuario = new UsuarioBLL().carregaPersonal(usuario.id_usuario);
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
                personals = new PersonalBLL().buscaPersonalNome(txtpersonal.Text);
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
            personals = new PersonalBLL().buscaTodosPersonal();
            if (personals.Count == 0) MessageBox.Show("Nenhum personal encontrado!", "Busca Personal");
            else
            {
                foreach (Personal personal in personals)
                {
                    gridPersonal.Rows.Add(personal.nome, personal.crea, personal.email, personal.endereco);
                }
            }
        }

        private Boolean verificaSelecionado()
        {
            foreach (DataGridViewRow linha in gridPersonal.Rows)
            {
                if (linha.Selected == true)
                {
                    personal = personals[linha.Index];
                    return true;
                }
            }
            return false;
        }

        private void btnContratar_Click(object sender, EventArgs e)
        {
            if (verificaSelecionado())
            {
                if (personalUsuario.id_personal != 0)
                {
                    MessageBox.Show("Você já possui um personal contratado");
                }
                else
                {
                    confirmaContrato();
                }
            }
            else MessageBox.Show("Selecione um Personal!");
        }

        private void confirmaContrato()
        {
            if (personal != null)
            {
                var resp = MessageBox.Show("Deseja contratar este Personal?\n\n" +
                    "Nome: " + personal.nome +
                    "\nCREA: " + personal.crea +
                    "\nCPF/CNPJ: " + personal.cpf_cnpj,
                    "Contratar Personal", MessageBoxButtons.YesNo);


                if (resp.ToString().Equals("Yes"))
                {
                    int contratado = new UsuarioBLL().incluiPersonal(usuario.id_usuario, personal.id_personal);
                    if (contratado > 0)
                    {
                        MessageBox.Show("Personal contratado com sucesso", "Novo Personal");
                        //limpa linhas do grid
                        gridPersonal.Rows.Clear();
                        personal = null; personalUsuario = null; personals.Clear();
                        carregaPersonal();
                    }
                    else if (contratado == -1)
                    {
                        MessageBox.Show("Você já possui um pesonal contratado", "Novo Personal");
                        //limpa linhas do grid
                        gridPersonal.Rows.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao contratar Personal", "Novo Personal");
                    }
                }
            }
        }

        private void btnDispensar_Click(object sender, EventArgs e)
        {
            if (personalUsuario.id_personal == 0)
            {
                MessageBox.Show("Você não possui um personal contratado");
            }
            else
            {
                confirmaDispensar();
            }
        }

        private void confirmaDispensar()
        {
            var resp = MessageBox.Show("Deseja dispensar o seu personal?\n\n" +
                "Nome: " + personalUsuario.nome +
                "\nCREA: " + personalUsuario.crea +
                "\nCPF/CNPJ: " + personalUsuario.cpf_cnpj,
                "Dispensar Personal", MessageBoxButtons.YesNo);


            if (resp.ToString().Equals("Yes"))
            {
                int dispensado = new UsuarioBLL().removePersonal(usuario.id_usuario);
                if (dispensado > 0)
                {
                    MessageBox.Show("Personal dispensado com sucesso", "Dispensar Personal");
                    //limpa linhas do grid
                    gridPersonal.Rows.Clear();
                    personal = null; personalUsuario = null; personals.Clear();
                    carregaPersonal();
                }
                else if (dispensado == -1)
                {
                    MessageBox.Show("Você não possui um pesonal contratado", "Dispensar Personal");
                    //limpa linhas do grid
                    gridPersonal.Rows.Clear();
                }
                else
                {
                    MessageBox.Show("Erro ao dispensar Personal", "Dispensar Personal");
                }
            }
        }

        private void btnMeuPersonal_Click(object sender, EventArgs e)
        {
            gridPersonal.Rows.Clear();

            if (personalUsuario.id_personal != 0)
            {
                gridPersonal.Rows.Add(personalUsuario.nome, personalUsuario.crea, personalUsuario.email, personalUsuario.endereco);
                personals.Clear();
                personals.Add(personalUsuario);
            }
            else MessageBox.Show("Você não possui personal");
        }
    }
}
