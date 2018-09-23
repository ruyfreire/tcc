using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using tcc.DTO;

namespace tcc.DAL
{
    public class DietaDAL
    {
        /* Verifica se ja existe uma dieta do mesmo tipo no mesmo dia, e cancela caso já tenha,
         * inclui uma nova dieta do usuario,
         e passa o ID da dieta criada, para o metodo que atualiza o dicionario usuario_dieta
         retorna -1 se tentar repetir tipo da refeicao no mesmo dia da semana */
        public int incluirDietaUsuario(int id_usuario, Dieta novaDieta)
        {
            try
            {
                /* Chama função para verificar se este tipo de dieta ja existe no banco de dados */
                IList<Dieta> dietasUsuario = carregaDietasDeUsuario(id_usuario);
                foreach(Dieta dietaSeleciona in dietasUsuario)
                {
                    if (dietaSeleciona.dia_semana.Equals(novaDieta.dia_semana) && dietaSeleciona.tipo_refeicao.Equals(novaDieta.tipo_refeicao) )
                    {
                        return -1; // retorna -1 para informar cancelamento de cadastro
                    }
                }

                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;
                SqlDataReader er;


                cm.CommandText = "INSERT INTO dieta (dia_semana, tipo_refeicao) OUTPUT Inserted.id_dieta VALUES (@dia_semana, @tipo_refeicao)";

                //Parametros irá substituir os valores dentro do campo
                cm.Parameters.Add("dia_semana", System.Data.SqlDbType.VarChar).Value = novaDieta.dia_semana;
                cm.Parameters.Add("tipo_refeicao", System.Data.SqlDbType.VarChar).Value = novaDieta.tipo_refeicao;
   
                cm.Connection = con;
                con.Open();
                er = cm.ExecuteReader();

                int qtd = 0;
                if (er.HasRows)
                {
                    er.Read();
                    /* Chama a função para atualizar o dicionario de usuario_dieta,
                     enviando o id do usuario e o id da dieta recem criada */
                    insereDicionarioDietaUsuario(id_usuario, Convert.ToInt32(er[0]));
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

        /* recebe id de usuario e dieta, insere no dicionario usuario_dieta,
         retorna o numero de linhas afetadas */
        public int insereDicionarioDietaUsuario(int id_usuario, int id_dieta)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;

                cm.CommandText = "INSERT INTO usuario_dieta (link_usuario, link_dieta)" +
                                    "VALUES (@link_usuario, @link_dieta)";

                //Parametros irá substituir os valores dentro do campo
                cm.Parameters.Add("link_usuario", System.Data.SqlDbType.Int).Value = id_usuario;
                cm.Parameters.Add("link_dieta", System.Data.SqlDbType.Int).Value = id_dieta;

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


        /* remove dieta informada,
         * e chama metodo para atualizar dicionario usuario_dieta,
         retorna 1 se deletar corretamente,
         retorna -1 se deletar dieta, mas der erro ao deletar dicionario
         retorna 0 se já der erro ao deletar dieta */
        public int excluiDietaUnicaUsuario(int id_usuario, int id_dieta)
        {
            try
            {
                /* Carrega os alimentos da dieta, para excluir no dicionario dieta_alimentos */
                IList<Alimento> alimentosDieta = new AlimentoDAL().carregaAlimentosDieta(id_dieta);


                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;

                cm.CommandText = "DELETE FROM dieta WHERE id_dieta=" + id_dieta;

                cm.Connection = con;
                con.Open();

                int dietaExcluida = 0;
                dietaExcluida = cm.ExecuteNonQuery();
                if (dietaExcluida > 0)
                {
                    /* Chama a função para atualizar o dicionario de usuario_dieta,
                     enviando o id do usuario e o id da dieta */
                    removeDicionarioDietaUsuario(id_usuario, id_dieta);

                    /* Exclui no dicionario dieta_alimentos */
                    foreach (Alimento alimento in alimentosDieta)
                    {
                        new AlimentoDAL().excluiAlimentoDieta(id_dieta, alimento.id_alimento);
                    }
                }

                con.Close();

                return dietaExcluida;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /* Busca todas dietas do usuario, usando o metodo buscaDietasDeUsuario,
         depois exclui uma a uma, e exclui o dicionario com o metodo removeDicionarioDietaUsuario */
        public int excluiTodasDietasUsuario(int id_usuario)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;

                IList<Dieta> dietas = carregaDietasDeUsuario(id_usuario);
                int totalDieta = 0;
                int qtd;
                foreach (Dieta dieta in dietas)
                {
                    /* Carrega os alimentos da dieta, para excluir no dicionario dieta_alimentos */
                    IList<Alimento> alimentosDieta = new AlimentoDAL().carregaAlimentosDieta(dieta.id_dieta);

                    cm.CommandText = "DELETE FROM dieta WHERE id_dieta=" + dieta.id_dieta;

                    cm.Connection = con;
                    con.Open();

                    qtd = 0;
                    qtd = cm.ExecuteNonQuery();
                    if (qtd > 0)
                    {
                        /* Chama a função para atualizar o dicionario de usuario_dieta,
                         enviando o id do usuario e o id da dieta */
                        removeDicionarioDietaUsuario(id_usuario, dieta.id_dieta);

                        /* Carrega os alimentos da dieta, para excluir no dicionario dieta_alimentos */                        
                        foreach (Alimento alimento in alimentosDieta)
                        {
                            new AlimentoDAL().excluiAlimentoDieta(dieta.id_dieta, alimento.id_alimento);
                        }

                        totalDieta++; // soma ao total de dietas excluidas
                    }
                    con.Close();
                }
                return totalDieta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /* recebe id de usuario e dieta, remove no dicionario usuario_dieta,
         retorna o numero de linhas afetadas */
        public int removeDicionarioDietaUsuario(int id_usuario, int id_dieta)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;

                cm.CommandText = "DELETE FROM usuario_dieta WHERE link_usuario=" + id_usuario +
                                " AND " + "link_dieta=" + id_dieta;

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


        /* Busca todas dietas, com base o id do usuario informado
         e retorna uma lista com todas dietas do usuario */
        public IList<Dieta> carregaDietasDeUsuario(int id_usuario)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;
                SqlDataReader er;

                cm.CommandText = "SELECT TabelaDieta.* FROM dieta AS TabelaDieta INNER JOIN usuario_dieta AS LinkUsuario ON LinkUsuario.link_dieta = TabelaDieta.id_dieta INNER JOIN usuario AS TabelaUsuario ON LinkUsuario.link_usuario = TabelaUsuario.id_usuario WHERE TabelaUsuario.id_usuario=" + id_usuario + "ORDER BY dia_semana";

                cm.Connection = con;
                con.Open();

                er = cm.ExecuteReader();

                IList<Dieta> listaDietas = new List<Dieta>();
                if (er.HasRows)
                {
                    while (er.Read())
                    {
                        Dieta dieta = new Dieta
                        {
                            id_dieta = Convert.ToInt32(er["id_dieta"]),
                            dia_semana = Convert.ToString(er["dia_semana"]),                            
                            tipo_refeicao = Convert.ToString(er["tipo_refeicao"])
                        };

                        listaDietas.Add(dieta);
                    }
                }

                con.Close();
                return listaDietas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /* Recebe um objeto DIETA junto com ID_dieta, e altera a informações no banco 
         retorna -1 se tentar repetir tipo da refeicao no mesmo dia da semana,
         retorna -2 se não alterar nada */
        public int alteraDietasDeUsuario(Dieta dieta, int id_usuario)
        {
            try
            {
                /* Chama função para verificar se este tipo de dieta ja existe no banco de dados */
                IList<Dieta> dietasUsuario = carregaDietasDeUsuario(id_usuario);
                foreach (Dieta dietaSeleciona in dietasUsuario)
                {
                    if (dietaSeleciona.id_dieta == dieta.id_dieta)
                    {
                        if (dietaSeleciona.dia_semana.Equals(dieta.dia_semana) && dietaSeleciona.tipo_refeicao.Equals(dieta.tipo_refeicao))
                        {
                            return -2; // retorna -2 se dados forem iguais
                        }
                    }

                    if (dietaSeleciona.id_dieta != dieta.id_dieta)
                    {
                        if ( dietaSeleciona.dia_semana.Equals(dieta.dia_semana) && dietaSeleciona.tipo_refeicao.Equals(dieta.tipo_refeicao) )
                        {
                            return -1; // retorna -1 se repetir informações
                        }
                    }
                }

                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;

                cm.CommandText = "UPDATE dieta SET dia_semana=@dia_semana, tipo_refeicao=@tipo_refeicao " +
                                    "WHERE id_dieta=" + dieta.id_dieta;

                //Parametros irá substituir os valores dentro do campo dia_semana
                cm.Parameters.Add("dia_semana", System.Data.SqlDbType.VarChar).Value = dieta.dia_semana;
                cm.Parameters.Add("tipo_refeicao", System.Data.SqlDbType.VarChar).Value = dieta.tipo_refeicao;

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
