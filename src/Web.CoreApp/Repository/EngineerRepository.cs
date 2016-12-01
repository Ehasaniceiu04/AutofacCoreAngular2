using System;
using System.Collections.Generic;
using Web.CoreApp.Model;

namespace Web.CoreApp.Repository
{
    public class EngineerRepository: Repository<Engineer>,IEngineerRepository
    {
        public EngineerRepository(EngineerContext context):base(context)
        {

        }

        public IEnumerable<Engineer> GetEngineerWithCourses()
        {
            throw new NotImplementedException();
        }
    }
}
