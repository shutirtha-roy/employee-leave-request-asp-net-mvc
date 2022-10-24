using HRIS.Web.Models;

namespace HRIS.Web.Repository
{
    public interface IEmployeeLeaveRepository : IRepository<EmployeeLeaveModel>
    {
        void Update(EmployeeLeaveModel obj);
    }
}
