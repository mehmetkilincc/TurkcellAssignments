using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ProjectAssignment.Entities.Concrete;

namespace ProjectAssignment.Business.Abstract
{
    public interface IClassroomService
    {
        IEnumerable<Classroom> GetAll();
        Classroom GetById(int id);
        void Add(Classroom classroom);
        void Delete(Classroom classroom);
        void Update(Classroom classroom);
    }
}
