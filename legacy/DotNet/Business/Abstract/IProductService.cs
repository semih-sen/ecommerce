using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<IList<Product>> GetList(Expression<Func<Product, bool>> filter = null);
        
        IDataResult<Product> Get(Expression<Func<Product, bool>> filter);
        
        IResult Add(Product product);
        IResult Update(Product product);
        IResult Delete(Product product);
    }
}
