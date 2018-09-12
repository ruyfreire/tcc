using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tcc
{
    public partial class CadastroPersonal : Form
    {
        public CadastroPersonal()
        {
            InitializeComponent();
        }

        private void formcadastropersonnal_Load(object sender, EventArgs e)
        {
            /* Define o tipo correto do campo data, e chama o metodo validaData através do TypeValidationCompleted,
            * que é executado automaticamente no campo maskedtextbox quando perde o foco
            */
            maskednascimento.ValidatingType = typeof(System.DateTime);
            maskednascimento.TypeValidationCompleted += new TypeValidationEventHandler(validaData);
        }

        private void label1_Click(object sender, EventArgs e)
        {
 
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            limpar_camposCadastro();
        }
        public void limpar_camposCadastro()
        {
            txtname.Clear();
            txtemail.Clear();
            txtsenha.Clear();
            txtcrea.Clear();
            txtendereco.Clear();
            maskednascimento.Clear();
            maskedcpf.Clear();
            comboBoxsexo.SelectedIndex = comboBoxsexo.Items.IndexOf("");
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Validacoes validar = new Validacoes();
                if (
                    validar.validaCampos("nome", txtname.Text)
                    && validar.validaCampos("email", txtemail.Text.ToLower())
                    && validar.validaCampos("senha", txtsenha.Text)
                    && validar.validaCampos("cpf", maskedcpf.Text)
                    && validar.validaCampos("crn", txtcrea.Text)
                    && validar.validaCampos("nascimento", maskednascimento.Text)
                    && validar.validaCampos("sexo", comboBoxsexo.Text)
                    && validar.validaCampos("endereço", txtendereco.Text)
                    )
                {
                    //após validar, inclui no objeto e envia para a prox camada
                    DTO.Personal novoUser = new DTO.Personal();

                    novoUser.nome = txtname.Text;
                    novoUser.email = txtemail.Text.ToLower();
                    novoUser.senha = txtsenha.Text;
                    novoUser.cpf_cnpj = Convert.ToString(maskednascimento.Text);
                    novoUser.nascimento = Convert.ToDateTime(maskednascimento.Text);
                    novoUser.sexo = comboBoxsexo.Text;
                    novoUser.crea = Convert.ToString(txtcrea.Text);
                    novoUser.nascimento = Convert.ToDateTime(maskednascimento.Text);
                    novoUser.endereco = txtendereco.Text;

                    //verifica se foi cadastrado com sucesso
                    var cadastrado = new BLL.PersonalBLL().novoPersonal(novoUser);
                    if (cadastrado >= 1)
                    {
                        MessageBox.Show("Cadastro realidado com sucesso!", "Novo usuário");
                        Close();
                    }
                    else if (cadastrado == -1)
                    {
                        MessageBox.Show("E-mail ja cadastrado!", "Novo usuário");
                    }
                    else
                    {
                        MessageBox.Show("Erro ao cadastrar!", "Novo usuário");
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;

            }

        }
        private void CadastroNutricionista_FormClosed(object sender, FormClosedEventArgs e)
        {
            telaLogin(); //volta para tela de login
        }


        private void validaData(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                MessageBox.Show("Data inválida", "Data de nascimento");
                maskednascimento.Focus();
            }
        }


        private void telaLogin()
        {
            login telaLogin = new login();
            telaLogin.Show();
        }

        private void txtsenha_TextChanged(object sender, EventArgs e)
        {

        }
    } 
}
