using HRIS.Web.Models;
using HRIS.Web.Repository;

namespace HRIS.Web.Services
{
    public class LeaveTypeService : ILeaveTypeService
    {
        
        public LeaveTypeService()
        {
            
        }

        public void CreateLeaveType(LeaveTypeModel leaveType, IUnitOfWork unitOfWork)
        {
            unitOfWork.LeaveType.Add(leaveType);
            unitOfWork.Save();
        }

        public IEnumerable<LeaveTypeModel> GetAll(IUnitOfWork unitOfWork)
        {
            return unitOfWork.LeaveType.GetAll();
        }

        public dynamic GetData(IUnitOfWork unitOfWork)
        {
            var enumerator = from value in unitOfWork.LeaveType.GetAll() select new { value.Id, value.Title };
            return enumerator;
        }
    }
}
