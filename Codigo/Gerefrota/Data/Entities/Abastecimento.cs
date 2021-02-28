using System;

#nullable disable

namespace Data.Entities
{
    public partial class Abastecimento
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public int LeituraOdometro { get; set; }
        public int LitrosAbastecidos { get; set; }
        public int IdVeiculo { get; set; }

        public virtual Veiculo IdVeiculoNavigation { get; set; }
    }
}
