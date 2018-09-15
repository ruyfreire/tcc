using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using tcc.DTO;

namespace tcc.DAL
{
    public class TreinoDAL
    {
        /* Verifica se ja existe uma dieta do mesmo tipo, e cancela caso já tenha,
         * inclui uma nova dieta do usuario,
         e passa o ID da dieta criada, para o metodo que atualiza o dicionario usuario_dieta 
         
        public int incluirTreinoUsuario(int id_usuario, Dieta novoTreino)
        {
            try
            {
                // Chama função para verificar se este tipo de dieta ja existe no banco de dados
                IList<Treino> treinosUsuario = carregaTreinosDeUsuario(id_usuario);
                foreach (Treino treinoSeleciona in treinosUsuario)
                {
                    if (treinoSeleciona.tipo_refeicao.Equals(novaDieta.tipo_refeicao))
                    {
                        return -1; // retorna -1 para informar cancelamento de cadastro
                    }
                }

                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;
                SqlDataReader er;


                cm.CommandText = "INSERT INTO dieta (tipo_refeicao, qtde_porcao) OUTPUT Inserted.id_dieta VALUES (@tipo_refeicao, @qtde_porcao)";

                //Parametros irá substituir os valores dentro do campo
                cm.Parameters.Add("tipo_refeicao", System.Data.SqlDbType.VarChar).Value = novaDieta.tipo_refeicao;
                cm.Parameters.Add("qtde_porcao", System.Data.SqlDbType.Int).Value = novaDieta.qtde_porcao;

                cm.Connection = con;
                con.Open();
                er = cm.ExecuteReader();

                int qtd = 0;
                if (er.HasRows)
                {
                    er.Read();
                    // Chama a função para atualizar o dicionario de usuario_dieta,
                    // enviando o id do usuario e o id da dieta recem criada
                    qtd = insereDicionarioDietaUsuario(id_usuario, Convert.ToInt32(er[0]));
                }

                con.Close();
                return qtd;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    */

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

    }
}
