using System;
using System.Collections;
using System.Collections.Generic;
using tcc.DAL;
using tcc.DTO;

namespace tcc.BLL
{
    public class ExerciciosBLL
    {
        public int incluiExercicioTreino(int id_treino, int id_exercicio)
        {
            return new ExerciciosDAL().incluiExercicioTreino(id_treino, id_exercicio);
        }


        public int excluiExercicioTreino(int id_treino, int id_exercicio)
        {
            return new ExerciciosDAL().excluiExercicioTreino(id_treino, id_exercicio);
        }


        public IList<Exercicio> carregaExerciciosTreino(int id_treino)
        {
            return new ExerciciosDAL().carregaExerciciosTreino(id_treino);
        }

        public Exercicio buscaExercicioEspecifico(int id_exercicio)
        {
            return new ExerciciosDAL().buscaExercicioEspecifico(id_exercicio);
        }


        public IList<Exercicio> buscaListaDeExerciciosEspecificos(ArrayList id_exercicios)
        {
            return new ExerciciosDAL().buscaListaDeExerciciosEspecificos(id_exercicios);
        }


        public IList<Exercicio> buscaTodosExercicios()
        {
            return new ExerciciosDAL().buscaTodosExercicios();
        }
        

        public IList<Exercicio> buscaExerciciosNome(String nome_exercicio)
        {
            return new ExerciciosDAL().buscaExerciciosNome(nome_exercicio);
        }
    }
}
