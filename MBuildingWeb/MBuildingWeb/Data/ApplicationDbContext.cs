using MBuildingWeb.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using MBuildingWeb.Models.Product;
using MBuildingWeb.Models.Order;
using MBuildingWeb.Models.Client;

namespace MBuildingWeb.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            this.Database.EnsureCreated();
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<MBuildingWeb.Models.Product.ProductCreateVM> ProductCreateVM { get; set; }
        public DbSet<MBuildingWeb.Models.Product.ProductIndexVM> ProductIndexVM { get; set; }
        public DbSet<MBuildingWeb.Models.Product.ProductEditVM> ProductEditVM { get; set; }
        public DbSet<MBuildingWeb.Models.Product.ProductDetailsVM> ProductDetailsVM { get; set; }
        public DbSet<MBuildingWeb.Models.Product.ProductDeleteVM> ProductDeleteVM { get; set; }
        public DbSet<MBuildingWeb.Models.Order.OrderIndexVM> OrderIndexVM { get; set; }
        public DbSet<MBuildingWeb.Models.Order.OrderConfirmVM> OrderConfirmVM { get; set; }
        public DbSet<MBuildingWeb.Models.Client.ClientIndexVM> ClientIndexVM { get; set; }
        public DbSet<MBuildingWeb.Models.Client.ClientDeleteVM> ClientDeleteVM { get; set; }
    }
}
