using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FantasyEuroleague.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<PlayerStat> PlayerStats { get; set; }
        public DbSet<TeamStat> TeamStats { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Game Entity
            modelBuilder.Entity<Game>()
            .HasRequired(t => t.GuestTeam)
            .WithMany(ts => ts.AwayGames)
            .HasForeignKey(g => g.GuestTeamID)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<Game>()
            .HasRequired(t => t.HomeTeam)
            .WithMany(hg => hg.HomeGames)
            .HasForeignKey(h => h.HomeTeamID)
            .WillCascadeOnDelete(false);

            // Profile Entity
            modelBuilder.Entity<Profile>()
                .HasKey(k => k.PlayerID);

            modelBuilder.Entity<Profile>()
                .HasRequired(pr => pr.Player)
                .WithRequiredDependent(pl => pl.Profile);

            // PlayerStats
            modelBuilder.Entity<PlayerStat>()
                .HasKey(ps => new { ps.PlayerID, ps.GameID });

            //TeamStats
            modelBuilder.Entity<TeamStat>()
                .HasKey(ts => new { ts.TeamID, ts.GameID });

            base.OnModelCreating(modelBuilder);
        }

        public ApplicationDbContext()
            : base("FantasyEuroleagueDBContext", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}