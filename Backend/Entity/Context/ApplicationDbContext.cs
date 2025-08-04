using Entity.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Entity.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Game> Games { get; set; }
        public DbSet<Player> Players { get; set; }

        public DbSet<GamePlayer> GamePlayers { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Deck> Decks { get; set; }
        public DbSet<Move> Moves { get; set; }
        public DbSet<Round> Rounds { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Move>()
            .HasOne(m => m.Round)
            .WithMany(r => r.Moves)
            .HasForeignKey(m => m.RoundId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }
    }
}
