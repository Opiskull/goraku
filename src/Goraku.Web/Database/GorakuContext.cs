using Goraku.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace Goraku.Web
{
    public class GorakuContext : DbContext
    {
        public DbSet<Anime> Animes { get; set; }
        public DbSet<Manga> Mangas { get; set; }

        public GorakuContext(DbContextOptions<GorakuContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}