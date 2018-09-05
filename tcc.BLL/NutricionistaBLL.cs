using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tcc.DAL;
using tcc.DTO;

namespace tcc.BLL
{
    public class NutricionistaBLL
    {
        public int novoNutricionista(Nutricionista novo)
        {
            try
            {
                return new NutricionistaDAL().novoNutricionista(novo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int autenticaNutricionista(String email, String senha)
        {
            try
            {
                //verifica se nutricionista existe, antes de autenticar senha
                int existeNutricionista = new NutricionistaDAL().existeNutricionista(email);

                // se encontrar nutricionista, verifica a resposta de retorno
                if (existeNutricionista == 1)
                {
                    return new NutricionistaDAL().autenticaNutricionista(email, senha);
                }

                //se nao encontrar nutricionista, retorna 0
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


        public Nutricionista carregaNutricionista(String email)
        {
            try
            {
                return new NutricionistaDAL().carregaNutricionista(email);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
