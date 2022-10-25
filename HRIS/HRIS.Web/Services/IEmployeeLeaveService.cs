using HRIS.Web.BusinessObjects;
using HRIS.Web.Entities;
using HRIS.Web.Models;
using HRIS.Web.Repository;

namespace HRIS.Web.Services
{
    public interface IEmployeeLeaveService
    {
        void CreateLeaveType(EmployeeLeave employeeLeave);
        object GetAll();
    }
}
