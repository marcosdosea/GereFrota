using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class Usuario
    {
        public Usuario()
        {
            Motorista = new HashSet<Motorista>();
        }

        public int Id { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string NumeroMatricula { get; set; }
        public int IdTipoUsuario { get; set; }
        public int IdUnidade { get; set; }

        public virtual TipoUsuario IdTipoUsuarioNavigation { get; set; }
        public virtual Unidade IdUnidadeNavigation { get; set; }
        public virtual ICollection<Motorista> Motorista { get; set; }
    }
}
