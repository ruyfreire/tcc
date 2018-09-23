using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using tcc.DTO;

namespace tcc.DAL
{
    public class ExerciciosDAL
    {
        /* Recebe id do treino e do exericio, e vincula os dois na tabela/dicionario treino_exericios 
         retorna 1 se inserir corretamente,
         retorna 0 se falhar */
        public int incluiExercicioTreino(int id_treino, int id_exercicio)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;

                cm.CommandText = "INSERT INTO treino_exercicio (link_treino, link_exercicio) " +
                    "VALUES (@link_treino, @link_exericio)";

                //Parametros irá substituir os valores dentro do campo
                cm.Parameters.Add("link_treino", System.Data.SqlDbType.Int).Value = id_treino;
                cm.Parameters.Add("link_exericio", System.Data.SqlDbType.Int).Value = id_exercicio;

                cm.Connection = con;
                con.Open();

                int qtd = cm.ExecuteNonQuery();

                if (qtd > 0) return 1;
                else return 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /* Recebe id do treino e do exercicio, e exclui o vinculo na tabela/dicionario treino_exercicio 
         retorna 1 se excluir corretamente,
         retorna 0 se falhar */
        public int excluiExercicioTreino(int id_treino, int id_exercicio)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;

                cm.CommandText = "DELETE FROM treino_exercicio WHERE link_treino=" + id_treino + " AND " + "link_exercicio=" + id_exercicio;

                cm.Connection = con;
                con.Open();

                int qtd = cm.ExecuteNonQuery();

                if (qtd > 0) return 1;
                else return 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


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
                    tipo_exercicio = Convert.ToString(er["tipo_exercicio"])
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
                        tipo_exercicio = Convert.ToString(er["tipo_exercicio"])
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
                            tipo_exercicio = Convert.ToString(er["tipo_exercicio"])
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


        public IList<Exercicio> buscaExerciciosNome( String nome_exercicio)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;
                SqlDataReader er;

                cm.CommandText = "SELECT * FROM exercicios WHERE nome LIKE '%" + nome_exercicio + "%'";

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
                            tipo_exercicio = Convert.ToString(er["tipo_exercicio"])
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

        /* Busca os exercicios, de acordo com o id do treino,
         e retorna uma lista de todos exercicios neste treino */
        public IList<Exercicio> carregaExerciciosTreino(int id_treino)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;
                SqlDataReader er;

                cm.CommandText = "SELECT tbExercicios.* FROM exercicios AS tbExercicios " +
                                "INNER JOIN treino_exercicio AS LinkTreino " +
                                "ON tbExercicios.id_exercicio = LinkTreino.link_exercicio " +
                                "INNER JOIN treino AS tbTreino " +
                                "ON LinkTreino.link_treino = tbTreino.id_treino " +
                                "WHERE tbTreino.id_treino = " + id_treino;

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
                            tipo_exercicio = Convert.ToString(er["tipo_exercicio"])
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
