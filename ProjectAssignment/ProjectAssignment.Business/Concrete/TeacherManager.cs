using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ProjectAssignment.Business.Abstract;
using ProjectAssignment.DataAccess.Abstract;
using ProjectAssignment.DataAccess.Concrete;
using ProjectAssignment.Entities.Concrete;

namespace ProjectAssignment.Business.Concrete
{
    public class TeacherManager : ITeacherService
    {
        private readonly ITeacherDal _teacherDal;

        public TeacherManager(ITeacherDal teacherDal)
        {
            this._teacherDal = teacherDal;
        }
        public IEnumerable<Teacher> GetAll()
        {
            return _teacherDal.GetAll();
        }

        public IEnumerable<Teacher> GetAllByFilter(Expression<Func<Teacher, bool>> filter)
        {
            return _teacherDal.GetAllByFilter(filter);
        }

        public Teacher GetById(int id)
        {
            return _teacherDal.GetById(p => p.Id == id);
        }

        public void Add(Teacher teacher)
        {
            _teacherDal.Add(teacher);
        }

        public void Update(Teacher teacher)
        {
            var studentToTeacher = _teacherDal.GetById(p => p.Id == teacher.Id);
            if (studentToTeacher == null)
                throw new InvalidOperationException("Öğretmen kayıtlı değil!");

            _teacherDal.Update(teacher);
        }

        public void Delete(Teacher teacher)
        {
            _teacherDal.Delete(teacher);
        }
    }
}
