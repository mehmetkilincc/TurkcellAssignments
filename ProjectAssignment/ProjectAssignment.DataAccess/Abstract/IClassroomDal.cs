using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ProjectAssignment.Entities.Concrete;

namespace ProjectAssignment.DataAccess.Abstract
{
    public interface IClassroomDal:IRepository<Classroom>
    {
    }
}
