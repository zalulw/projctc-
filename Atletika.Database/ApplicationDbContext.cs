using Atletika.Database.Entities;
using Microsoft.EntityFrameworkCore;
namespace Atletika.Database;
public class ApplicationDbContext : DbContext
{
    public DbSet<AthleteEntity> Athletes { get; set; }
    public DbSet<CityEntity> Cities { get; set; }
    public DbSet<ClubEntity> Clubs { get; set; }
    public DbSet<CompetitionEntity> Competitions { get; set; }
    public DbSet<EnrollmentEntity> Enrollments { get; set; }
    public DbSet<EventEntity> Events { get; set; }
    public DbSet<StreetEntity> Streets { get; set; }
    public ApplicationDbContext() : base()
    {
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=AtletikaDB;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<EnrollmentEntity>()
            .HasKey(e => new { e.Id });

        modelBuilder.Entity<EnrollmentEntity>()
            .HasOne(e => e.Athlete)
            .WithMany()
            .HasForeignKey(e => e.AthleteId);

        modelBuilder.Entity<EnrollmentEntity>()
            .HasOne(e => e.Event)
            .WithMany()
            .HasForeignKey(e => e.EventId);

        modelBuilder.Entity<EnrollmentEntity>()
            .HasOne(e => e.Competition)
            .WithMany(c => c.Enrollments)
            .HasForeignKey(e => e.CompetitionId);
    }
}