#nullable disable

namespace Domain.Entities
{
    public partial class Avarias
    {
        public int Id { get; set; }
        public int IdVistoria { get; set; }
        public int IdComponente { get; set; }

        public virtual Componente IdComponenteNavigation { get; set; }
        public virtual Vistoria IdVistoriaNavigation { get; set; }
    }
}
