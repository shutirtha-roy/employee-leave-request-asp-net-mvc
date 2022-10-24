using HRIS.Web.Models;

namespace HRIS.Web.Repository
{
    public interface ILeaveTypeRepository : IRepository<LeaveTypeModel>
    {
        void Update(LeaveTypeModel obj);
    }
}
