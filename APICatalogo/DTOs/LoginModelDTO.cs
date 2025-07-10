using System.ComponentModel.DataAnnotations;

namespace APICatalogo.DTOs
{
    public class LoginModelDTO
    {
        [Required(ErrorMessage = "O nome de usuário é obrigatório!")]
        public string? Username { get; set; }

        [Required(ErrorMessage = "A senha é obrigatória!")]
        public string? Password { get; set; }
    }
}
