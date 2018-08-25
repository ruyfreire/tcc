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

        public int novoUsuarioDAL(Usuario novoUser)
        {
            try
            {
                /*Conexão com BD
                * e busca todos os dados do usuario*/
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;

                cm.CommandText = "INSERT INTO usuario (email, nome, senha, nascimento, sexo, peso, altura, objetivo)" +
                                 "VALUES (@email, @nome, @senha, @nascimento, @sexo, @peso, @altura, @objetivo)";

                /*Parametros irá substituir os valores dentro do campo */
                cm.Parameters.Add("email", System.Data.SqlDbType.VarChar).Value = novoUser.email;
                cm.Parameters.Add("nome", System.Data.SqlDbType.VarChar).Value = novoUser.nome;
                cm.Parameters.Add("senha", System.Data.SqlDbType.Char).Value = novoUser.senha;
                cm.Parameters.Add("nascimento", System.Data.SqlDbType.DateTime).Value = novoUser.nascimento;
                cm.Parameters.Add("sexo", System.Data.SqlDbType.DateTime).Value = novoUser.sexo;
                cm.Parameters.Add("peso", System.Data.SqlDbType.Real).Value = novoUser.peso;
                cm.Parameters.Add("altura", System.Data.SqlDbType.Real).Value = novoUser.altura;
                cm.Parameters.Add("objetivo", System.Data.SqlDbType.VarChar).Value = novoUser.objetivo;

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

        /*
        public void validaUser()
        {
            try
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = System.Data.CommandType.Text;

                cm.CommandText = "SELECT * FROM usuario WHERE email";

                cm.Parameters.Add("email", System.Data.SqlDbType.VarChar).Value = novoUser.email;
                cm.Parameters.Add("nome", System.Data.SqlDbType.VarChar).Value = novoUser.nome;
                cm.Parameters.Add("senha", System.Data.SqlDbType.Char).Value = novoUser.senha;
                cm.Parameters.Add("nascimento", System.Data.SqlDbType.DateTime).Value = novoUser.nascimento;
                cm.Parameters.Add("sexo", System.Data.SqlDbType.DateTime).Value = novoUser.sexo;
                cm.Parameters.Add("peso", System.Data.SqlDbType.Real).Value = novoUser.peso;
                cm.Parameters.Add("altura", System.Data.SqlDbType.Real).Value = novoUser.altura;
                cm.Parameters.Add("objetivo", System.Data.SqlDbType.VarChar).Value = novoUser.objetivo;

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
         */

        public void buscaUsuarioDAL()
        {
            try
            {
                /*Conexão com BD
                * e busca todos os dados do usuario*/
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.CST;
                //SqlCommand cm = new SqlCommand();
                //cm.CommandType = System.Data.CommandType.Text;
                //cm.CommandText = "SELECT*FROM tb_usuarios";
                //cm.Connection = con;
                //SqlDataReader er;
                con.Open();

                MessageBox.Show("Banco de Dados conectado!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar Banco de Dados!");
                throw ex;
            }
        }



    }
}
