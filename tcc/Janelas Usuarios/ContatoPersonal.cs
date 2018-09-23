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
    public partial class ContatoPersonal : Form
    {
        Usuario usuario;

        public ContatoPersonal()
        {
            InitializeComponent();
        }

        private void ContatoPersonal_Load(object sender, EventArgs e)
        {
            usuario = ((usuarioMDI)MdiParent).usuario;
            Personal personal = new UsuarioBLL().carregaPersonal(usuario);

            if (personal.id_personal == 0) lblSemPersonal.Visible = true;
            else
            {
                txtnome.Text = personal.nome.ToUpper();
                txtcrea.Text = personal.crea.ToUpper();
                txtemail.Text = personal.email.ToUpper();
                txtendereco.Text = personal.endereco.ToUpper();
            }
        }
    }
}
