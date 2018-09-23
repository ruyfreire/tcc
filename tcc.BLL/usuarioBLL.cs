using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using tcc.DAL;
using tcc.DTO;

namespace tcc.BLL
{
    public class UsuarioBLL
    {
        public int novoUsuarioBLL(Usuario novoUser)
        {
            try
            {
                return new UsuarioDAL().novoUsuarioDAL(novoUser);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public int autenticaUsuario(String login, String senha)
        {
            try
            {
                //verifica se usuario existe, antes de autenticar senha
                int existeUsuario = new UsuarioDAL().existeUsuario("confereLogin", login);
                    
                // se encontrar usuario, verifica a resposta de retorno
                if (existeUsuario == 1)
                {
                    return new UsuarioDAL().autenticaUsuario(login, senha);
                }

                //se nao encontrar usuario, retorna 0
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public Usuario carregaUsuario(String login)
        {
            try
            {
                return new UsuarioDAL().carregaUsuario(login);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public int alteraUsuario(Usuario usuario, Usuario usuarioAntigo)
        {            
            return new UsuarioDAL().alteraUsuario(usuario, usuarioAntigo);
        }

        public Usuario recuperaSenha(Usuario usuario)
        {
            return new UsuarioDAL().recuperaSenha(usuario);
        }

        public Personal carregaPersonal(int id_usuario)
        {
            return new UsuarioDAL().carregaPersonal(id_usuario);
        }


        public Nutricionista carregaNutricionista(int id_usuario)
        {
            return new UsuarioDAL().carregaNutricionista(id_usuario);
        }

        public int incluiPersonal(int id_usuario, int id_gym_personal)
        {
            return new UsuarioDAL().insereDicionarioGymPersonalUsuario(id_usuario, id_gym_personal);
        }

        public int removePersonal(int id_usuario)
        {
            return new UsuarioDAL().removeDicionarioGymPersonalUsuario(id_usuario);
        }


        public int incluiNutricionista(int id_usuario, int id_nutricionista)
        {
            return new UsuarioDAL().insereDicionarioNutricionistaUsuario(id_usuario, id_nutricionista);
        }


        public int removeNutricionista(int id_usuario)
        {
            return new UsuarioDAL().removeDicionarioNutricionistaUsuario(id_usuario);
        }


        public int excluiUsuario(Usuario usuario)
        {
            return new UsuarioDAL().excluiUsuario(usuario);
        }


        public IList<Usuario> buscaUsuariosNome(String nome_usuario)
        {
            return new UsuarioDAL().buscaUsuariosNome(nome_usuario);
        }
    }
}
