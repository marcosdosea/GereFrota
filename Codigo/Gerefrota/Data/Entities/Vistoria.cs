using System;

#nullable disable

namespace Data.Entities
{
    public partial class Vistoria
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Descricao { get; set; }
        public int IdVeiculo { get; set; }
        public int IdRelatorioMecanico { get; set; }

        public virtual RelatorioMecanico IdRelatorioMecanicoNavigation { get; set; }
        public virtual Veiculo IdVeiculoNavigation { get; set; }
    }
}
