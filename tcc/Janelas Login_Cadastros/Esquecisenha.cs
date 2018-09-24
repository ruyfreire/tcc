using System;
using System.Windows.Forms;
using tcc.BLL;
using tcc.DTO;

namespace tcc
{
    public partial class Esquecisenha : Form
    {
        private String perfil;
        Usuario usuarioRecuperado;
        Personal personalRecuperado;
        Nutricionista nutricionistaRecuperado;

        public Esquecisenha(string perfil)
        {
            InitializeComponent();
            this.perfil = perfil;
        }

        private void Esquecisenha_Load(object sender, EventArgs e)
        {
            /* Define o tipo correto do campo data, e chama o metodo validaData através do TypeValidationCompleted,
            * que é executado automaticamente no campo maskedtextbox quando perde o foco
            */
            maskednascimento.ValidatingType = typeof(System.DateTime);
            maskednascimento.TypeValidationCompleted += new TypeValidationEventHandler(validaData);
            lblperfil.Text = perfil;
        }

        private void validaData(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                MessageBox.Show("Data inválida");
                maskednascimento.Focus();
            }
        }    
        
        private void btnrecuperar_Click(object sender, EventArgs e)
        {
            Validacoes valida = new Validacoes();

            if (txtlogin.Text.Equals("") || txtemail.Text.Equals("") || maskednascimento.Text.Replace("/", "").Replace(" ", "").Equals(""))
            {
                MessageBox.Show("Preencha todos os campos", "Recuperação de senha");
            }
            else if(!valida.validaCampos("login", txtlogin.Text) || !valida.validaCampos("email", txtemail.Text) || !valida.validaCampos("nascimento", maskednascimento.Text) || !valida.validaCampos("idade", maskednascimento.Text) )
            {
                return;
            }
            else
            {
                switch (perfil)
                {
                    case "Usuário":
                        Usuario usuario = new Usuario
                        {
                            login = txtlogin.Text,
                            email = txtemail.Text,
                            nascimento = Convert.ToDateTime(maskednascimento.Text)
                        };
                        usuarioRecuperado = new UsuarioBLL().recuperaSenha(usuario);
                        if (usuarioRecuperado.id_usuario == 0)
                        {
                            MessageBox.Show("Nenhum usuário encontrado com estes dados");
                        }
                        else
                        {
                            MessageBox.Show("Defina uma nova senha para o seu usuário");
                            mudaTelaSenha();                            
                        }
                    break;


                    case "Personal":
                        Personal personal = new Personal
                        {
                            login = txtlogin.Text,
                            email = txtemail.Text,
                            nascimento = Convert.ToDateTime(maskednascimento.Text)
                        };
                        personalRecuperado = new PersonalBLL().recuperaSenha(personal);
                        if (personalRecuperado.id_personal == 0)
                        {
                            MessageBox.Show("Nenhum usuário encontrado com estes dados");
                        }
                        else
                        {
                            MessageBox.Show("Defina uma nova senha para o seu usuário");
                            mudaTelaSenha();
                        }
                    break;


                    case "Nutricionista":
                        Nutricionista nutricionista = new Nutricionista
                        {
                            login = txtlogin.Text,
                            email = txtemail.Text,
                            nascimento = Convert.ToDateTime(maskednascimento.Text)
                        };
                        nutricionistaRecuperado = new NutricionistaBLL().recuperaSenha(nutricionista);
                        if (nutricionistaRecuperado.id_nutricionista == 0)
                        {
                            MessageBox.Show("Nenhum usuário encontrado com estes dados");
                        }
                        else
                        {
                            MessageBox.Show("Defina uma nova senha para o seu usuário");
                            mudaTelaSenha();
                        }
                     break;
                }

            }
        }

        private void mudaTelaSenha()
        {
            lbllogin.Visible = false; txtlogin.Visible = false;
            lblemail.Visible = false; txtemail.Visible = false;
            lblnascimento.Visible = false; maskednascimento.Visible = false;
            btnrecuperar.Visible = false;

            lblnovasenha.Visible = true; txtnovasenha.Visible = true;
            lblrepetesenha.Visible = true; txtrepetesenha.Visible = true;
            btnsalvar.Visible = true;
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            int salvo;

            if ( !txtnovasenha.Text.Equals(txtrepetesenha.Text) ) MessageBox.Show("As senhas não são iguais");

            else if(! new Validacoes().validaCampos("senha", txtnovasenha.Text)) return;

            else
            {
                switch (perfil)
                {
                    case "Usuário":
                        usuarioRecuperado.senha = txtnovasenha.Text;
                        salvo = new UsuarioBLL().alteraUsuario(usuarioRecuperado, usuarioRecuperado);
                        if (salvo > 0) { MessageBox.Show("Senha atualizada com sucesso"); telaLogin(); }
                        else MessageBox.Show("Erro ao atualizar dados");
                    break;


                    case "Personal":
                        personalRecuperado.senha = txtnovasenha.Text;
                        salvo = new PersonalBLL().alteraPersonal(personalRecuperado, personalRecuperado);
                        if (salvo > 0) { MessageBox.Show("Senha atualizada com sucesso"); telaLogin(); }
                        else MessageBox.Show("Erro ao atualizar dados");
                    break;


                    case "Nutricionista":
                        nutricionistaRecuperado.senha = txtnovasenha.Text;
                        salvo = new NutricionistaBLL().alteraNutricionista(nutricionistaRecuperado, nutricionistaRecuperado);
                        if (salvo > 0) { MessageBox.Show("Senha atualizada com sucesso"); telaLogin(); }
                        else MessageBox.Show("Erro ao atualizar dados");
                    break;
                }
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            telaLogin();
        }


        private void Esquecisenha_FormClosed(object sender, FormClosedEventArgs e)
        {
            telaLogin();
        }

        private void telaLogin()
        {
            login telaLogin = new login();
            telaLogin.Show();
            Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
