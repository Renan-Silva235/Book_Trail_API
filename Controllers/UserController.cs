using BookTrail_Api.DTOs.Requests;
using BookTrail_Api.DTOs.Responses;
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
            MessageResponse response = new MessageResponse("Conta Criada com sucesso!.");
            return Ok(response);
        }
        catch (Exception e)
        {
            MessageResponse response = new MessageResponse(e.Message);

            return BadRequest(response);
        }
    }
}