using DisasterRelief.API.DTOs.Auth;
using DisasterRelief.API.Helpers;
using DisasterRelief.API.Services.Interfaces;
using DisasterReliefAPI.Models;
using DisasterReliefAPI.Repositories.Interfaces;

namespace DisasterRelief.API.Services;

public class AuthService : IAuthService
{
    private readonly IUserRepository _userRepository;
    private readonly IRefreshTokenRepository _refreshTokenRepository;
    private readonly JwtTokenGenerator _jwtTokenGenerator;

    public AuthService(
        IUserRepository userRepository,
        IRefreshTokenRepository refreshTokenRepository,
        JwtTokenGenerator jwtTokenGenerator)
    {
        _userRepository = userRepository;
        _refreshTokenRepository = refreshTokenRepository;
        _jwtTokenGenerator = jwtTokenGenerator;
    }

    public async Task<LoginResponse?> LoginAsync(LoginRequest request)
    {
        var user = await _userRepository.GetByEmailAsync(request.Email);

        if (user == null)
            return null;

        if (!PasswordHelper.VerifyPassword(request.Password, user.PasswordHash))
            return null;

        if (user.Status == 0)
            return null;

        var accessToken = _jwtTokenGenerator.GenerateAccessToken(
            user,
            user.Role.RoleName);

        var refreshToken = _jwtTokenGenerator.GenerateRefreshToken();

        var refreshTokenEntity = new RefreshToken
        {
            UserId = user.UserId,
            Token = refreshToken,
            CreatedAt = DateTime.UtcNow,
            ExpiresAt = DateTime.UtcNow.AddDays(7),
            IsRevoked = false
        };

        await _refreshTokenRepository.AddAsync(refreshTokenEntity);

        return new LoginResponse
        {
            UserId = user.UserId,
            FullName = user.FullName,
            Email = user.Email,
            Role = user.Role.RoleName,
            AccessToken = accessToken,
            RefreshToken = refreshToken,
            ExpiresAt = DateTime.UtcNow.AddMinutes(30)
        };
    }

    public async Task<bool> RegisterAsync(RegisterRequest request)
    {
        if (await _userRepository.EmailExistsAsync(request.Email))
            return false;

        var user = new User
        {
            FullName = request.FullName,
            Email = request.Email,
            PasswordHash = PasswordHelper.HashPassword(request.Password),
            Phone = request.Phone,
            Address = request.Address,
            RoleId = 4, // Requester mặc định
            Status = 1,
            CreatedAt = DateTime.UtcNow
        };

        await _userRepository.AddAsync(user);

        return true;
    }

    public async Task<LoginResponse?> RefreshTokenAsync(
        RefreshTokenRequest request)
    {
        var token =
            await _refreshTokenRepository.GetByTokenAsync(request.RefreshToken);

        if (token == null)
            return null;

        if (token.IsRevoked)
            return null;

        if (token.ExpiresAt < DateTime.UtcNow)
            return null;

        var accessToken =
            _jwtTokenGenerator.GenerateAccessToken(
                token.User,
                token.User.Role.RoleName);

        return new LoginResponse
        {
            UserId = token.User.UserId,
            FullName = token.User.FullName,
            Email = token.User.Email,
            Role = token.User.Role.RoleName,
            AccessToken = accessToken,
            RefreshToken = token.Token,
            ExpiresAt = DateTime.UtcNow.AddMinutes(30)
        };
    }

    public async Task<bool> LogoutAsync(string refreshToken)
    {
        var token =
            await _refreshTokenRepository.GetByTokenAsync(refreshToken);

        if (token == null)
            return false;

        token.IsRevoked = true;
        token.RevokedAt = DateTime.UtcNow;

        _refreshTokenRepository.Update(token);

        return true;
    }
}