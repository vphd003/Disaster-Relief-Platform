using DisasterRelief.API.DTOs.Auth;
using DisasterRelief.API.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DisasterRelief.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    /// <summary>
    /// Login
    /// </summary>
    [HttpPost("login")]
    [AllowAnonymous]
    public async Task<IActionResult> Login(LoginRequest request)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var result = await _authService.LoginAsync(request);

        if (result == null)
            return Unauthorized(new
            {
                message = "Email hoặc mật khẩu không đúng."
            });

        return Ok(result);
    }

    /// <summary>
    /// Register
    /// </summary>
    [HttpPost("register")]
    [AllowAnonymous]
    public async Task<IActionResult> Register(RegisterRequest request)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var result = await _authService.RegisterAsync(request);

        if (!result)
            return BadRequest(new
            {
                message = "Email đã tồn tại."
            });

        return Ok(new
        {
            message = "Đăng ký thành công."
        });
    }

    /// <summary>
    /// Refresh Token
    /// </summary>
    [HttpPost("refresh-token")]
    [AllowAnonymous]
    public async Task<IActionResult> RefreshToken(
        RefreshTokenRequest request)
    {
        var result =
            await _authService.RefreshTokenAsync(request);

        if (result == null)
            return Unauthorized();

        return Ok(result);
    }

    /// <summary>
    /// Logout
    /// </summary>
    [Authorize]
    [HttpPost("logout")]
    public async Task<IActionResult> Logout(
        RefreshTokenRequest request)
    {
        var result =
            await _authService.LogoutAsync(request.RefreshToken);

        if (!result)
            return BadRequest();

        return Ok(new
        {
            message = "Logout successful."
        });
    }
}