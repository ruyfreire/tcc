﻿using System;
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

        private void criarUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formcadastro formularioCadastro = new formcadastro();
            formularioCadastro.Show();
            this.Visible = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            String login = txtUsuario.Text;
            String senha = txtSenha.Text;
            
            int autentica = new UsuarioBLL().autenticaUsuario(login, senha);

             if (autentica == 1)
            {
                MessageBox.Show("Autenticado com Sucesso!");
                Usuario usuario = new UsuarioBLL().carregaUsuario(login);
            }
            else if (autentica == -1)
            {
                MessageBox.Show("Senha inválida!");
            }
            else
            {
                MessageBox.Show("Usuário não existe!");
            }

            
            /*
            int autentica = new PersonalBLL().autenticaPersonal(email, senha);

            if (autentica == 1)
            {
                MessageBox.Show("Autenticado com Sucesso!");
                Personal personal = new PersonalBLL().carregaPersonal(email);
                MessageBox.Show(
                    "Nome: " + personal.nome +
                    "\nEmail: " + personal.email +
                    "\nSenha: " + personal.senha +
                    "\nNascimento: " + personal.nascimento +
                    "\nSexo: " + personal.sexo +
                    "\nCREA: " + personal.crea +
                    "\nCPF/CNPJ: " + personal.cpf_cnpj
                );

            }
            else if (autentica == -1)
            {
                MessageBox.Show("Senha inválida!");
            }
            else
            {
                MessageBox.Show("Personal não existe!");
            }


            int autentica = new NutricionistaBLL().autenticaNutricionista(email, senha);

            if (autentica == 1)
            {
                MessageBox.Show("Autenticado com Sucesso!");
                Nutricionista nutricionista = new NutricionistaBLL().carregaNutricionista(email);
                MessageBox.Show(
                    "Nome: " + nutricionista.nome +
                    "\nEmail: " + nutricionista.email +
                    "\nSenha: " + nutricionista.senha +
                    "\nNascimento: " + nutricionista.nascimento +
                    "\nSexo: " + nutricionista.sexo +
                    "\nCRN: " + nutricionista.crn +
                    "\nCPF/CNPJ: " + nutricionista.cpf_cnpj
                );
            }
            else if (autentica == -1)
            {
                MessageBox.Show("Senha inválida!");
            }
            else
            {
                MessageBox.Show("Nutricionista não existe!");
            }
            */
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            {
                CadastroPersonal formularioCadastro = new CadastroPersonal();
                formularioCadastro.Show();
                this.Visible = false;
            }
        }

        private void criarnutricionista_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CadastroNutricionista formularioCadastro = new CadastroNutricionista();
            formularioCadastro.Show();
            this.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Esquecisenha formularioCadastro = new Esquecisenha(comboperfil.Text);
            formularioCadastro.Show();
            this.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
