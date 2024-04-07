using System.ComponentModel.DataAnnotations;

namespace JWTWithDotNetCore.DTOs;

public class RegisterDto
{
    public string UserName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}