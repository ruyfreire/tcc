using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using tcc.BLL;
using tcc.DTO;

namespace tcc
{
    public partial class cadastrocliente : Form
    {
        IList<Usuario> usuarios;
        Usuario usuario = null;
        Profissional profissional;

        public cadastrocliente()
        {
            InitializeComponent();
        }

        private void cadastrocliente_Load(object sender, EventArgs e)
        {
            profissional = ((profissionalMDI)MdiParent).profissional;
        }


        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Regex testaCampo = new Regex(@"^[a-zA-Z]+$");

            if (txtNome.Text.Length < 3 || !testaCampo.IsMatch(txtNome.Text))
                MessageBox.Show("Digite um texto válido e no mínimo 3 letras", "Busca Clientes");
            else
            {
                //limpa linhas do grid
                gridclientes.Rows.Clear();

                //carrega usuarios da busca
                usuarios = new UsuarioBLL().buscaUsuariosNome(txtNome.Text);
                if (usuarios.Count == 0) MessageBox.Show("Nenhum alimento encontrado!", "Busca Clientes");
                else
                {
                    foreach (Usuario usuario in usuarios)
                    {
                        gridclientes.Rows.Add(usuario.nome, usuario.email, usuario.sexo, usuario.objetivo);
                    }
                }
            }
            gridclientes.Rows[0].Selected = false;
        }


        private void btnVincular_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow linha in gridclientes.Rows)
            {
                if(linha.Selected == true)
                {
                    usuario = usuarios[ linha.Index ];
                    confirmaVinculo();
                    return;
                }
            }
            MessageBox.Show("Selecione um cliente!");
        }


        private void confirmaVinculo()
        {
            if (profissional.GetType() == typeof(Personal) && usuario.id_gym_personal != 0)
            {
                MessageBox.Show("Usuário ja possui um personal");
                return;
            }
            else if (profissional.GetType() == typeof(Nutricionista) && usuario.id_nutricionista != 0)
            {
                MessageBox.Show("Usuário ja possui um nutricionista");
                return;
            }
            else if (usuario != null)
            {
                var resp = MessageBox.Show("Deseja vincular este cliente ao seu perfil?\n\n" +
                    "Nome: " + usuario.nome +
                    "\nObjetivo: " + usuario.objetivo, 
                    "Vincular cliente", MessageBoxButtons.YesNo);


                if (resp.ToString().Equals("Yes"))
                {
                    if (profissional.GetType() == typeof(Personal))
                    {
                        int vinculado = new UsuarioBLL().atualizaPersonal(usuario, ((Personal)profissional).id_personal);
                        if(vinculado > 0)
                        {
                            MessageBox.Show("Cliente Vinculado com sucesso", "Novo Cliente");
                            //limpa linhas do grid
                            gridclientes.Rows.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Erro em vincular novo cliente", "Novo Cliente");
                        }
                    }
                    else
                    {
                        int vinculado = new UsuarioBLL().atualizaPersonal(usuario, ((Nutricionista)profissional).id_nutricionista);
                        if (vinculado > 0)
                        {
                            MessageBox.Show("Cliente Vinculado com sucesso", "Novo Cliente");
                            //limpa linhas do grid
                            gridclientes.Rows.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Erro em vincular novo cliente", "Novo Cliente");
                        }
                    }
                }
            }
        }

        private void gridclientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
