using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ProjectAssignment.Entities.Abstract;

namespace ProjectAssignment.DataAccess.Abstract
{
    public interface IRepository<T> where T : class,IEntity,new()
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAllByFilter(Expression<Func<T, bool>> filter);
        T GetById(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
