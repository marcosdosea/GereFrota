using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Entities
{
    public partial class Veiculo
    {
        public Veiculo()
        {
            Abastecimento = new HashSet<Abastecimento>();
            ConsumivelVeicular = new HashSet<ConsumivelVeicular>();
            SolicitacoesManutencao = new HashSet<SolicitacoesManutencao>();
            Viagem = new HashSet<Viagem>();
            Vistoria = new HashSet<Vistoria>();
        }

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

        public virtual Frota IdFrotaNavigation { get; set; }
        public virtual ICollection<Abastecimento> Abastecimento { get; set; }
        public virtual ICollection<ConsumivelVeicular> ConsumivelVeicular { get; set; }
        public virtual ICollection<SolicitacoesManutencao> SolicitacoesManutencao { get; set; }
        public virtual ICollection<Viagem> Viagem { get; set; }
        public virtual ICollection<Vistoria> Vistoria { get; set; }
    }
}
