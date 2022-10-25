using HRIS.Web.Entities;
using HRIS.Web.Models;
using HRIS.Web.Repository;

namespace HRIS.Web.Services
{
    public interface IEmployeeLeaveService
    {
        void CreateLeaveType(EmployeeLeaveEntity employeeLeave, IUnitOfWork unitOfWork);
        IEnumerable<EmployeeLeaveEntity> GetAll(IUnitOfWork unitOfWork);
    }
}
