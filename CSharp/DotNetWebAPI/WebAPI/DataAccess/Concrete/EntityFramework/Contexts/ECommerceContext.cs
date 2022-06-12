using Microsoft.EntityFrameworkCore;
using WebAPI.DataAccess.Concrete.EntityFramework.Contexts.Mappings;
using WebAPI.Entities;

namespace WebAPI.DataAccess.Concrete.EntityFramework.Contexts
{
    public class ECommerceContext:DbContext
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