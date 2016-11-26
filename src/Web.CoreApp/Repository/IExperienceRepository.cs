using Web.CoreApp.Model;

namespace Web.CoreApp.Repository
{
    interface IExperienceRepository:IRepository<Experience>
    {
        Experience GetExperiencesWithEngineer(int id);
    }
}
