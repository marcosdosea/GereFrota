using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Entities
{
    public partial class CategoriaCnh
    {
        public CategoriaCnh()
        {
            Motorista = new HashSet<Motorista>();
        }

        public int Id { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<Motorista> Motorista { get; set; }
    }
}
