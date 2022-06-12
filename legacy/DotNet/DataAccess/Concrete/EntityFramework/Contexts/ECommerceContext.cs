using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Concrete.EntityFramework.Contexts.Mappings;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework.Contexts
{
    public class ECommerceContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { 
            optionsBuilder
               .UseNpgsql("Host=192.168.1.40;Database=ECommerceDb;Username=postgres;Password=2956;");
          // optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=ECommerceDb;Trusted_Connection=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          modelBuilder.ApplyConfiguration(new ProductMap());
        }

        public DbSet<Product> Products { get; set; }
    }
}
