using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tcc.BLL;
using tcc.DTO;

namespace tcc
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            comboperfil.SelectedIndex = 0;
            txtLogin.Focus();
        }

        private void criarUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formcadastro formularioCadastro = new formcadastro();
            formularioCadastro.Show();
            this.Visible = false;
        }

        private void criarnutricionista_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CadastroNutricionista formularioCadastro = new CadastroNutricionista();
            formularioCadastro.Show();
            this.Visible = false;
        }

        private void criarPersonal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CadastroPersonal cadastroPersonal = new CadastroPersonal();
            cadastroPersonal.Show();
            this.Visible = false;
        }
                
        private void btnOk_Click(object sender, EventArgs e)
        {
            String login = txtLogin.Text;
            String senha = txtSenha.Text;
            String perfil = comboperfil.Text;
            int autentica;


            switch (perfil)
            {
                case "Usuário":
                    autentica = new UsuarioBLL().autenticaUsuario(login, senha);
                    if (autentica == 1)
                    {
                        /* carrega perfil do Usuario */
                        Usuario usuario = new UsuarioBLL().carregaUsuario(login);

                        /* Cria janela inicial e mdi */
                        usuarioMDI mdi = new usuarioMDI(usuario);
                        InicioUsuario telaInicial = new InicioUsuario(mdi);

                        /* coloca tela inicial dentro de mdi */
                        telaInicial.MdiParent = mdi;

                        /* exibe as janelas, e maximiza tela incial dentro de mdi */
                        mdi.Show();
                        telaInicial.WindowState = FormWindowState.Maximized;
                        telaInicial.Show();
                        this.Visible = false;
                    }
                    else if (autentica == -1)
                    {
                        MessageBox.Show("Senha inválida!");
                    }
                    else
                    {
                        MessageBox.Show("Usuário não existe!");
                    }
                break;

                case "Personal":
                    autentica = new PersonalBLL().autenticaPersonal(login, senha);
                    if (autentica == 1)
                    {
                        /* carrega perfil */
                        Personal personal = new PersonalBLL().carregaPersonal(login);

                        /* Cria janela inicial e mdi */
                        profissionalMDI mdi = new profissionalMDI(personal);
                        InicioProfissional telaInicial = new InicioProfissional(mdi);

                        /* coloca tela inicial dentro de mdi */
                        telaInicial.MdiParent = mdi;

                        /* exibe as janelas, e maximiza tela incial dentro de mdi */
                        mdi.Show();
                        telaInicial.WindowState = FormWindowState.Maximized;
                        telaInicial.Show();
                        this.Visible = false;
                    }
                    else if (autentica == -1)
                    {
                        MessageBox.Show("Senha inválida!");
                    }
                    else
                    {
                        MessageBox.Show("Personal não existe!");
                    }
                break;

                case "Nutricionista":
                    autentica = new NutricionistaBLL().autenticaNutricionista(login, senha);
                    if (autentica == 1)
                    {
                        /* carrega perfil */
                        Nutricionista nutricionista = new NutricionistaBLL().carregaNutricionista(login);
                        
                        /* Cria janela inicial e mdi */
                        profissionalMDI mdi = new profissionalMDI(nutricionista);
                        InicioProfissional telaInicial = new InicioProfissional(mdi);

                        /* coloca tela inicial dentro de mdi */
                        telaInicial.MdiParent = mdi;

                        /* exibe as janelas, e maximiza tela incial dentro de mdi */
                        mdi.Show();
                        telaInicial.WindowState = FormWindowState.Maximized;
                        telaInicial.Show();
                        this.Visible = false;
                    }
                    else if (autentica == -1)
                    {
                        MessageBox.Show("Senha inválida!");
                    }
                    else
                    {
                        MessageBox.Show("Nutricionista não existe!");
                    }
                break;
                default:
                    MessageBox.Show("Selecione um perfil");
                    comboperfil.Focus();
                break;
            }            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void esqueciSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Esquecisenha esqueciSenha = new Esquecisenha(comboperfil.Text);
            esqueciSenha.Show();
            this.Visible = false;
        }

    }
}
