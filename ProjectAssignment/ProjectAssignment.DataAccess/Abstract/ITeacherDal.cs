﻿using ProjectAssignment.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAssignment.DataAccess.Abstract
{
    public interface ITeacherDal : IRepository<Teacher>
    {
    }
}
