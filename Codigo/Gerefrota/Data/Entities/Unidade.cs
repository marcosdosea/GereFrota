using System.Collections.Generic;

#nullable disable

namespace Data.Entities
{
    public partial class Unidade
    {
        public Unidade()
        {
            Frota = new HashSet<Frota>();
            Usuario = new HashSet<Usuario>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }

        public virtual ICollection<Frota> Frota { get; set; }
        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}
