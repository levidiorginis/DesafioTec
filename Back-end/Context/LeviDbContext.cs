using Back_end.Models;
using Microsoft.EntityFrameworkCore;

namespace Back_end.Context
{
    public class LeviDbContext : DbContext
    {
        public LeviDbContext(DbContextOptions<LeviDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<__EFMigrationsHistory> __EFMigrationsHistory { get; set; }
    }
}
