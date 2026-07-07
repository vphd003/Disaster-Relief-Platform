using System.ComponentModel.DataAnnotations;

namespace DisasterRelief.API.DTOs.Auth;

public class RegisterRequest
{
    [Required]
    public string FullName { get; set; } = string.Empty;

    [Required]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;

    [Required]
    public string Password { get; set; } = string.Empty;

    public string? Phone { get; set; }

    public string? Address { get; set; }
}