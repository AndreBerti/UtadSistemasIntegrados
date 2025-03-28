using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace criadorAleatorioDados
{
    public class Peca
    {
        public string codigo { get; }
        public DateTime data { get; }
        public int duracao { get; }
        public EnumResultadoTeste resultadoTeste { get; }
        public Contabilidade financa { get; }

        public Peca()
        {
            Random random = new Random();
            codigo = GeraCodigo();
            data = GeraData();
            duracao = random.Next(10, 51);
            resultadoTeste = GerarTeste();
            financa = new Contabilidade(codigo, duracao, resultadoTeste);
        }

        public EnumResultadoTeste GerarTeste()
        {
            Random random = new Random();

            switch (random.Next(1, 7))
            {
                case 1:
                    return EnumResultadoTeste.OK;
                case 2:
                    return EnumResultadoTeste.FalhaInspecaoEstanqueidade;
                case 3:
                    return EnumResultadoTeste.FalhaInspecaoResistencia;
                case 4:
                    return EnumResultadoTeste.FalhaInspecaoVisual;
                case 5:
                    return EnumResultadoTeste.FalhaInspecaoDimensoes;
                case 6:
                    return EnumResultadoTeste.Desconhecido;
                default:
                    return EnumResultadoTeste.OK; 
            }
        }



        public DateTime GeraData()
        {
            Random random = new Random();
            //Cria Data Aleatória
            int ano = random.Next(1950, 2025);
            int mes = random.Next(1, 13);
            int dia = random.Next(1, DateTime.DaysInMonth(ano, mes) + 1);
            //Cria Hora Aleatória
            int hora = random.Next(0, 24);
            int minuto = random.Next(0, 60);
            int segundo = random.Next(0, 60);
            return new DateTime(ano, mes, dia, hora, minuto,segundo);
        }

        public string GeraCodigo()
        {
            Random random = new Random();
            const string letras = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int tipo = random.Next(1,5);
            string codigo="";
            for (int i = 0; i < 6; i++)
            {
                codigo += letras[random.Next(0, letras.Length)];
            }
            //selecionando o tipo de peça
            switch (tipo)
            {
                case 1:
                    codigo = "AA"+codigo;
                    break;
                case 2:
                    codigo = "AB"+codigo;
                    break;
                case 3:
                    codigo = "BA" + codigo;
                    break;
                case 4:
                    codigo = "BB" + codigo;
                    break;
                default:
                    codigo = "ERRO";
                    break;
            }
            return codigo;
        }

       
    }

    
}
