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
        SqlConnection con = new SqlConnection
        {
            ConnectionString = Properties.Settings.Default.CST
        };
        SqlCommand cm = new SqlCommand
        {
            CommandType = System.Data.CommandType.Text
        };
        SqlDataReader er;

        /*Recebe o objeto USUARIO,
        e insere na tabela de usuarios */
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
                    cm.CommandText = "INSERT INTO usuario (email, nome, login, senha, nascimento, sexo, peso, altura, objetivo)" +
                                     "VALUES (@email, @nome, @login, @senha, @nascimento, @sexo, @peso, @altura, @objetivo)";

                    //Parametros irá substituir os valores dentro do campo
                    cm.Parameters.Add("email", System.Data.SqlDbType.VarChar).Value = novoUser.email;
                    cm.Parameters.Add("nome", System.Data.SqlDbType.VarChar).Value = novoUser.nome;
                    cm.Parameters.Add("login", System.Data.SqlDbType.VarChar).Value = novoUser.login;
                    cm.Parameters.Add("senha", System.Data.SqlDbType.Char).Value = novoUser.senha;
                    cm.Parameters.Add("nascimento", System.Data.SqlDbType.DateTime).Value = novoUser.nascimento;
                    cm.Parameters.Add("sexo", System.Data.SqlDbType.Char).Value = novoUser.sexo;
                    cm.Parameters.Add("peso", System.Data.SqlDbType.Real).Value = novoUser.peso;
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


        /* busca usuario existente atraves do login, 
        retorna 1 se encontrar,
        retorna 0 senao encontrar */
        public int existeUsuario(String login)
        {
            try
            {                
                cm.CommandText = "SELECT * FROM usuario WHERE login='" + login + "'";

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


        /* Busca usuário pelo login, e compara a senha digitada, com a senha do banco
        se for igual, retorna 1
        se for diferente, retorna 0 */
        public int autenticaUsuario(String login, String senha)
        {
            try
            {
                cm.CommandText = "SELECT RTRIM(senha) FROM usuario WHERE login='" + login + "'";

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


        /* Busca usuário pelo id, cria um objeto USUARIO, 
        e retorna o objeto com todos os dados do perfil */
        public Usuario carregaUsuario(string login)
        {
            try
            {
                cm.CommandText = "SELECT * FROM usuario WHERE login='" + login + "'";

                cm.Connection = con;
                con.Open();

                er = cm.ExecuteReader();
                er.Read();

                //se encontrar correspondencia, retornar -1 para canselar cadastro
                Usuario usuario = new Usuario
                {
                    id_usuario = Convert.ToInt32(er["id_usuario"]),
                    email = Convert.ToString(er["email"]),
                    nome = Convert.ToString(er["nome"]),
                    login = Convert.ToString(er["login"]),
                    senha = Convert.ToString(er["senha"]),
                    nascimento = Convert.ToDateTime(er["nascimento"]),
                    sexo = Convert.ToString(er["sexo"]),
                    peso = Convert.ToDecimal(er["peso"]),
                    altura = Convert.ToDecimal(er["altura"]),
                    objetivo = Convert.ToString(er["objetivo"])
                };

                return usuario;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
                                    

        /* Recebe onjeto usuário, e atualiza as informações no banco */
        public int alteraUsuario(Usuario usuario)
        {
            try
            {
                cm.CommandText = "UPDATE usuario  SET email=@email, nome=@nome, login=@login, senha=@senha, nascimento=@nascimento, sexo=@sexo, peso=@peso, altura=@altura, objetivo=@objetivo";

                cm.Parameters.Add("email", System.Data.SqlDbType.VarChar).Value = usuario.email;
                cm.Parameters.Add("nome", System.Data.SqlDbType.VarChar).Value = usuario.nome;
                cm.Parameters.Add("login", System.Data.SqlDbType.VarChar).Value = usuario.login;
                cm.Parameters.Add("senha", System.Data.SqlDbType.Char).Value = usuario.senha;
                cm.Parameters.Add("nascimento", System.Data.SqlDbType.DateTime).Value = usuario.nascimento;
                cm.Parameters.Add("sexo", System.Data.SqlDbType.Char).Value = usuario.sexo;
                cm.Parameters.Add("peso", System.Data.SqlDbType.Real).Value = usuario.peso;
                cm.Parameters.Add("altura", System.Data.SqlDbType.Real).Value = usuario.altura;
                cm.Parameters.Add("objetivo", System.Data.SqlDbType.VarChar).Value = usuario.objetivo;

                cm.Connection = con;
                con.Open();
                int qtd = cm.ExecuteNonQuery();

                return qtd;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public int excluiUsuario(Usuario usuario)
        {
            try
            {
                cm.CommandText = "DELETE FROM usuario  WHERE id_usuario=" + usuario.id_usuario;

                cm.Connection = con;
                con.Open();
                int qtd = cm.ExecuteNonQuery();

                if(qtd > 0)
                {
                    new DietaDAL().excluiTodasDietasUsuario(usuario.id_usuario);
                }
                return qtd;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
