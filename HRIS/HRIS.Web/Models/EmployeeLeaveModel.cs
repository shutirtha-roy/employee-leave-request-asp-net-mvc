using Autofac;
using HRIS.Web.Entities;
using HRIS.Web.Repository;
using HRIS.Web.Services;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRIS.Web.Models
{
    public class EmployeeLeaveModel : IModel<Guid>
    {
        [Key]
        public Guid Id { get; set; }
        public string? EmployeeId { get; set; }
        [Required]
        [Display(Name = "LeaveTypeModel")]
        public Guid LeaveTypeId { get; set; }
        [ForeignKey("LeaveTypeId")]
        [ValidateNever]
        public LeaveTypeModel LeaveTypeModel { get; set; }
        public DateTime LeaveDate { get; set; }
        public string? Remarks { get; set; }
        private IEmployeeLeaveService _employeeLeaveService;
        private ILifetimeScope _scope;

        public EmployeeLeaveModel()
        {
            _employeeLeaveService = new EmployeeLeaveService();
        }

        public void ResolveDependency(ILifetimeScope scope)
        {
            _scope = scope;
            _employeeLeaveService = _scope.Resolve<IEmployeeLeaveService>();
        }

        public void CreateEmployeeLeave(IUnitOfWork unitOfWork)
        {
            EmployeeLeaveEntity employeeLeaveEntity = new EmployeeLeaveEntity();
            employeeLeaveEntity.Id = Id;
            employeeLeaveEntity.EmployeeId = EmployeeId;
            employeeLeaveEntity.LeaveTypeId = LeaveTypeId;
            employeeLeaveEntity.LeaveDate = LeaveDate;
            employeeLeaveEntity.Remarks = Remarks;

            _employeeLeaveService.CreateLeaveType(employeeLeaveEntity, unitOfWork);
        }

        public object GetAll(IUnitOfWork unitOfWork)
        {
            return _employeeLeaveService.GetAll(unitOfWork);
        }
    }
}
