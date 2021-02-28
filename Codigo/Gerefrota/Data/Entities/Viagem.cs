using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Entities
{
    public partial class Viagem
    {
        public Viagem()
        {
            Multa = new HashSet<Multa>();
        }

        public int Id { get; set; }
        public string Origem { get; set; }
        public string Destino { get; set; }
        public TimeSpan HorarioSaida { get; set; }
        public TimeSpan HorarioChegada { get; set; }
        public string LeituraOdometroInicial { get; set; }
        public string LeituraOdometroFinal { get; set; }
        public string Descricao { get; set; }
        public int IdVeiculo { get; set; }
        public int IdMotorista { get; set; }

        public virtual Motorista IdMotoristaNavigation { get; set; }
        public virtual Veiculo IdVeiculoNavigation { get; set; }
        public virtual ICollection<Multa> Multa { get; set; }
    }
}
