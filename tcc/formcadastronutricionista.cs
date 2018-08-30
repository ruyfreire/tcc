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
    public partial class CadastroNutricionista : Form
    {
        public CadastroNutricionista()
        {
            InitializeComponent();
        }

        private void formcadastronutricionista_Load(object sender, EventArgs e)
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
            txtcrn.Clear();
            maskedcpf.Clear();
            txtendereco.Clear();
            maskednascimento.Clear();
            comboBoxsexo.SelectedIndex = comboBoxsexo.Items.IndexOf("");
        }
    }
}
