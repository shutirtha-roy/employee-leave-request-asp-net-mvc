namespace HRIS.Web.BusinessObjects
{
    public class EmployeeLeave
    {
        public Guid Id { get; set; }
        public string? EmployeeId { get; set; }
        public Guid LeaveTypeId { get; set; }
        public DateTime LeaveDate { get; set; }
        public string? Remarks { get; set; }
    }
}
