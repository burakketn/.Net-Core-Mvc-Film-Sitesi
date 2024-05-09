using FilmSitesi.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FilmSitesi.Data
{
    public class FilmDbContext : DbContext
    {
        public FilmDbContext(DbContextOptions<FilmDbContext> options) : base(options)
        {

        }
        public DbSet<Film> Films { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

    }
}
