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
                    //Conexão com BD
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = Properties.Settings.Default.CST;
                    SqlCommand cm = new SqlCommand();
                    cm.CommandType = System.Data.CommandType.Text;

                    cm.CommandText = "INSERT INTO usuario (email, nome, senha, nascimento, sexo, peso, altura, objetivo)" +
                                     "VALUES (@email, @nome, @senha, @nascimento, @sexo, @peso, @altura, @objetivo)";

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
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;
                SqlDataReader er;

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
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;
                SqlDataReader er;

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
        public Usuario carregaUsuario(String login)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;
                SqlDataReader er;

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
                if (er["id_gym_personal"].ToString().Equals("")) usuario.id_gym_personal = 0;
                else usuario.id_gym_personal = Convert.ToInt32(er["id_gym_personal"]);

                if (er["id_nutricionista"].ToString().Equals("")) usuario.id_nutricionista = 0;
                else usuario.id_nutricionista = Convert.ToInt32(er["id_nutricionista"]);

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
                //Conexão com BD
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;

                cm.CommandText = "UPDATE usuario  SET email=@email, nome=@nome, login=@login, senha=@senha, nascimento=@nascimento, sexo=@sexo, peso=@peso, altura=@altura, objetivo=@objetivo WHERE id_usuario=" + usuario.id_usuario;

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


        public int excluiUsuario(int id_usuario)
        {
            try
            {
                //excluiUsuario dietas e treinos do usuario
                new DietaDAL().excluiTodasDietasUsuario(id_usuario);
                new TreinoDAL().excluiTodosTreinoUsuario(id_usuario);

                //Conexão com BD
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;

                cm.CommandText = "DELETE FROM usuario  WHERE id_usuario=" + id_usuario;

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


        public int atualizaPersonal(Usuario user, int id_gym_personal)
        {
            try
            {
                Usuario usuario = carregaUsuario(user.login);
                if (usuario.id_gym_personal != 0 && id_gym_personal != 0)
                    return -1;


                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;

                cm.CommandText = "UPDATE usuario SET id_gym_personal=@id_gym_personal WHERE id_usuario=" + usuario.id_usuario;

                //Parametros irá substituir os valores dentro do campo
                if (id_gym_personal == 0)
                {
                    cm.Parameters.Add("id_gym_personal", System.Data.SqlDbType.Int).Value = DBNull.Value;
                    removeDicionarioGymPersonalUsuario(usuario.id_usuario, id_gym_personal);
                }
                else
                {
                    cm.Parameters.Add("id_gym_personal", System.Data.SqlDbType.Int).Value = id_gym_personal;
                    insereDicionarioGymPersonalUsuario(usuario.id_usuario, id_gym_personal);
                }

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

        public int insereDicionarioGymPersonalUsuario(int id_usuario, int id_gym_personal)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;

                cm.CommandText = "INSERT INTO gym_personal_usuario (link_personal, link_usuario)" +
                                    "VALUES (@link_personal, @link_usuario)";

                //Parametros irá substituir os valores dentro do campo
                cm.Parameters.Add("link_personal", System.Data.SqlDbType.Int).Value = id_gym_personal;
                cm.Parameters.Add("link_usuario", System.Data.SqlDbType.Int).Value = id_usuario;
                
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

        public int removeDicionarioGymPersonalUsuario(int id_usuario, int id_gym_personal)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;

                cm.CommandText = "DELETE FROM gym_personal_usuario WHERE link_personal=" + id_gym_personal + " AND " + "link_usuario=" + id_usuario;

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



        public int atualizaNutricionista(int id_usuario, int id_nutricionista)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;

                cm.CommandText = "UPDATE usuario SET id_nutricionista=@id_nutricionista WHERE id_usuario=" + id_usuario;

                //Parametros irá substituir os valores dentro do campo
                if (id_nutricionista == 0)
                {
                    cm.Parameters.Add("id_gym_personal", System.Data.SqlDbType.Int).Value = DBNull.Value;
                    removeDicionarioNutricionistaUsuario(id_usuario, id_nutricionista);
                }
                else
                {
                    cm.Parameters.Add("id_gym_personal", System.Data.SqlDbType.Int).Value = id_nutricionista;
                    insereDicionarioNutricionistaUsuario(id_usuario, id_nutricionista);
                }

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

        public int insereDicionarioNutricionistaUsuario(int id_usuario, int id_nutricionista)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;

                cm.CommandText = "INSERT INTO nutricionista_usuario (link_nutricionista, link_usuario)" +
                                    "VALUES (@link_nutricionista, @link_usuario)";

                //Parametros irá substituir os valores dentro do campo
                cm.Parameters.Add("link_nutricionista", System.Data.SqlDbType.Int).Value = id_nutricionista;
                cm.Parameters.Add("link_usuario", System.Data.SqlDbType.Int).Value = id_usuario;

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

        public int removeDicionarioNutricionistaUsuario(int id_usuario, int id_nutricionista)
        {
            try
            {
                //Conexão com BD e insere os dados do usuario
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;

                cm.CommandText = "DELETE FROM nutricionista_usuario WHERE link_nutricionista=" + id_nutricionista + " AND " + "link_usuario=" + id_usuario;

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
    }
}
