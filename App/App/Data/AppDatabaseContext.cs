using App.Persistence.Models;
using Microsoft.EntityFrameworkCore;

namespace App.Persistence.Data
{
    public class AppDatabaseContext : DbContext
    {
        private readonly string connectionDetails = "server=localhost; user=company; password=company; Database=citb517-client-server";
        public DbSet<User> Users { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Media> Medias { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(connectionDetails, ServerVersion.AutoDetect(connectionDetails));
        }
    }
}