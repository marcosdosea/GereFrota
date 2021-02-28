using System;

#nullable disable

namespace Domain.Models
{
    public class AbastecimentoModel
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public int LeituraOdometro { get; set; }
        public int LitrosAbastecidos { get; set; }
        public int IdVeiculo { get; set; }
    }
}
