using System;
using Web.CoreApp.Model;

namespace Web.CoreApp.Repository
{
    public class ExperienceRepository : Repository<Experience>, IExperienceRepository
    {
        public ExperienceRepository(EngineerContext context) : base(context)
        {
        }

        public Experience GetExperiencesWithEngineer(int id)
        {
            throw new NotImplementedException();
        }
    }
}
