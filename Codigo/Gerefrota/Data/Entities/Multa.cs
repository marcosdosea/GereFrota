#nullable disable

namespace Data.Entities
{
    public partial class Multa
    {
        public int Id { get; set; }
        public decimal Valor { get; set; }
        public int QtdPontos { get; set; }
        public int IdViagem { get; set; }

        public virtual Viagem IdViagemNavigation { get; set; }
    }
}
