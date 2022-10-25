using HRIS.Web.Entities;
using HRIS.Web.Models;

namespace HRIS.Web.Repository
{
    public interface IEmployeeLeaveRepository : IRepository<EmployeeLeaveEntity>
    {
        void Update(EmployeeLeaveEntity obj);
    }
}
