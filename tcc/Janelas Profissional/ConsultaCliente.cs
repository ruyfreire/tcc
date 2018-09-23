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
    public partial class ConsultaCliente : Form
    {
        IList<Usuario> usuarios;
        Profissional profissional;
        Usuario usuario = null;

        public ConsultaCliente()
        {
            InitializeComponent();
        }

        private void ConsultaCliente_Load(object sender, EventArgs e)
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
                if (profissional.GetType() == typeof(Personal))
                    usuarios = new PersonalBLL().buscaClientesNome( ((Personal)profissional).id_personal, txtNome.Text );
                else
                    usuarios = new NutricionistaBLL().buscaClientesNome(((Nutricionista)profissional).id_nutricionista, txtNome.Text);

                if (usuarios.Count == 0) MessageBox.Show("Nenhum cliente encontrado em sua lista!", "Busca Clientes");
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

        private void btnBuscarTodos_Click(object sender, EventArgs e)
        {
            //limpa linhas do grid
            gridclientes.Rows.Clear();

            //carrega usuarios da busca
            if (profissional.GetType() == typeof(Personal))
                usuarios = new PersonalBLL().buscaTodosClientes(((Personal)profissional).id_personal);
            else
                usuarios = new NutricionistaBLL().buscaTodosClientes(((Nutricionista)profissional).id_nutricionista);

            if (usuarios.Count == 0) MessageBox.Show("Nenhum cliente encontrado em sua lista!", "Busca Clientes");
            else
            {
                foreach (Usuario usuario in usuarios)
                {
                    gridclientes.Rows.Add(usuario.nome, usuario.email, usuario.sexo, usuario.objetivo);
                }
            }
            gridclientes.Rows[0].Selected = false;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow linha in gridclientes.Rows)
            {
                if (linha.Selected == true)
                {
                    usuario = usuarios[linha.Index];
                    confirmaRemover();
                    return;
                }
            }
            MessageBox.Show("Selecione um cliente!");
        }

        private void confirmaRemover()
        {
            if (usuario != null)
            {
                var resp = MessageBox.Show("Deseja remover este cliente?\n\n" +
                    "Nome: " + usuario.nome +
                    "\nObjetivo: " + usuario.objetivo,
                    "Remover cliente", MessageBoxButtons.YesNo);


                if (resp.ToString().Equals("Yes"))
                {
                    if (profissional.GetType() == typeof(Personal))
                    {
                        int removido = new UsuarioBLL().removePersonal(usuario.id_usuario);
                        if (removido > 0)
                        {
                            MessageBox.Show("Cliente removido com sucesso", "Remover Cliente");
                            //limpa linhas do grid
                            gridclientes.Rows.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Erro em removido o cliente", "Remover Cliente");
                        }
                    }
                    else
                    {
                        int removido = new UsuarioBLL().removeNutricionista(usuario.id_usuario);
                        if (removido > 0)
                        {
                            MessageBox.Show("Cliente removido com sucesso", "Remover Cliente");
                            //limpa linhas do grid
                            gridclientes.Rows.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Erro em remover o cliente", "Remover Cliente");
                        }
                    }
                }
            }
        }
    }
}
