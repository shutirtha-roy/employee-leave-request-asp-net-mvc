using HRIS.Web.Entities;
using HRIS.Web.Models;
using HRIS.Web.Repository;

namespace HRIS.Web.Services
{
    public class LeaveTypeService : ILeaveTypeService
    {
        private readonly IUnitOfWork _unitOfWork;
        public LeaveTypeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void CreateLeaveType(LeaveTypeEntity leaveType)
        {
            _unitOfWork.LeaveType.Add(leaveType);
            _unitOfWork.Save();
        }

        public IEnumerable<LeaveTypeEntity> GetAll()
        {
            return _unitOfWork.LeaveType.GetAll();
        }

        public dynamic GetData()
        {
            var enumerator = from value in _unitOfWork.LeaveType.GetAll() select new { value.Id, value.Title };
            return enumerator;
        }
    }
}
