using HRIS.Web.Entities;
using HRIS.Web.Models;
using HRIS.Web.Repository;

namespace HRIS.Web.Services
{
    public class EmployeeLeaveService : IEmployeeLeaveService
    {
        private readonly IUnitOfWork _unitOfWork;
        public EmployeeLeaveService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void CreateLeaveType(EmployeeLeaveEntity employeeLeave)
        {
            _unitOfWork.EmployeeLeave.Add(employeeLeave);
            _unitOfWork.Save();
        }

        public IEnumerable<EmployeeLeaveEntity> GetAll()
        {
            return _unitOfWork.EmployeeLeave.GetAll();
        }
    }
}
