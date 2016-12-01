using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.CoreApp.Model;

namespace Web.CoreApp.Repository
{
    interface IEngineerRepository:IRepository<Engineer>
    {
        IEnumerable<Engineer> GetEngineerWithCourses();

    }
}
