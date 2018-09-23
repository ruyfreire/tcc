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

            profissional = ((profissionalMDI)MdiParent).profissional;

            preebcheCampo();
        }

        private void validaData(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                MessageBox.Show("Data inválida", "Data de nascimento");
                maskednascimento.Focus();
            }
        }

        private void preebcheCampo()
        {
            txtname.Text = profissional.nome;
            txtlogin.Text = profissional.login;
            txtemail.Text = profissional.email;
            txtsenha.Text = profissional.senha;
            txtcpf_cnpj.Text = profissional.cpf_cnpj;

            if (profissional.GetType() == typeof(Personal)) txtcrea_crn.Text = ((Personal)profissional).crea;
            else txtcrea_crn.Text = ((Nutricionista)profissional).crn;

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

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }
    }
}
