using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNovo
{
    public class ValoresProduto
    {
            public double custoProducao { get; }
            public double prejuizo { get; }
            public double lucro { get; }

            public ValoresProduto(string codigo, int tempo, EnumResultadoTeste resultadoTeste)
            {
                custoProducao = CalculoCustoProducao(codigo, tempo);
                prejuizo = CalculoPrejuizo(codigo, tempo, resultadoTeste);
                lucro = CalculoLucro(codigo);
            }

            public double CalculoCustoProducao(string codigo, int tempo)
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

            public double CalculoPrejuizo(string codigo, int tempo, EnumResultadoTeste resultadoTeste)
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
                    case EnumResultadoTeste.OK:
                        custoPrejuizo += 0;
                        break;
                    case EnumResultadoTeste.FalhaInspecaoVisual:
                        custoPrejuizo += 3;
                        break;
                    case EnumResultadoTeste.FalhaInspecaoResistencia:
                        custoPrejuizo += 2;
                        break;
                    case EnumResultadoTeste.FalhaInspecaoDimensoes:
                        custoPrejuizo += 2.4;
                        break;
                    case EnumResultadoTeste.FalhaInspecaoEstanqueidade:
                        custoPrejuizo += 1.7;
                        break;
                    case EnumResultadoTeste.Desconhecido:
                        custoPrejuizo += 4.5;
                        break;

                }
                return custoPrejuizo;
            }

            public double CalculoLucro(string codigo)
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
                lucro = lucro - (custoProducao + prejuizo);
                return lucro;
            }
        }
}
