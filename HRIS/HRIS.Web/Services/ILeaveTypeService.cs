using HRIS.Web.Models;
using HRIS.Web.Repository;

namespace HRIS.Web.Services
{
    public interface ILeaveTypeService
    {
        void CreateLeaveType(LeaveTypeModel leaveType, IUnitOfWork unitOfWork);
        IEnumerable<LeaveTypeModel> GetAll(IUnitOfWork unitOfWork);
        dynamic GetData(IUnitOfWork unitOfWork);
    }
}
