using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.ValidationRules;
using Core.Aspects.Autofac.Logging;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        [LogAspect(typeof(FileLogger))]
        public IDataResult<IList<Product>> GetList(Expression<Func<Product, bool>> filter = null)
        {
            return new SuccessDataResult<IList<Product>>(_productDal.GetList(filter));
        }

        [LogAspect(typeof(FileLogger))]
        public IDataResult<Product> Get(Expression<Func<Product, bool>> filter)
        {
            return new SuccessDataResult<Product>(_productDal.Get(filter));
        }

       
        [LogAspect(typeof(FileLogger))]
        [ValidationAspect(typeof(ProductValidator))]
        public IResult Add(Product product)
        {
            _productDal.Add(product);


            return new SuccessResult();
        }
        [LogAspect(typeof(FileLogger))]
        public IResult Update(Product product)
        {
            _productDal.Update(product);
            return new SuccessResult();
        }
        [LogAspect(typeof(FileLogger))] 
        public IResult Delete(Product product)
        {
            _productDal.Delete(product);
            return new SuccessResult();
        }
    }
}
