using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SistemaNovo
{
    public class Produto
    {
        public string Codigo { get; set; }
        public DateTime Data { get; set; }
        public DateTime Hora { get; set; }
        public int Duracao { get; set; }
        public EnumResultadoTeste Resultado { get; set; }
        public ValoresProduto Valores { get; set; }
        
        public Produto(string codigo,DateTime data, int duracao, EnumResultadoTeste resultado)
        {
            this.Codigo = codigo;
            this.Data = data;
            this.Hora = data;
            this.Duracao = duracao;
            this.Resultado = resultado;
            this.Valores = new ValoresProduto(codigo, duracao, resultado);

        }

        public static Produto GetProduto(string codigo)
        {
            using (Db dbConnection = new Db())
            {
                try
                {
                    dbConnection.Open();
                    string query = "SELECT * FROM dbo.Produto WHERE codigo = @codigo";
                    using (SqlCommand command = new SqlCommand(query, dbConnection.Connection))
                    {
                        command.Parameters.AddWithValue("@codigo", codigo);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string data = reader["data"].ToString();
                                string hora = reader["hora"].ToString();
                                DateTime dataEHora;
                                try 
                                {
                                    dataEHora = Convert.ToDateTime(data + " " + hora);
                                }

                                catch (Exception e)
                                {
                                    return null;
                                }

                                return new Produto(
                                    reader["codigo"].ToString(),
                                    dataEHora,
                                    Convert.ToInt32(reader["duracao"]),
                                    (EnumResultadoTeste)Enum.Parse(typeof(EnumResultadoTeste), reader["resultado"].ToString())
                                );
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao buscar produto: {ex.Message}");
                }
            }
            return null; // Retorna null se o produto não for encontrado
        }


        public string CreateProduto(Produto produto)
        {
            using (Db dbConnection = new Db())
            {
                try
                {
                    dbConnection.Open();
                    string query = "INSERT INTO dbo.Produto (codigo, data, hora, duracao, resultado, custo_producao, prejuizo, lucro) VALUES (@codigo, @data, @hora, @duracao, @resultado, @custo, @prejuizo, @lucro)";
                    using (SqlCommand command = new SqlCommand(query, dbConnection.Connection))
                    {
                        command.Parameters.AddWithValue("@codigo", produto.Codigo);
                        command.Parameters.AddWithValue("@data", produto.Data.ToString("yyyy-MM-dd"));
                        command.Parameters.AddWithValue("@hora", produto.Hora.ToString("HH:mm:ss"));
                        command.Parameters.AddWithValue("@duracao", produto.Duracao);
                        command.Parameters.AddWithValue("@resultado", produto.Resultado.ToString());
                        command.Parameters.AddWithValue("@custo", produto.Valores.custoProducao);
                        command.Parameters.AddWithValue("@prejuizo", produto.Valores.prejuizo);
                        command.Parameters.AddWithValue("@lucro", produto.Valores.lucro);

                        command.ExecuteNonQuery();
                    }
                    return "Notificação: Registro adicionado com sucesso!";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao adicionar registro: {ex.Message}");
                }
            }
            return "Notificação: Erro ao adicionar o registro";
        }

        public static string RemoverProduto(string codigo)
        {
            using (Db dbConnection = new Db())
            {
                try
                {
                    dbConnection.Open();
                    string query = "DELETE FROM dbo.Produto WHERE codigo = @codigo";
                    using (SqlCommand command = new SqlCommand(query, dbConnection.Connection))
                    {
                        command.Parameters.AddWithValue("@codigo", codigo);
                        int rowsAffected = command.ExecuteNonQuery();
                        if( rowsAffected > 0)
                        {
                            return "Notificação: Produto Removido Com Sucesso!";
                        }
                        else return "Notificação:"+codigo+" Produto Não Encontrado!";
                        
                    }
                }
                catch (Exception ex)
                {
                    return ($"Erro ao remover produto: {ex.Message}");
                }
            }
        }
    }
}
