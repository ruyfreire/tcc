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
    }
}
