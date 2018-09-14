using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tcc.DTO;

namespace tcc.DAL
{
    public class NutricionistaDAL
    {
        /*Recebe o objeto Nutricionista,
        e insere na tabela de usuarios
        */
        public int novoNutricionista(Nutricionista novo)
        {
            try
            {
                //Chama função para verificar se email ja existe no banco de dados
                if (existeNutricionista(novo.email) == 1)
                {
                    return -1; // retorna -1 para informar cancelamento de cadastro
                }
                else
                {
                    //Conexão com BD e insere os dados do usuario
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = Properties.Settings.Default.CST;
                    SqlCommand cm = new SqlCommand();
                    cm.CommandType = System.Data.CommandType.Text;

                    cm.CommandText = "INSERT INTO nutricionista (email, nome, senha, nascimento, sexo, crn, endereco, cpf_cnpj)" +
                                     "VALUES (@email, @nome, @senha, @nascimento, @sexo, @crn, @endereco, @cpf_cnpj)";

                    //Parametros irá substituir os valores dentro do campo
                    cm.Parameters.Add("email", System.Data.SqlDbType.VarChar).Value = novo.email;
                    cm.Parameters.Add("nome", System.Data.SqlDbType.VarChar).Value = novo.nome;
                    cm.Parameters.Add("senha", System.Data.SqlDbType.Char).Value = novo.senha;
                    cm.Parameters.Add("nascimento", System.Data.SqlDbType.DateTime).Value = novo.nascimento;
                    cm.Parameters.Add("sexo", System.Data.SqlDbType.Char).Value = novo.sexo;
                    cm.Parameters.Add("crn", System.Data.SqlDbType.VarChar).Value = novo.crn;
                    cm.Parameters.Add("endereco", System.Data.SqlDbType.VarChar).Value = novo.endereco;
                    cm.Parameters.Add("cpf_cnpj", System.Data.SqlDbType.VarChar).Value = novo.cpf_cnpj;

                    cm.Connection = con;
                    con.Open();
                    int qtd = cm.ExecuteNonQuery();

                    return qtd;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /*busca nutricionista existente atraves do email, 
        retorna 1 se encontrar,
        retorna 0 senao encontrar
        */
        public int existeNutricionista(String email)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;
                SqlDataReader er;

                cm.CommandText = "SELECT * FROM nutricionista WHERE email='" + email + "'";

                cm.Connection = con;
                con.Open();

                er = cm.ExecuteReader();

                //se encontrar correspondencia, retornar 1
                if (er.HasRows)
                {
                    return 1;
                }
                else
                {
                    //senao, retorna zero
                    return 0;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /*
        Busca nutricionista pelo email, e compara a senha digitada, com a senha do banco
        se for igual, retorna 1
        se for diferente, retorna 0
        */
        public int autenticaNutricionista(String email, String senha)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;
                SqlDataReader er;

                cm.CommandText = "SELECT RTRIM(senha) FROM nutricionista WHERE email='" + email + "'";

                cm.Connection = con;
                con.Open();

                er = cm.ExecuteReader();

                er.Read();

                String senhaSalva = er.GetString(0);

                if (senha.Equals(senhaSalva))
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /*
        Busca nutricionista pelo email, cria um objeto NUTRICIONISTA, 
        e retorna o objeto com todos os dados do perfil
        */
        public Nutricionista carregaNutricionista(String email)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;
                SqlDataReader er;

                cm.CommandText = "SELECT * FROM nutricionista WHERE email='" + email + "'";

                cm.Connection = con;
                con.Open();

                er = cm.ExecuteReader();
                er.Read();

                Nutricionista nutricionista = new Nutricionista
                {
                    email = Convert.ToString(er["email"]),
                    nome = Convert.ToString(er["nome"]),
                    senha = Convert.ToString(er["senha"]),
                    nascimento = Convert.ToDateTime(er["nascimento"]),
                    sexo = Convert.ToString(er["sexo"]),
                    crn = Convert.ToString(er["crn"]),
                    endereco = Convert.ToString(er["endereco"]),
                    cpf_cnpj = Convert.ToString(er["cpf_cnpj"])
                };

                return nutricionista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
