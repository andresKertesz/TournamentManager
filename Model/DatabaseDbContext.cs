using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TournamentManager.Model
{
    public class DatabaseDbContext : DbContext
    {

        public DbSet<Team> Teams { get; set; }
        public DbSet<League> Leagues { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {


            optionsBuilder.UseSqlite($"Filename={Program.DefaultDatabaseName}", sqliteOptionsAction: op =>
            {

                op.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);

            }) ;

            base.OnConfiguring(optionsBuilder);

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>().ToTable("Teams");
            modelBuilder.Entity<Team>(entity =>
            {
                entity.HasMany(e => e.Leagues)
                .WithMany(y => y.Teams)
                .UsingEntity(j => j.ToTable("TeamLeague"));
            });

            modelBuilder.Entity<League>(entity =>
            {
                entity.HasOne(x => x.Winner)
                .WithMany(x => x.LeaguesWon)
                .HasForeignKey(x => x.WinnerID);

            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
