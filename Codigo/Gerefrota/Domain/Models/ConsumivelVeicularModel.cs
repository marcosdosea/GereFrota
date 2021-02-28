using System;

#nullable disable

namespace Domain.Models
{
    public class ConsumivelVeicularModel
    {
        public int Id { get; set; }
        public double Valor { get; set; }
        public DateTime DataDespesa { get; set; }
        public int IdCategoriaConsumivel { get; set; }
        public int IdVeiculos { get; set; }
    }
}
