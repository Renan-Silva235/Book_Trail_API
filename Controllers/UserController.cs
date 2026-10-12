using BookTrail_Api.DTOs.Requests;
using BookTrail_Api.Entities;
using BookTrail_Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookTrail_Api.Controllers;

[ApiController]
[Route("user")]
public class UserController : ControllerBase
{
    private readonly ILogger<UserController> _logger;
    private UserService _service;
    private string message = "";
    
    public UserController(ILogger<UserController> logger, UserService service)
    {
        _logger = logger;
        _service = service;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] UserRegisterRequestDTO dto)
    {
        try
        {
            await _service.RegisterUser(dto);
            message = "Conta Criada com sucesso!.";
            return Ok(message);
        }
        catch (Exception e)
        {
            message = e.Message;
            return BadRequest(message);
        }
    }
}