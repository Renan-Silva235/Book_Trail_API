using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookTrail_Api.Entities;

[Table("users")]
public class User
{
    [Key]
    public long Id { get; set; }
    
    [Required(ErrorMessage = "Nome é Obrigatório")]
    public string UserName { get; set; }
    
    [Required(ErrorMessage = "E-mail é obrigatório")]
    public string Email { get; set; }
    
    [Required(ErrorMessage = "Senha é obrigatório")]
    public string PasswordHash { get; set; }
}
    