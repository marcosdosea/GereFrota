using System;

#nullable disable

namespace Domain.Models
{
    public class VistoriaModel
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Descricao { get; set; }
        public bool? TemAvaria { get; set; }
        public int IdVeiculo { get; set; }
        public int IdRelatorioMecanico { get; set; }
    }
}
