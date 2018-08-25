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
    public partial class formcadastro : Form
    {
        public formcadastro()
        {
            InitializeComponent();
        }

        private void formcadastro_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            { 
            Usuario novoUser = new Usuario();
            novoUser.nome = txtname.Text;
            novoUser.email = txtemail.Text;
            novoUser.senha = txtsenha.Text;
            novoUser.nascimento = Convert.ToDateTime (maskednascimento.Text);
            novoUser.sexo = comboBoxsexo.Text;
            novoUser.peso = Convert.ToInt32( txtpeso.Text);
            novoUser.altura = Convert.ToInt32 (txtaltura.Text);
            novoUser.objetivo = comboBoxobjetivo.Text;
            new UsuarioBLL().novoUsuarioBLL(novoUser);       
                }
            catch (Exception ex)
            {
                throw ex;
            }
            private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
