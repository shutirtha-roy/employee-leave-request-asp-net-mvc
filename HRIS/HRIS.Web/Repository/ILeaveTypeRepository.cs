using HRIS.Web.Entities;
using HRIS.Web.Models;

namespace HRIS.Web.Repository
{
    public interface ILeaveTypeRepository : IRepository<LeaveTypeEntity>
    {
        void Update(LeaveTypeEntity obj);
    }
}
