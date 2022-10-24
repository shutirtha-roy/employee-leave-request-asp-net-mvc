namespace HRIS.Web.Repository
{
    public interface IUnitOfWork
    {
        ILeaveTypeRepository LeaveType { get; }
        IEmployeeLeaveRepository EmployeeLeave { get; }
        void Save();
    }
}
