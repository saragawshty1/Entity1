using Microsoft.EntityFrameworkCore;
using P01_SalesDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_SalesDatabase.Data
{
    internal class ApplicationDbContext :DbContext
    {
        public DbSet<Customer>Customers { get; set; }
        public DbSet<product>products { get; set; }
        public DbSet<Store>Stores { get; set; }
        public DbSet<Sales>Sales { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=DBSales;Integrated Security=True;TrustServerCertificate=True"); 

        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<product>().
        //}
    }
}
