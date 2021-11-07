using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class Componente
    {
        public Componente()
        {
            Avarias = new HashSet<Avarias>();
        }

        public int Id { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<Avarias> Avarias { get; set; }
    }
}
