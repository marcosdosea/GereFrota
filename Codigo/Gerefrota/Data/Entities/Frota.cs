using System.Collections.Generic;

#nullable disable

namespace Data.Entities
{
    public partial class Frota
    {
        public Frota()
        {
            Veiculo = new HashSet<Veiculo>();
        }

        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public int IdUnidade { get; set; }

        public virtual Unidade IdUnidadeNavigation { get; set; }
        public virtual ICollection<Veiculo> Veiculo { get; set; }
    }
}
