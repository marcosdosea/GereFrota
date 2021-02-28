using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Entities
{
    public partial class TiposManutencao
    {
        public TiposManutencao()
        {
            SolicitacoesManutencao = new HashSet<SolicitacoesManutencao>();
        }

        public int Id { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<SolicitacoesManutencao> SolicitacoesManutencao { get; set; }
    }
}
