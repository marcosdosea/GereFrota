using System;

#nullable disable

namespace Domain.Models
{
    public class ViagemModel
    {
        public int Id { get; set; }
        public string Origem { get; set; }
        public string Destino { get; set; }
        public TimeSpan HorarioSaida { get; set; }
        public TimeSpan HorarioChegada { get; set; }
        public string LeituraOdometroInicial { get; set; }
        public string LeituraOdometroFinal { get; set; }
        public string Descricao { get; set; }
        public int IdVeiculo { get; set; }
        public int IdMotorista { get; set; }
    }
}
