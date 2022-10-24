using Autofac;
using HRIS.Web.Repository;
using HRIS.Web.Services;

namespace HRIS.Web
{
    public class WebModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>()
                .InstancePerLifetimeScope();

            builder.RegisterType<EmployeeProfile>().As<IEmployeeProfile>()
                .InstancePerLifetimeScope();

            base.Load(builder);
        }
    }
}
