using System;

#nullable disable

namespace Data.Entities
{
    public partial class ConsumivelVeicular
    {
        public int Id { get; set; }
        public double Valor { get; set; }
        public DateTime DataDespesa { get; set; }
        public int IdCategoriaConsumivel { get; set; }
        public int IdVeiculos { get; set; }

        public virtual CategoriaConsumivel IdCategoriaConsumivelNavigation { get; set; }
        public virtual Veiculo IdVeiculosNavigation { get; set; }
    }
}
