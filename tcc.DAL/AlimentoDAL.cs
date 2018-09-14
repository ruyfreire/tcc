using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using tcc.DTO;

namespace tcc.DAL
{
    public class AlimentoDAL
    {
        /* Recebe id da dieta e do alimento, e vincula os dois na tabela/dicionario DIETA_ALIMENTOS 
         retorna 1 se inserir corretamente,
         retorna 0 se falhar */
        public int incluiAlimentoDieta(int id_dieta, int id_alimento)
        {
            try
            {
                if(existeLinkAlimentoDieta(id_dieta, id_alimento) == 1 )
                {
                    return -1;
                }

                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;

                cm.CommandText = "INSERT INTO dieta_alimentos (link_dieta, link_alimento) " +
                    "VALUES (@link_dieta, @link_alimento)";

                //Parametros irá substituir os valores dentro do campo
                cm.Parameters.Add("link_dieta", System.Data.SqlDbType.Int).Value = id_dieta;
                cm.Parameters.Add("link_alimento", System.Data.SqlDbType.Int).Value = id_alimento;

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

        /* Recebe id da dieta e do alimento, e exclui o vinculo na tabela/dicionario DIETA_ALIMENTOS 
         retorna 1 se excluir corretamente,
         retorna 0 se falhar */
        public int excluiAlimentoDieta(int id_dieta, int id_alimento)
        {
            try
            {
                if (existeLinkAlimentoDieta(id_dieta, id_alimento) == 0)
                {
                    return -1;
                }

                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;

                cm.CommandText = "DELETE FROM dieta_alimentos WHERE link_dieta=" + id_dieta + " AND " + "link_alimento=" + id_alimento;

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

        /* Verifica na tabela/dicionario dieta_alimento se possui o link da dieta e alimento informado,
         retorna 1 se encontrar,
         retorna 0 se não encontrar */
        public int existeLinkAlimentoDieta(int id_dieta, int id_alimento)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;
                SqlDataReader er;

                cm.CommandText = "SELECT * FROM dieta_alimentos WHERE link_dieta=" + id_dieta + " AND " + "link_alimento=" + id_alimento;

                cm.Connection = con;
                con.Open();

                er = cm.ExecuteReader();
                if(er.HasRows) return 1;
                else return 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /* Busca um alimento especifico,
         de acordo com o id que é passado ao método */
        public Alimento buscaUnicoAlimento(int id)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;
                SqlDataReader er;

                cm.CommandText = "SELECT * FROM alimentos WHERE id_alimento=" + id ;

                cm.Connection = con;
                con.Open();

                er = cm.ExecuteReader();
                er.Read();

                Alimento alimento = new Alimento
                {
                    id_alimento = Convert.ToInt32(er["id_alimento"]),
                    nome = Convert.ToString(er["nome"]),
                    grupo_nutricional = Convert.ToString(er["grupo_nutricional"]),
                    calorias = Convert.ToInt32(er["calorias"]),
                    porcao = Convert.ToInt32(er["porcao"])
                };

                return alimento;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /* Recebe lista de IDs, carrega os alimentos com estes IDs,
         e retorna uma lista com todos encontrados */
        public IList<Alimento> buscaListaDeAlimentosEspecificos(ArrayList id_Alimentos)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;
                SqlDataReader er;
                cm.Connection = con;

                IList<Alimento> lista_Alimentos = new List<Alimento>();
                foreach (int id in id_Alimentos)
                {
                    cm.CommandText = "SELECT * FROM alimentos WHERE id_alimento=" + id;

                    con.Open();

                    er = cm.ExecuteReader();
                    er.Read();

                    Alimento alimento = new Alimento
                    {
                        id_alimento = Convert.ToInt32(er["id_alimento"]),
                        nome = Convert.ToString(er["nome"]),
                        grupo_nutricional = Convert.ToString(er["grupo_nutricional"]),
                        calorias = Convert.ToInt32(er["calorias"]),
                        porcao = Convert.ToInt32(er["porcao"])
                    };

                    lista_Alimentos.Add(alimento);

                    con.Close();
                }

                return lista_Alimentos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /* Carrega todos alimentos do banco de dados,
         e coloca em uma lista, que é retornada */
        public IList<Alimento> buscaTodosAlimentos()
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;
                SqlDataReader er;

                cm.CommandText = "SELECT * FROM alimentos";

                cm.Connection = con;
                con.Open();

                er = cm.ExecuteReader();

                IList<Alimento> listaAlimentos = new List<Alimento>();
                if (er.HasRows)
                {
                    while (er.Read())
                    {
                        Alimento alimento = new Alimento
                        {
                            id_alimento = Convert.ToInt32(er["id_alimento"]),
                            nome = Convert.ToString(er["nome"]),
                            grupo_nutricional = Convert.ToString(er["grupo_nutricional"]),
                            calorias = Convert.ToInt32(er["calorias"]),
                            porcao = Convert.ToInt32(er["porcao"])
                        };

                        listaAlimentos.Add(alimento);
                    }
                }

                return listaAlimentos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /* Busca os alimentos, de acordo com o id da dieta,
         e retorna uma lista de todos alimentos nesta dieta */
        public IList<Alimento> carregaAlimentosDieta(int id_Dieta)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;
                SqlDataReader er;

                cm.CommandText = "SELECT TabelaAlimentos.* FROM alimentos AS TabelaAlimentos INNER JOIN dieta_alimentos AS LinkDieta ON TabelaAlimentos.id_alimento = LinkDieta.link_alimento INNER JOIN dieta AS TabelaDieta ON LinkDieta.link_dieta = TabelaDieta.id_dieta WHERE TabelaDieta.id_dieta =" + id_Dieta;

                cm.Connection = con;
                con.Open();

                er = cm.ExecuteReader();

                IList<Alimento> listaAlimentos = new List<Alimento>();
                if (er.HasRows)
                {
                    while (er.Read())
                    {
                        Alimento alimento = new Alimento
                        {
                            id_alimento = Convert.ToInt32(er["id_alimento"]),
                            nome = Convert.ToString(er["nome"]),
                            grupo_nutricional = Convert.ToString(er["grupo_nutricional"]),
                            calorias = Convert.ToInt32(er["calorias"]),
                            porcao = Convert.ToInt32(er["porcao"])
                        };

                        listaAlimentos.Add(alimento);
                    }
                }

                return listaAlimentos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
