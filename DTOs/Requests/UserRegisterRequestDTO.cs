using System.ComponentModel.DataAnnotations;

namespace BookTrail_Api.DTOs.Requests;

public record UserRegisterRequestDTO(

    [Required(ErrorMessage = "Nome é Obrigatório")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Nome deve ter no mínimo 3 caracteres.")]
    string Username,

    [Required(ErrorMessage = "E-mail é obrigatório")]
    [EmailAddress(ErrorMessage = "Insira um formato de E-mail válido.")]
    string Email,

    [Required(ErrorMessage = "Senha é obrigatório")]
    [StringLength(50, MinimumLength = 6, ErrorMessage = "Senha deve ter no mínimo 6 caracteres.")]
    string Password
    );