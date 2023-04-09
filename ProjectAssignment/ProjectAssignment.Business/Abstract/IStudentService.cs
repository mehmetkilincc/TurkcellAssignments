using ProjectAssignment.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAssignment.Business.Abstract
{
    public interface IStudentService
    {
        IEnumerable<Student> GetAll();
        IEnumerable<Student> GetAllByFilter(Expression<Func<Student, bool>> filter);
        Student GetById(int id);
        void Add(Student student);
        void Update(Student student);
        void Delete(Student student);
    }
}
