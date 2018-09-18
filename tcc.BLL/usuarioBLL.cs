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
                int existeUsuario = new UsuarioDAL().existeUsuario(login);
                    
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


        public int atualizaPersonal(Usuario usuario, int id_gym_personal)
        {
            return new UsuarioDAL().atualizaPersonal(usuario, id_gym_personal);
        }
    }
}
