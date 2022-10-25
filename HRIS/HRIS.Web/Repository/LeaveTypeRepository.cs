using HRIS.Web.Data;
using HRIS.Web.Entities;
using HRIS.Web.Models;

namespace HRIS.Web.Repository
{
    public class LeaveTypeRepository : Repository<LeaveTypeEntity>, ILeaveTypeRepository
    {
        private ApplicationDbContext _db;

        public LeaveTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(LeaveTypeEntity obj)
        {
            _db.LeaveTypes.Update(obj);
        }
    }
}
