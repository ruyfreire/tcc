using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tcc.DAL;
using tcc.DTO;

namespace tcc.BLL
{
    public class PersonalBLL
    {
        public int novoPersonal(Personal novo)
        {
            try
            {
                return new PersonalDAL().novoPersonal(novo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public int autenticaPersonal(String login, String senha)
        {
            try
            {
                //verifica se personal existe, antes de autenticar senha
                int existePersonal = new PersonalDAL().existePersonal("confereLogin", login);

                // se encontrar personal, verifica a resposta de retorno
                if (existePersonal == 1)
                {
                    return new PersonalDAL().autenticaPersonal(login, senha);
                }

                //se nao encontrar personal, retorna 0
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


        public Personal carregaPersonal(String login)
        {
            try
            {
                return new PersonalDAL().carregaPersonal(login);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public int alteraPersonal(Personal personal, Personal personalAntigo)
        {
            return new PersonalDAL().alteraPersonal(personal, personalAntigo);
        }

        public Personal recuperaSenha(Personal personal)
        {
            return new PersonalDAL().recuperaSenha(personal);
        }


        public IList<Personal> buscaPersonalNome(String nome_personal)
        {
            return new PersonalDAL().buscaPersonalNome(nome_personal);
        }


        public IList<Personal> buscaTodosPersonal()
        {
            return new PersonalDAL().buscaTodosPersonal();
        }


        public IList<Usuario> buscaClientesNome(int id_personal, String nome_usuario)
        {
            return new PersonalDAL().buscaClientesNome(id_personal, nome_usuario);
        }

        public IList<Usuario> buscaTodosClientes(int id_personal)
        {
            return new PersonalDAL().buscaTodosClientes(id_personal);
        }
    }
}
