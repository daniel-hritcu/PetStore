using Microsoft.EntityFrameworkCore;
using PetStore.MVC.Models;

namespace PetStore.MVC.Data
{
    public class PetStoreDbContext : DbContext
    {
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Pet> Pets { get; set; }

        public PetStoreDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pet>()
            .HasOne(p => p.Owner)
            .WithMany(o => o.Pets);

            base.OnModelCreating(modelBuilder);
        }

    }
}
