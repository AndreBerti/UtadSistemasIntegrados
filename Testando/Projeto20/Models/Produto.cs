using System;
using System.ComponentModel.DataAnnotations;

namespace Projeto20.Models
{
    public class Produto
    {
        [Key]
        public string Codigo { get; set; }
        public DateTime Data { get; set; }
        public TimeSpan Hora { get; set; }
        public int Duracao { get; set; }
        public string Resultado { get; set; }
        public double Custo { get; set; }
        public double Prejuizo { get; set; }
        public double Lucro { get; set; }
    }
}
