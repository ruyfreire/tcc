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
                if (usuarios.Count == 0) MessageBox.Show("Nenhum cliente encontrado!", "Busca Clientes");
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
            if (usuario != null)
            {
                var resp = MessageBox.Show("Deseja vincular este cliente ao seu perfil?\n\n" +
                    "Nome: " + usuario.nome +
                    "\nObjetivo: " + usuario.objetivo, 
                    "Vincular cliente", MessageBoxButtons.YesNo);


                if (resp.ToString().Equals("Yes"))
                {
                    if (profissional.GetType() == typeof(Personal))
                    {
                        int vinculado = new UsuarioBLL().incluiPersonal(usuario.id_usuario, ((Personal)profissional).id_personal);
                        if(vinculado > 0)
                        {
                            MessageBox.Show("Cliente Vinculado com sucesso", "Novo Cliente");
                            //limpa linhas do grid
                            gridclientes.Rows.Clear();
                        }
                        else if (vinculado == -1)
                        {
                            MessageBox.Show("Cliente já possui Personal", "Novo Cliente");
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
                        int vinculado = new UsuarioBLL().incluiNutricionista(usuario.id_usuario, ((Nutricionista)profissional).id_nutricionista);
                        if (vinculado > 0)
                        {
                            MessageBox.Show("Cliente Vinculado com sucesso", "Novo Cliente");
                            //limpa linhas do grid
                            gridclientes.Rows.Clear();
                        }
                        else if (vinculado == -1)
                        {
                            MessageBox.Show("Cliente já possui Nutricionista", "Novo Cliente");
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
    }
}
