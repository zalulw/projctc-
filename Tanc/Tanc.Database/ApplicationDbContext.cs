using Microsoft.EntityFrameworkCore;

namespace Tanc.Database;

public class ApplicationDbContext : DbContext
{
    public DbSet<CompetitionEntity> Competitions { get; set; }

    public DbSet<GroupEntity> Groups { get; set; }

    public DbSet<LocationEntity> Locations { get; set; }

    public DbSet<MemberEntity> Members { get; set; }

    public ApplicationDbContext() : base()
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);

        optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=VehicleDB;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True;");
        //.LogTo(Console.WriteLine);
    }
}
