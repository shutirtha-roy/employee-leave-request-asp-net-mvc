using HRIS.Web.Data;
using HRIS.Web.Entities;
using HRIS.Web.Models;

namespace HRIS.Web.Repository
{
    public class EmployeeLeaveRepository : Repository<EmployeeLeaveEntity>, IEmployeeLeaveRepository
    {
        private ApplicationDbContext _db;

        public EmployeeLeaveRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(EmployeeLeaveEntity obj)
        {
            _db.EmployeeLeaves.Update(obj);
        }
    }
}
