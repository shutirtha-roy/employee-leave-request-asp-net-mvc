using HRIS.Web.Entities;
using HRIS.Web.Models;
using HRIS.Web.Repository;

namespace HRIS.Web.Services
{
    public interface ILeaveTypeService
    {
        void CreateLeaveType(LeaveTypeEntity leaveType, IUnitOfWork unitOfWork);
        IEnumerable<LeaveTypeEntity> GetAll(IUnitOfWork unitOfWork);
        dynamic GetData(IUnitOfWork unitOfWork);
    }
}
