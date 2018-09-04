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
    public partial class formcadastro : Form
    {
        public formcadastro()
        {
            InitializeComponent();
        }

        private void formcadastro_Load(object sender, EventArgs e)
        {
            /* Define o tipo correto do campo data, e chama o metodo validaData através do TypeValidationCompleted,
            * que é executado automaticamente no campo maskedtextbox quando perde o foco
            */
            maskednascimento.ValidatingType = typeof(System.DateTime);
            maskednascimento.TypeValidationCompleted += new TypeValidationEventHandler(validaData);
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            limpar_camposCadastro();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Validacoes validar = new Validacoes();
                if ( 
                    validar.validaCampos("nome", txtname.Text)
                    && validar.validaCampos("email", txtemail.Text)
                    && validar.validaCampos("senha", txtsenha.Text)
                    && validar.validaCampos("nascimento", maskednascimento.Text)
                    && validar.validaCampos("sexo", comboBoxsexo.Text)
                    && validar.validaCampos("peso", txtpeso.Text)
                    && validar.validaCampos("altura", txtaltura.Text)
                    && validar.validaCampos("objetivo", comboBoxobjetivo.Text)
                    )
                {
                    //após validar, inclui no objeto e envia para a prox camada
                    Usuario novoUser = new Usuario();

                    novoUser.nome = txtname.Text;
                    novoUser.email = txtemail.Text;
                    novoUser.senha = txtsenha.Text;
                    novoUser.nascimento = Convert.ToDateTime(maskednascimento.Text);
                    novoUser.sexo = comboBoxsexo.Text;
                    novoUser.peso = Convert.ToDecimal(txtpeso.Text);
                    novoUser.altura = Convert.ToDecimal(txtaltura.Text);
                    novoUser.objetivo = comboBoxobjetivo.Text;

                    //verifica se foi cadastrado com sucesso
                    var cadastrado = new UsuarioBLL().novoUsuarioBLL(novoUser);
                    if (cadastrado >= 1)
                    {
                        MessageBox.Show("Cadastro realidado com sucesso!", "Novo usuário");
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }


        public void limpar_camposCadastro()
        {
            txtname.Clear();
            txtemail.Clear();
            txtsenha.Clear();
            txtpeso.Clear();
            txtaltura.Clear();
            maskednascimento.Clear();
            comboBoxsexo.SelectedIndex = comboBoxsexo.Items.IndexOf("");
            comboBoxobjetivo.SelectedIndex = comboBoxobjetivo.Items.IndexOf("");
        }


        private void formcadastro_FormClosed(object sender, FormClosedEventArgs e)
        {
            login telaLogin = new login();
            telaLogin.Show();
        }
        

        private void validaData(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                MessageBox.Show("Data inválida", "Data de nascimento");
                maskednascimento.Focus();
            }
        }
    }
}
