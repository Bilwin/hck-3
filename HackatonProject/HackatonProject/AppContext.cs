using HackatonProject.Models;
using Microsoft.EntityFrameworkCore;

namespace HackatonProject
{
    public class AppContext : DbContext
    {
        private readonly string _databasePath;

        public DbSet<User> Users { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Publication> Publications { get; set; }

        public AppContext(string databasePath)
        {
            _databasePath = databasePath;

            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={_databasePath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Publication>()
                .HasOne(e => e.Organization);
        }

        public void Add(User user)
        {
            Users.Add(user);
            SaveChanges();
        }
    }
}