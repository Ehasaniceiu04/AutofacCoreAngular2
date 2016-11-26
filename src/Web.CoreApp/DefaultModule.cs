using Autofac;

namespace Web.CoreApp
{
    public class DefaultModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Employee>().As<IEmployee>();
        }
    }
}