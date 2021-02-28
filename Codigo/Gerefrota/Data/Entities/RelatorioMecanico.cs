using System.Collections.Generic;

#nullable disable

namespace Data.Entities
{
    public partial class RelatorioMecanico
    {
        public RelatorioMecanico()
        {
            Vistoria = new HashSet<Vistoria>();
        }

        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal ValorPecas { get; set; }
        public decimal ValorServico { get; set; }
        public decimal ValorTotal { get; set; }

        public virtual ICollection<Vistoria> Vistoria { get; set; }
    }
}
