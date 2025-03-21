﻿using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class CategoriaConsumivel
    {
        public CategoriaConsumivel()
        {
            ConsumivelVeicular = new HashSet<ConsumivelVeicular>();
        }

        public int Id { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<ConsumivelVeicular> ConsumivelVeicular { get; set; }
    }
}
