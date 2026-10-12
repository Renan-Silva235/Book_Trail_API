using System.ComponentModel.DataAnnotations;

namespace BookTrail_Api.DTOs.Requests;

public record UserRegisterRequestDTO(
    [StringLength(50, MinimumLength = 3)]
    string Username,
    
    [EmailAddress]
    string Email, 
    
    [StringLength(50, MinimumLength = 6)]
    string Password);