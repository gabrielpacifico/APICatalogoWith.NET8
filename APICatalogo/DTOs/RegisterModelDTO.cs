using System.ComponentModel.DataAnnotations;

namespace APICatalogo.DTOs
{
    public class RegisterModelDTO
    {
        [Required(ErrorMessage = "O nome de usuário é obrigatório!")]
        public string? Username { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "O email é obrigatório!")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "A senha é obrigatória!")]
        public string? Password { get; set; }
    }
}
