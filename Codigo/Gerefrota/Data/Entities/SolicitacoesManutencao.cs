using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Entities
{
    public partial class SolicitacoesManutencao
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Descricao { get; set; }
        public int IdStatusSolicitacao { get; set; }
        public int IdTiposManutencao { get; set; }
        public int IdVeiculo { get; set; }

        public virtual StatusSolicitacao IdStatusSolicitacaoNavigation { get; set; }
        public virtual TiposManutencao IdTiposManutencaoNavigation { get; set; }
        public virtual Veiculo IdVeiculoNavigation { get; set; }
    }
}
