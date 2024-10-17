using Lecso.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lecso.Database
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<CompetitionEntity> Competitions { get; set; }

        public DbSet<JudgeEntity> Judges { get; set; }

        public DbSet<LocationEntity> Locations { get; set; }

        public DbSet<MemberEntity> Members { get; set; }

        public DbSet<TeamEntity> Teams { get; set; }


        public ApplicationDbContext() : base()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=LecsoDB;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True;");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TeamEntity>()
                        .HasIndex(t => t.TeamName)
                        .IsUnique();

        }
    }
}
