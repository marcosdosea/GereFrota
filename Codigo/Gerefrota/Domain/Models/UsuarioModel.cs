#nullable disable

namespace Domain.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string NumeroMatricula { get; set; }
        public int IdTipoUsuario { get; set; }
        public int IdUnidade { get; set; }
    }
}
