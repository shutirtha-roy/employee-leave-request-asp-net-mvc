using Autofac;
using HRIS.Web.BusinessObjects;
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
        private ILifetimeScope _scope;

        public LeaveTypeModel()
        {
        }

        public void ResolveDependency(ILifetimeScope scope)
        {
            _scope = scope;
            _leaveTypeService = _scope.Resolve<ILeaveTypeService>();
        }

        public void CreateLeaveType()
        {
            LeaveType leaveType = new LeaveType();
            leaveType.Id = Id;
            leaveType.Title = Title;

            _leaveTypeService.CreateLeaveType(leaveType);
        }

        public object GetAll()
        {
            return _leaveTypeService.GetAll();
        }

        public object GetData()
        {
            return _leaveTypeService.GetData();
        }
    }
}
