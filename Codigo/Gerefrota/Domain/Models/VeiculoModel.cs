using System;

#nullable disable

namespace Domain.Models
{
    public class VeiculoModel
    {
        public int Id { get; set; }
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public string AnoFabricacao { get; set; }
        public string AnoModelo { get; set; }
        public DateTime DataEmplacamento { get; set; }
        public string Chassi { get; set; }
        public string Categoria { get; set; }
        public int Capacidade { get; set; }
        public string NomeclaturaViatura { get; set; }
        public int LeituraOdômetro { get; set; }
        public string Renavam { get; set; }
        public DateTime VencimentoIpva { get; set; }
        public bool Status { get; set; }
        public int IdFrota { get; set; }
    }
}
