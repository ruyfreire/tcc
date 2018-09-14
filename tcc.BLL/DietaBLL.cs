using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tcc.DAL;
using tcc.DTO;

namespace tcc.BLL
{
    public class DietaBLL
    {

        public int incluirDietaUsuario(int id_usuario, Dieta novaDieta)
        {
            return new DietaDAL().incluirDietaUsuario(id_usuario, novaDieta);
        }


        public int excluiDietaUnicaUsuario(int id_usuario, int id_dieta)
        {
            return new DietaDAL().excluiDietaUnicaUsuario(id_usuario, id_dieta);
        }


        public IList<Dieta> carregaDietasDeUsuario(int id)
        {
            return new DietaDAL().carregaDietasDeUsuario(id);
        }


        public int alteraDietasDeUsuario(Dieta dieta)
        {
            return new DietaDAL().alteraDietasDeUsuario(dieta);
        }

        
    }
}
