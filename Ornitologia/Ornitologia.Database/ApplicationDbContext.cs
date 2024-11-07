using Microsoft.EntityFrameworkCore;
using Ornitologia.Database.Entities;
using System.Security.Cryptography.X509Certificates;

namespace Ornitologia.Database
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<NoteEntity> Notes { get; set; }
        public DbSet<CityEntity> Cities { get; set; }
        public DbSet<BirdEntity> Birds { get; set; }
        public DbSet<ClassEntity> Classes { get; set; }
        public DbSet<SpeciesEntity> Species { get; set; }
        public DbSet<StreetEntity> Streets { get; set; }
        public DbSet<SubclassEntity> Subclasses { get; set; }
        public DbSet<TribeEntity> Tribes { get; set; }
        public DbSet<MemberEntity> Members { get; set; }

        public ApplicationDbContext() : base()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=OrnitologiaDB;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True;");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BirdEntity>()
                .HasOne(b => b.Member)  
                .WithMany(m => m.Birds) 
                .HasForeignKey(b => b.MemberId); 

            modelBuilder.Entity<BirdEntity>()
                .HasOne(b => b.Species)
                .WithMany() 
                .HasForeignKey(b => b.SpeciesId);

            modelBuilder.Entity<NoteEntity>()
                .HasOne(x => x.Member)
                .WithMany(x => x.Notes)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<NoteEntity>()
                .HasOne(x => x.Bird)
                .WithMany(x => x.Notes)
                .OnDelete(DeleteBehavior.NoAction);

            /*modelBuilder.Entity<BirdEntity>()
                   .HasOne(b => b.Species)
                   .WithMany()
                   .HasForeignKey(b => b.SpeciesId)
                   .OnDelete(DeleteBehavior.Restrict);*/
        }

    }
}
