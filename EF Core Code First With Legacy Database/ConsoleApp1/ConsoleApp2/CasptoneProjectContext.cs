using ConsoleApp2.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ConsoleApp2
{
    class CasptoneProjectContext : DbContext
    {
        public CasptoneProjectContext()
        {
            
        }

        public CasptoneProjectContext(DbContextOptions<CasptoneProjectContext> options)
            : base(options)
        {
        }
        public DbSet<Account> Accounts { get; set; } // Account
        public DbSet<AccountType> AccountTypes { get; set; } // AccountType
        public DbSet<Branch> Branches { get; set; } // Branch
        public DbSet<City> Cities { get; set; } // City
        public DbSet<Customer> Customers { get; set; } // Customer
        public DbSet<District> Districts { get; set; } // District
        public DbSet<Order> Orders { get; set; } // Order
        public DbSet<OrderDetail> OrderDetails { get; set; } // OrderDetail
        public DbSet<Promotion> Promotions { get; set; } // Promotion
        public DbSet<PromotionDetail> PromotionDetails { get; set; } // PromotionDetail
        public DbSet<Service> Services { get; set; } // Service
        public DbSet<ServiceStatus> ServiceStatus { get; set; } // ServiceStatus
        public DbSet<ServiceType> ServiceTypes { get; set; } // ServiceType
        public DbSet<Supplier> Suppliers { get; set; } // Supplier

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.AddConfiguration(new AccountConfiguration());
            modelBuilder.AddConfiguration(new AccountTypeConfiguration());
            modelBuilder.AddConfiguration(new BranchConfiguration());
            modelBuilder.AddConfiguration(new CityConfiguration());
            modelBuilder.AddConfiguration(new CustomerConfiguration());
            modelBuilder.AddConfiguration(new DistrictConfiguration());
            modelBuilder.AddConfiguration(new OrderConfiguration());
            modelBuilder.AddConfiguration(new OrderDetailConfiguration());
            modelBuilder.AddConfiguration(new PromotionConfiguration());
            modelBuilder.AddConfiguration(new PromotionDetailConfiguration());
            modelBuilder.AddConfiguration(new ServiceConfiguration());
            modelBuilder.AddConfiguration(new ServiceStatusConfiguration());
            modelBuilder.AddConfiguration(new SupplierStatusConfiguration());

            base.OnModelCreating(modelBuilder);
        }
         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=tcp:hoangpnse62077.database.windows.net,1433;Initial Catalog=CapstoneProjectFinalDb;Persist Security Info=False;User ID=hoang;Password=Tedu@12345;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }
    }
}
