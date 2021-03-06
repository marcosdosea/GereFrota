using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class Motorista
    {
        public Motorista()
        {
            Viagem = new HashSet<Viagem>();
        }

        public int Id { get; set; }
        public DateTime Validade { get; set; }
        public string Cnh { get; set; }
        public int IdCategoriaCnh { get; set; }
        public int IdUsuario { get; set; }

        public virtual CategoriaCnh IdCategoriaCnhNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<Viagem> Viagem { get; set; }
    }
}
