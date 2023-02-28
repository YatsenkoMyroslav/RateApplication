using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RateApplication.Models;

namespace RateApplication.Data;

public class ApplicationDbContext : IdentityDbContext<User>
{
    
    public virtual DbSet<Establishment> Establishments { get; set; }
    public virtual DbSet<Feedback> Feedbacks { get; set; }
    
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
        Database.EnsureCreated();
    }
}