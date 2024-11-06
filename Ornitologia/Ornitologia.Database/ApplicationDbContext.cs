﻿using Microsoft.EntityFrameworkCore;
using Ornitologia.Database.Entities;

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

        public ApplicationDbContext() : base()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=OrnitologiaDB;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True;");

        }
    }
}