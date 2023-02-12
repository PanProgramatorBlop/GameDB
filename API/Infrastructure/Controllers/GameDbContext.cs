using API.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class GameDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Developer> Developers { get; set;}

        public GameDbContext(DbContextOptions<GameDbContext> options) : base(options) 
        { 
        }
    }
}
