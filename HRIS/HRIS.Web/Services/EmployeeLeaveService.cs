using HRIS.Web.Models;
using HRIS.Web.Repository;

namespace HRIS.Web.Services
{
    public class EmployeeLeaveService : IEmployeeLeaveService
    {
        public EmployeeLeaveService()
        {

        }

        public void CreateLeaveType(EmployeeLeaveModel employeeLeave, IUnitOfWork unitOfWork)
        {
            unitOfWork.EmployeeLeave.Add(employeeLeave);
            unitOfWork.Save();
        }

        public IEnumerable<EmployeeLeaveModel> GetAll(IUnitOfWork unitOfWork)
        {
            return unitOfWork.EmployeeLeave.GetAll();
        }
    }
}
