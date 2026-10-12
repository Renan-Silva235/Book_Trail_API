using BookTrail_Api.DbContext;
using BookTrail_Api.DTOs.Requests;
using BookTrail_Api.Entities;
using Microsoft.AspNetCore.Identity;

namespace BookTrail_Api.Services;

public class UserService
{
    public readonly AppDbContext _dbContext;
    private readonly PasswordHasher<User> _passwordHasher;
    
    public UserService(AppDbContext dbContext)
    {
        _dbContext = dbContext;
        _passwordHasher = new PasswordHasher<User>();
    }

    public async Task RegisterUser(UserRegisterRequestDTO dto)
    {
        if (_dbContext.Users.Any(user => user.Email == dto.Email)) throw new Exception("Esse e-mail já existe no sistema.");
        User user = new User
        {
            UserName = dto.Username,
            Email = dto.Email,
            PasswordHash = _passwordHasher.HashPassword(null, dto.Password)
        };
        _dbContext.Users.Add(user);
        await _dbContext.SaveChangesAsync();
    }
}