using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ZodiacHockey.Data
{
    public class Context: DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Element> Elements { get; set; }
        public DbSet<FantasyProvider> FantasyProviders { get; set; }
        public DbSet<League> Leagues { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<PlayerData> PlayersData { get; set; }
        public DbSet<PlayerHistoricalArchive> PlayerHistoricalArchives { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<PositionType> PositionTypes { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<ZodiacSign> ZodiacSigns { get; set; }
        public DbSet<ZodiacStrength> ZodiacStrengths { get; set; }
        public DbSet<ZodiacWeakness> ZodiacWeaknesses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>().ToTable("Team");
            modelBuilder.Entity<FantasyProvider>().ToTable("FantasyProvider");
            modelBuilder.Entity<League>().ToTable("League");
            modelBuilder.Entity<PlayerData>().ToTable("PlayerData");
            modelBuilder.Entity<PlayerHistoricalArchive>().ToTable("PlayerHistoricalArchive");
            modelBuilder.Entity<Position>().ToTable("Position");
            modelBuilder.Entity<PositionType>().ToTable("PositionType");
            modelBuilder.Entity<Element>().ToTable("Element");
            modelBuilder.Entity<ZodiacSign>().ToTable("ZodiacSign");
            modelBuilder.Entity<ZodiacStrength>().ToTable("ZodiacStrength");
            modelBuilder.Entity<ZodiacWeakness>().ToTable("ZodiacWeakness");
            modelBuilder.Entity<Player>().ToTable("Player");
            modelBuilder.Entity<Position>().HasKey(c => new {c.PositionId});
            modelBuilder.Entity<Element>().HasKey(c => new { c.ElementId });
            modelBuilder.Entity<FantasyProvider>().HasKey(c => new { c.FantasyProviderId });
            modelBuilder.Entity<League>().HasKey(c => new { c.LeagueId });
            modelBuilder.Entity<Position>().HasKey(c => new { c.PositionId });
            modelBuilder.Entity<Player>().HasKey(c => new { c.PlayerId });
            modelBuilder.Entity<PositionType>().HasKey(c => new { c.PositionTypeId });
            modelBuilder.Entity<Position>().HasKey(c => new { c.PositionId });
            modelBuilder.Entity<Team>().HasKey(c => new { c.TeamId });
            modelBuilder.Entity<ZodiacSign>().HasKey(c => new { c.ZodiacSignId });
            modelBuilder.Entity<Position>().HasKey(c => new { c.PositionId });
        }


    }
}
