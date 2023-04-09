using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ProjectAssignment.Business.Abstract;
using ProjectAssignment.DataAccess.Abstract;
using ProjectAssignment.Entities.Concrete;

namespace ProjectAssignment.Business.Concrete
{
    public class StudentManager : IStudentService
    {
        private readonly IStudentDal _studentDal;

        public StudentManager(IStudentDal studentDal)
        {
            this._studentDal = studentDal;
        }

        public IEnumerable<Student> GetAll()
        {
            return _studentDal.GetAll();
        }

        public IEnumerable<Student> GetAllByFilter(Expression<Func<Student, bool>> filter)
        {
            return _studentDal.GetAllByFilter(filter);
        }

        public Student GetById(int id)
        {
            return _studentDal.GetById(p=>p.Id==id);
        }

        public void Add(Student student)
        {
            _studentDal.Add(student);
        }

        public void Update(Student student)
        {
            var studentToUpdate = _studentDal.GetById(p => p.Id == student.Id);

            if (studentToUpdate == null)
                throw new Exception("Öğrenci kayıtlı değil!");

            _studentDal.Update(studentToUpdate);
        }

        public void Delete(Student student)
        {
            _studentDal.Delete(student);
        }
    }
}
