using Microsoft.AspNetCore.Identity;

namespace RateApplication.Models;

public class User : IdentityUser
{
    public string Name { get; set; }
    public string Lasname { get; set; }
    public string PhotoPath { get; set; }
    public int Rating { get; set; }
    public Establishment[] Establishments { get; set; }
}