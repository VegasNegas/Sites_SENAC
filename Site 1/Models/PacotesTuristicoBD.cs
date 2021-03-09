using System.Collections.Generic;
using MySqlConnector;

namespace Atividade_2.Models
{
    public class PacotesTuristicoBD
    {   
        private const string DadosConexao = "Database=login; Data Source=localhost; User Id=root";
       
        public List<PacotesTuristicos> Listar(){
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            string Query = "SELECT * FROM pacoteturistico;";

            MySqlCommand ComandoQuery = new MySqlCommand(Query, Conexao);
            MySqlDataReader DadosEncontrados = ComandoQuery.ExecuteReader();

            List<PacotesTuristicos> lista = new List<PacotesTuristicos>();

            while(DadosEncontrados.Read()){
                PacotesTuristicos PacoteEncontrado = new PacotesTuristicos();
                PacoteEncontrado.Id = DadosEncontrados.GetInt32("Id");
                if(!DadosEncontrados.IsDBNull(DadosEncontrados.GetOrdinal("Nome")))
                    PacoteEncontrado.Nome = DadosEncontrados.GetString("Nome");
                if(!DadosEncontrados.IsDBNull(DadosEncontrados.GetOrdinal("Origem")))
                    PacoteEncontrado.Origem = DadosEncontrados.GetString("Origem");
                if(!DadosEncontrados.IsDBNull(DadosEncontrados.GetOrdinal("Destino")))
                    PacoteEncontrado.Destino = DadosEncontrados.GetString("Destino");
                if(!DadosEncontrados.IsDBNull(DadosEncontrados.GetOrdinal("Atrativo")))
                    PacoteEncontrado.Atrativos = DadosEncontrados.GetString("Atrativo");
                if(!DadosEncontrados.IsDBNull(DadosEncontrados.GetOrdinal("Saida")))
                    PacoteEncontrado.Saida = DadosEncontrados.GetDateTime("Saida");
                if(!DadosEncontrados.IsDBNull(DadosEncontrados.GetOrdinal("Retorno")))
                    PacoteEncontrado.Retorno = DadosEncontrados.GetDateTime("Retorno");
                if(!DadosEncontrados.IsDBNull(DadosEncontrados.GetOrdinal("Usuario")))
                    PacoteEncontrado.Usuario = DadosEncontrados.GetInt32("Usuario");

                lista.Add(PacoteEncontrado);
            }
            Conexao.Close();

            return lista;
        }

        public void Cadastrar(PacotesTuristicos pacotes, int Id){
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            string Query = "INSERT INTO pacoteturistico(Nome, Origem, Destino, Atrativo, Saida, Retorno, Usuario) VALUE(@Nome, @Origem, @Destino, @Atrativo, @Saida, @Retorno, @Usuario)";

            MySqlCommand ComandoQuery = new MySqlCommand(Query, Conexao);
            ComandoQuery.Parameters.AddWithValue("@Nome", pacotes.Nome);
            ComandoQuery.Parameters.AddWithValue("@Origem", pacotes.Origem);
            ComandoQuery.Parameters.AddWithValue("@Destino", pacotes.Destino);
            ComandoQuery.Parameters.AddWithValue("@Atrativo", pacotes.Atrativos);
            ComandoQuery.Parameters.AddWithValue("@Saida", pacotes.Saida);
            ComandoQuery.Parameters.AddWithValue("@Retorno", pacotes.Retorno);
            ComandoQuery.Parameters.AddWithValue("@Usuario", Id);

            ComandoQuery.ExecuteNonQuery();

            Conexao.Close();

        }

        public void Editar(PacotesTuristicos pacotes, int Id){
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            string Query = "UPDATE pacoteturistico SET Nome=@Nome, Origem=@Origem, Destino=@Destino, Atrativo=@Atrativo, Saida=@Saida, Retorno=@Retorno, Usuario=@Usuario WHERE Id=@Id;";

            MySqlCommand ComandoQuery = new MySqlCommand(Query, Conexao);
            
            ComandoQuery.Parameters.AddWithValue("@Nome", pacotes.Nome);
            ComandoQuery.Parameters.AddWithValue("@Origem", pacotes.Origem);
            ComandoQuery.Parameters.AddWithValue("@Destino", pacotes.Destino);
            ComandoQuery.Parameters.AddWithValue("@Atrativo", pacotes.Atrativos);
            ComandoQuery.Parameters.AddWithValue("@Saida", pacotes.Saida);
            ComandoQuery.Parameters.AddWithValue("@Retorno", pacotes.Retorno);
            ComandoQuery.Parameters.AddWithValue("@Usuario", Id);
            ComandoQuery.Parameters.AddWithValue("@Id", pacotes.Id);
            ComandoQuery.ExecuteNonQuery();

            Conexao.Close();

        }

        public void Remover(int Id){
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            string Query = "DELETE FROM pacoteturistico WHERE Id = @Id;";

            MySqlCommand ComandoQuery = new MySqlCommand(Query, Conexao);
            
            ComandoQuery.Parameters.AddWithValue("@Id", Id);
            ComandoQuery.ExecuteNonQuery();

            Conexao.Close();
        }

        public PacotesTuristicos BuscarId(int Id){
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            string Query = "SELECT * FROM pacoteturistico WHERE Id = @Id;";

            MySqlCommand ComandoQuery = new MySqlCommand(Query, Conexao);
            
            ComandoQuery.Parameters.AddWithValue("@Id", Id);
            
            MySqlDataReader DadosEncontrados = ComandoQuery.ExecuteReader();

            PacotesTuristicos PacoteEncontrado = null;
            if(DadosEncontrados.Read()){
                PacoteEncontrado = new PacotesTuristicos();
                PacoteEncontrado.Id = Id;
                if(!DadosEncontrados.IsDBNull(DadosEncontrados.GetOrdinal("Nome")))
                    PacoteEncontrado.Nome = DadosEncontrados.GetString("Nome");
                if(!DadosEncontrados.IsDBNull(DadosEncontrados.GetOrdinal("Origem")))
                    PacoteEncontrado.Origem = DadosEncontrados.GetString("Origem");
                if(!DadosEncontrados.IsDBNull(DadosEncontrados.GetOrdinal("Destino")))
                    PacoteEncontrado.Destino = DadosEncontrados.GetString("Destino");
                if(!DadosEncontrados.IsDBNull(DadosEncontrados.GetOrdinal("Atrativo")))
                    PacoteEncontrado.Atrativos = DadosEncontrados.GetString("Atrativo");
                if(!DadosEncontrados.IsDBNull(DadosEncontrados.GetOrdinal("Saida")))
                    PacoteEncontrado.Saida = DadosEncontrados.GetDateTime("Saida");
                if(!DadosEncontrados.IsDBNull(DadosEncontrados.GetOrdinal("Retorno")))
                    PacoteEncontrado.Retorno = DadosEncontrados.GetDateTime("Retorno");
                if(!DadosEncontrados.IsDBNull(DadosEncontrados.GetOrdinal("Usuario")))
                    PacoteEncontrado.Usuario = DadosEncontrados.GetInt32("Usuario");
            }
            Conexao.Close();

            return PacoteEncontrado;
        }
        
    }
   
}