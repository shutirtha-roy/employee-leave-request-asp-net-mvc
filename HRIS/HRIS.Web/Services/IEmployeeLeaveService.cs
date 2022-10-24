using HRIS.Web.Models;
using HRIS.Web.Repository;

namespace HRIS.Web.Services
{
    public interface IEmployeeLeaveService
    {
        void CreateLeaveType(EmployeeLeaveModel employeeLeave, IUnitOfWork unitOfWork);
        IEnumerable<EmployeeLeaveModel> GetAll(IUnitOfWork unitOfWork);
    }
}
