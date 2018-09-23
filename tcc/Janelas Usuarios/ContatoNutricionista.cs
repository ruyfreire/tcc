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
    public partial class ContatoNutricionista : Form
    {
        Usuario usuario;        

        public ContatoNutricionista()
        {
            InitializeComponent();
        }

        private void ContatoNutricionista_Load(object sender, EventArgs e)
        {
            usuario = ((usuarioMDI)MdiParent).usuario;
            Nutricionista nutricionista = new UsuarioBLL().carregaNutricionista(usuario);

            if(nutricionista.id_nutricionista == 0) lblSemNutricionista.Visible = true;
            else
            {
                txtnome.Text = nutricionista.nome.ToUpper();
                txtcrn.Text = nutricionista.crn.ToUpper();
                txtemail.Text = nutricionista.email.ToUpper();
                txtendereco.Text = nutricionista.endereco.ToUpper();
            }
        }
    }
}
