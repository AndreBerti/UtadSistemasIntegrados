using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace criadorAleatorioDados
{
    public enum EnumResultadoTeste
    {
        OK = 1,
        FalhaInspecaoVisual = 2,
        FalhaInspecaoResistencia = 3,
        FalhaInspecaoDimensoes = 4,
        FalhaInspecaoEstanqueidade = 5,
        Desconhecido = 6
    }
}
