using Autofac;
using CoreMVCApp.Manager;
using Web.CoreApp.Model;
using Web.CoreApp.Repository;


namespace Web.CoreApp
{
    public class AutoFacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Employee>().As<IEmployee>();
            builder.RegisterGeneric(typeof(Repository<>)).As(typeof(IRepository<>));
            builder.RegisterType<EngineerRepository>().As<IEngineerRepository>();
            builder.RegisterType<ExperienceRepository>().As<IExperienceRepository>();
            //builder.RegisterType<EngineerContext>().As<EngineerContext>();
            builder.RegisterType<EFUnitOfWork>().As<IUnitOfWork>();
            builder.RegisterType<EngineerManager>().As<IEngineerManager>();

        }
    }
}