using Microsoft.AspNetCore.Identity;

namespace TodoApi.Models;

public class ApplicationUser : IdentityUser
{
    public string FullName { get; set; } = null!;
}