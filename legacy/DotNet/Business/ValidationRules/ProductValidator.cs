using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.CategoryId).NotEmpty();
            RuleFor(p => p.SupplierId).NotEmpty();
            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p => p.ProductDescription).NotEmpty();
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.UnitsInStock).NotEmpty();
        }   
    }       
}           
