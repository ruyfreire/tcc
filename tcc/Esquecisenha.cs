using System;
using System.Windows.Forms;
using tcc.DTO;

namespace tcc
{
    public partial class Esquecisenha : Form
    {
        public Esquecisenha(string perfil)
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnenviar_Click(object sender, EventArgs e)

        {
            Usuario novoUser = new Usuario

            {
                login = txtlogin.Text,
                email = txtemail.Text,
                nascimento = Convert.ToDateTime(maskednascimento.Text)
            };
        }
        private void validaData(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                MessageBox.Show("Data inválida");
                maskednascimento.Focus();
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtemail.Clear();
            txtemail.Clear();
            maskednascimento.Clear();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Esquecisenha_Load(object sender, EventArgs e)
        {
            /* Define o tipo correto do campo data, e chama o metodo validaData através do TypeValidationCompleted,
* que é executado automaticamente no campo maskedtextbox quando perde o foco
*/
            maskednascimento.ValidatingType = typeof(System.DateTime);
            maskednascimento.TypeValidationCompleted += new TypeValidationEventHandler(validaData);
        }

        private void Esquecisenha_FormClosed(object sender, FormClosedEventArgs e)
        {
        telaLogin(); //volta para tela de login
        }

        private void telaLogin()
        {
            login telaLogin = new login();
            telaLogin.Show();
        }
    }
}
