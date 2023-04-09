using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectAssignment.Business.Abstract;
using ProjectAssignment.DataAccess.Abstract;
using ProjectAssignment.DataAccess.Concrete;
using ProjectAssignment.Entities.Concrete;

namespace ProjectAssignment.Business.Concrete
{
    public class ClassroomManager:IClassroomService
    {
        private readonly IClassroomDal _classroomDal;

        public ClassroomManager(IClassroomDal classroomDal)
        {
            this._classroomDal = classroomDal;
        }

        public IEnumerable<Classroom> GetAll()
        {
            return _classroomDal.GetAll();
        }

        public Classroom GetById(int id)
        {
            return _classroomDal.GetById(p => p.Id == id);
        }   

        public void Add(Classroom classroom)
        {
            var existClassroom = _classroomDal.GetById(p => p.ClassName == classroom.ClassName);
            if (existClassroom != null)
            {
                throw new Exception($"Bu Sınıf Adı Kullanılmaktadır!");
            }
            _classroomDal.Add(classroom);
        }

        public void Update(Classroom classroom)
        {
            var existingClassroom = _classroomDal.GetById(p=>p.Id ==classroom.Id);
            if (existingClassroom == null)
            {
                throw new Exception("Sınıf kayıtlı değil!");
            }
            _classroomDal.Update(classroom);
        }

        public void Delete(Classroom classroom)
        {
            _classroomDal.Delete(classroom);
        }
    }
}
