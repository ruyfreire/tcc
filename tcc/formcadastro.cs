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
            * que é executado automaticamente no campo maskedtextbox quando perde o foco */
            maskednascimento.ValidatingType = typeof(System.DateTime);
            maskednascimento.TypeValidationCompleted += new TypeValidationEventHandler(validaData);
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            limpar_camposCadastro();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            enviarCadastro();
        }

        private void validaData(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                MessageBox.Show("Data inválida");
                maskednascimento.Focus();
            }
        }

        public void enviarCadastro()
        {
            try
            {

                Regex testaNome = new Regex(@"^[a-zA-Z]+\s{1}[a-zA-Z]+?(\s{1}[a-zA-Z]+){0,4}$", RegexOptions.IgnoreCase);
                //valida nome com expressao regular, minimo de 1 sobrenome e maximo de 5
                if ( !testaNome.IsMatch(txtname.Text) )
                {
                    MessageBox.Show("Nome inválido, (apenas letras, mínimo 1 sobrenome, e máximo 5, sem espaço no começo ou final)");
                    return;
                }
                if ((txtname.Text.Equals("")))
                {
                    MessageBox.Show("Campo nome vazio!");
                    return;
                }
                if (txtname.Text.Length < 3)
                {
                    MessageBox.Show("Nome menor que 3 letras");
                    return;
                }

                //valida e-mail com expressao regular para carecteres paermitidos
                Regex testaEmail = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");
                if (!testaEmail.IsMatch(txtemail.Text))
                {
                    MessageBox.Show("E-mail inválido");
                    return;
                }


                //valda senha entre 6 e 8
                if (txtsenha.Text.Length < 6 || txtsenha.Text.Length > 8)
                {
                    MessageBox.Show("A senha deve conter de 6 a 8 caracteres");
                    return;
                }

                if (comboBoxsexo.SelectedItem == null)
                {
                    MessageBox.Show("Selecione um sexo");
                    return;
                }

                
                //valida formato de peso com expressao regular
                Regex testaPeso = new Regex(@"^[3-9][0-9]?[0-9]\.[0-9]{2}$");
                if (!testaPeso.IsMatch(txtpeso.Text))
                {
                    MessageBox.Show("Digite o peso da no formato  '00.00'");
                    return;
                }


                //valida altura entre 50 e 250
                int altura = Convert.ToInt32(txtaltura.Text);
                if (altura < 50 || altura > 250)
                {
                    MessageBox.Show("Altura deve estar entre 50 e 250cm");
                    return;
                }

                if (comboBoxobjetivo.SelectedItem == null)
                {
                    MessageBox.Show("Selecione um objetivo");
                    return;
                }


                //após validar, inclui no objeto e envia para a prox camada
                Usuario novoUser = new Usuario();

                novoUser.nome = txtname.Text;
                novoUser.email = txtemail.Text;
                novoUser.senha = txtsenha.Text;
                novoUser.nascimento = Convert.ToDateTime(maskednascimento.Text);
                novoUser.sexo = comboBoxsexo.Text;
                novoUser.peso = Convert.ToDecimal(txtpeso.Text);
                novoUser.altura = Convert.ToInt32(txtaltura.Text);
                novoUser.objetivo = comboBoxobjetivo.Text;

                //verifica se foi cadastrado com sucesso
                var cadastro = new UsuarioBLL().novoUsuarioBLL(novoUser);
                if (cadastro >= 1)
                {
                    MessageBox.Show("Cadastro realidado com sucesso!");
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
    }
}
