using BookTrail_Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookTrail_Api.DbContext;

public class AppDbContext : Microsoft.EntityFrameworkCore.DbContext
{
    public DbSet<User> Users { get; set; }
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }
}