using HRIS.Web.Entities;
using HRIS.Web.Repository;
using HRIS.Web.Services;
using System.ComponentModel.DataAnnotations;

namespace HRIS.Web.Models
{
    public class LeaveTypeModel : IModel<Guid>
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string? Title { get; set; }
        private ILeaveTypeService _leaveTypeService;

        public LeaveTypeModel()
        {
            _leaveTypeService = new LeaveTypeService();
        }

        public void CreateLeaveType(IUnitOfWork unitOfWork)
        {
            LeaveTypeEntity leaveTypeEntity = new LeaveTypeEntity();
            leaveTypeEntity.Id = Id;
            leaveTypeEntity.Title = Title;

            _leaveTypeService.CreateLeaveType(leaveTypeEntity, unitOfWork);
        }

        public object GetAll(IUnitOfWork unitOfWork)
        {
            return _leaveTypeService.GetAll(unitOfWork);
        }

        public object GetData(IUnitOfWork unitOfWork)
        {
            return _leaveTypeService.GetData(unitOfWork);
        }
    }
}
