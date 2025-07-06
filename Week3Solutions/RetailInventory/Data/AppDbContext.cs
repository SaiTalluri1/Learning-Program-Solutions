using Microsoft.EntityFrameworkCore;
using RetailInventory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailInventory.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Use your local SQL Server connection string
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=RetailDb;Trusted_Connection=True;TrustServerCertificate=True;");

        }
    }
}
