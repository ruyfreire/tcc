using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using tcc.DTO;

namespace tcc.DAL
{
    public class ExerciciosDAL
    {   
        /* Busca um exercicio especifico,
         de acordo com o id que é passado ao método */
        public Exercicio buscaExercicioEspecifico(int id)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;
                SqlDataReader er;

                cm.CommandText = "SELECT * FROM exercicios WHERE id_exercicio=" + id;

                cm.Connection = con;
                con.Open();

                er = cm.ExecuteReader();
                er.Read();

                Exercicio exercicio = new Exercicio
                {
                    id_exercicio = Convert.ToInt32(er["id_exercicio"]),
                    nome = Convert.ToString(er["nome"]),
                    grupo_muscular = Convert.ToString(er["grupo_muscular"]),
                    execucao = Convert.ToString(er["execucao"]),
                    queima_calorica = Convert.ToInt32(er["queima_calorica"]),
                    tempo = Convert.ToInt32(er["tempo"])
                };

                return exercicio;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /* Recebe lista de IDs, carrega os exercicios com estes IDs,
         e retorna uma lista com todos encontrados */
        public IList<Exercicio> buscaListaDeExerciciosEspecificos(ArrayList id_Exercicios)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;
                SqlDataReader er;
                cm.Connection = con;

                IList<Exercicio> lista_Exercicios = new List<Exercicio>();
                foreach (int id in id_Exercicios)
                {
                    cm.CommandText = "SELECT * FROM exercicios WHERE id_exercicio=" + id;

                    con.Open();

                    er = cm.ExecuteReader();
                    er.Read();

                    Exercicio exercicio = new Exercicio
                    {
                        id_exercicio = Convert.ToInt32(er["id_exercicio"]),
                        nome = Convert.ToString(er["nome"]),
                        grupo_muscular = Convert.ToString(er["grupo_muscular"]),
                        execucao = Convert.ToString(er["execucao"]),
                        queima_calorica = Convert.ToInt32(er["queima_calorica"]),
                        tempo = Convert.ToInt32(er["tempo"])
                    };

                    lista_Exercicios.Add(exercicio);

                    con.Close();
                }

                return lista_Exercicios;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /* Carrega todos exercicios do banco de dados,
        e coloca em uma lista, que é retornada */
        public IList<Exercicio> buscaTodosExercicios()
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;
                SqlDataReader er;

                cm.CommandText = "SELECT * FROM exercicios";

                cm.Connection = con;
                con.Open();

                er = cm.ExecuteReader();

                IList<Exercicio> listaExercicios = new List<Exercicio>();
                if (er.HasRows)
                {
                    while (er.Read())
                    {
                        Exercicio exercicio = new Exercicio
                        {
                            id_exercicio = Convert.ToInt32(er["id_exercicio"]),
                            nome = Convert.ToString(er["nome"]),
                            grupo_muscular = Convert.ToString(er["grupo_muscular"]),
                            execucao = Convert.ToString(er["execucao"]),
                            queima_calorica = Convert.ToInt32(er["queima_calorica"]),
                            tempo = Convert.ToInt32(er["tempo"])
                        };

                        listaExercicios.Add(exercicio);
                    }
                }

                return listaExercicios;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
