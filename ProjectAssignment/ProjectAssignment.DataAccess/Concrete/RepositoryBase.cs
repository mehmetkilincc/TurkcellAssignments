using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using ProjectAssignment.DataAccess.Abstract;
using ProjectAssignment.Entities.Abstract;

namespace ProjectAssignment.DataAccess.Concrete
{
    public class RepositoryBase<T>:IRepository<T> where T : class, IEntity, new()
    {
        private static int _counter = 1;
        private readonly List<T> entities = new List<T>();
        public IEnumerable<T> GetAll()
        {
            return entities;
        }

        public IEnumerable<T> GetAllByFilter(Expression<Func<T, bool>> filter)
        {
            return entities.Where(filter.Compile());
        }

        public T GetById(Expression<Func<T, bool>> filter)
        {
            return entities.FirstOrDefault(filter.Compile());
        }

        public void Add(T entity)
        {
            entity.Id = _counter++;
            entities.Add(entity);
        }

        public void Update(T entity)
        {
            T entityToUpdate = entities.FirstOrDefault(p => p.Id == entity.Id);
            //var entityContext = context.Entry(entity);
            //entityContext.State = EntityState.Modified;
            //context.SaveChanges();
        }

        public void Delete(T entity)
        {
            entities.Remove(entity);
        }
    }
}
