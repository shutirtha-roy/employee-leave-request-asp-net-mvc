using HRIS.Web.Entities;
using HRIS.Web.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HRIS.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<LeaveTypeEntity> LeaveTypes { get; set; }
        public DbSet<EmployeeLeaveEntity> EmployeeLeaves { get; set; }
    }
}