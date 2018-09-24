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
    public partial class CadastrarDieta : Form
    {
        public CadastrarDieta()
        {
            InitializeComponent();
        }

        private void CadastrarDieta_Load(object sender, EventArgs e)
        {
            txtDiaDaSemana.SelectedIndex = 0;
            txtTipoDeRefeicao.SelectedIndex = 0;
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            Dieta dieta = new Dieta()
            {
                dia_semana = txtDiaDaSemana.Text,
                tipo_refeicao = txtTipoDeRefeicao.Text
            };
            /* Pegar o perfil do usuario que esta no MDI principal, e armazenar o id dele */
            int id_usuario = ((usuarioMDI)MdiParent).usuario.id_usuario;
            int cadastrado = new DietaBLL().incluirDietaUsuario(id_usuario, dieta);
            switch (Convert.ToString(cadastrado))
            {
                case "-1":
                    MessageBox.Show("Usuário já possui uma dieta deste tipo, para este dia da semana.", "Nova Dieta");
                    break;
                case "1":
                    MessageBox.Show("Dieta cadastrada com sucesso.", "Nova Dieta");
                    break;
                default:
                    MessageBox.Show("Erro ao cadastrar dieta.", "Nova Dieta");
                    break;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
