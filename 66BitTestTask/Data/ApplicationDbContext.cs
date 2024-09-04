using _66BitTestTask.Models;
using Microsoft.EntityFrameworkCore;

namespace _66BitTestTask.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
    }
}
