using HRIS.Web.Entities;
using HRIS.Web.Models;
using HRIS.Web.Repository;

namespace HRIS.Web.Services
{
    public class EmployeeLeaveService : IEmployeeLeaveService
    {
        public EmployeeLeaveService()
        {

        }

        public void CreateLeaveType(EmployeeLeaveEntity employeeLeave, IUnitOfWork unitOfWork)
        {
            unitOfWork.EmployeeLeave.Add(employeeLeave);
            unitOfWork.Save();
        }

        public IEnumerable<EmployeeLeaveEntity> GetAll(IUnitOfWork unitOfWork)
        {
            return unitOfWork.EmployeeLeave.GetAll();
        }
    }
}
