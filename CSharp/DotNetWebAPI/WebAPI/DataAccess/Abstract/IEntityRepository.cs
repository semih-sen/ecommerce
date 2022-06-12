using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using WebAPI.Entities;
namespace WebAPI.DataAccess.Abstract
{
    public interface IEntityRepository<T> where T: class, IEntity, new(){
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        IList<T> GetList(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
    }
}