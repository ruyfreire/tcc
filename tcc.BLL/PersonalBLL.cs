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

        public int autenticaPersonal(String email, String senha)
        {
            try
            {
                //verifica se personal existe, antes de autenticar senha
                int existePersonal = new PersonalDAL().existePersonal(email);

                // se encontrar personal, verifica a resposta de retorno
                if (existePersonal == 1)
                {
                    return new PersonalDAL().autenticaPersonal(email, senha);
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


        public Personal carregaPersonal(String email)
        {
            try
            {
                return new PersonalDAL().carregaPersonal(email);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
