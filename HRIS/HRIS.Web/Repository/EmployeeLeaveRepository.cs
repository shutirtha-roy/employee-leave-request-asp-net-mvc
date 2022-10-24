using HRIS.Web.Data;
using HRIS.Web.Models;

namespace HRIS.Web.Repository
{
    public class EmployeeLeaveRepository : Repository<EmployeeLeaveModel>, IEmployeeLeaveRepository
    {
        private ApplicationDbContext _db;

        public EmployeeLeaveRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(EmployeeLeaveModel obj)
        {
            _db.EmployeeLeaves.Update(obj);
        }
    }
}
