using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tcc.DAL;
using tcc.DTO;

namespace tcc.BLL
{
    public class TreinoBLL
    {
        public int incluirTreinoUsuario(int id_usuario, Treino novoTreino)
        {
            return new TreinoDAL().incluirTreinoUsuario(id_usuario, novoTreino);
        }


        public int excluiTreinoUnicoUsuario(int id_usuario, int id_treino)
        {
            return new TreinoDAL().excluiTreinoUnicoUsuario(id_usuario, id_treino);
        }

        public int excluiTodosTreinoUsuario(int id_usuario)
        {
            return new TreinoDAL().excluiTodosTreinoUsuario(id_usuario);
        }


        public IList<Treino> carregaTreinosDeUsuario(int id_usuario)
        {
            return new TreinoDAL().carregaTreinosDeUsuario(id_usuario);
        }


        public int alteraTreinoDeUsuario(Treino treino)
        {
            return new TreinoDAL().alteraTreinoDeUsuario(treino);
        }
    }
}
