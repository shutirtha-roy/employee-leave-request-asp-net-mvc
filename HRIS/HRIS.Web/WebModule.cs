using Autofac;
using HRIS.Web.Models;
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

            builder.RegisterType<LeaveTypeModel>().AsSelf();

            builder.RegisterType<LeaveTypeService>().As<ILeaveTypeService>()
                .InstancePerLifetimeScope();

            builder.RegisterType<EmployeeLeaveService>().As<IEmployeeLeaveService>()
                .InstancePerLifetimeScope();

            base.Load(builder);
        }
    }
}
