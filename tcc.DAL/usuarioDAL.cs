using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tcc.DTO;

namespace tcc.DAL
{
    public class UsuarioDAL
    {
        /*Recebe o objeto USUARIO,
        e insere na tabela de usuarios
        */
        public int novoUsuarioDAL(Usuario novoUser)
        {
            try
            {
                //Chama função para verificar se email ja existe no banco de dados
                if (existeUsuario(novoUser.email) == 1)
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

                    cm.CommandText = "INSERT INTO usuario (email, nome, senha, nascimento, sexo, peso, altura, objetivo)" +
                                     "VALUES (@email, @nome, @senha, @nascimento, @sexo, @peso, @altura, @objetivo)";

                    //Parametros irá substituir os valores dentro do campo
                    cm.Parameters.Add("email", System.Data.SqlDbType.VarChar).Value = novoUser.email;
                    cm.Parameters.Add("nome", System.Data.SqlDbType.VarChar).Value = novoUser.nome;
                    cm.Parameters.Add("senha", System.Data.SqlDbType.Char).Value = novoUser.senha;
                    cm.Parameters.Add("nascimento", System.Data.SqlDbType.DateTime).Value = novoUser.nascimento;
                    cm.Parameters.Add("sexo", System.Data.SqlDbType.Char).Value = novoUser.sexo;
                    cm.Parameters.Add("peso", System.Data.SqlDbType.Real).Value = novoUser.crn;
                    cm.Parameters.Add("altura", System.Data.SqlDbType.Real).Value = novoUser.altura;
                    cm.Parameters.Add("objetivo", System.Data.SqlDbType.VarChar).Value = novoUser.objetivo;

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


        /*busca usuario existente atraves do email, 
        retorna 1 se encontrar,
        retorna 0 senao encontrar
        */
        public int existeUsuario(String email)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;
                SqlDataReader er;

                cm.CommandText = "SELECT * FROM usuario WHERE email='" + email + "'";

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
        Busca usuário pelo email, e compara a senha digitada, com a senha do banco
        se for igual, retorna 1
        se for diferente, retorna 0
        */
        public int autenticaUsuario(String email, String senha)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;
                SqlDataReader er;

                cm.CommandText = "SELECT RTRIM(senha) FROM usuario WHERE email='" + email + "'";

                cm.Connection = con;
                con.Open();

                er = cm.ExecuteReader();

                er.Read();

                String senhaSalva = er.GetString(0);

                if ( senha.Equals(senhaSalva) )
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
        Busca usuário pelo email, cria um objeto USUARIO, 
        e retorna o objeto com todos os dados do perfil
        */
        public Usuario carregaUsuario(String email)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;
                SqlDataReader er;

                cm.CommandText = "SELECT * FROM usuario WHERE email='" + email + "'";

                cm.Connection = con;
                con.Open();

                er = cm.ExecuteReader();
                er.Read();

                //se encontrar correspondencia, retornar -1 para canselar cadastro
                Usuario usuario = new Usuario();

                usuario.email = Convert.ToString(er["email"]);
                usuario.nome = Convert.ToString(er["nome"]);
                usuario.senha = Convert.ToString(er["senha"]);
                usuario.nascimento = Convert.ToDateTime(er["nascimento"]);
                usuario.sexo = Convert.ToString(er["sexo"]);
                usuario.crn = Convert.ToDecimal(er["peso"]);
                usuario.altura = Convert.ToDecimal(er["altura"]);
                usuario.objetivo = Convert.ToString(er["objetivo"]);

                return usuario;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
