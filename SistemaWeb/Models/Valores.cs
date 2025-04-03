namespace SistemaWeb.Models
{
    public class Valores
    {
       
        public static double CalculoCustoProducao(string codigo, int tempo)
        {
            string valor = codigo[0] + "" + codigo[1];
            switch (valor)
            {
                case "AA":
                    return 1.9 * tempo;
                case "AB":
                    return 1.3 * tempo;
                case "BA":
                    return 1.7 * tempo;
                case "BB":
                    return 1.2 * tempo;
                default: return 0;
            }
        }

        public static double CalculoPrejuizo(string codigo, int tempo, EnumResultados resultadoTeste)
        {
            double custoPrejuizo = 0;
            string valorCodigo = codigo[0] + "" + codigo[1];
            switch (valorCodigo)
            {
                case "AA":
                    custoPrejuizo += 0.9 * tempo;
                    break;
                case "AB":
                    custoPrejuizo += 1.1 * tempo;
                    break;
                case "BA":
                    custoPrejuizo += 1.2 * tempo;
                    break;
                case "BB":
                    custoPrejuizo += 1.3 * tempo;
                    break;
            }

            switch (resultadoTeste)
            {
                case EnumResultados.OK:
                    custoPrejuizo += 0;
                    break;
                case EnumResultados.FalhaInspecaoVisual:
                    custoPrejuizo += 3;
                    break;
                case EnumResultados.FalhaInspecaoResistencia:
                    custoPrejuizo += 2;
                    break;
                case EnumResultados.FalhaInspecaoDimensoes:
                    custoPrejuizo += 2.4;
                    break;
                case EnumResultados.FalhaInspecaoEstanqueidade:
                    custoPrejuizo += 1.7;
                    break;
                case EnumResultados.Desconhecido:
                    custoPrejuizo += 4.5;
                    break;

            }
            return custoPrejuizo;
        }

        public static double CalculoLucro(string codigo,double custo, double prejuizo)
        {
            string valor = codigo[0] + "" + codigo[1];
            double lucro = 0;
            switch (valor)
            {
                case "AA":
                    lucro = 120;
                    break;
                case "AB":
                    lucro = 100;
                    break;
                case "BA":
                    lucro = 110;
                    break;
                case "BB":
                    lucro = 90;
                    break;
                default:
                    return 0;
            }
            lucro = lucro - (prejuizo+custo);
            return lucro;
        }

    }
}
