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
            return 1;
            /*
            try
            {
                return 1;
                //return new UsuarioDAL().novoUsuarioDAL(novoUser);
            }
            catch (Exception ex)
            {
                throw ex;
            }
             */
        }

        public void buscaUsuarioBLL()
        {
            new UsuarioDAL().buscaUsuarioDAL();
        }
    }
}
