using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tcc.DAL
{
    public class UsuarioDAL
    {

        public void buscaUsuario()
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
