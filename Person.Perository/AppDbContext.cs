using Microsoft.EntityFrameworkCore;
using Person.Domain.Interfaces;
using Person.Repository.Extensions;
using System;
using System.Linq;

namespace Person.Repository
{
    using Domain = Person.Domain.Domains;
    public class AppDbContext : DbContext, IAppDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Domain.Person> Persons { get; set; }
        public DbSet<Domain.Relation> Relations { get; set; }
        public DbSet<Domain.PhoneNumber> PhoneNumbers { get; set; }

        public override int SaveChanges()
        {
            try
            {
                return base.SaveChanges();
            }
            catch (Exception ex)
            {
                //
                throw;
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Domain.Person>()
                .HasMany(ph => ph.PhoneNumbers)
                .WithOne(p => p.Person);


            modelBuilder.Entity<Domain.Relation>()
                .HasKey(e => new { e.FromId, e.ToId });

            modelBuilder.Entity<Domain.Relation>()
                .HasOne(e => e.PersonFrom)
                .WithMany(e => e.RelatedTo)
                .HasForeignKey(e => e.FromId);

            modelBuilder.Entity<Domain.Relation>()
                .HasOne(e => e.PersonTo)
                .WithMany(e => e.RelatedFrom)
                .HasForeignKey(e => e.ToId);

            modelBuilder.Entity<Domain.Person>()
                .Property(p => p.Id).UseIdentityColumn(1,1);

            modelBuilder.Entity<Domain.Person>()
                .Property(p => p.FirstName).IsRequired();

            modelBuilder.Entity<Domain.Person>()
                .Property(p => p.LastName).IsRequired();
            modelBuilder.Entity<Domain.Person>()
                .Property(p => p.PrivateNumber).IsRequired();
            modelBuilder.Entity<Domain.Person>()
                .Property(p => p.BirthDate).IsRequired();


            modelBuilder.Seed();
            foreach (var foreignKey in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }
    }
}
