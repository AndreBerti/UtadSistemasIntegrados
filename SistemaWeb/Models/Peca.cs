namespace SistemaWeb.Models
{
    public class Peca
    {
        public string Codigo { get; set; }
        public DateTime Dia { get; set; }
        public TimeSpan Hora { get; set; }
        public int Duracao { get; set; }
        public EnumResultados Resultados { get; set; }
        public double CustoProducao { get; set; }
        public double Prejuizo { get; set; }
        public double Lucro { get; set; }

        public Peca(string codigo, DateTime dia, TimeSpan hora, int duracao, EnumResultados resultados)
        {
            Codigo = codigo;
            Dia = dia;
            Hora = hora;
            Duracao = duracao;
            Resultados = resultados;
            CustoProducao = Valores.CalculoCustoProducao(codigo, duracao);
            Prejuizo = Valores.CalculoPrejuizo(codigo, duracao, resultados);
            Lucro = Valores.CalculoLucro(codigo, CustoProducao, Prejuizo);

        }
        public Peca(string codigo, DateTime dia, TimeSpan hora, int duracao, EnumResultados resultados, double custo, double prejuizo, double lucro)
        {
            Codigo = codigo;
            Dia = dia;
            Hora = hora;
            Duracao = duracao;
            Resultados = resultados;
            CustoProducao = custo;
            Prejuizo = prejuizo;
            Lucro = lucro;

        }
    }
}