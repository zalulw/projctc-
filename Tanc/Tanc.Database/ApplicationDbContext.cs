using Microsoft.EntityFrameworkCore;
using Tanc.Database.Entities;
namespace Tanc.Database;
public class ApplicationDbContext : DbContext
{
    public DbSet<CityEntity> Cities { get; set; }
    public DbSet<CompetitionEntity> Competitions { get; set; }
    public DbSet<CountryEntity> Countries { get; set; }
    public DbSet<MemberEntity> Members { get; set; }
    public DbSet<StreetEntity> Streets { get; set; }
    public DbSet<TeamEntity> Teams { get; set; }
    public ApplicationDbContext() : base()
    {
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=TancDB;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TeamEntity>()
                    .HasIndex(t => t.TeamName)
                    .IsUnique();

    }
}