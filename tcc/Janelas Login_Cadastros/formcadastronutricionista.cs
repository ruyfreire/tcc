using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tcc.DTO;

namespace tcc
{
    public partial class CadastroNutricionista : Form
    {
        public CadastroNutricionista()
        {
            InitializeComponent();
        }

        private void formcadastronutricionista_Load(object sender, EventArgs e)
        {
            /* Define o tipo correto do campo data, e chama o metodo validaData através do TypeValidationCompleted,
            * que é executado automaticamente no campo maskedtextbox quando perde o foco
            */
            maskednascimento.ValidatingType = typeof(System.DateTime);
            maskednascimento.TypeValidationCompleted += new TypeValidationEventHandler(validaData);

        }

        private void txtcpf_cnpj_Enter(Object sender, EventArgs e)
        {
            if (cboCPF_CNPJ.Text.Equals(""))
            {
                MessageBox.Show("Escolha o tipo do documento primeiro", "CPF / CNPJ");
                cboCPF_CNPJ.Focus();
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            limpar_camposCadastro();
        }

        public void limpar_camposCadastro()
        {
            txtname.Clear();
            txtemail.Clear();
            txtlogin.Clear();
            txtsenha.Clear();
            txtcrn.Clear();
            txtcpf_cnpj.Clear();
            txtendereco.Clear();
            maskednascimento.Clear();
            comboBoxsexo.SelectedIndex = comboBoxsexo.Items.IndexOf("");
        }

        private void Btnsalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Validacoes validar = new Validacoes();
                if (
                    validar.validaCampos("nome", txtname.Text)
                    && validar.validaCampos("login", txtlogin.Text.ToLower())
                    && validar.validaCampos("email", txtemail.Text.ToLower())
                    && validar.validaCampos("senha", txtsenha.Text)
                    && validar.validaCampos("cpf_cnpj", txtcpf_cnpj.Text)
                    && validar.validaCampos("crn", txtcrn.Text)
                    && validar.validaCampos("nascimento", maskednascimento.Text)
                    && validar.validaCampos("idade", maskednascimento.Text)
                    && validar.validaCampos("sexo", comboBoxsexo.Text)
                    && validar.validaCampos("endereço", txtendereco.Text)
                    )
                {
                    //após validar, inclui no objeto e envia para a prox camada
                    Nutricionista nutricionista = new Nutricionista
                    {
                        nome = txtname.Text,
                        login = txtlogin.Text.ToLower(),
                        email = txtemail.Text.ToLower(),
                        senha = txtsenha.Text,
                        cpf_cnpj = txtcpf_cnpj.Text,
                        crn = txtcrn.Text,
                        nascimento = Convert.ToDateTime(maskednascimento.Text),
                        sexo = comboBoxsexo.Text,
                        endereco = txtendereco.Text
                    };

                    //verifica se foi cadastrado com sucesso
                    var cadastrado = new BLL.NutricionistaBLL().novoNutricionista(nutricionista);
                    if (cadastrado == 3)
                    {
                        MessageBox.Show("Cadastro realidado com sucesso!", "Novo Nutricionista");
                        Close();
                    }
                    else if (cadastrado == 2)
                    {
                        MessageBox.Show("E-mail ja cadastrado!", "Novo Nutricionista");
                    }
                    else if (cadastrado == 1)
                    {
                        MessageBox.Show("Login já existe, tente um novo", "Novo Nutricionista");
                    }
                    else 
                    {
                        MessageBox.Show("Erro ao cadastrar!", "Novo Nutricionista");
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        private void Formcadastronutricionista_Formclosed(object sender, FormClosedEventArgs e)
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

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cboCPF_CNPJ_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboCPF_CNPJ.Text.Equals("CPF"))
            {
                txtcpf_cnpj.Mask = "000,000,000-00";
            }
            else if (cboCPF_CNPJ.Text.Equals("CNPJ"))
            {
                txtcpf_cnpj.Mask = "00,000,000/0000-00";
            }
        }


    }
}

