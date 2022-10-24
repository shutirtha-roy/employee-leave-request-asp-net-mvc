using HRIS.Web.Data;
using HRIS.Web.Models;

namespace HRIS.Web.Repository
{
    public class LeaveTypeRepository : Repository<LeaveTypeModel>, ILeaveTypeRepository
    {
        private ApplicationDbContext _db;

        public LeaveTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(LeaveTypeModel obj)
        {
            _db.LeaveTypes.Update(obj);
        }
    }
}
