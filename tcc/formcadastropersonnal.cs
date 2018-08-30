using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tcc
{
    public partial class CadastroPersonal : Form
    {
        public CadastroPersonal()
        {
            InitializeComponent();
        }

        private void formcadastropersonnal_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            limpar_camposCadastro();
        }
        public void limpar_camposCadastro()
        {
            txtname.Clear();
            txtemail.Clear();
            txtsenha.Clear();
            txtcrea.Clear();
            txtendereco.Clear();
            maskednascimento.Clear();
            maskedcpf.Clear();
            comboBoxsexo.SelectedIndex = comboBoxsexo.Items.IndexOf("");
        }
    }   
}
