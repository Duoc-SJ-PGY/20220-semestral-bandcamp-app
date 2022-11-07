using Microsoft.EntityFrameworkCore;
using TwitterAPI.Models;

namespace TwitterAPI.Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Tweets> Tweets { get; set; }
    }
}
