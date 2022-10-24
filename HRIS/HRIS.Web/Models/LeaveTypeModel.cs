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
            _leaveTypeService.CreateLeaveType(this, unitOfWork);
        }

        public IEnumerable<LeaveTypeModel> GetAll(IUnitOfWork unitOfWork)
        {
            return _leaveTypeService.GetAll(unitOfWork);
        }

        public dynamic GetData(IUnitOfWork unitOfWork)
        {
            return _leaveTypeService.GetData(unitOfWork);
        }
    }
}
