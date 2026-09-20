using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShooterGameAPI.Module;

namespace ShooterGameAPI.Data
{
    public class GameDbContext : DbContext
    {
        public GameDbContext(DbContextOptions<GameDbContext> options) : base (options)
        {

        }

        public DbSet<Leaderboard> leaderboard { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Leaderboard>().HasKey(l => new { l.Name, l.CharacterType });
            modelBuilder.Entity<LoginRegister>().HasKey(l => new { l.Name });
            modelBuilder.Entity<Feedbacks>().HasKey(f => new { f.Name });

            modelBuilder.Entity<LoginRegister>().ToTable("namepassword");
            modelBuilder.Entity<Feedbacks>().ToTable("feedback");
        }

        public DbSet<LoginRegister> loginRegisters { get; set; }
        public DbSet<Feedbacks> feedbacks { get; set; }

    }
}
