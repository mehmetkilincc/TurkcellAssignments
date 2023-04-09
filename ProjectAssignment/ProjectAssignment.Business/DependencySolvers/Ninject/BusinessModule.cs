using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using ProjectAssignment.Business.Abstract;
using ProjectAssignment.Business.Concrete;
using ProjectAssignment.DataAccess.Abstract;
using ProjectAssignment.DataAccess.Concrete;

namespace ProjectAssignment.Business.DependencySolvers.Ninject
{
    public class BusinessModule: NinjectModule
    {
        public override void Load()
        {
            //For Student 
            Bind<IStudentService>().To<StudentManager>().InSingletonScope();
            Bind<IStudentDal>().To<StudentDal>().InSingletonScope();

            //For Teacher
            Bind<ITeacherService>().To<TeacherManager>().InSingletonScope();
            Bind<ITeacherDal>().To<TeacherDal>().InSingletonScope();

            //For Classroom
            Bind<IClassroomService>().To<ClassroomManager>().InSingletonScope();
            Bind<IClassroomDal>().To<ClassroomDal>().InSingletonScope();
        }
    }
}
