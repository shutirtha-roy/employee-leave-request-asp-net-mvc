using HRIS.Web.BusinessObjects;
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

        public void CreateLeaveType(LeaveType leaveType)
        {
            LeaveTypeEntity leaveTypeEntity = new LeaveTypeEntity();
            leaveTypeEntity.Id = leaveType.Id;
            leaveTypeEntity.Title = leaveType.Title;

            _unitOfWork.LeaveType.Add(leaveTypeEntity);
            _unitOfWork.Save();
        }

        public object GetAll()
        {
            return _unitOfWork.LeaveType.GetAll();
        }

        public object GetData()
        {
            var enumerator = from value in _unitOfWork.LeaveType.GetAll() select new { value.Id, value.Title };
            return enumerator;
        }
    }
}
