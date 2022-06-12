using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.EntityFramework.Contexts.Mappings
{
    public class ProductMap:IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("products", "public");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).HasColumnName("id");
            builder.Property(p => p.CategoryId).HasColumnName("category_id");
            builder.Property(p => p.SupplierId).HasColumnName("supplier_id");
            builder.Property(p => p.ProductName).HasColumnName("product_name");
            builder.Property(p => p.ProductDescription).HasColumnName("product_desc");
            builder.Property(p => p.UnitPrice).HasColumnName("unit_price");
            builder.Property(p => p.UnitsInStock).HasColumnName("units_in_stock");
        }
    }
}
