namespace Domain.Entities.Auxs
{
    public class VeiculoESolicitacaoManutencao
    {
        public Veiculo Veiculo { get; set; }
        public SolicitacoesManutencao SolicitacoesManutencao { get; set; }
        public TiposManutencao TiposManutencao { get; set; }
        public StatusSolicitacao StatusSolicitacao { get; set; }
    }
}
