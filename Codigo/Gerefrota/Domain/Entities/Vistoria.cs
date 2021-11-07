using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class Vistoria
    {
        public Vistoria()
        {
            Avarias = new HashSet<Avarias>();
        }

        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Descricao { get; set; }
        public bool? TemAvaria { get; set; }
        public int IdVeiculo { get; set; }
        public int IdRelatorioMecanico { get; set; }

        public virtual RelatorioMecanico IdRelatorioMecanicoNavigation { get; set; }
        public virtual Veiculo IdVeiculoNavigation { get; set; }
        public virtual ICollection<Avarias> Avarias { get; set; }
    }
}
