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
        retorna 1 se login ja existir,
        retorna 2 se email ja existir,
        retorna 3 se cadastrar com sucesso 
        retorna 0 se der erro */
        public int novoPersonal(Personal novo)
        {
            try
            {
                //Chama função para verificar se email e login ja existe no banco de dados
                switch (Convert.ToString(existePersonal(novo.email, novo.login)))
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

                cm.CommandText = "INSERT INTO gym_personal (email, nome, login, senha, nascimento, sexo, crea, endereco, cpf_cnpj)" +
                                    "VALUES (@email, @nome, @login, @senha, @nascimento, @sexo, @crea, @endereco, @cpf_cnpj)";

                //Parametros irá substituir os valores dentro do campo
                cm.Parameters.Add("email", System.Data.SqlDbType.VarChar).Value = novo.email;
                cm.Parameters.Add("nome", System.Data.SqlDbType.VarChar).Value = novo.nome;
                cm.Parameters.Add("login", System.Data.SqlDbType.VarChar).Value = novo.login;
                cm.Parameters.Add("senha", System.Data.SqlDbType.Char).Value = novo.senha;
                cm.Parameters.Add("nascimento", System.Data.SqlDbType.DateTime).Value = novo.nascimento;
                cm.Parameters.Add("sexo", System.Data.SqlDbType.Char).Value = novo.sexo;
                cm.Parameters.Add("crea", System.Data.SqlDbType.VarChar).Value = novo.crea;
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


        /* busca personal existente atraves do login e email, 
        retorna 1 se encontrar email igual,
        chama existe email e retorna 2 se encontrar email igual.
        retorna 0 se não encontrar nada 
        
        para confirmar um personal, enviar 'confereLogin' no campo email,
        apenas para confirmar existencia de login */
        public int existePersonal(String email, String login)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;
                SqlDataReader er;

                cm.CommandText = "SELECT * FROM gym_personal WHERE login='" + login + "'";

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
                    /* se for uma verificação de personal ja existente,
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

                cm.CommandText = "SELECT * FROM gym_personal WHERE email='" + email + "'";

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
        Busca personal pelo login, e compara a senha digitada, com a senha do banco
        se for igual, retorna 1
        se for diferente, retorna 0
        */
        public int autenticaPersonal(String login, String senha)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;
                SqlDataReader er;

                cm.CommandText = "SELECT RTRIM(senha) FROM gym_personal WHERE login='" + login + "'";

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
        public Personal carregaPersonal(String login)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;
                SqlDataReader er;

                cm.CommandText = "SELECT * FROM gym_personal WHERE login='" + login + "'";

                cm.Connection = con;
                con.Open();

                er = cm.ExecuteReader();
                er.Read();

                Personal personal = new Personal
                {
                    id_personal = Convert.ToInt32(er["id_personal"]),
                    nome = Convert.ToString(er["nome"]),
                    login = Convert.ToString(er["login"]),
                    senha = Convert.ToString(er["senha"]),
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


        /* Recebe objeto personal, e atualiza as informações no banco */
        public int alteraPersonal(Personal personal, Personal personalAntigo)
        {
            try
            {
                if (!personal.login.Equals(personalAntigo.login) || !personal.email.Equals(personalAntigo.email))
                {
                    //Chama função para verificar se email e login ja existe no banco de dados
                    switch (Convert.ToString(existePersonal(personal.email, personal.login)))
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

                cm.CommandText = "UPDATE gym_personal  SET email=@email, nome=@nome, login=@login, senha=@senha, nascimento=@nascimento, sexo=@sexo, crea=@crea, endereco=@endereco, cpf_cnpj=@cpf_cnpj WHERE id_personal=" + personal.id_personal;

                //Parametros irá substituir os valores dentro do campo
                cm.Parameters.Add("email", System.Data.SqlDbType.VarChar).Value = personal.email;
                cm.Parameters.Add("nome", System.Data.SqlDbType.VarChar).Value = personal.nome;
                cm.Parameters.Add("login", System.Data.SqlDbType.VarChar).Value = personal.login;
                cm.Parameters.Add("senha", System.Data.SqlDbType.Char).Value = personal.senha;
                cm.Parameters.Add("nascimento", System.Data.SqlDbType.DateTime).Value = personal.nascimento;
                cm.Parameters.Add("sexo", System.Data.SqlDbType.Char).Value = personal.sexo;
                cm.Parameters.Add("crea", System.Data.SqlDbType.VarChar).Value = personal.crea;
                cm.Parameters.Add("endereco", System.Data.SqlDbType.VarChar).Value = personal.endereco;
                cm.Parameters.Add("cpf_cnpj", System.Data.SqlDbType.VarChar).Value = personal.cpf_cnpj;

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

        public Personal recuperaSenha(Personal personal)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;
                SqlDataReader er;

                cm.CommandText = "SELECT * FROM gym_personal WHERE login = '" + personal.login + "' AND email = '" + personal.email + "' AND nascimento ='" + personal.nascimento.ToShortDateString() + "'";

                cm.Connection = con;
                con.Open();

                er = cm.ExecuteReader();

                if (er.HasRows)
                {
                    Personal user = carregaPersonal(personal.login);
                    return user;
                }
                else
                {
                    Personal user = new Personal { id_personal = 0 };
                    return user;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public IList<Personal> buscaPersonalNome(String nome_personal)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;
                SqlDataReader er;

                cm.CommandText = "SELECT * FROM gym_personal WHERE nome LIKE '%" + nome_personal + "%'";

                cm.Connection = con;
                con.Open();

                er = cm.ExecuteReader();

                IList<Personal> listaPersonal = new List<Personal>();
                if (er.HasRows)
                {
                    while (er.Read())
                    {
                        Personal personal = new Personal
                        {
                            id_personal = Convert.ToInt32(er["id_personal"]),
                            nome = Convert.ToString(er["nome"]),
                            email = Convert.ToString(er["email"]),
                            nascimento = Convert.ToDateTime(er["nascimento"]),
                            sexo = Convert.ToString(er["sexo"]),
                            crea = Convert.ToString(er["crea"]),
                            endereco = Convert.ToString(er["endereco"]),
                            cpf_cnpj = Convert.ToString(er["cpf_cnpj"])
                        };

                        listaPersonal.Add(personal);
                    }
                }

                return listaPersonal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public IList<Personal> buscaTodosPersonal()
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;
                SqlDataReader er;

                cm.CommandText = "SELECT * FROM gym_personal";

                cm.Connection = con;
                con.Open();

                er = cm.ExecuteReader();

                IList<Personal> listaPersonal = new List<Personal>();
                if (er.HasRows)
                {
                    while (er.Read())
                    {
                        Personal personal = new Personal
                        {
                            id_personal = Convert.ToInt32(er["id_personal"]),
                            nome = Convert.ToString(er["nome"]),
                            email = Convert.ToString(er["email"]),
                            nascimento = Convert.ToDateTime(er["nascimento"]),
                            sexo = Convert.ToString(er["sexo"]),
                            crea = Convert.ToString(er["crea"]),
                            endereco = Convert.ToString(er["endereco"]),
                            cpf_cnpj = Convert.ToString(er["cpf_cnpj"])
                        };

                        listaPersonal.Add(personal);
                    }
                }

                return listaPersonal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public IList<Usuario> buscaClientesNome(int id_personal, String nome_usuario)
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
                    "INNER JOIN gym_personal_usuario AS LinkPersonal " +
                    "ON tbClientes.id_usuario = LinkPersonal.link_usuario " +
                    "INNER JOIN gym_personal AS tbPersonal " +
                    "ON LinkPersonal.link_personal = tbPersonal.id_personal " +
                    "WHERE tbPersonal.id_personal = " + id_personal + " AND tbClientes.nome LIKE '%" + nome_usuario + "%'";

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


        public IList<Usuario> buscaTodosClientes(int id_personal)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;
                SqlDataReader er;

                cm.CommandText = "SELECT tbClientes.id_usuario, tbClientes.nome, tbClientes.email, tbClientes.sexo, tbClientes.objetivo FROM usuario AS tbClientes " +
                    "INNER JOIN gym_personal_usuario AS LinkPersonal " +
                    "ON tbClientes.id_usuario = LinkPersonal.link_usuario " +
                    "INNER JOIN gym_personal AS tbPersonal " +
                    "ON LinkPersonal.link_personal = tbPersonal.id_personal " +
                    "WHERE tbPersonal.id_personal = " + id_personal;

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
