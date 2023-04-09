using ProjectAssignment.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAssignment.Business.Abstract
{
    public interface ITeacherService
    {
        IEnumerable<Teacher> GetAll();
        IEnumerable<Teacher> GetAllByFilter(Expression<Func<Teacher, bool>> filter);
        Teacher GetById(int id);
        void Add(Teacher teacher);
        void Update(Teacher teacher);
        void Delete(Teacher teacher);
    }
}
