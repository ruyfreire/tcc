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

        public void enviarCadastro()
        {
            try
            {
                String[] lista = {"nome", "email", "senha", "nascimento", "sexo", "peso", "altura", "objetivo"};
                if (validaCampos(lista) )
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
                        MessageBox.Show("Cadastro realidado com sucesso!");
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
                            MessageBox.Show("Nome inválido, (apenas letras, mínimo 1 sobrenome, e máximo 5, sem espaço no começo ou final)");
                            return false;
                        }
                        if ((txtname.Text.Equals("")))
                        {
                            MessageBox.Show("Campo nome vazio!");
                            return false;
                        }
                        if (txtname.Text.Length < 3)
                        {
                            MessageBox.Show("Nome menor que 3 letras");
                            return false;
                        }
                    break;


                    //valida e-mail com expressao regular para carecteres paermitidos
                    case "email":
                        Regex testaEmail = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");
                        if (!testaEmail.IsMatch(txtemail.Text))
                        {
                            MessageBox.Show("E-mail inválido");
                            return false;
                        }
                        break;


                    case "senha":
                        //valda senha entre 6 e 8
                        if (txtsenha.Text.Length < 6 || txtsenha.Text.Length > 8)
                        {
                            MessageBox.Show("A senha deve conter de 6 a 8 caracteres");
                            return false;
                        }
                        break;


                    case "nascimento":
                        String nascimento = maskednascimento.Text.Replace("/", "");
                        nascimento = nascimento.Replace(" ", "");
                        if(nascimento == "")
                        {
                            MessageBox.Show("Preencha a data de nascimento!");
                            return false;
                        }
                    break;


                    case "sexo":
                        if (comboBoxsexo.SelectedItem == null)
                        {
                            MessageBox.Show("Selecione um sexo");
                            return false;
                        }
                        break;


                    //valida peso entre 30 e 200
                    case "peso":
                        Regex testaPeso = new Regex(@"^[0-9]{0,3},[0-9]{2}$");
                        if (!testaPeso.IsMatch(txtpeso.Text))
                        {
                            MessageBox.Show("Use virgula e valor entre 30,00 e 200,00");
                            return false;
                        }
                        else
                        {
                            Decimal peso = Convert.ToDecimal(txtpeso.Text);
                            Decimal menor = 30.00m;
                            Decimal maior = 200.00m;
                            if (Decimal.Compare(peso, menor) < 0 || Decimal.Compare(peso, maior) > 0)
                            {
                                MessageBox.Show("Peso não permitido!");
                                return false;
                            }
                        }
                        break;


                    //valida altura entre 0,50 e 2,50
                    case "altura":
                        Regex testaAltura = new Regex(@"^[0-2],[0-5][0-9]$");
                        if (!testaAltura.IsMatch(txtaltura.Text))
                        {
                            MessageBox.Show("Use virgula e valor entre 0,50 a 2,59");
                            return false;
                        }
                        else
                        {
                            Decimal altura = Convert.ToDecimal(txtaltura.Text);
                            Decimal menor = 0.50m;
                            Decimal maior = 2.50m;
                            if (Decimal.Compare(altura, menor) < 0 || Decimal.Compare(altura, maior) > 0)
                            {
                                MessageBox.Show("Altura não permitida!");
                                return false;
                            }
                        }
                        break;


                    case "objetivo":
                        if (comboBoxobjetivo.SelectedItem == null)
                        {
                            MessageBox.Show("Selecione um objetivo");
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
                MessageBox.Show("Data inválida");
                maskednascimento.Focus();
            }
        }
    }
}
