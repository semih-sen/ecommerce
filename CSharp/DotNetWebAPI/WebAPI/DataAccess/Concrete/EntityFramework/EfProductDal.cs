using WebAPI.DataAccess.Abstract;
using WebAPI.DataAccess.Concrete.EntityFramework.Contexts;
using WebAPI.Entities;

namespace WebAPI.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal:EfEntityRepositoryBase<Product, ECommerceContext>, IProductDal
    {
            
    }
}