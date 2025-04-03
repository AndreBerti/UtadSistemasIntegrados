using Microsoft.Data.SqlClient;
using SistemaWeb.Models;
using System.Data;

namespace SistemaWeb.Db
{
    public class DbAccess
    {
        SqlCommand _comandos = null;
        public static IConfiguration Configuration { get; set; }
        private string GetConnectionString()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
            Configuration = builder.Build();
            string connectionString = Configuration.GetConnectionString("DefaultConnection");
            if (connectionString == null)
            {
                throw new Exception("Chave 'DefaultConnection' não encontrada no arquivo appsettings.json.");
            }
            return connectionString;
        }

        public List<Peca> ListarPecas()
        {
            List<Peca> pecas = new List<Peca>();
            using (SqlConnection _connection = new SqlConnection(GetConnectionString()))
            {
                _comandos = _connection.CreateCommand();
                _comandos.CommandType = CommandType.StoredProcedure;
                _comandos.CommandText = "[dbo].[listar_pecas]";
                _connection.Open();
                SqlDataReader reader = _comandos.ExecuteReader();
                while (reader.Read())
                {
                        string _codigo = reader["Codigo"] != DBNull.Value ? reader["Codigo"].ToString() : null;
                        DateTime _dia = Convert.ToDateTime(reader["Dia"].ToString());
                        TimeSpan _hora = (TimeSpan)reader["Hora"];
                        int _duracao = Convert.ToInt32(reader["Duracao"]);
                        EnumResultados _resultado = reader["Resultado"] != DBNull.Value ? Enum.Parse<EnumResultados>(reader["Resultado"].ToString()) : EnumResultados.Desconhecido;
                        double _custo = Convert.ToDouble(reader["Custo"]);
                        double _prejuizo = Convert.ToDouble(reader["Prejuizo"]);
                        double _lucro = Convert.ToDouble(reader["Lucro"]);

                        if (_codigo != null)
                        {
                            Peca peca = new Peca(_codigo, _dia, _hora, _duracao, _resultado, _custo, _prejuizo, _lucro);
                            pecas.Add(peca);
                        }
                        else
                        {
                            Console.WriteLine("Aviso: Codigo nulo encontrado no banco de dados.");
                        }
                    
                }
                return pecas;
            }
        }
    }
}