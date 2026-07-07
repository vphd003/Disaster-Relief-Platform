using DisasterRelief.API.DTOs.Auth;

namespace DisasterRelief.API.Services.Interfaces;

public interface IAuthService
{
    Task<LoginResponse?> LoginAsync(LoginRequest request);

    Task<bool> LogoutAsync(string refreshToken);

    Task<LoginResponse?> RefreshTokenAsync(RefreshTokenRequest request);

    Task<bool> RegisterAsync(RegisterRequest request);
}