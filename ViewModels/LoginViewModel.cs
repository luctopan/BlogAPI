using System.ComponentModel.DataAnnotations;

namespace BlogAPI.ViewModels;

public class LoginViewModel
{
    [Required(ErrorMessage = "Informe o e-mail.")]
    [EmailAddress(ErrorMessage = "O e-mail é inválido.")]
    public string Email { get; set; }
    
    [Required(ErrorMessage = "Informe a senha.")]
    public string Password { get; set; }
}