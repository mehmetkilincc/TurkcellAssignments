using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectAssignment.Entities.Abstract;

namespace ProjectAssignment.Entities.Concrete
{

    public class Student:IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        
        public Classroom Classroom { get; set; }
    }
}
