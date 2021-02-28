using System.Collections.Generic;

#nullable disable

namespace Data.Entities
{
    public partial class StatusSolicitacao
    {
        public StatusSolicitacao()
        {
            SolicitacoesManutencao = new HashSet<SolicitacoesManutencao>();
        }

        public int Id { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<SolicitacoesManutencao> SolicitacoesManutencao { get; set; }
    }
}
