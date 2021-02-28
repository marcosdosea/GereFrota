#nullable disable

namespace Domain.Models
{
    public class RelatorioMecanicoModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal ValorPecas { get; set; }
        public decimal ValorServico { get; set; }
        public decimal ValorTotal { get; set; }
    }
}
