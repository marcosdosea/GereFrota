using System;

#nullable disable

namespace Domain.Models
{
    public class MotoristaModel
    {
        public int Id { get; set; }
        public DateTime Validade { get; set; }
        public string Cnh { get; set; }
        public int IdCategoriaCnh { get; set; }
        public int IdUsuario { get; set; }
    }
}
