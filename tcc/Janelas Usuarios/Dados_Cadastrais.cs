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
    public partial class Dados_Cadastrais : Form
    {
        Usuario usuario;

        public Dados_Cadastrais()
        {
            InitializeComponent();
        }

        private void Dados_Cadastrais_Load(object sender, EventArgs e)
        {
            /* Define o tipo correto do campo data, e chama o metodo validaData através do TypeValidationCompleted,
            * que é executado automaticamente no campo maskedtextbox quando perde o foco
            */
            masknascimento.ValidatingType = typeof(System.DateTime);
            masknascimento.TypeValidationCompleted += new TypeValidationEventHandler(validaData);

            usuario = ((usuarioMDI)MdiParent).usuario;

            preebcheCampo();
        }

        private void validaData(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                MessageBox.Show("Data inválida", "Data de nascimento");
                masknascimento.Focus();
            }
        }

        private void preebcheCampo()
        {
            txtnome.Text = usuario.nome;
            txtemail.Text = usuario.email;
            txtlogin.Text = usuario.login;
            txtsenha.Text = usuario.senha;
            masknascimento.Text = Convert.ToString(usuario.nascimento);
            cbosexo.SelectedItem = usuario.sexo;
            txtpeso.Text = Convert.ToString(usuario.peso);
            txtaltura.Text = Convert.ToString(usuario.altura);
            cboobjetivo.SelectedItem = usuario.objetivo;
        }

        private void liberaCampos()
        {
            txtnome.ReadOnly = false;
            txtemail.ReadOnly = false;
            txtlogin.ReadOnly = false;
            txtsenha.ReadOnly = false;
            masknascimento.ReadOnly = false;
            cbosexo.Enabled = true;
            txtpeso.ReadOnly = false;
            txtaltura.ReadOnly = false;
            cboobjetivo.Enabled = true;
        }

        private void bloqueiaCampos()
        {
            txtnome.ReadOnly = true;
            txtemail.ReadOnly = true;
            txtlogin.ReadOnly = true;
            txtsenha.ReadOnly = true;
            masknascimento.ReadOnly = true;
            cbosexo.Enabled = false;
            txtpeso.ReadOnly = true;
            txtaltura.ReadOnly = true;
            cboobjetivo.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (btnEditar.Text.Equals("Editar")) editando();
            else cancelando();
        }

        private void editando()
        {
            liberaCampos();
            btnEditar.Text = "Cancelar";
            btnSalvar.Visible = true;
        }

        private void cancelando()
        {
            preebcheCampo();
            bloqueiaCampos();
            btnEditar.Text = "Editar";
            btnSalvar.Visible = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Validacoes validar = new Validacoes();
                if (
                    validar.validaCampos("nome", txtnome.Text)
                    && validar.validaCampos("email", txtemail.Text.ToLower())
                    && validar.validaCampos("login", txtlogin.Text.ToLower())
                    && validar.validaCampos("senha", txtsenha.Text)
                    && validar.validaCampos("nascimento", masknascimento.Text)
                    && validar.validaCampos("idade", masknascimento.Text)
                    && validar.validaCampos("sexo", cbosexo.Text)
                    && validar.validaCampos("peso", txtpeso.Text)
                    && validar.validaCampos("altura", txtaltura.Text)
                    && validar.validaCampos("objetivo", cboobjetivo.Text)
                    )
                {
                    //após validar, inclui no objeto e envia para a prox camada
                    Usuario novoUser = new Usuario
                    {
                        id_usuario = usuario.id_usuario,
                        nome = txtnome.Text,
                        email = txtemail.Text.ToLower(),
                        login = txtlogin.Text.ToLower(),
                        senha = txtsenha.Text,
                        nascimento = Convert.ToDateTime(masknascimento.Text),
                        sexo = cbosexo.Text,
                        peso = Convert.ToDecimal(txtpeso.Text),
                        altura = Convert.ToDecimal(txtaltura.Text),
                        objetivo = cboobjetivo.Text
                    };

                    if (
                            novoUser.nome.Equals(usuario.nome) &&
                            novoUser.email.ToLower().Equals(usuario.email) &&
                            novoUser.login.ToLower().Equals(usuario.login) &&
                            novoUser.senha.Equals(usuario.senha) &&
                            novoUser.nascimento.Equals(usuario.nascimento) &&
                            novoUser.sexo.Equals(usuario.sexo) &&
                            novoUser.peso.Equals(usuario.peso) &&
                            novoUser.altura.Equals(usuario.altura) &&
                            novoUser.objetivo.Equals(usuario.objetivo)
                        )
                    {
                        MessageBox.Show("Nada Foi alterado!", "Alterar usuário");
                        cancelando();
                        return;
                    }

                    //verifica se foi cadastrado com sucesso
                    int cadastrado = new UsuarioBLL().alteraUsuario(novoUser, usuario);
                    if (cadastrado == 3)
                    {
                        MessageBox.Show("Cadastro atualizado com sucesso!", "Alterar usuário");
                        usuario = new UsuarioBLL().carregaUsuario(novoUser.login);
                        ((usuarioMDI)MdiParent).usuario = usuario;
                        cancelando();
                    }
                    else if (cadastrado == 2)
                    {
                        MessageBox.Show("E-mail ja cadastrado!", "Alterar usuário");
                    }
                    else if (cadastrado == 1)
                    {
                        MessageBox.Show("Login já existe, tente um novo", "Alterar usuário");
                    }
                    else
                    {
                        MessageBox.Show("Erro ao alterar!", "Alterar usuário");
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

    }
}
