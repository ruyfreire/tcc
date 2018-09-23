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
        e insere na tabela de nutricionista
        retorna 1 se login ja existir,
        retorna 2 se email ja existir,
        retorna 3 se cadastrar com sucesso 
        retorna 0 se der erro */
        public int novoNutricionista(Nutricionista novo)
        {
            try
            {
                //Chama função para verificar se email e login ja existe no banco de dados
                switch (Convert.ToString(existeNutricionista(novo.email, novo.login)))
                {
                    case "1":
                        return 1; // login ja existente
                    case "2":
                        return 2; // e-mail ja existente
                }

                //Conexão com BD e insere os dados do usuario
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;

                cm.CommandText = "INSERT INTO nutricionista (email, nome, login, senha, nascimento, sexo, crn, endereco, cpf_cnpj)" +
                                    "VALUES (@email, @nome, @login, @senha, @nascimento, @sexo, @crn, @endereco, @cpf_cnpj)";

                //Parametros irá substituir os valores dentro do campo
                cm.Parameters.Add("email", System.Data.SqlDbType.VarChar).Value = novo.email;
                cm.Parameters.Add("nome", System.Data.SqlDbType.VarChar).Value = novo.nome;
                cm.Parameters.Add("login", System.Data.SqlDbType.VarChar).Value = novo.login;
                cm.Parameters.Add("senha", System.Data.SqlDbType.Char).Value = novo.senha;
                cm.Parameters.Add("nascimento", System.Data.SqlDbType.DateTime).Value = novo.nascimento;
                cm.Parameters.Add("sexo", System.Data.SqlDbType.Char).Value = novo.sexo;
                cm.Parameters.Add("crn", System.Data.SqlDbType.VarChar).Value = novo.crn;
                cm.Parameters.Add("endereco", System.Data.SqlDbType.VarChar).Value = novo.endereco;
                cm.Parameters.Add("cpf_cnpj", System.Data.SqlDbType.VarChar).Value = novo.cpf_cnpj;

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


        /* busca nutricionista existente atraves do login e email, 
        retorna 1 se encontrar login igual,
        chama existe email e retorna 2 se encontrar email igual.
        retorna 0 se não encontrar nada 
        
        para confirmar um nutricionista, enviar 'confereLogin' no campo email,
        apenas para confirmar existencia de login */
        public int existeNutricionista(String email, String login)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;
                SqlDataReader er;

                cm.CommandText = "SELECT * FROM nutricionista WHERE login='" + login + "'";

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
                    /* se for uma verificação de nutricionista ja existente,
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

                cm.CommandText = "SELECT * FROM nutricionista WHERE email='" + email + "'";

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

        /*
        Busca nutricionista pelo login, e compara a senha digitada, com a senha do banco
        se for igual, retorna 1
        se for diferente, retorna 0
        */
        public int autenticaNutricionista(String login, String senha)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;
                SqlDataReader er;

                cm.CommandText = "SELECT RTRIM(senha) FROM nutricionista WHERE login='" + login + "'";

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
        public Nutricionista carregaNutricionista(String login)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;
                SqlDataReader er;

                cm.CommandText = "SELECT * FROM nutricionista WHERE login='" + login + "'";

                cm.Connection = con;
                con.Open();

                er = cm.ExecuteReader();
                er.Read();

                Nutricionista nutricionista = new Nutricionista
                {
                    id_nutricionista = Convert.ToInt32(er["id_nutricionista"]),
                    nome = Convert.ToString(er["nome"]),
                    email = Convert.ToString(er["email"]),
                    login = Convert.ToString(er["login"]),
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


        public int alteraNutricionista(Nutricionista nutricionista, Nutricionista nutricionistaAntigo)
        {
            try
            {
                if (!nutricionista.login.Equals(nutricionistaAntigo.login) || !nutricionista.email.Equals(nutricionistaAntigo.email))
                {
                    //Chama função para verificar se email e login ja existe no banco de dados
                    switch (Convert.ToString(existeNutricionista(nutricionista.email, nutricionista.login)))
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

                cm.CommandText = "UPDATE nutricionista  SET email=@email, nome=@nome, login=@login, senha=@senha, nascimento=@nascimento, sexo=@sexo, crn=@crn, endereco=@endereco, cpf_cnpj=@cpf_cnpj WHERE id_nutricionista=" + nutricionista.id_nutricionista;

                //Parametros irá substituir os valores dentro do campo
                cm.Parameters.Add("email", System.Data.SqlDbType.VarChar).Value = nutricionista.email;
                cm.Parameters.Add("nome", System.Data.SqlDbType.VarChar).Value = nutricionista.nome;
                cm.Parameters.Add("login", System.Data.SqlDbType.VarChar).Value = nutricionista.login;
                cm.Parameters.Add("senha", System.Data.SqlDbType.Char).Value = nutricionista.senha;
                cm.Parameters.Add("nascimento", System.Data.SqlDbType.DateTime).Value = nutricionista.nascimento;
                cm.Parameters.Add("sexo", System.Data.SqlDbType.Char).Value = nutricionista.sexo;
                cm.Parameters.Add("crn", System.Data.SqlDbType.VarChar).Value = nutricionista.crn;
                cm.Parameters.Add("endereco", System.Data.SqlDbType.VarChar).Value = nutricionista.endereco;
                cm.Parameters.Add("cpf_cnpj", System.Data.SqlDbType.VarChar).Value = nutricionista.cpf_cnpj;

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


        public Nutricionista recuperaSenha(Nutricionista nutricionista)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;
                SqlDataReader er;

                cm.CommandText = "SELECT * FROM nutricionista WHERE login = '" + nutricionista.login + "' AND email = '" + nutricionista.email + "' AND nascimento ='" + nutricionista.nascimento.ToShortDateString() + "'";

                cm.Connection = con;
                con.Open();

                er = cm.ExecuteReader();

                if (er.HasRows)
                {
                    Nutricionista user = carregaNutricionista(nutricionista.login);
                    return user;
                }
                else
                {
                    Nutricionista user = new Nutricionista { id_nutricionista = 0 };
                    return user;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public IList<Nutricionista> buscaNutricionistaNome(String nome_nutricionista)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;
                SqlDataReader er;

                cm.CommandText = "SELECT * FROM nutricionista WHERE nome LIKE '%" + nome_nutricionista + "%'";

                cm.Connection = con;
                con.Open();

                er = cm.ExecuteReader();

                IList<Nutricionista> listaNutricionistas = new List<Nutricionista>();
                if (er.HasRows)
                {
                    while (er.Read())
                    {
                        Nutricionista nutricionista = new Nutricionista
                        {
                            id_nutricionista = Convert.ToInt32(er["id_nutricionista"]),
                            nome = Convert.ToString(er["nome"]),
                            email = Convert.ToString(er["email"]),
                            nascimento = Convert.ToDateTime(er["nascimento"]),
                            sexo = Convert.ToString(er["sexo"]),
                            crn = Convert.ToString(er["crn"]),
                            endereco = Convert.ToString(er["endereco"]),
                            cpf_cnpj = Convert.ToString(er["cpf_cnpj"])
                        };

                        listaNutricionistas.Add(nutricionista);
                    }
                }

                return listaNutricionistas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public IList<Nutricionista> buscaTodosNutricionista()
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;
                SqlDataReader er;

                cm.CommandText = "SELECT * FROM nutricionista";

                cm.Connection = con;
                con.Open();

                er = cm.ExecuteReader();

                IList<Nutricionista> listaNutricionistas = new List<Nutricionista>();
                if (er.HasRows)
                {
                    while (er.Read())
                    {
                        Nutricionista nutricionista = new Nutricionista
                        {
                            id_nutricionista = Convert.ToInt32(er["id_nutricionista"]),
                            nome = Convert.ToString(er["nome"]),
                            email = Convert.ToString(er["email"]),
                            nascimento = Convert.ToDateTime(er["nascimento"]),
                            sexo = Convert.ToString(er["sexo"]),
                            crn = Convert.ToString(er["crn"]),
                            endereco = Convert.ToString(er["endereco"]),
                            cpf_cnpj = Convert.ToString(er["cpf_cnpj"])
                        };

                        listaNutricionistas.Add(nutricionista);
                    }
                }

                return listaNutricionistas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public IList<Usuario> buscaClientesNome(int id_nutricionista, String nome_usuario)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;
                SqlDataReader er;

                cm.CommandText = "SELECT tbClientes.id_usuario, tbClientes.nome, tbClientes.email, tbClientes.sexo, tbClientes.objetivo " +
                    "FROM usuario AS tbClientes " +
                    "INNER JOIN nutricionista_usuario AS LinkNutricionista " +
                    "ON tbClientes.id_usuario = LinkNutricionista.link_usuario " +
                    "INNER JOIN nutricionista AS tbNutricionista " +
                    "ON LinkNutricionista.link_nutricionista = tbNutricionista.id_nutricionista " +
                    "WHERE tbNutricionista.id_nutricionista = " + id_nutricionista + " AND tbClientes.nome LIKE '%" + nome_usuario + "%'";

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


        public IList<Usuario> buscaTodosClientes(int id_nutricionista)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;
                SqlDataReader er;

                cm.CommandText = "SELECT tbClientes.id_usuario, tbClientes.nome, tbClientes.email, tbClientes.sexo, tbClientes.objetivo " +
                    "FROM usuario AS tbClientes " +
                    "INNER JOIN nutricionista_usuario AS LinkNutricionista " +
                    "ON tbClientes.id_usuario = LinkNutricionista.link_usuario " +
                    "INNER JOIN nutricionista AS tbNutricionista " +
                    "ON LinkNutricionista.link_nutricionista = tbNutricionista.id_nutricionista " +
                    "WHERE tbNutricionista.id_nutricionista = " + id_nutricionista;

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
