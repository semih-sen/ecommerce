using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int SupplierId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public double UnitPrice { get; set; }
        public double UnitsInStock { get; set; }

    }
}
