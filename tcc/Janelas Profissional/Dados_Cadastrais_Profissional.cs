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
    public partial class Dados_Cadastrais_Profissional : Form
    {
        Profissional profissional;

        public Dados_Cadastrais_Profissional()
        {
            InitializeComponent();
        }

        private void Dados_Cadastrais_Profissional_Load(object sender, EventArgs e)
        {
            /* Define o tipo correto do campo data, e chama o metodo validaData através do TypeValidationCompleted,
            * que é executado automaticamente no campo maskedtextbox quando perde o foco
            */
            maskednascimento.ValidatingType = typeof(System.DateTime);
            maskednascimento.TypeValidationCompleted += new TypeValidationEventHandler(validaData);

            preencheCampo();            
        }

        private void validaData(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                MessageBox.Show("Data inválida", "Data de nascimento");
                maskednascimento.Focus();
            }
        }

        private void preencheCampo()
        {
            profissional = ((profissionalMDI)MdiParent).profissional;

            txtname.Text = profissional.nome;
            txtlogin.Text = profissional.login;
            txtemail.Text = profissional.email;
            txtsenha.Text = profissional.senha;
            txtcpf_cnpj.Text = profissional.cpf_cnpj;

            if (profissional.GetType() == typeof(Personal))
            {
                lblcrea_crn.Text = "CREA :";
                txtcrea_crn.Text = ((Personal)profissional).crea;
            }
            else
            {
                lblcrea_crn.Text = "CRN :";
                txtcrea_crn.Text = ((Nutricionista)profissional).crn;
            }

            maskednascimento.Text = Convert.ToString(profissional.nascimento);
            cbosexo.Text = Convert.ToString(profissional.sexo);
            txtendereco.Text = Convert.ToString(profissional.endereco);
        }

        private void liberaCampos()
        {
            txtname.ReadOnly = false;
            txtlogin.ReadOnly = false;
            txtemail.ReadOnly = false;
            txtsenha.ReadOnly = false;
            txtcpf_cnpj.ReadOnly = false;
            txtcrea_crn.ReadOnly = false;
            maskednascimento.ReadOnly = false;
            cbosexo.Enabled = true;
            txtendereco.ReadOnly = false;
        }

        private void bloqueiaCampos()
        {
            txtname.ReadOnly = true;
            txtlogin.ReadOnly = true;
            txtemail.ReadOnly = true;
            txtsenha.ReadOnly = true;
            txtcpf_cnpj.ReadOnly = true;
            txtcrea_crn.ReadOnly = true;
            maskednascimento.ReadOnly = true;
            cbosexo.Enabled = false;
            txtendereco.ReadOnly = true;
        }

        private void editando()
        {
            liberaCampos();
            btnEditar.Text = "Cancelar";
            btnSalvar.Visible = true;
        }

        private void cancelando()
        {
            preencheCampo();
            bloqueiaCampos();
            btnEditar.Text = "Editar";
            btnSalvar.Visible = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (btnEditar.Text.Equals("Editar")) editando();
            else cancelando();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (profissional.GetType() == typeof(Personal)) alteraPersonal();
            else alteraNutricionista();
        }

        private void alteraPersonal()
        {
            try
            {
                Personal personal = (Personal)profissional;

                Validacoes validar = new Validacoes();
                if (
                    validar.validaCampos("nome", txtname.Text)
                    && validar.validaCampos("login", txtlogin.Text.ToLower())
                    && validar.validaCampos("email", txtemail.Text.ToLower())
                    && validar.validaCampos("senha", txtsenha.Text)
                    && validar.validaCampos("cpf_cnpj", txtcpf_cnpj.Text)
                    && validar.validaCampos("crea", txtcrea_crn.Text)
                    && validar.validaCampos("nascimento", maskednascimento.Text)
                    && validar.validaCampos("sexo", cbosexo.Text)
                    && validar.validaCampos("endereco", txtendereco.Text)
                    )
                {
                    //após validar, inclui no objeto e envia para a prox camada
                     
                    Personal novoPersonal  = new Personal
                    {
                        id_personal = personal.id_personal,
                        nome = txtname.Text,
                        login = txtlogin.Text.ToLower(),
                        email = txtemail.Text.ToLower(),
                        senha = txtsenha.Text,
                        cpf_cnpj = txtcpf_cnpj.Text,
                        crea = txtcrea_crn.Text,
                        nascimento = Convert.ToDateTime(maskednascimento.Text),
                        sexo = cbosexo.Text,
                        endereco = txtendereco.Text
                    };

                    if (
                            novoPersonal.nome.Equals(personal.nome) &&
                            novoPersonal.login.ToLower().Equals(personal.login) &&
                            novoPersonal.email.ToLower().Equals(personal.email) &&
                            novoPersonal.senha.Equals(personal.senha) &&
                            novoPersonal.cpf_cnpj.Equals(personal.cpf_cnpj) &&
                            novoPersonal.crea.Equals(personal.crea) &&
                            novoPersonal.nascimento.Equals(personal.nascimento) &&
                            novoPersonal.sexo.Equals(personal.sexo) &&
                            novoPersonal.endereco.Equals(personal.endereco)
                        )
                    {
                        MessageBox.Show("Nada Foi alterado!", "Alterar Personal");
                        cancelando();
                        return;
                    }

                    //verifica se foi cadastrado com sucesso
                    int cadastrado = new PersonalBLL().alteraPersonal(novoPersonal, personal);
                    if (cadastrado == 3)
                    {
                        MessageBox.Show("Cadastro atualizado com sucesso!", "Alterar Personal");
                        personal = new PersonalBLL().carregaPersonal(novoPersonal.login);
                        ((profissionalMDI)MdiParent).profissional = personal;
                        cancelando();
                    }
                    else if (cadastrado == 2)
                    {
                        MessageBox.Show("E-mail ja cadastrado!", "Alterar Personal");
                    }
                    else if (cadastrado == 1)
                    {
                        MessageBox.Show("Login já existe, tente um novo", "Alterar Personal");
                    }
                    else
                    {
                        MessageBox.Show("Erro ao alterar!", "Alterar Personal");
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        private void alteraNutricionista()
        {
            try
            {
                Nutricionista nutricionista = ((Nutricionista)profissional);

                Validacoes validar = new Validacoes();
                if (
                    validar.validaCampos("nome", txtname.Text)
                    && validar.validaCampos("login", txtlogin.Text.ToLower())
                    && validar.validaCampos("email", txtemail.Text.ToLower())
                    && validar.validaCampos("senha", txtsenha.Text)
                    && validar.validaCampos("cpf_cnpj", txtcpf_cnpj.Text)
                    && validar.validaCampos("crn", txtcrea_crn.Text)
                    && validar.validaCampos("nascimento", maskednascimento.Text)
                    && validar.validaCampos("sexo", cbosexo.Text)
                    && validar.validaCampos("endereco", txtendereco.Text)
                    )
                {
                    //após validar, inclui no objeto e envia para a prox camada

                    Nutricionista novoNutricionista = new Nutricionista
                    {
                        id_nutricionista = nutricionista.id_nutricionista,
                        nome = txtname.Text,
                        login = txtlogin.Text.ToLower(),
                        email = txtemail.Text.ToLower(),
                        senha = txtsenha.Text,
                        cpf_cnpj = txtcpf_cnpj.Text,
                        crn = txtcrea_crn.Text,
                        nascimento = Convert.ToDateTime(maskednascimento.Text),
                        sexo = cbosexo.Text,
                        endereco = txtendereco.Text
                    };

                    if (
                            novoNutricionista.nome.Equals(nutricionista.nome) &&
                            novoNutricionista.login.ToLower().Equals(nutricionista.login) &&
                            novoNutricionista.email.ToLower().Equals(nutricionista.email) &&
                            novoNutricionista.senha.Equals(nutricionista.senha) &&
                            novoNutricionista.cpf_cnpj.Equals(nutricionista.cpf_cnpj) &&
                            novoNutricionista.crn.Equals(nutricionista.crn) &&
                            novoNutricionista.nascimento.Equals(nutricionista.nascimento) &&
                            novoNutricionista.sexo.Equals(nutricionista.sexo) &&
                            novoNutricionista.endereco.Equals(nutricionista.endereco)
                        )
                    {
                        MessageBox.Show("Nada Foi alterado!", "Alterar Nutricionista");
                        cancelando();
                        return;
                    }

                    //verifica se foi cadastrado com sucesso
                    int cadastrado = new NutricionistaBLL().alteraNutricionista(novoNutricionista, nutricionista);
                    if (cadastrado == 3)
                    {
                        MessageBox.Show("Cadastro atualizado com sucesso!", "Alterar Nutricionista");
                        nutricionista = new NutricionistaBLL().carregaNutricionista(novoNutricionista.login);
                        ((profissionalMDI)MdiParent).profissional = nutricionista;
                        cancelando();
                    }
                    else if (cadastrado == 2)
                    {
                        MessageBox.Show("E-mail ja cadastrado!", "Alterar Nutricionista");
                    }
                    else if (cadastrado == 1)
                    {
                        MessageBox.Show("Login já existe, tente um novo", "Alterar Nutricionista");
                    }
                    else
                    {
                        MessageBox.Show("Erro ao alterar!", "Alterar Nutricionista");
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
