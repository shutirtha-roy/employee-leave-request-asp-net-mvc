using HRIS.Web.BusinessObjects;
using HRIS.Web.Models;
using HRIS.Web.Repository;

namespace HRIS.Web.Services
{
    public interface ILeaveTypeService
    {
        void CreateLeaveType(LeaveType leaveType);
        object GetAll();
        object GetData();
    }
}
