using System;
using MySqlConnector;

namespace Atividade_2.Models
{
    public class UsuarioBD
    {
        private const string DadosConexao = "Database=login; Data Source=localhost; User Id=root";

        public Usuario FazerLogin(Usuario usuario){
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            
            string Query = "SELECT * FROM usuario WHERE Login = @Login AND Senha = @Senha";
            
            MySqlCommand ComandoQuery = new MySqlCommand(Query, Conexao);
            ComandoQuery.Parameters.AddWithValue("@Login", usuario.Login);
            ComandoQuery.Parameters.AddWithValue("@Senha", usuario.Senha);
            MySqlDataReader DadosEncontrados = ComandoQuery.ExecuteReader();
            
            Usuario UsuarioEncontrado = null;

            if(DadosEncontrados.Read()){
                UsuarioEncontrado = new Usuario();
                UsuarioEncontrado.Id = DadosEncontrados.GetInt32("Id");
                
                if(!DadosEncontrados.IsDBNull(DadosEncontrados.GetOrdinal("Nome")))
                    UsuarioEncontrado.Nome = DadosEncontrados.GetString("Nome");
                if(!DadosEncontrados.IsDBNull(DadosEncontrados.GetOrdinal("Login")))
                    UsuarioEncontrado.Login = DadosEncontrados.GetString("Login");
                if(!DadosEncontrados.IsDBNull(DadosEncontrados.GetOrdinal("Senha")))
                    UsuarioEncontrado.Senha = DadosEncontrados.GetString("Senha");
                if(!DadosEncontrados.IsDBNull(DadosEncontrados.GetOrdinal("DataNascimento")))
                    UsuarioEncontrado.DataNascimento = DadosEncontrados.GetDateTime("DataNascimento");
            }
            Conexao.Close();
            return UsuarioEncontrado;
        }


        
        public static void TestarConexao(){
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            Console.WriteLine("Banco de dados funcionando");
            Conexao.Close();
        }
    }
}