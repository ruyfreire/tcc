using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using tcc.DTO;

namespace tcc.DAL
{
    public class TreinoDAL
    {
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
