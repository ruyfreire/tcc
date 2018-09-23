using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using tcc.DTO;

namespace tcc.DAL
{
    public class TreinoDAL
    {
        /* Verifica se ja existe uma treino do mesmo dia da semana, e cancela caso já tenha,
         * inclui um novo treino do usuario,
         e passa o ID do trieno criado, para o metodo que atualiza o dicionario usuario_treino
         retorna -1 se tentar repetir mesmo dia da semana */         
        public int incluirTreinoUsuario(int id_usuario, Treino novoTreino)
        {
            try
            {
                // Chama função para verificar se este tipo de treino ja existe no banco de dados
                IList<Treino> treinosUsuario = carregaTreinosDeUsuario(id_usuario);
                foreach (Treino treinoSeleciona in treinosUsuario)
                {
                    if (treinoSeleciona.diaSemana.Equals(novoTreino.diaSemana))
                    {
                        return -1; // retorna -1 para informar cancelamento de cadastro
                    }
                }

                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;
                SqlDataReader er;


                cm.CommandText = "INSERT INTO treino (dia_semana, serie, duracao) OUTPUT Inserted.id_treino VALUES (@dia_semana, @serie, @duracao)";

                //Parametros irá substituir os valores dentro do campo
                cm.Parameters.Add("dia_semana", System.Data.SqlDbType.VarChar).Value = novoTreino.diaSemana;
                cm.Parameters.Add("serie", System.Data.SqlDbType.Int).Value = novoTreino.serie;
                cm.Parameters.Add("duracao", System.Data.SqlDbType.Int).Value = novoTreino.duracao;

                cm.Connection = con;
                con.Open();
                er = cm.ExecuteReader();

                int qtd = 0;
                if (er.HasRows)
                {
                    er.Read();
                    // Chama a função para atualizar o dicionario de usuario_dieta,
                    // enviando o id do usuario e o id da dieta recem criada
                    insereDicionarioTreinoUsuario(id_usuario, Convert.ToInt32(er[0]));
                    qtd++;
                }

                con.Close();
                return qtd;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /* recebe id de usuario e treino, insere no dicionario usuario_treino,
         retorna o numero de linhas afetadas */
        public int insereDicionarioTreinoUsuario(int id_usuario, int id_treino)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;

                cm.CommandText = "INSERT INTO usuario_treino (link_usuario, link_treino)" +
                                    "VALUES (@link_usuario, @link_treino)";

                //Parametros irá substituir os valores dentro do campo
                cm.Parameters.Add("link_usuario", System.Data.SqlDbType.Int).Value = id_usuario;
                cm.Parameters.Add("link_treino", System.Data.SqlDbType.Int).Value = id_treino;

                cm.Connection = con;
                con.Open();

                int qtd = cm.ExecuteNonQuery();

                con.Close();
                return qtd;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /* remove treino informada,
         * e chama metodo para atualizar dicionario usuario_treino,
         retorna 1 se deletar corretamente,
         retorna -1 se deletar treino, mas der erro ao deletar dicionario
         retorna 0 se já der erro ao deletar treino */
        public int excluiTreinoUnicoUsuario(int id_usuario, int id_treino)
        {
            try
            {
                /* Carrega os exercicios do treino, para excluir no dicionario treino_exercicio */
                IList<Exercicio> exerciciosTreino = new ExerciciosDAL().carregaExerciciosTreino(id_treino);

                
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;

                cm.CommandText = "DELETE FROM treino WHERE id_treino=" + id_treino;

                cm.Connection = con;
                con.Open();


                int treinoExcluido = 0;
                treinoExcluido = cm.ExecuteNonQuery();
                if (treinoExcluido > 0)
                {
                    /* Chama a função para atualizar o dicionario de usuario_treino,
                     enviando o id do usuario e o id do treino */
                    removeDicionarioTreinoUsuario(id_usuario, id_treino);

                    /* Exclui no dicionario treino_exercicio */
                    foreach (Exercicio exercicio in exerciciosTreino)
                    {
                        new ExerciciosDAL().excluiExercicioTreino(id_treino, exercicio.id_exercicio);
                    }
                }

                con.Close();
                return treinoExcluido;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /* Busca todos treinos do usuario, usando o metodo buscaTreinoDeUsuario,
         depois exclui uma a uma, e exclui o dicionario com o metodo removeDicionarioTreinoUsuario */
        public int excluiTodosTreinoUsuario(int id_usuario)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;

                IList<Treino> treinos = carregaTreinosDeUsuario(id_usuario);
                int totalTreino = 0;
                int qtd;
                foreach (Treino treino in treinos)
                {

                    /* Carrega os exercicios do treino, para excluir no dicionario treino_exercicio */
                    IList<Exercicio> exerciciosTreino = new ExerciciosDAL().carregaExerciciosTreino(treino.id_treino);

                    cm.CommandText = "DELETE FROM treino WHERE id_treino=" + treino.id_treino;

                    cm.Connection = con;
                    con.Open();

                    qtd = 0;
                    qtd = cm.ExecuteNonQuery();
                    if (qtd > 0)
                    {
                        /* Chama a função para atualizar o dicionario de usuario_treino,
                         enviando o id do usuario e o id do trieno */
                        removeDicionarioTreinoUsuario(id_usuario, treino.id_treino);

                        /* Carrega os exercicios do treino, para excluir no dicionario treino_exercicio */
                        foreach (Exercicio exercicio in exerciciosTreino)
                        {
                            new ExerciciosDAL().excluiExercicioTreino(treino.id_treino, exercicio.id_exercicio);
                        }

                        totalTreino++; // soma ao total de dietas excluidas
                    }
                    con.Close();
                }
                return totalTreino;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /* recebe id de usuario e treino, remove no dicionario usuario_treino,
         retorna o numero de linhas afetadas */
        public int removeDicionarioTreinoUsuario(int id_usuario, int id_treino)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;

                cm.CommandText = "DELETE FROM usuario_treino WHERE link_usuario=" + id_usuario +
                                " AND " + "link_treino=" + id_treino;

                cm.Connection = con;
                con.Open();

                int qtd = cm.ExecuteNonQuery();

                con.Close();
                return qtd;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /* Carrega todos treinos do banco de dados,
         e coloca em uma lista, que é retornada */
        public IList<Treino> carregaTodosTreinos()
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;
                SqlDataReader er;

                cm.CommandText = "SELECT * FROM treino";

                cm.Connection = con;
                con.Open();

                er = cm.ExecuteReader();

                IList<Treino> listaTreinos = new List<Treino>();
                while (er.HasRows)
                {
                    if (er.Read())
                    {
                        Treino treino = new Treino
                        {
                            id_treino = Convert.ToInt32(er["id_treino"]),
                            serie = Convert.ToInt32(er["serie"]),
                            duracao = Convert.ToInt32(er["duracao"])
                        };

                        listaTreinos.Add(treino);
                    }
                }

                return listaTreinos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /* Busca um treino especifico,
         de acordo com o id que é passado ao método */
        public Treino carregaTreinoEspecifico(int id)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;
                SqlDataReader er;

                cm.CommandText = "SELECT * FROM treino WHERE id_treino=" + id;

                cm.Connection = con;
                con.Open();

                er = cm.ExecuteReader();
                er.Read();

                Treino treino = new Treino
                {
                    id_treino = Convert.ToInt32(er["id_treino"]),
                    serie = Convert.ToInt32(er["serie"]),
                    duracao = Convert.ToInt32(er["duracao"])
                };

                return treino;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /* Recebe lista de IDs, carrega os treinos com estes IDs,
         e retorna uma lista com todos encontrados */
        public IList<Treino> carregaListaTreinosEspecificos(ArrayList id_Treinos)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;
                SqlDataReader er;
                cm.Connection = con;

                IList<Treino> lista_Treinos = new List<Treino>();
                foreach (int id in id_Treinos)
                {
                    cm.CommandText = "SELECT * FROM treino WHERE id_treino=" + id;

                    con.Open();

                    er = cm.ExecuteReader();
                    er.Read();

                    Treino treino = new Treino
                    {
                        id_treino = Convert.ToInt32(er["id_treino"]),
                        serie = Convert.ToInt32(er["serie"]),
                        duracao = Convert.ToInt32(er["duracao"])
                    };

                    lista_Treinos.Add(treino);

                    con.Close();
                }

                return lista_Treinos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /* Busca todas dietas, com base o id do usuario informado
         e retorna uma lista com todas dietas do usuario */
        public IList<Treino> carregaTreinosDeUsuario(int id_usuario)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;
                SqlDataReader er;

                cm.CommandText = "SELECT TabelaTreino.* FROM treino AS TabelaTreino INNER JOIN usuario_treino AS LinkTreino ON LinkTreino.link_treino = TabelaTreino.id_treino INNER JOIN usuario AS TabelaUsuario ON LinkTreino.link_usuario = TabelaUsuario.id_usuario WHERE TabelaUsuario.id_usuario=" + id_usuario;

                cm.Connection = con;
                con.Open();

                er = cm.ExecuteReader();

                IList<Treino> listaTreinos = new List<Treino>();
                if (er.HasRows)
                {
                    while (er.Read())
                    {
                        Treino treino = new Treino
                        {
                            id_treino = Convert.ToInt32(er["id_treino"]),
                            diaSemana = Convert.ToString(er["dia_semana"]),
                            serie = Convert.ToInt32(er["serie"]),
                            duracao = Convert.ToInt32(er["duracao"])
                        };

                        listaTreinos.Add(treino);
                    }
                }

                con.Close();
                return listaTreinos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /* Recebe um objeto TREINO junto com ID_treino, e altera a informações no banco
         retorna -1 se tentar repetir mesmo dia da semana */
        public int alteraTreinoDeUsuario(Treino treino, int id_usuario)
        {
            try
            {
                // Chama função para verificar se este tipo de treino ja existe no banco de dados
                IList<Treino> treinosUsuario = carregaTreinosDeUsuario(id_usuario);
                foreach (Treino treinoSeleciona in treinosUsuario)
                {
                    if (treinoSeleciona.id_treino == treino.id_treino)
                    {
                        if (treinoSeleciona.diaSemana.Equals(treino.diaSemana) && treinoSeleciona.serie.Equals(treino.serie) && treinoSeleciona.duracao.Equals(treino.duracao) )
                        {
                            return -2; // retorna -2 se dados forem iguais
                        }
                    }

                    if (treinoSeleciona.id_treino != treino.id_treino)
                    {
                        if (treinoSeleciona.diaSemana.Equals(treino.diaSemana))
                        {
                            return -1; // retorna -1 para informar cancelamento de cadastro
                        }
                    }
                }

                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;

                cm.CommandText = "UPDATE treino  SET dia_semana=@dia_semana, serie=@serie, duracao=@duracao " +
                                    "WHERE id_treino=" + treino.id_treino;

                //Parametros irá substituir os valores dentro do campo
                cm.Parameters.Add("dia_semana", System.Data.SqlDbType.VarChar).Value = treino.diaSemana;
                cm.Parameters.Add("serie", System.Data.SqlDbType.Int).Value = treino.serie;
                cm.Parameters.Add("duracao", System.Data.SqlDbType.Int).Value = treino.duracao;

                cm.Connection = con;
                con.Open();

                int qtd = cm.ExecuteNonQuery();

                con.Close();
                return qtd;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
