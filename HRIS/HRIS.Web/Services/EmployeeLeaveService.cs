using HRIS.Web.Entities;
using HRIS.Web.Models;
using HRIS.Web.Repository;
using EmployeeLeaveBO = HRIS.Web.BusinessObjects.EmployeeLeave;
using EmployeeLeaveEO = HRIS.Web.Entities.EmployeeLeaveEntity;

namespace HRIS.Web.Services
{
    public class EmployeeLeaveService : IEmployeeLeaveService
    {
        private readonly IUnitOfWork _unitOfWork;
        public EmployeeLeaveService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void CreateLeaveType(EmployeeLeaveBO employeeLeave)
        {
            EmployeeLeaveEO employeeLeaveEntity = new EmployeeLeaveEO();
            employeeLeaveEntity.Id = employeeLeave.Id;
            employeeLeaveEntity.EmployeeId = employeeLeave.EmployeeId;
            employeeLeaveEntity.LeaveTypeId = employeeLeave.LeaveTypeId;
            employeeLeaveEntity.LeaveDate = employeeLeave.LeaveDate;
            employeeLeaveEntity.Remarks = employeeLeave.Remarks;

            _unitOfWork.EmployeeLeave.Add(employeeLeaveEntity);
            _unitOfWork.Save();
        }

        public object GetAll()
        {
            return _unitOfWork.EmployeeLeave.GetAll();
        }
    }
}
