using System.ComponentModel.DataAnnotations;

namespace JWTWithDotNetCore.DTOs;

public class LoginDto
{
    public string UserNameOrEmail { get; set; }
    public string Password { get; set; }
}