using System.ComponentModel.DataAnnotations;

namespace HRIS.Web.Entities
{
    public class LeaveTypeEntity
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string? Title { get; set; }
    }
}
