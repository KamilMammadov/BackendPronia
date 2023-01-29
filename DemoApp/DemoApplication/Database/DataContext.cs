﻿using DemoApplication.Database.Models;
using DemoApplication.Extensions;
using Microsoft.EntityFrameworkCore;
using System.Drawing;
using System.Reflection;
using Color = DemoApplication.Database.Models.Color;
using Size = DemoApplication.Database.Models.Size;

namespace DemoApplication.Database
{
    public partial class DataContext : DbContext
    {
        public DataContext(DbContextOptions options)
            : base(options)
        {

        }




        public DbSet<Navbar> Navbars { get; set; }
        public DbSet<SubNavbar> SubNavbars { get; set; }
        public DbSet<PaymentBenefit> PaymentBenefits { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Catagories { get; set; }
        public DbSet<ProductCategory> ProductCatagories { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<ProductColor> ProductColors { get; set; }
        public DbSet<ProductSize> ProductSizes { get; set; }
        public DbSet<ProductTag> ProductTags { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Tag> Tags { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Role> Roles { get; set; }
        public DbSet<UserActivation> UserActivations { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<BasketProduct> BasketProducts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }














        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly<Program>();
        }
    }

    //#region Auditing

    //public partial class DataContext
    //{
    //    public override int SaveChanges()
    //    {
    //        AutoAudit();

    //        return base.SaveChanges();
    //    }

    //    public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
    //    {
    //        AutoAudit();

    //        return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
    //    }

    //    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    //    {
    //        AutoAudit();

    //        return base.SaveChangesAsync(cancellationToken);
    //    }

    //    public override int SaveChanges(bool acceptAllChangesOnSuccess)
    //    {
    //        AutoAudit();

    //        return base.SaveChanges(acceptAllChangesOnSuccess);
    //    }

    //    //private void AutoAudit()
    //    //{
    //    //    foreach (var entry in ChangeTracker.Entries())
    //    //    {
    //    //        if (entry.Entity is not IAuditable auditableEntry) //Short version
    //    //        {
    //    //            continue;
    //    //        }

    //    //        //IAuditable auditableEntry = (IAuditable)entry;

    //    //        DateTime currentDate = DateTime.Now;

    //    //        if (entry.State == EntityState.Added)
    //    //        {
    //    //            auditableEntry.CreatedAt = currentDate;
    //    //            auditableEntry.UpdatedAt = currentDate;
    //    //        }
    //    //        else if (entry.State == EntityState.Modified)
    //    //        {
    //    //            auditableEntry.UpdatedAt = currentDate;
    //    //        }
    //    //    }
    //    //}
    //}

    //#endregion
}
