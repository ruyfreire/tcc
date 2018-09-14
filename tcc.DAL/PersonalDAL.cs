using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tcc.DTO;

namespace tcc.DAL
{
    public class PersonalDAL
    {
        /*Recebe o objeto Personal,
        e insere na tabela de gym_personal
        */
        public int novoPersonal(Personal novo)
        {
            try
            {
                //Chama função para verificar se email ja existe no banco de dados
                if (existePersonal(novo.email) == 1)
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

                    cm.CommandText = "INSERT INTO gym_personal (email, nome, senha, nascimento, sexo, crea, endereco, cpf_cnpj)" +
                                     "VALUES (@email, @nome, @senha, @nascimento, @sexo, @crea, @endereco, @cpf_cnpj)";

                    //Parametros irá substituir os valores dentro do campo
                    cm.Parameters.Add("email", System.Data.SqlDbType.VarChar).Value = novo.email;
                    cm.Parameters.Add("nome", System.Data.SqlDbType.VarChar).Value = novo.nome;
                    cm.Parameters.Add("senha", System.Data.SqlDbType.Char).Value = novo.senha;
                    cm.Parameters.Add("nascimento", System.Data.SqlDbType.DateTime).Value = novo.nascimento;
                    cm.Parameters.Add("sexo", System.Data.SqlDbType.Char).Value = novo.sexo;
                    cm.Parameters.Add("crea", System.Data.SqlDbType.VarChar).Value = novo.crea;
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


        /*busca personal existente atraves do email, 
        retorna 1 se encontrar,
        retorna 0 senao encontrar
        */
        public int existePersonal(String email)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;
                SqlDataReader er;

                cm.CommandText = "SELECT * FROM gym_personal WHERE email='" + email + "'";

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
        Busca personal pelo email, e compara a senha digitada, com a senha do banco
        se for igual, retorna 1
        se for diferente, retorna 0
        */
        public int autenticaPersonal(String email, String senha)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;
                SqlDataReader er;

                cm.CommandText = "SELECT RTRIM(senha) FROM gym_personal WHERE email='" + email + "'";

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
        Busca personal pelo email, cria um objeto PERSONAL, 
        e retorna o objeto com todos os dados do perfil
        */
        public Personal carregaPersonal(String email)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;
                SqlDataReader er;

                cm.CommandText = "SELECT * FROM gym_personal WHERE email='" + email + "'";

                cm.Connection = con;
                con.Open();

                er = cm.ExecuteReader();
                er.Read();

                Personal personal = new Personal
                {
                    senha = Convert.ToString(er["senha"]),
                    nome = Convert.ToString(er["nome"]),
                    email = Convert.ToString(er["email"]),
                    nascimento = Convert.ToDateTime(er["nascimento"]),
                    sexo = Convert.ToString(er["sexo"]),
                    crea = Convert.ToString(er["crea"]),
                    endereco = Convert.ToString(er["endereco"]),
                    cpf_cnpj = Convert.ToString(er["cpf_cnpj"])
                };

                return personal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
