using System;
using System.IO;
using System.Text;
using System.Globalization;

namespace criadorAleatorioDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Configurações
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string path = Path.Combine(desktopPath, "pecas_financas.csv");
            int quantidadePecas = 1000;

            try
            {
                // Configuração de cultura para garantir ponto decimal
                CultureInfo culture = CultureInfo.InvariantCulture;

                // Cabeçalho do CSV
                var csvContent = new StringBuilder();
                csvContent.AppendLine("Código;Data;Duração(min);ResultadoTeste;CustoProdução;Prejuízo;Lucro");

                Console.WriteLine("Iniciando geração de dados...");

                // Gerar as peças
                for (int i = 0; i < quantidadePecas; i++)
                {
                    var peca = new Peca();

                    // Formatar a linha do CSV
                    var linha = string.Format(culture,
                        "{0};{1:yyyy-MM-dd HH:mm:ss};{2};{3};{4:F2};{5:F2};{6:F2}",
                        peca.codigo,
                        peca.data,
                        peca.duracao,
                        peca.resultadoTeste,
                        peca.financa.custoProducao,
                        peca.financa.prejuizo,
                        peca.financa.lucro);

                    csvContent.AppendLine(linha);

                    // Mostrar progresso a cada 100 peças
                    if ((i + 1) % 100 == 0)
                        Console.WriteLine($"Geradas {i + 1} de {quantidadePecas} peças");
                }

                // Escrever no arquivo
                File.WriteAllText(path, csvContent.ToString(), Encoding.UTF8);

                Console.WriteLine($"\nArquivo gerado com sucesso em: {path}");
                Console.WriteLine($"Total de peças: {quantidadePecas}");
                Console.WriteLine("Pressione qualquer tecla para sair...");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro: {ex.Message}");
                Console.ReadKey();
            }
        }
    }
}