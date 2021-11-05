namespace Domain.Models.Auxs
{
    public class VeiculoESolicitacaoManutencaoModel
    {
        public VeiculoModel Veiculo { get; set; }
        public SolicitacoesManutencaoModel SolicitacoesManutencao { get; set; }
        public TiposManutencaoModel TiposManutencao { get; set; }
        public StatusSolicitacaoModel StatusSolicitacao { get; set; }
    }
}
