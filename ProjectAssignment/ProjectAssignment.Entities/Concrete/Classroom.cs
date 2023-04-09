using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectAssignment.Entities.Abstract;

namespace ProjectAssignment.Entities.Concrete
{

    public class Classroom:IEntity
    {
        public int Id { get; set; }
        public string ClassName { get; set; }
    }
}
