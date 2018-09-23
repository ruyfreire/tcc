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
        retorna 1 se login ja existir,
        retorna 2 se email ja existir,
        retorna 3 se cadastrar com sucesso 
        retorna 0 se der erro */
        public int novoUsuarioDAL(Usuario novoUser)
        {
            try
            {
                //Chama função para verificar se email e login ja existe no banco de dados
                switch( Convert.ToString( existeUsuario(novoUser.email, novoUser.login) ) )
                {
                    case "1":
                        return 1; // login ja existente
                    case "2":
                        return 2; // e-mail ja existente
                }

                //Conexão com BD
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;

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

                if (qtd > 0) return 3;
                else return 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /* busca usuario existente atraves do login e email, 
        retorna 1 se encontrar login igual,
        chama existe email e retorna 2 se encontrar email igual.
        retorna 0 se não encontrar nada 
        
        para confirmar um usuario, enviar 'confereLogin' no campo email,
        apenas para confirmar existencia de login */
        public int existeUsuario(String email, String login)
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
                    con.Close();
                    return 1;
                }
                else
                {
                    /* se for uma verificação de usuario ja existente,
                     * recebe confereLogin no lugar do email para verifcar apenas o login */
                    if (email.Equals("confereLogin")) return 0;

                    return existeEmail(email);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int existeEmail(String email)
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

                if (er.HasRows)
                {
                    con.Close();
                    return 2;
                }
                else
                {
                    con.Close();
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

                return usuario;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        

        /* Recebe onjeto usuário, e atualiza as informações no banco */
        public int alteraUsuario(Usuario usuario, Usuario usuarioAntigo)
        {
            try
            {
                if (!usuario.login.Equals(usuarioAntigo.login) || !usuario.email.Equals(usuarioAntigo.email) )
                {
                    //Chama função para verificar se email e login ja existe no banco de dados
                    switch (Convert.ToString(existeUsuario(usuario.email, usuario.login)))
                    {
                        case "1":
                            return 1; // login ja existente
                        case "2":
                            return 2; // e-mail ja existente
                    }
                }

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
                if (qtd > 0) return 3;
                else return 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public Usuario recuperaSenha(Usuario usuario)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;
                SqlDataReader er;

                cm.CommandText = "SELECT * FROM usuario WHERE login = '" + usuario.login + "' AND email = '" + usuario.email + "' AND nascimento ='" + usuario.nascimento.ToShortDateString() + "'";

                cm.Connection = con;
                con.Open();

                er = cm.ExecuteReader();

                if (er.HasRows)
                {
                    Usuario user = carregaUsuario(usuario.login);
                    return user;
                }
                else
                {
                    Usuario user = new Usuario { id_usuario = 0 };
                    return user;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /* Recebe objeto usuario, verifica se possue id_personal, se for vazio, retorna objeto Personal com id 0
          se tiver id, busca personal, e retorna dados em objeto personal */
        public Personal carregaPersonal(int id_usuario)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;
                SqlDataReader er;

                cm.CommandText = "SELECT tbPersonal.* FROM gym_personal AS tbPersonal " +
                                "INNER JOIN gym_personal_usuario AS linkPersonal " +
                                "ON tbPersonal.id_personal = linkPersonal.link_personal " +
                                "INNER JOIN usuario AS tbUsuario " +
                                "ON linkPersonal.link_usuario = tbUsuario.id_usuario " +
                                "WHERE tbUsuario.id_usuario = " + id_usuario;

                cm.Connection = con;
                con.Open();

                er = cm.ExecuteReader();

                if (er.HasRows)
                {
                    er.Read();
                    Personal personal = new Personal
                    {
                        id_personal = Convert.ToInt32(er["id_personal"]),
                        email = Convert.ToString(er["email"]),
                        nome = Convert.ToString(er["nome"]),
                        nascimento = Convert.ToDateTime(er["nascimento"]),
                        sexo = Convert.ToString(er["sexo"]),
                        crea = Convert.ToString(er["crea"]),
                        endereco = Convert.ToString(er["endereco"]),
                        cpf_cnpj = Convert.ToString(er["cpf_cnpj"])
                    };
                    return personal;
                }
                else
                {
                    return new Personal { id_personal = 0 };
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /* Recebe objeto usuario, verifica se possue id_nutricionista, se for vazio, retorna objeto nutricionista com id 0
          se tiver id, busca nutricionista, e retorna dados em objeto nutricionista */
        public Nutricionista carregaNutricionista(int id_usuario)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;
                SqlDataReader er;

                cm.CommandText = "SELECT tbNutricionista.* FROM nutricionista AS tbNutricionista " +
                                "INNER JOIN nutricionista_usuario AS linkNutricionista " +
                                "ON tbNutricionista.id_nutricionista = linkNutricionista.link_nutricionista " +
                                "INNER JOIN usuario AS tbUsuario " +
                                "ON linkNutricionista.link_usuario = tbUsuario.id_usuario " +
                                "WHERE tbUsuario.id_usuario = " + id_usuario;

                cm.Connection = con;
                con.Open();

                er = cm.ExecuteReader();

                if (er.HasRows)
                {
                    er.Read();
                    Nutricionista nutricionista = new Nutricionista
                    {
                        id_nutricionista = Convert.ToInt32(er["id_nutricionista"]),
                        email = Convert.ToString(er["email"]),
                        nome = Convert.ToString(er["nome"]),
                        nascimento = Convert.ToDateTime(er["nascimento"]),
                        sexo = Convert.ToString(er["sexo"]),
                        crn = Convert.ToString(er["crn"]),
                        endereco = Convert.ToString(er["endereco"]),
                        cpf_cnpj = Convert.ToString(er["cpf_cnpj"])
                    };
                    return nutricionista;
                }
                else
                {
                    return new Nutricionista { id_nutricionista = 0 };
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        

        /* Carrega usuario, e verifica se tem id personal e compara o id informado
         retorna -1 caso ja tenha personal e tentarem adicionar mais um
         retorna -2 caso nao tenha personal, e tentarem excluir
         retorna > 0 se conseguir vincular usuario e personal */
        public int verificaPersonal(int id_usuario)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;
                SqlDataReader er;

                cm.CommandText = "SELECT * FROM gym_personal_usuario WHERE link_usuario = " + id_usuario;

                cm.Connection = con;
                con.Open();
                er = cm.ExecuteReader();

                if (er.HasRows)
                {
                    return 1;
                }
                return 0;
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
                if (verificaPersonal(id_usuario) > 0)
                {
                    return -1;
                }

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

        public int removeDicionarioGymPersonalUsuario(int id_usuario)
        {
            try
            {
                if (verificaPersonal(id_usuario) == 0)
                {
                    return -1;
                }

                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;

                cm.CommandText = "DELETE FROM gym_personal_usuario WHERE link_usuario=" + id_usuario;

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


        /* Carrega usuario, e verifica se tem id nutricionista e compara o id informado
         retorna -1 caso ja tenha nutricionista e tentarem adicionar mais um
         retorna -2 caso nao tenha nutricionista, e tentarem excluir
         retorna > 0 se conseguir vincular usuario e nutricionista */
        public int verificaNutricionista(int id_usuario)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;
                SqlDataReader er;

                cm.CommandText = "SELECT * FROM nutricionista_usuario WHERE link_usuario = " + id_usuario;

                cm.Connection = con;
                con.Open();
                er = cm.ExecuteReader();

                if (er.HasRows)
                {
                    return 1;
                }
                return 0;
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
                if(verificaNutricionista(id_usuario) > 0)
                {
                    return -1;
                }

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

        public int removeDicionarioNutricionistaUsuario(int id_usuario)
        {
            try
            {
                if (verificaNutricionista(id_usuario) == 0)
                {
                    return -1;
                }

                //Conexão com BD e insere os dados do usuario
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;

                cm.CommandText = "DELETE FROM nutricionista_usuario WHERE link_usuario=" + id_usuario;

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


        /* Exclui usuario e remove todas informaçoes ligadas a ele, como treinos, dietas, personal e nutricionista */
        public int excluiUsuario(Usuario usuario)
        {
            try
            {
                //excluiUsuario dietas e treinos do usuario
                new DietaDAL().excluiTodasDietasUsuario(usuario.id_usuario);
                new TreinoDAL().excluiTodosTreinoUsuario(usuario.id_usuario);
                //remove o link de personal e nutricionista
                removeDicionarioNutricionistaUsuario(usuario.id_usuario);
                removeDicionarioGymPersonalUsuario(usuario.id_usuario);

                //Conexão com BD
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;

                cm.CommandText = "DELETE FROM usuario  WHERE id_usuario=" + usuario.id_usuario;

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


        public IList<Usuario> buscaUsuariosNome(String nome_usuario)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;
                SqlDataReader er;

                cm.CommandText = "SELECT id_usuario, nome, email, sexo, objetivo FROM usuario WHERE nome LIKE '%" + nome_usuario + "%'";

                cm.Connection = con;
                con.Open();

                er = cm.ExecuteReader();

                IList<Usuario> listausuarios = new List<Usuario>();
                if (er.HasRows)
                {
                    while (er.Read())
                    {
                        Usuario usuario = new Usuario
                        {
                            id_usuario = Convert.ToInt32(er["id_usuario"]),
                            nome = Convert.ToString(er["nome"]),
                            email = Convert.ToString(er["email"]),
                            sexo = Convert.ToString(er["sexo"]),
                            objetivo = Convert.ToString(er["objetivo"])
                        };

                        listausuarios.Add(usuario);
                    }
                }

                return listausuarios;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
    }
}
