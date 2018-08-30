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
            maskednascimento.ValidatingType = typeof(System.DateTime);
            maskednascimento.TypeValidationCompleted += new TypeValidationEventHandler(validaData);
            */
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            limpar_camposCadastro();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            try
            {
                String[] lista = { "nome", "email", "senha", "nascimento", "sexo", "peso", "altura", "objetivo" };
                if (validaCampos(lista))
                {
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

        public Boolean validaCampos(Array lista)
        {
            foreach (String opcao in lista)
            {
                switch (opcao)
                {
                    //valida nome com expressao regular, minimo de 1 sobrenome e maximo de 5
                    case "nome":
                        Regex testaNome = new Regex(@"^[a-zA-Z]+\s{1}[a-zA-Z]+?(\s{1}[a-zA-Z]+){0,4}$", RegexOptions.IgnoreCase);
                        if (!testaNome.IsMatch(txtname.Text))
                        {
                            MessageBox.Show("Nome inválido, (apenas letras, mínimo 1 sobrenome, e máximo 5, sem espaço no começo ou final)", "Nome");
                            return false;
                        }
                        if ((txtname.Text.Equals("")))
                        {
                            MessageBox.Show("Campo nome vazio!", "Nome");
                            return false;
                        }
                        if (txtname.Text.Length < 3)
                        {
                            MessageBox.Show("Nome menor que 3 letras", "Nome");
                            return false;
                        }
                    break;


                    //valida e-mail com expressao regular para carecteres paermitidos
                    case "email":
                        Regex testaEmail = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");
                        if (!testaEmail.IsMatch(txtemail.Text))
                        {
                            MessageBox.Show("E-mail inválido", "E-mail");
                            return false;
                        }
                        break;


                    case "senha":
                        //valda senha entre 6 e 8
                        if (txtsenha.Text.Length < 6 || txtsenha.Text.Length > 8)
                        {
                            MessageBox.Show("A senha deve conter de 6 a 8 caracteres", "Senha");
                            return false;
                        }
                        break;


                    case "nascimento":
                        String nascimento = maskednascimento.Text.Replace("/", "");
                        nascimento = nascimento.Replace(" ", "");
                        if(nascimento == "")
                        {
                            MessageBox.Show("Preencha a data de nascimento!", "Data de Nascimento");
                            return false;
                        }
                    break;


                    case "sexo":
                        if (comboBoxsexo.SelectedItem == null)
                        {
                            MessageBox.Show("Selecione um sexo", "Sexo");
                            return false;
                        }
                        break;


                    //valida peso entre 30 e 200
                    case "peso":
                        Regex testaPeso = new Regex(@"^[0-9]{0,3},?([0-9]){0,2}$");
                        Decimal peso = Convert.ToDecimal(txtpeso.Text);
                        Console.WriteLine(peso);
                        Decimal peso_menor = 30m;
                        Decimal peso_maior = 200m;
                        if (!testaPeso.IsMatch(txtpeso.Text))
                        {
                            MessageBox.Show("Formato inválido, entre com o peso correto (30kg a 200kg)", "Peso");
                            return false;
                        }
                        else
                        {
                            if (Decimal.Compare(peso, peso_menor) < 0 || Decimal.Compare(peso, peso_maior) > 0)
                            {
                                MessageBox.Show("Valor permitido de 30kg a 200kg", "Peso");
                                return false;
                            }
                        }
                        break;


                    //valida altura entre 0,50 e 2,50
                    case "altura":
                        Regex testaAltura = new Regex(@"^[0-9],?([0-9]){0,2}$");
                        Decimal altura = Convert.ToDecimal(txtaltura.Text);
                        Decimal altura_menor = 0.5m;
                        Decimal altura_maior = 2.5m;
                        if (!testaAltura.IsMatch(txtaltura.Text))
                        {
                            MessageBox.Show("Formato inválido, entre com a altura correta (0,5m a 2,59m)", "Altura");
                            return false;
                        }
                        else
                        {
                            if ( (Decimal.Compare(altura, altura_menor) < 0) || (Decimal.Compare(altura, altura_maior) > 0))
                            {
                                MessageBox.Show("Valor permitido de 0,5m a 2,59m", "Altura");
                                return false;
                            }
                        }

                    break;


                    case "objetivo":
                        if (comboBoxobjetivo.SelectedItem == null)
                        {
                            MessageBox.Show("Selecione um objetivo", "Objetivo");
                            return false;
                        }
                        break;

                    default:
                        break;
                }
            }
            return true;
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
