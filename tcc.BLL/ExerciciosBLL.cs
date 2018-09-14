using System.Collections;
using System.Collections.Generic;
using tcc.DAL;
using tcc.DTO;

namespace tcc.BLL
{
    public class ExerciciosBLL
    {
        public Exercicio buscaExercicioEspecifico(int id_Exercicio)
        {
            return new ExerciciosDAL().buscaExercicioEspecifico(id_Exercicio);
        }


        public IList<Exercicio> buscaListaDeExerciciosEspecificos(ArrayList id_Exercicios)
        {
            return new ExerciciosDAL().buscaListaDeExerciciosEspecificos(id_Exercicios);
        }


        public IList<Exercicio> buscaTodosExercicios()
        {
            return new ExerciciosDAL().buscaTodosExercicios();
        }
    }
}
