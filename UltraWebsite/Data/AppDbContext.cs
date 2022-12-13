using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using UltraWebsite.Models.Configurations;
using UltraWebsite.Models.Entity;

namespace UltraWebsite.Data
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {




        }

        public DbSet<Tag> Tags { get; set; }
        public DbSet<ProductTag> ProductTags { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Catagory> Catalogues { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
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
            modelBuilder.Entity<Order>()
                 .HasOne(p => p.user)
                 .WithMany(p => p.Orders)
                 .HasForeignKey(p => p.user_id);
            modelBuilder.Entity<Order>()
                 .HasOne(b => b.Product)
                 .WithMany(i => i.Orders)
                 .HasForeignKey(b => b.product_id);


            //modelBuilder.Entity<Order>()
            //    .HasOne(p => p.Product)
            //    .WithOne(p => p.Order)
            //    .HasForeignKey<Product>(p => p.order_id)
            //    .OnDelete(DeleteBehavior.SetNull);
            modelBuilder.ApplyConfiguration(new CatagoryConfigration());

        }

    }
}
