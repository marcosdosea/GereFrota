using System;

#nullable disable

namespace Domain.Models
{
    public class SolicitacoesManutencaoModel
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Descricao { get; set; }
        public int IdStatusSolicitacao { get; set; }
        public int IdTiposManutencao { get; set; }
        public int IdVeiculo { get; set; }
    }
}
