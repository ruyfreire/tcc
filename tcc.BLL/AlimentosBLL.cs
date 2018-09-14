using System.Collections.Generic;
using tcc.DTO;
using tcc.DAL;
using System.Collections;

namespace tcc.BLL
{
    public class AlimentosBLL
    {
        public int incluiAlimentoDieta(int id_dieta, int id_alimento)
        {
            return new AlimentoDAL().incluiAlimentoDieta(id_dieta, id_alimento);
        }


        public int excluiAlimentoDieta(int id_dieta, int id_alimento)
        {
            return new AlimentoDAL().excluiAlimentoDieta(id_dieta, id_alimento);
        }


        public IList<Alimento> carregaAlimentosDieta(int id_Dieta)
        {
            return new AlimentoDAL().carregaAlimentosDieta(id_Dieta);
        }


        public Alimento buscaUnicoAlimento(int id_alimento)
        {
            return new AlimentoDAL().buscaUnicoAlimento(id_alimento);
        }


        public IList<Alimento> buscaListaDeAlimentosEspecificos(ArrayList id_alimentos)
        {
            return new AlimentoDAL().buscaListaDeAlimentosEspecificos(id_alimentos);
        }


        public IList<Alimento> buscaTodosAlimentos()
        {
            return new AlimentoDAL().buscaTodosAlimentos();
        }

    }
}
