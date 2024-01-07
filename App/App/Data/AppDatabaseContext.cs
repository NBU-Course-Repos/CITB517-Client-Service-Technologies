using App.Persistence.Models;
using Microsoft.EntityFrameworkCore;

namespace App.Persistence.Data
{
    public class AppDatabaseContext : DbContext
    {
        private readonly string connectionDetails = "server=localhost; user=company; password=company; Database=citb517-client-server";
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Comment> Comments { get; set; } = null!;
        public DbSet<Media> Medias { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(connectionDetails, ServerVersion.AutoDetect(connectionDetails));
        }

        //public void Create<Type>(Type entity)
        //{
        //    switch (Type)
        //    {

        //    }
        //}
    }
}