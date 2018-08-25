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
                var nome = novoUser.nome;
                Regex testaNome = new Regex(@"^[A-Za-z][ ][A-Za-z]$");
                Regex testaPeso = new Regex(@"^[3-9][0-9]?[0-9],[0-9]{2}$");
                Regex testaEmail = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");


                if (!testaEmail.IsMatch(novoUser.email))
                {
                    return 100;
                }
                if ((!testaNome.IsMatch(nome)) || (string.IsNullOrEmpty(nome)) || (nome.Length < 5))
                {
                    return 101;
                }
                if (novoUser.senha.Length <= 6 || novoUser.senha.Length > 8)
                {
                    return 102;
                }
                if (!testaPeso.IsMatch(Convert.ToString(novoUser.peso)))
                {
                    return 103;
                }

                return new UsuarioDAL().novoUsuarioDAL(novoUser);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void buscaUsuarioBLL()
        {
            new UsuarioDAL().buscaUsuarioDAL();
        }
    }
}
