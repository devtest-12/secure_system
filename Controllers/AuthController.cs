using Microsoft.AspNetCore.Mvc;
using Scoops2GoAPI.Services;

namespace Scoops2GoAPI.Controllers;

public record AuthRequest(string Username, string Password);

[ApiController]
[Route("auth")]
public class AuthController : ControllerBase
{
    private readonly AuthService _auth;

    public AuthController(AuthService auth)
    {
        _auth = auth;
    }

    [HttpPost("register")]
    public IActionResult Register([FromBody] AuthRequest req)
    {
        _auth.Register(req.Username, req.Password);
        return Ok("Registered");
    }

    [HttpPost("login")]
    public IActionResult Login([FromBody] AuthRequest req)
    {
        var user = _auth.Authenticate(req.Username, req.Password);
        return user != null ? Ok("Login success") : Unauthorized("Invalid credentials");
    }
}

