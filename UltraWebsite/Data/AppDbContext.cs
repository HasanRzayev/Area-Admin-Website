using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using UltraWebsite.Models.Configurations;
using UltraWebsite.Models.Entity;

namespace UltraWebsite.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Tag> Tags { get; set; }

        public DbSet<ProductTag> ProductTags { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Catagory> Catalogues { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasOne(s => s.Catalogue)
                .WithMany(g => g.Products)
                .HasForeignKey(s => s.catalogue_id);
            modelBuilder.Entity<ProductTag>()
               .HasKey(pt => new { pt.ProductId, pt.TagId });
            modelBuilder.Entity<ProductTag>()
               .HasOne(p => p.Product)
               .WithMany(p => p.ProductTags)
               .HasForeignKey(p => p.ProductId);
            modelBuilder.Entity<ProductTag>()
                 .HasOne(p => p.Tag)
                 .WithMany(p => p.ProductTags)
                 .HasForeignKey(p => p.TagId);


            modelBuilder.ApplyConfiguration(new CatagoryConfigration());
          
        }

    }
}
